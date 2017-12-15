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
using System.Threading;

namespace Mech423RacingSimulator_LynxLu
{
    public partial class SensorTest : Form
    {
        public SensorTest()
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
        //int state = 0;
        public class Axis_Acceleration
        {
            public double X, Y, Z;
        }

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
                //int data2;

                //if (SerialReceivedQueue.Count() < 3)
                //    return;

                //while (SerialReceivedQueue.Count() % 3 != 0)
                //{
                //    SerialReceivedQueue.TryDequeue(out data2);
                //}

                //Console.WriteLine(SerialReceivedQueue.Count());

                QueueSize.Text = SerialReceivedQueue.Count().ToString();

                int x, y, z;
                SerialReceivedQueue.TryDequeue(out QueueData);
                if (QueueData != 255)
                    return;
                SerialReceivedQueue.TryDequeue(out QueueData);
                if (QueueData == 255 || QueueData == 0)
                    return;
                else
                {
                    x = QueueData;
                }
                SerialReceivedQueue.TryDequeue(out QueueData);
                if (QueueData == 255 || QueueData == 0)
                    return;
                else
                {
                    y = QueueData;
                }
                SerialReceivedQueue.TryDequeue(out QueueData);
                if (QueueData == 255 || QueueData == 0)
                    return;
                else
                {
                    z = QueueData;
                }

                GlobalVariables.AccelerationData.X = x;
                GlobalVariables.AccelerationData.Y = y;
                GlobalVariables.AccelerationData.Z = z;

                //if (SerialReceivedQueue.TryDequeue(out QueueData))
                //    GlobalVariables.AccelerationData.X = QueueData;
                //else
                //{
                //    Console.WriteLine("Error");
                //    Console.WriteLine(SerialReceivedQueue.Count());
                //    return;
                //}
                //if (SerialReceivedQueue.TryDequeue(out QueueData))
                //    GlobalVariables.AccelerationData.Y = QueueData;
                //else
                //{
                //    YaxisBox.AppendText("Error");
                //    return;
                //}
                //if (SerialReceivedQueue.TryDequeue(out QueueData))
                //    GlobalVariables.AccelerationData.Z = QueueData;
                //else
                //{
                //    ZaxisBox.AppendText("Error");
                //    return;
                //}

                if (GlobalVariables.AccelerationData.X == 0 || GlobalVariables.AccelerationData.Y == 0 || GlobalVariables.AccelerationData.Z == 0)
                {
                    return;
                }

