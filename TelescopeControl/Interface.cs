using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCOM.DriverAccess;
using ASCOM.Utilities;
using ASCOM.DeviceInterface;


namespace TelescopeControl
{

    public partial class Interface : Form
    {

        public Interface()
        {
            InitializeComponent();
        }

        public void Interface_Load(object sender, EventArgs e)
        {

        }


        public void btnSelectTelescope_Click(object sender, EventArgs e)
        {
            string teleID;
            var objChooser = new ASCOM.Utilities.Chooser();
            objChooser.DeviceType = "Telescope";
            teleID = objChooser.Choose();
            Properties.Settings.Default.Telescope = teleID;
        }

        public void btnConnect_Click(object sender, EventArgs e)
        {
            var objTelescope = new ASCOM.DriverAccess.Telescope(Properties.Settings.Default.Telescope);
            objTelescope.Connected = true;
            btnConnect.Enabled = false;
        }
    }
}
