using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ASCOM.DriverAccess;
using ASCOM.Utilities;
using ASCOM.DeviceInterface;


namespace TelescopeControl
{

    public partial class btnSetOffset : Form
    {

        #region declarations 

        List<string> targetNames = new List<string>();
        List<string> aos = new List<string>();
        List<string> los = new List<string>();
        List<string> startRa = new List<string>();
        List<string> startDec = new List<string>();
        List<string> endRa = new List<string>();
        List<string> endDec = new List<string>();
        int nTargets;
        int year, month, day;
        Telescope objTelescope;
        double slewSpeed = 1.0/0.0; // should be able to find from the telescope, maybe using a class which performs a slew and calculates a rms
        double currentRa;
        double currentDec;
        DateTime nextAos;
        bool endOfNight = false;
        int imagesCaptured = 0;
        int idx = 0;
        int offsetHours;
        int offsetMins;
        double nextDec;
        double nextRa;
        int sdx;

        #endregion

        public btnSetOffset() //this name is wrong and I don't know how to change it...
        {
            InitializeComponent();
        }

        public void Interface_Load(object sender, EventArgs e)
        {        
        }

        public void btnSelectTelescope_Click(object sender, EventArgs e)
        {
            // opens the ASCOM chooser menu to find telescope
            string teleID;
            var objChooser = new ASCOM.Utilities.Chooser();
            objChooser.DeviceType = "Telescope";
            teleID = objChooser.Choose();
            Properties.Settings.Default.Telescope = teleID;
            
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            // connects to telescope
            try 
            {
                objTelescope = new ASCOM.DriverAccess.Telescope(Properties.Settings.Default.Telescope);
                objTelescope.Connected = true;
                btnConnect.Enabled = false;
                btnCheckTelesscope.Enabled = true;               
            } // if no telescope has been chosen
            catch (Exception)
            {
                lbWarning.Text = "Warning:  Please select Telescope";
            }

        }

        private void btnSelectData_Click(object sender, EventArgs e)
        {
            // opens the windows browse files interface to choose file
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                Properties.Settings.Default.data = fileToOpen;
            }
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            // import data

            // with file open
            using (var reader = new StreamReader(@Properties.Settings.Default.data))
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var observationDate = values[0].Split('-');

                year = Int16.Parse(observationDate[0]);
                month = Int16.Parse(observationDate[1]);
                day = Int16.Parse(observationDate[2]);
                nTargets = Int16.Parse(values[1]);

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(',');

                    targetNames.Add(values[0]);
                    aos.Add(values[1]);
                    los.Add(values[2]);
                    startRa.Add(values[3]);
                    startDec.Add(values[4]);
                    endRa.Add(values[5]);
                    endDec.Add(values[6]);
                }

