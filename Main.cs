using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Mech423RacingSimulator_LynxLu
{


    public partial class RacingSimulator : Form
    {
        public RacingSimulator()
        {
            InitializeComponent();
        }

        string Gamepath = @"C:\Users\Nullcaster\source\repos\Mech423RacingSimulator-LynxLu\Mech423RacingSimulator-LynxLu\Mech423CarSimulator-LynxLu.exe";
        private void Start_Click(object sender, EventArgs e)
        {
            SetupButton.Enabled = false;
            Stop.Enabled = true;
            if (Start.Text == "Restart")
            {
                foreach (var process in Process.GetProcessesByName("PortWindow")) //Closes by process name
                {
                    process.Kill();
                }
                try //The exe is sometimes access by visual studio so kill process may result in error
                {
                    foreach (var process in Process.GetProcessesByName("Mech423CarSimulator-LynxLu")) //Closes by process name
                    {
                        process.Kill();
                    }
                }
                catch { }
            }

            Start.Text = "Restart";

            GameWindow.AppFilename = Gamepath;
            GameWindow.Start();

            Process.Start(@"C:\Users\Nullcaster\source\repos\Mech423RacingSimulator-LynxLu\Mech423RacingSimulator-LynxLu\CompiledDataAcquisitionGUI\PortWindow\PortWindow\bin\Debug\PortWindow.exe"); //Start Controller
        }

        Form debuggingpanel = new SensorTest();
        private void SetupButton_Click(object sender, EventArgs e)
        {
            debuggingpanel.Close();
            debuggingpanel = new SensorTest();
            debuggingpanel.Show();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            GameWindow.Stop();
            Start.Text = "Start";


            Stop.Enabled = false;
            SetupButton.Enabled = true;

            foreach (var process in Process.GetProcessesByName("PortWindow")) //Closes by process name
            {
                process.Kill();
            }
            try //The exe is sometimes access by visual studio so kill process may result in error
            {
                foreach (var process in Process.GetProcessesByName("Mech423CarSimulator-LynxLu")) //Closes by process name
                {
                    process.Kill();
                }
            }
            catch { }
        }

        private void RacingSimulator_FormClosing(object sender, FormClosingEventArgs e) //Safety purpose, kills control process
        {
            foreach (var process in Process.GetProcessesByName("PortWindow")) //Closes by process name
            {
                process.Kill();
            }
            try //The exe is sometimes access by visual studio so kill process may result in error
            {
                foreach (var process in Process.GetProcessesByName("Mech423CarSimulator-LynxLu")) //Closes by process name
                {
                    process.Kill();
                }
            }
            catch { }
        }
    }
}