                int gravityoffset = 40;
                if (GlobalVariables.Accel_X.Count() > 100)
                {
                    if (Orientation.Text == "+Z")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X, 2) + Math.Pow(GlobalVariables.AccelerationData.Y, 2) + Math.Pow(GlobalVariables.AccelerationData.Z - gravityoffset, 2)) / 214).ToString();
                    }
                    else if (Orientation.Text == "-Z")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X, 2) + Math.Pow(GlobalVariables.AccelerationData.Y, 2) + Math.Pow(GlobalVariables.AccelerationData.Z + gravityoffset, 2)) / 214).ToString();
                    }
                    else if (Orientation.Text == "-Y")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X, 2) + Math.Pow(GlobalVariables.AccelerationData.Y - gravityoffset, 2) + Math.Pow(GlobalVariables.AccelerationData.Z, 2)) / 214).ToString();
                    }
                    else if (Orientation.Text == "+Y")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X, 2) + Math.Pow(GlobalVariables.AccelerationData.Y + gravityoffset, 2) + Math.Pow(GlobalVariables.AccelerationData.Z, 2)) / 214).ToString();
                    }
                    else if (Orientation.Text == "-X")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X - gravityoffset, 2) + Math.Pow(GlobalVariables.AccelerationData.Y, 2) + Math.Pow(GlobalVariables.AccelerationData.Z, 2)) / 214).ToString();
                    }
                    else if (Orientation.Text == "+X")
                    {
                        TotalG.Text = (Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X + gravityoffset, 2) + Math.Pow(GlobalVariables.AccelerationData.Y, 2) + Math.Pow(GlobalVariables.AccelerationData.Z, 2)) / 214).ToString();
                    }
                }
                
                //TotalG.Text = Math.Sqrt(Math.Pow(GlobalVariables.AccelerationData.X,2) + Math.Pow(GlobalVariables.AccelerationData.Y,2) + Math.Pow(GlobalVariables.AccelerationData.Z,2)).ToString();

                GlobalVariables.Accel_X.Add(GlobalVariables.AccelerationData.X);
                GlobalVariables.Accel_Y.Add(GlobalVariables.AccelerationData.Y);
                GlobalVariables.Accel_Z.Add(GlobalVariables.AccelerationData.Z);


                if (GlobalVariables.Accel_X.Count() < 10) //Difference - For Orientation
                {
                    XaxisBox.Text = (GlobalVariables.Accel_X.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Max() - 127).ToString();
                    YaxisBox.Text = (GlobalVariables.Accel_Y.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Max() - 127).ToString();
                    ZaxisBox.Text = (GlobalVariables.Accel_Z.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Max() - 127).ToString();
                }
                else
                {
                    XaxisBox.Text = (GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - 10, 10).Max() - 127).ToString();
                    YaxisBox.Text = (GlobalVariables.Accel_Y.GetRange(GlobalVariables.Accel_X.Count() - 10, 10).Max() - 127).ToString();
                    ZaxisBox.Text = (GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_X.Count() - 10, 10).Max() - 127).ToString();
                }



                if (GlobalVariables.Accel_X.Count() < 100) //Average
                {
                    XAvg.Text = GlobalVariables.Accel_X.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Average().ToString();
                    YAvg.Text = GlobalVariables.Accel_Y.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Average().ToString();
                    ZAvg.Text = GlobalVariables.Accel_Z.GetRange(0, GlobalVariables.Accel_X.Count() - 1).Average().ToString();
                }
                else
                {
                    XAvg.Text = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - 100, 100).Average().ToString();
                    YAvg.Text = GlobalVariables.Accel_Y.GetRange(GlobalVariables.Accel_X.Count() - 100, 100).Average().ToString();
                    ZAvg.Text = GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_X.Count() - 100, 100).Average().ToString();
                }


                double sum = 0;
                int numberofindex = 500;
                if( GlobalVariables.Accel_X.Count() > numberofindex)
                {
                    List<double> values = GlobalVariables.Accel_Y.GetRange(GlobalVariables.Accel_X.Count() - numberofindex, numberofindex);
                    double valuesaverage = values.Average();



                    for (int i = 0; i < numberofindex; i++)
                    {
                        sum = sum + Math.Pow(values[i] - valuesaverage, 2);
                    }

                    Console.WriteLine((0.002 * Math.Sqrt(sum)).ToString());
                    XStdev.Text = (0.002* Math.Sqrt(sum)).ToString();
                    sum = 0;
                }
                if (GlobalVariables.Accel_Y.Count() > numberofindex)
                {
                    List<double> values = GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_Y.Count() - numberofindex, numberofindex);
                    double valuesaverage = values.Average();



                    for (int i = 0; i < numberofindex; i++)
                    {
                        sum = sum + Math.Pow(values[i] - valuesaverage, 2);
                    }

                    Console.WriteLine((0.002 * Math.Sqrt(sum)).ToString());
                    YStdev.Text = (0.002 * Math.Sqrt(sum)).ToString();
                    sum = 0;
                }
                if (GlobalVariables.Accel_Z.Count() > numberofindex)
                {
                    List<double> values = GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_Z.Count() - numberofindex, numberofindex);
                    double valuesaverage = values.Average();

                    for (int i = 0; i < numberofindex; i++)
                    {
                        sum = sum + Math.Pow(values[i] - valuesaverage, 2);
                    }

                    Console.WriteLine((0.002 * Math.Sqrt(sum)).ToString());
                    ZStdev.Text = (0.002 * Math.Sqrt(sum)).ToString();
                    sum = 0;
                }

                BufferSizeBox.Text = XDataBox.Text.Split(' ').ToList().Count.ToString();

                XDataBox.AppendText(GlobalVariables.Accel_X[GlobalVariables.Accel_X.Count() - 1].ToString() + " ");
                XDataBox.AppendText(GlobalVariables.Accel_Y[GlobalVariables.Accel_Y.Count() - 1].ToString() + " ");
                XDataBox.AppendText(GlobalVariables.Accel_Z[GlobalVariables.Accel_Z.Count() - 1].ToString() + " ");

                AccelGraph.Series["Accel_X"].Points.AddXY(AccelGraph.Series["Accel_X"].Points.Count(), GlobalVariables.AccelerationData.X.ToString());
                AccelGraph.Series["Accel_Y"].Points.AddXY(AccelGraph.Series["Accel_Y"].Points.Count(), GlobalVariables.AccelerationData.Y.ToString());
                AccelGraph.Series["Accel_Z"].Points.AddXY(AccelGraph.Series["Accel_Z"].Points.Count(), GlobalVariables.AccelerationData.Z.ToString());

                if (AccelGraph.ChartAreas[0].AxisX.Maximum - AccelGraph.ChartAreas[0].AxisX.Minimum > 100)
                {
                    AccelGraph.ChartAreas[0].AxisX.Minimum = AccelGraph.ChartAreas[0].AxisX.Minimum + 1; ;
                }

                try
                {
                    if (Math.Abs(Convert.ToInt32(XaxisBox.Text)) + Math.Abs(Convert.ToInt32(YaxisBox.Text)) + Math.Abs(Convert.ToInt32(ZaxisBox.Text)) < 55)
                    {
                        if (Convert.ToInt32(XaxisBox.Text) > 30)
                        {
                            Orientation.Text = "-X";
                            Orientreal.Text = "Forward";
                        }
                        else if (Convert.ToInt32(YaxisBox.Text) > 30)
                        {
                            Orientation.Text = "-Y";
                            Orientreal.Text = "Left";
                        }
                        else if (Convert.ToInt32(ZaxisBox.Text) > 30)
                        {
                            Orientation.Text = "+Z";
                            Orientreal.Text = "Facing up";
                        }
                        else if (Convert.ToInt32(XaxisBox.Text) < -30)
                        {
                            Orientation.Text = "+X";
                            Orientreal.Text = "Backward";
                        }
                        else if (Convert.ToInt32(YaxisBox.Text) < -30)
                        {
                            Orientation.Text = "+Y";
                            Orientreal.Text = "Right";
                        }
                        else if (Convert.ToInt32(ZaxisBox.Text) < -30)
                        {
                            Orientation.Text = "-Z";
                            Orientreal.Text = "Facing Down";
                        }
                        else
                            Orientation.Text = "";
                    }
                }
                catch { }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (serCom.IsOpen)
            {
                DisconnectButton.Text = "Connect";
                serCom.Close();
                //GlobalVariables.Accel_X.Clear();
                //GlobalVariables.Accel_Y.Clear();
                //GlobalVariables.Accel_Z.Clear();
                SerialPortListBox.Enabled = true;
            }
            else if (serCom.IsOpen == false)
            {

                serCom.DataBits = 8;
                serCom.BaudRate = 9600;
                try
                {
                    serCom.PortName = SerialPortListBox.Text.ToString();
                    DisconnectButton.Text = "Disconnect";
                    serCom.Open();
                    SerialPortListBox.Enabled = false;
                }
                catch
                {
                    DisconnectButton.Text = "Connect";
                    MessageBox.Show("Unable to Establish Connection", "Error");
                }
            }
        }

        public Axis_Acceleration Bin2Acc(Axis_Acceleration data)
        {
            double Vdd = 5;
            Axis_Acceleration result = new Axis_Acceleration();
            result.X = (data.X - 127) * (Vdd / 254) * (0.145 * Vdd); //0.145*Vdd is sensitivity V/g and Vdd/254 is for rangescale
            result.Y = (data.Y - 127) * (Vdd / 254) * (0.145 * Vdd);
            result.Z = -1 * (data.Z - 127) * (Vdd / 254) * (0.145 * Vdd);
            return result;
        }

        private void SerialPortListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serCom.PortName = SerialPortListBox.Text.ToString();
        }

        int counter = 2;
        ConcurrentQueue<int> SerialReceivedQueue = new ConcurrentQueue<int>();
        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (counter > 0)
            {
                int bytesNumberr = 0;
                try
                {

                    while (serCom.BytesToRead > 0)
                    {
                        serCom.ReadByte();
                        bytesNumberr++;
                    }
                    Console.WriteLine(bytesNumberr);
                }
                catch { }
                Invoke(new Action(() =>
                {
                    BytestoreadBox.Text = bytesNumberr.ToString();
                }));

                counter--;
                return;

            }
            counter = 3;
            //int test;
            //while (SerialReceivedQueue.Count()>3)
            //{
            //    SerialReceivedQueue.TryDequeue(out test);
            //}

            try
            {
                while (serCom.BytesToRead > 0)
                {
                
                    int data = serCom.ReadByte();

                    //if (data == 255) //remove the starting byte
                    //    continue;

                    SerialReceivedQueue.Enqueue(data);
                }


            }
            catch { }

        }

        private void SetupWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            serCom.Close();
        }

        string zstate = "-Z";
        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            //Sequence.Text = "";
            timer3.Enabled = false;
            try
            {
                double xmax, xmin, ymax, ymin, zmax, zmin;
                int indexnumber = 50;
                xmax = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Max();
                xmin = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Min();
                ymax = GlobalVariables.Accel_Y.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Max();
                ymin = GlobalVariables.Accel_Y.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Min();
                zmax = GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Max();
                zmin = GlobalVariables.Accel_Z.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).Min(); ;

                if (xmax - 127 > 127 - xmin)
                    XDiff.Text = (xmax - 127).ToString();
                else
                    XDiff.Text = (xmin - 127).ToString();

                if (xmax - 127 > 127 - xmin)
                    YDiff.Text = (ymax - 127).ToString();
                else
                    YDiff.Text = (ymin - 127).ToString();

                if (zmax - 167 > 167 - zmin)
                    ZDiff.Text = (zmax - 167).ToString();
                else
                    ZDiff.Text = (zmin - 167).ToString();

                if (Math.Abs(Convert.ToInt32(XDiff.Text)) + Math.Abs(Convert.ToInt32(YDiff.Text)) + Math.Abs(Convert.ToInt32(ZDiff.Text)) > 100)
                {
                    int xmaxindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(xmax);
                    int xminindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(xmin);
                    int ymaxindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(ymax);
                    int yminindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(ymin);
                    int zmaxindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(zmax);
                    int zminindex = GlobalVariables.Accel_X.GetRange(GlobalVariables.Accel_X.Count() - indexnumber, indexnumber).IndexOf(zmin);

                    //Console.WriteLine("xmaxindex " + xmaxindex + "xminindex " + xminindex + "ymaxindex" + ymaxindex + "yminindex" + yminindex + "zmaxindex" + zmaxindex + "zminindex");
                    //Console.WriteLine("xmax " + xmax + "xmin " + xmin + "ymax" + ymax + "ymin" + ymin + "zmax" + zmax + "zmin");

                    if (xmax - xmin > ymax - ymin && xmax - xmin > zmax - zmin)
                    {
                        if (xmaxindex < xminindex)
                        {
                            Console.WriteLine("Triggered +x");
                            Sequence.AppendText("+X");
                        }
                        else
                        {
                            Sequence.AppendText("+X");
                        }
                    }
                    else if (xmax - xmin < ymax - ymin && ymax - ymin > zmax - zmin)
                    {
                        if (ymaxindex < yminindex)
                        {
                            Console.WriteLine("Triggered +y");
                            Sequence.AppendText("+Y");
                        }
                        else
                        {
                            Sequence.AppendText("+Y");
                        }
                    }
                    else
                    {
                        if (zmaxindex > zminindex)
                        {
                            Console.WriteLine("Triggered +z");
                            Sequence.AppendText("+Z");
                        }
                        else
                        {
                            Sequence.AppendText(zstate);
                        }
                    }
                    timer3.Enabled = true;
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e) //Clears the sea
        {
            if(Sequence.Text.Length>=2 && Sequence.Text[1] == 'Y')
            {
                Sequence.Text = "";
            }
            if (Sequence.Text.Length == 4 && ( Sequence.Text[2] != '+' || Sequence.Text[3]!='Y'))
            {
                Sequence.Text = "";
            }
            if (Sequence.Text.Length == 4 && (Sequence.Text[2] != '+' || Sequence.Text[3] != 'Y'))
            {
                Sequence.Text = "";
            }

            if (Sequence.Text.Length == 2 && Sequence.Text == "-Z")
            {
                Action.Text = "Free Fall";
                timer3.Enabled = true;
                timer2.Enabled = true;
                return;
            }
            if (Sequence.Text.Length == 4 && Sequence.Text == "+X+Y")
            {
                Action.Text = "Frisbee Throw";
                Sequence.Text = "";
                timer3.Enabled = true;
                timer2.Enabled = true;
                return;
            }
            //if (Sequence.Text.Length == 6 && Sequence.Text == "+Z+Y-Y")
            if (Sequence.Text.Length == 6)
            {
                Action.Text = "Wave";
                Sequence.Text = "";
                timer3.Enabled = true;
                timer2.Enabled = true;
                return;
            }
            else
            {
                timer3.Enabled = true;
                timer2.Enabled = true;
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Action.Text = "";
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Sequence.Text = "";
            timer3.Enabled = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
                zstate = "+Z";
        }

        private void SensorTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift)
                zstate = "+Z";
            if (e.KeyCode == Keys.Enter)
                zstate = "-Z";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sequence.Text = "";
            Action.Text = "";
        }
    }
}