                btnImportData.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;       
             // to add safety, requires telescope to be parked
            trackSatellites();
        }

        private void trackSatellites()
        {
            // main function 
            // does not loop, is run each time a satellite is tracked, or the second photograph is taken
            // this is to allow the timers to run, as well as to easily allow missed passes        

            lbTime.Text = DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 0)).ToString();
            objTelescope.Tracking = true;

            if (idx < nTargets)
            {
                if (imagesCaptured == 0)
                {
                    try
                    {
                        findNextTarget();
                        lbTargetLocked.Text = "Slewing";
                        double offsetRa;                    
                        // this if statement accounts for the overflow of offsetting RA, which cycles through 0 to 24 to 0
                        if (nextRa > offsetHours + 1.0 / 60.0 * offsetMins)
                        {
                            // RA is offset in the opposite direction to time, as we simulate seeing events occuring later, but want to ensure
                            // that they are above the horizon
                            offsetRa = nextRa - offsetHours - 1.0 / 60.0 * offsetMins;                        
                        }
                        else
                        {
                            offsetRa = 24 - (offsetHours + 1.0 / 60.0 * offsetMins - nextRa);
                        }
                        objTelescope.SlewToCoordinates(offsetRa, nextDec);
                        RunTimer.Start();                                           
                        imagesCaptured = 1; // note this line is only run after the RunTimer is stopped
                    }
                    catch 
                    {
                        lbWarningText.Text = "All satellite passes have finished";
                    }    

                }
                else if (imagesCaptured == 1)
                {
                    goToNextImage();
                    lbTargetLocked.Text = "Slewing";
                    double offsetRa;
                    if (nextRa > offsetHours + 1.0 / 60.0 * offsetMins)
                    {
                        offsetRa = nextRa - offsetHours - 1.0 / 60.0 * offsetMins;
                    }
                    else
                    {
                        offsetRa = 24 - (offsetHours + 1.0 / 60.0 * offsetMins - nextRa);
                    }
                    objTelescope.SlewToCoordinates(offsetRa, nextDec);
                    RunTimer.Start();
                    imagesCaptured = 0;
                }
            }
        }

        private void findNextTarget()
        {
            var targetAquired = false;

            while (!targetAquired)
            {
                // all of the below could be put into a pointer style function                
                var time = aos[idx].Split(':');
                var ra = startRa[idx].Split(' ');
                var dec = startDec[idx].Split(' ');
                char[] charsToTrim = { 'd', 'e', 'g' };
                var decSign = Math.Sign(double.Parse(dec[0].Trim(charsToTrim)));
                byte nextDay = 0;
                if (short.Parse(time[0]) < 12)
                {
                    nextDay = 1;
                }

                currentRa = objTelescope.RightAscension;
                currentDec = objTelescope.Declination;

                nextRa = double.Parse(ra[0].Trim('h')) + 1.0 / 60.0 * double.Parse(ra[1].Trim('m')) + 1.0 / 3600.0 * double.Parse(ra[2].Trim('s'));
                nextDec = double.Parse(dec[0].Trim(charsToTrim)) + 1.0 / 60.0 * decSign * double.Parse(dec[1].Trim('\'')) + 1.0 / 3600.0 * decSign * double.Parse(dec[2].Trim('\"'));
                nextAos = new DateTime(year, month, day, short.Parse(time[0]), short.Parse(time[1]), short.Parse(time[2])).Add(new TimeSpan(24 * nextDay, -1, 0)); // offset before the 
                double secondsToAos = (nextAos - DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 0))).TotalSeconds; //nged to an acceptable, latest possible AOS

                if ((secondsToAos - Math.Max(Math.Abs(nextRa - currentRa), Math.Abs(nextRa - currentDec)) / slewSpeed) > 0.0) // will need to be split up if the motor speeds are different
                {
                    lbTargetName.Text = targetNames[idx];
                    lbTargetAos.Text = nextAos.ToString();
                    // need to offset to optimal point        
                    targetAquired = true;
                }
                else
                {
                    idx++;
                }
            }
        }

        private void goToNextImage()
        {
            // this function assumes that the mount is able to move faster than the speed of the satellite
            var ra = endRa[idx].Split(' ');
            var dec = endDec[idx].Split(' ');
            var time = los[idx].Split(':');
            char[] charsToTrim = { 'd', 'e', 'g' };
            var decSign = Math.Sign(double.Parse(dec[0].Trim(charsToTrim)));
            byte nextDay = 0;
            if (short.Parse(time[0]) < 12)
            {
                nextDay = 1;
            }

            nextRa = double.Parse(ra[0].Trim('h')) + 1.0 / 60.0 * double.Parse(ra[1].Trim('m')) + 1.0 / 3600.0 * double.Parse(ra[2].Trim('s'));
            nextDec = double.Parse(dec[0].Trim(charsToTrim)) + 1.0 / 60.0 * decSign * double.Parse(dec[1].Trim('\'')) + 1.0 / 3600.0 * decSign * double.Parse(dec[2].Trim('\"'));
            nextAos = new DateTime(year, month, day, Int16.Parse(time[0]), Int16.Parse(time[1]), Int16.Parse(time[2])).Add(new TimeSpan(24*nextDay, -1 ,0)); // offset before the 

            lbTargetAos.Text = nextAos.ToString();
        }



        private void btnOffset_Click(object sender, EventArgs e)
        {
            // this allows offset to be set while the simulation is running
            try
            {
                if (short.Parse(txtEnterOffset.Text) + 1.0/60.0* short.Parse(textMinsOffset.Text) >= offsetHours + 1.0 / 60.0 * offsetMins)
                {
                    offsetHours = short.Parse(txtEnterOffset.Text);
                    offsetMins = short.Parse(textMinsOffset.Text);
              
                }
            }
            catch (Exception)
            {
                lbWarningText.Text = "Offset can only be increased";
            }
        }

        private void btnCheckTelesscope_Click(object sender, EventArgs e)
        {
            // perform checks of telescope and connection
            var canTrack = objTelescope.CanSetTracking;
            var canSlew = objTelescope.CanSlew;

            if (canTrack && canSlew)
            {
                btnStart.Enabled = true;
                lbWarningText.Text = "Ready to start tracking";
            }
            else
            {
                lbWarningText.Text = "Please ensure telescope is parked and polar aligned";
            }
        }

        private void manualSlew_Click(object sender, EventArgs e)
        {
            try
            {
                float ra = float.Parse(textRA.Text);
                float dec = float.Parse(textDec.Text);
                objTelescope.SlewToCoordinates(ra, dec);
            }
            catch
            {
            }
        }


        private void ImageTimer_Tick(object sender, EventArgs e)
        { 
            // this timer keeps the mount in position while an image is being taken
            if (sdx < 10)
            {
                sdx++;
                lbTargetLocked.Text = "Capturing image";
                lbTime.Text = DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 0)).ToString();
            }
            else
            {
                ImageTimer.Stop();
                trackSatellites();
            }
        }

        private void RunTimer_Tick(object sender, EventArgs e)
        {
            // this timer keeps the mount in position while it is waiting for the satellite to pass
            if (nextAos < DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 1)) && nextAos > DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, -1))) // need to include a tolerence
            {
                sdx = 0;
                ImageTimer.Start();
                RunTimer.Stop();                                         
            }
            else if (nextAos < DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 0)))
            {
                RunTimer.Stop();
                lbTargetLocked.Text = "Missed image";
                trackSatellites();
            }
            else {
                lbTargetLocked.Text = "Awaiting frame";
                lbTime.Text = DateTime.Now.Add(new TimeSpan(offsetHours, offsetMins, 0)).ToString();
            }
        }
    }
}
