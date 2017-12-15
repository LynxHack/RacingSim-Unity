namespace Mech423RacingSimulator_LynxLu
{
    partial class SensorTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.XDataBox = new System.Windows.Forms.TextBox();
            this.XaxisBox = new System.Windows.Forms.TextBox();
            this.YaxisBox = new System.Windows.Forms.TextBox();
            this.ZaxisBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialPortListBox = new System.Windows.Forms.ComboBox();
            this.AccelGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BufferSizeBox = new System.Windows.Forms.TextBox();
            this.BufferSize = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Sequence = new System.Windows.Forms.TextBox();
            this.XAvg = new System.Windows.Forms.TextBox();
            this.YAvg = new System.Windows.Forms.TextBox();
            this.ZAvg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.YAvgText = new System.Windows.Forms.Label();
            this.ZAvgText = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Orientation = new System.Windows.Forms.TextBox();
            this.ActionTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.XDiff = new System.Windows.Forms.TextBox();
            this.YDiff = new System.Windows.Forms.TextBox();
            this.ZDiff = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.XStdev = new System.Windows.Forms.TextBox();
            this.YStdev = new System.Windows.Forms.TextBox();
            this.ZStdev = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TotalG = new System.Windows.Forms.TextBox();
            this.QueueSize = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Action = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.BytestoreadBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.Orientreal = new System.Windows.Forms.TextBox();
            this.Totalgbox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serCom
            // 
            this.serCom.BaudRate = 128000;
            this.serCom.PortName = "COM4";
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data Buffer";
            // 
            // XDataBox
            // 
            this.XDataBox.Location = new System.Drawing.Point(794, 288);
            this.XDataBox.Multiline = true;
            this.XDataBox.Name = "XDataBox";
            this.XDataBox.Size = new System.Drawing.Size(247, 205);
            this.XDataBox.TabIndex = 12;
            // 
            // XaxisBox
            // 
            this.XaxisBox.Location = new System.Drawing.Point(38, 156);
            this.XaxisBox.Name = "XaxisBox";
            this.XaxisBox.Size = new System.Drawing.Size(70, 20);
            this.XaxisBox.TabIndex = 2;
            // 
            // YaxisBox
            // 
            this.YaxisBox.Location = new System.Drawing.Point(38, 182);
            this.YaxisBox.Name = "YaxisBox";
            this.YaxisBox.Size = new System.Drawing.Size(70, 20);
            this.YaxisBox.TabIndex = 3;
            // 
            // ZaxisBox
            // 
            this.ZaxisBox.Location = new System.Drawing.Point(38, 208);
            this.ZaxisBox.Name = "ZaxisBox";
            this.ZaxisBox.Size = new System.Drawing.Size(70, 20);
            this.ZaxisBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Port";
            // 
            // SerialPortListBox
            // 
            this.SerialPortListBox.FormattingEnabled = true;
            this.SerialPortListBox.Location = new System.Drawing.Point(38, 81);
            this.SerialPortListBox.Name = "SerialPortListBox";
            this.SerialPortListBox.Size = new System.Drawing.Size(132, 21);
            this.SerialPortListBox.TabIndex = 0;
            this.SerialPortListBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortListBox_SelectedIndexChanged);
            // 
            // AccelGraph
            // 
            this.AccelGraph.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea2.AxisX.Title = "Sample Point";
            chartArea2.AxisY.Title = "Acceleration (8 bit - binary)";
            chartArea2.Name = "ChartArea1";
            this.AccelGraph.ChartAreas.Add(chartArea2);
            this.AccelGraph.Location = new System.Drawing.Point(364, 43);
            this.AccelGraph.Name = "AccelGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.AccelGraph.Series.Add(series2);
            this.AccelGraph.Size = new System.Drawing.Size(678, 222);
            this.AccelGraph.TabIndex = 8;
            this.AccelGraph.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Acceleration Data";
            this.AccelGraph.Titles.Add(title2);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(185, 79);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(86, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Connect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z axis Difference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y axis Difference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X axis Difference";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(819, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "XData";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(891, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "YData";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(963, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "ZData";
            // 
            // BufferSizeBox
            // 
            this.BufferSizeBox.Location = new System.Drawing.Point(466, 315);
            this.BufferSizeBox.Name = "BufferSizeBox";
            this.BufferSizeBox.Size = new System.Drawing.Size(51, 20);
            this.BufferSizeBox.TabIndex = 23;
            // 
            // BufferSize
            // 
            this.BufferSize.AutoSize = true;
            this.BufferSize.Location = new System.Drawing.Point(463, 299);
            this.BufferSize.Name = "BufferSize";
            this.BufferSize.Size = new System.Drawing.Size(58, 13);
            this.BufferSize.TabIndex = 24;
            this.BufferSize.Text = "Buffer Size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Current Sequence";
            // 
            // Sequence
            // 
            this.Sequence.Location = new System.Drawing.Point(38, 428);
            this.Sequence.Name = "Sequence";
            this.Sequence.Size = new System.Drawing.Size(111, 20);
            this.Sequence.TabIndex = 25;
            // 
            // XAvg
            // 
            this.XAvg.Location = new System.Drawing.Point(216, 156);
            this.XAvg.Name = "XAvg";
            this.XAvg.Size = new System.Drawing.Size(70, 20);
            this.XAvg.TabIndex = 27;
            // 
            // YAvg
            // 
            this.YAvg.Location = new System.Drawing.Point(216, 182);
            this.YAvg.Name = "YAvg";
            this.YAvg.Size = new System.Drawing.Size(70, 20);
            this.YAvg.TabIndex = 28;
            // 
            // ZAvg
            // 
            this.ZAvg.Location = new System.Drawing.Point(216, 208);
            this.ZAvg.Name = "ZAvg";
            this.ZAvg.Size = new System.Drawing.Size(70, 20);
            this.ZAvg.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "X Avg";
            // 
            // YAvgText
            // 
            this.YAvgText.AutoSize = true;
            this.YAvgText.Location = new System.Drawing.Point(292, 185);
            this.YAvgText.Name = "YAvgText";
            this.YAvgText.Size = new System.Drawing.Size(36, 13);
            this.YAvgText.TabIndex = 31;
            this.YAvgText.Text = "Y Avg";
            // 
            // ZAvgText
            // 
            this.ZAvgText.AutoSize = true;
            this.ZAvgText.Location = new System.Drawing.Point(292, 211);
            this.ZAvgText.Name = "ZAvgText";
            this.ZAvgText.Size = new System.Drawing.Size(36, 13);
            this.ZAvgText.TabIndex = 32;
            this.ZAvgText.Text = "Z Avg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Current Orientation";
            // 
            // Orientation
            // 
            this.Orientation.Location = new System.Drawing.Point(38, 369);
            this.Orientation.Name = "Orientation";
            this.Orientation.Size = new System.Drawing.Size(111, 20);
            this.Orientation.TabIndex = 33;
            // 
            // ActionTimer
            // 
            this.ActionTimer.Enabled = true;
            this.ActionTimer.Interval = 2000;
            this.ActionTimer.Tick += new System.EventHandler(this.ActionTimer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "X axis Diff Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Y axis Diff Offset";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Z axis Diff Offset";
            // 
            // XDiff
            // 
            this.XDiff.Location = new System.Drawing.Point(38, 262);
            this.XDiff.Name = "XDiff";
            this.XDiff.Size = new System.Drawing.Size(70, 20);
            this.XDiff.TabIndex = 35;
            // 
            // YDiff
            // 
            this.YDiff.Location = new System.Drawing.Point(38, 288);
            this.YDiff.Name = "YDiff";
            this.YDiff.Size = new System.Drawing.Size(70, 20);
            this.YDiff.TabIndex = 36;
            // 
            // ZDiff
            // 
            this.ZDiff.Location = new System.Drawing.Point(38, 314);
            this.ZDiff.Name = "ZDiff";
            this.ZDiff.Size = new System.Drawing.Size(70, 20);
            this.ZDiff.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "X Stdev";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Y Stdev";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Z Stdev";
            // 
            // XStdev
            // 
            this.XStdev.Location = new System.Drawing.Point(216, 265);
            this.XStdev.Name = "XStdev";
            this.XStdev.Size = new System.Drawing.Size(70, 20);
            this.XStdev.TabIndex = 41;
            // 
            // YStdev
            // 
            this.YStdev.Location = new System.Drawing.Point(216, 291);
            this.YStdev.Name = "YStdev";
            this.YStdev.Size = new System.Drawing.Size(70, 20);
            this.YStdev.TabIndex = 42;
            // 
            // ZStdev
            // 
            this.ZStdev.Location = new System.Drawing.Point(216, 317);
            this.ZStdev.Name = "ZStdev";
            this.ZStdev.Size = new System.Drawing.Size(70, 20);
            this.ZStdev.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(458, 476);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "TotalG Avg";
            // 
            // TotalG
            // 
            this.TotalG.Location = new System.Drawing.Point(382, 473);
            this.TotalG.Name = "TotalG";
            this.TotalG.Size = new System.Drawing.Size(70, 20);
            this.TotalG.TabIndex = 47;
            // 
            // QueueSize
            // 
            this.QueueSize.Location = new System.Drawing.Point(466, 365);
            this.QueueSize.Name = "QueueSize";
            this.QueueSize.Size = new System.Drawing.Size(51, 20);
            this.QueueSize.TabIndex = 49;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(459, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Queue Size";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(38, 473);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(111, 20);
            this.Action.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(169, 473);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Action";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // BytestoreadBox
            // 
            this.BytestoreadBox.Location = new System.Drawing.Point(466, 424);
            this.BytestoreadBox.Name = "BytestoreadBox";
            this.BytestoreadBox.Size = new System.Drawing.Size(51, 20);
            this.BytestoreadBox.TabIndex = 53;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(449, 408);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "BytesToRead";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(169, 398);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Current Orientation (Real)";
            // 
            // Orientreal
            // 
            this.Orientreal.Location = new System.Drawing.Point(38, 395);
            this.Orientreal.Name = "Orientreal";
            this.Orientreal.Size = new System.Drawing.Size(111, 20);
            this.Orientreal.TabIndex = 56;
            // 
            // Totalgbox
            // 
            this.Totalgbox.Location = new System.Drawing.Point(541, 288);
            this.Totalgbox.Multiline = true;
            this.Totalgbox.Name = "Totalgbox";
            this.Totalgbox.Size = new System.Drawing.Size(247, 205);
            this.Totalgbox.TabIndex = 58;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(627, 499);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 59;
            this.label23.Text = "Total G log";
            // 
            // SensorTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 521);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Totalgbox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Orientreal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BytestoreadBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.QueueSize);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TotalG);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.XStdev);
            this.Controls.Add(this.YStdev);
            this.Controls.Add(this.ZStdev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.XDiff);
            this.Controls.Add(this.YDiff);
            this.Controls.Add(this.ZDiff);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Orientation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.YAvgText);
            this.Controls.Add(this.ZAvgText);
            this.Controls.Add(this.XAvg);
            this.Controls.Add(this.YAvg);
            this.Controls.Add(this.ZAvg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Sequence);
            this.Controls.Add(this.BufferSize);
            this.Controls.Add(this.BufferSizeBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XDataBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.XaxisBox);
            this.Controls.Add(this.AccelGraph);
            this.Controls.Add(this.YaxisBox);
            this.Controls.Add(this.SerialPortListBox);
            this.Controls.Add(this.ZaxisBox);
            this.MinimumSize = new System.Drawing.Size(260, 173);
            this.Name = "SensorTest";
            this.Text = "Setup Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupWindow_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SensorTest_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        public System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XDataBox;
        private System.Windows.Forms.TextBox XaxisBox;
        private System.Windows.Forms.TextBox YaxisBox;
        private System.Windows.Forms.TextBox ZaxisBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SerialPortListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelGraph;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BufferSizeBox;
        private System.Windows.Forms.Label BufferSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Sequence;
        private System.Windows.Forms.TextBox XAvg;
        private System.Windows.Forms.TextBox YAvg;
        private System.Windows.Forms.TextBox ZAvg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label YAvgText;
        private System.Windows.Forms.Label ZAvgText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Orientation;
        private System.Windows.Forms.Timer ActionTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox XDiff;
        private System.Windows.Forms.TextBox YDiff;
        private System.Windows.Forms.TextBox ZDiff;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox XStdev;
        private System.Windows.Forms.TextBox YStdev;
        private System.Windows.Forms.TextBox ZStdev;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TotalG;
        private System.Windows.Forms.TextBox QueueSize;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Action;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox BytestoreadBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Orientreal;
        private System.Windows.Forms.TextBox Totalgbox;
        private System.Windows.Forms.Label label23;
    }
}