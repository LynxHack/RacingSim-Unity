namespace Mech423RacingSimulator_LynxLu
{
    partial class SetupWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZDataBox = new System.Windows.Forms.TextBox();
            this.YDataBox = new System.Windows.Forms.TextBox();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serCom
            // 
            this.serCom.PortName = "COM4";
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(915, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Z axis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(684, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "X axis";
            // 
            // ZDataBox
            // 
            this.ZDataBox.Location = new System.Drawing.Point(823, 288);
            this.ZDataBox.Multiline = true;
            this.ZDataBox.Name = "ZDataBox";
            this.ZDataBox.Size = new System.Drawing.Size(219, 205);
            this.ZDataBox.TabIndex = 14;
            // 
            // YDataBox
            // 
            this.YDataBox.Location = new System.Drawing.Point(591, 288);
            this.YDataBox.Multiline = true;
            this.YDataBox.Name = "YDataBox";
            this.YDataBox.Size = new System.Drawing.Size(226, 205);
            this.YDataBox.TabIndex = 13;
            // 
            // XDataBox
            // 
            this.XDataBox.Location = new System.Drawing.Point(364, 288);
            this.XDataBox.Multiline = true;
            this.XDataBox.Name = "XDataBox";
            this.XDataBox.Size = new System.Drawing.Size(221, 205);
            this.XDataBox.TabIndex = 12;
            // 
            // XaxisBox
            // 
            this.XaxisBox.Location = new System.Drawing.Point(38, 156);
            this.XaxisBox.Name = "XaxisBox";
            this.XaxisBox.Size = new System.Drawing.Size(111, 20);
            this.XaxisBox.TabIndex = 2;
            // 
            // YaxisBox
            // 
            this.YaxisBox.Location = new System.Drawing.Point(38, 182);
            this.YaxisBox.Name = "YaxisBox";
            this.YaxisBox.Size = new System.Drawing.Size(111, 20);
            this.YaxisBox.TabIndex = 3;
            // 
            // ZaxisBox
            // 
            this.ZaxisBox.Location = new System.Drawing.Point(38, 208);
            this.ZaxisBox.Name = "ZaxisBox";
            this.ZaxisBox.Size = new System.Drawing.Size(111, 20);
            this.ZaxisBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Port";
            // 
            // SerialPortListBox
            // 
            this.SerialPortListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SerialPortListBox.FormattingEnabled = true;
            this.SerialPortListBox.Location = new System.Drawing.Point(17, 63);
            this.SerialPortListBox.Name = "SerialPortListBox";
            this.SerialPortListBox.Size = new System.Drawing.Size(132, 21);
            this.SerialPortListBox.TabIndex = 0;
            this.SerialPortListBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortListBox_SelectedIndexChanged);
            // 
            // AccelGraph
            // 
            chartArea4.AxisX.Title = "Sample Point";
            chartArea4.AxisY.Title = "Acceleration (8 bit - binary)";
            chartArea4.Name = "ChartArea1";
            this.AccelGraph.ChartAreas.Add(chartArea4);
            this.AccelGraph.Location = new System.Drawing.Point(364, 43);
            this.AccelGraph.Name = "AccelGraph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.AccelGraph.Series.Add(series4);
            this.AccelGraph.Size = new System.Drawing.Size(678, 239);
            this.AccelGraph.TabIndex = 8;
            this.AccelGraph.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Acceleration Data";
            this.AccelGraph.Titles.Add(title4);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.Color.LightSalmon;
            this.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisconnectButton.Location = new System.Drawing.Point(181, 109);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(86, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Connect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X axis";
            // 
            // SetupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(297, 153);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZDataBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YDataBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XDataBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.XaxisBox);
            this.Controls.Add(this.AccelGraph);
            this.Controls.Add(this.YaxisBox);
            this.Controls.Add(this.SerialPortListBox);
            this.Controls.Add(this.ZaxisBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(260, 173);
            this.Name = "SetupWindow";
            this.Text = "Setup Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZDataBox;
        private System.Windows.Forms.TextBox YDataBox;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Timer timer;
    }
}

