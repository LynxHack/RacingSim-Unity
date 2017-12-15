using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace Mech423RacingSimulator_LynxLu
{
    public partial class SetupWindow : Form
    {

        public SetupWindow()
        {
            InitializeComponent();

            AccelGraph.Series.Add("Accel_X");
            AccelGraph.Series["Accel_X"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_X"].Color = Color.Blue;

            AccelGraph.Series.Add("Accel_Y");
            AccelGraph.Series["Accel_Y"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_Y"].Color = Color.Green;

            AccelGraph.Series.Add("Accel_Z");
            AccelGraph.Series["Accel_Z"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_Z"].Color = Color.Yellow;

            GlobalVariables.Accel_X.Add(0);
            GlobalVariables.Accel_Y.Add(0);
            GlobalVariables.Accel_Z.Add(0);
        }

        public static class GlobalVariables
        {
            public static Axis_Acceleration AccelerationData = new Axis_Acceleration();
            public static List<double> Accel_X = new List<double>();
            public static List<double> Accel_Y = new List<double>();
            public static List<double> Accel_Z = new List<double>();
        }

        string[] PortArray;
        public class Axis_Acceleration
        {
            public double X, Y, Z;
        }

        string keystate = "";
        string keystate2 = "";
        private void timer_Tick(object sender, EventArgs e)
        {
            string[] test = SerialPort.GetPortNames().ToArray();
            if (SerialPortListBox.DroppedDown == false) //Prevent list updates during drop down activated so list doesn't flash
            {
                PortArray = SerialPort.GetPortNames().ToArray();
                SerialPortListBox.Items.Clear();
                foreach (string portname in PortArray)
                {
                    SerialPortListBox.Items.Add(portname);
                }
            }

            //Retrieve Acceleration data from one data packet
            if (DisconnectButton.Text == "Disconnect")
            {
                int QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.X = QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.Y = QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.Z = QueueData;

                if (GlobalVariables.AccelerationData.X == 0 || GlobalVariables.AccelerationData.Y == 0 || GlobalVariables.AccelerationData.Z == 0)
                {
                    return;
                }

                XaxisBox.Text = GlobalVariables.AccelerationData.X.ToString();
                YaxisBox.Text = GlobalVariables.AccelerationData.Y.ToString();
                ZaxisBox.Text = GlobalVariables.AccelerationData.Z.ToString();

                //Controls Sensitivity settings
                int YUpper = 135;
                int YLower = 120;

                int XUpper = 160;
                int XLower = 122;

                if (Convert.ToInt32(YaxisBox.Text) < YLower && Convert.ToInt32(YaxisBox.Text) > 0 && keystate != "left") //Left
                {
                    new Thread(delegate () {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                        InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    }).Start(); ;
                    keystate = "left";
                }
                else if (Convert.ToInt32(YaxisBox.Text) > YUpper && Convert.ToInt32(YaxisBox.Text) > 0 && keystate != "right") //Right
                {
                    new Thread(delegate ()
                    {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                        InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    }).Start();
                    keystate = "right";
                }
                else if (Convert.ToInt32(YaxisBox.Text) < YUpper && Convert.ToInt32(YaxisBox.Text) > YLower)
                {
                    new Thread(delegate ()
                    {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    }).Start();
                    keystate = "";
                }

                if (Convert.ToInt32(XaxisBox.Text) < XLower && Convert.ToInt32(XaxisBox.Text) > 0 && keystate2 != "up") //Up
                {
                    new Thread(delegate ()
                    {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                        InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    }).Start();
                    keystate2 = "up";
                }
                else if (Convert.ToInt32(XaxisBox.Text) > XUpper && Convert.ToInt32(XaxisBox.Text) > 0 && keystate2 != "down") //Right
                {
                    new Thread(delegate ()
                    {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                        InputSimulator.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                    }).Start();
                    keystate2 = "down";
                }
                else if (Convert.ToInt32(XaxisBox.Text) < XUpper && Convert.ToInt32(XaxisBox.Text) > XLower)
                {
                    new Thread(delegate ()
                    {
                        InputSimulator InputSimulator = new InputSimulator();
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                        InputSimulator.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                    }).Start();
                    keystate2 = "";
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (serCom.IsOpen)
            {
                DisconnectButton.Text = "Connect";
                serCom.Close();
                GlobalVariables.Accel_X.Clear();
                GlobalVariables.Accel_Y.Clear();
                GlobalVariables.Accel_Z.Clear();
                SerialPortListBox.Enabled = true;
            }
            else if (serCom.IsOpen == false)
            {

                serCom.DataBits = 8;
                serCom.BaudRate = 128000;
                try
                {
                    serCom.PortName = SerialPortListBox.Text.ToString();
                    DisconnectButton.Text = "Disconnect";
                    serCom.Open();
                    SerialPortListBox.Enabled = false;
                    this.Hide();
                }
                catch
                {
                    DisconnectButton.Text = "Connect";
                    MessageBox.Show("Unable to Establish Connection", "Error");
                }
            }
        }

        private void SerialPortListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serCom.PortName = SerialPortListBox.Text.ToString();
        }

        ConcurrentQueue<int> SerialReceivedQueue = new ConcurrentQueue<int>();
        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int ItemToClear;
            while (SerialReceivedQueue.TryDequeue(out ItemToClear))
            {
                //wait for queue to be cleared for the next set of data in order to not clog up the queue;
            }
            try
            {
                while (serCom.BytesToRead > 0)
                {
                    int data = serCom.ReadByte();

                    if (data == 255) //remove the starting byte
                        continue;
                    SerialReceivedQueue.Enqueue(data);
                }


            }
            catch { }
        }

        private void SetupWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            serCom.Close();
        }
    }
}


