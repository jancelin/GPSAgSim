namespace AgSim
{
    partial class FormSim
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNMEA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHz = new System.Windows.Forms.NumericUpDown();
            this.tbarHeading = new System.Windows.Forms.TrackBar();
            this.lblHeadingTrue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHead0 = new System.Windows.Forms.Button();
            this.btnHead270 = new System.Windows.Forms.Button();
            this.btnHead180 = new System.Windows.Forms.Button();
            this.btnHead90 = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNMEA
            // 
            this.txtNMEA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMEA.Location = new System.Drawing.Point(9, 9);
            this.txtNMEA.Multiline = true;
            this.txtNMEA.Name = "txtNMEA";
            this.txtNMEA.Size = new System.Drawing.Size(546, 63);
            this.txtNMEA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "M/sec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hz";
            // 
            // nudHz
            // 
            this.nudHz.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHz.Location = new System.Drawing.Point(460, 188);
            this.nudHz.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHz.Name = "nudHz";
            this.nudHz.Size = new System.Drawing.Size(79, 40);
            this.nudHz.TabIndex = 4;
            this.nudHz.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHz.ValueChanged += new System.EventHandler(this.nudHz_ValueChanged);
            // 
            // tbarHeading
            // 
            this.tbarHeading.LargeChange = 20;
            this.tbarHeading.Location = new System.Drawing.Point(78, 171);
            this.tbarHeading.Maximum = 360;
            this.tbarHeading.Name = "tbarHeading";
            this.tbarHeading.Size = new System.Drawing.Size(347, 45);
            this.tbarHeading.TabIndex = 8;
            this.tbarHeading.TickFrequency = 20;
            this.tbarHeading.Value = 180;
            this.tbarHeading.Scroll += new System.EventHandler(this.tbarHeading_Scroll);
            // 
            // lblHeadingTrue
            // 
            this.lblHeadingTrue.AutoSize = true;
            this.lblHeadingTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTrue.Location = new System.Drawing.Point(230, 144);
            this.lblHeadingTrue.Name = "lblHeadingTrue";
            this.lblHeadingTrue.Size = new System.Drawing.Size(40, 24);
            this.lblHeadingTrue.TabIndex = 9;
            this.lblHeadingTrue.Text = "180";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "360";
            // 
            // btnHead0
            // 
            this.btnHead0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead0.Location = new System.Drawing.Point(200, 97);
            this.btnHead0.Name = "btnHead0";
            this.btnHead0.Size = new System.Drawing.Size(75, 30);
            this.btnHead0.TabIndex = 12;
            this.btnHead0.Text = "0";
            this.btnHead0.UseVisualStyleBackColor = true;
            this.btnHead0.Click += new System.EventHandler(this.btnHead0_Click);
            // 
            // btnHead270
            // 
            this.btnHead270.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead270.Location = new System.Drawing.Point(464, 97);
            this.btnHead270.Name = "btnHead270";
            this.btnHead270.Size = new System.Drawing.Size(75, 30);
            this.btnHead270.TabIndex = 13;
            this.btnHead270.Text = "270";
            this.btnHead270.UseVisualStyleBackColor = true;
            this.btnHead270.Click += new System.EventHandler(this.btnHead270_Click);
            // 
            // btnHead180
            // 
            this.btnHead180.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead180.Location = new System.Drawing.Point(374, 97);
            this.btnHead180.Name = "btnHead180";
            this.btnHead180.Size = new System.Drawing.Size(75, 30);
            this.btnHead180.TabIndex = 14;
            this.btnHead180.Text = "180";
            this.btnHead180.UseVisualStyleBackColor = true;
            this.btnHead180.Click += new System.EventHandler(this.btnHead180_Click);
            // 
            // btnHead90
            // 
            this.btnHead90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHead90.Location = new System.Drawing.Point(291, 97);
            this.btnHead90.Name = "btnHead90";
            this.btnHead90.Size = new System.Drawing.Size(75, 30);
            this.btnHead90.TabIndex = 15;
            this.btnHead90.Text = "90";
            this.btnHead90.UseVisualStyleBackColor = true;
            this.btnHead90.Click += new System.EventHandler(this.btnHead90_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(12, 97);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 30);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(88, 97);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 30);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // tbarStepDistance
            // 
            this.tbarStepDistance.LargeChange = 10;
            this.tbarStepDistance.Location = new System.Drawing.Point(57, 222);
            this.tbarStepDistance.Maximum = 100;
            this.tbarStepDistance.Name = "tbarStepDistance";
            this.tbarStepDistance.Size = new System.Drawing.Size(368, 45);
            this.tbarStepDistance.SmallChange = 2;
            this.tbarStepDistance.TabIndex = 18;
            this.tbarStepDistance.TickFrequency = 10;
            this.tbarStepDistance.Value = 10;
            this.tbarStepDistance.Scroll += new System.EventHandler(this.tbarStepDistance_Scroll);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.Location = new System.Drawing.Point(27, 218);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(20, 24);
            this.lblStep.TabIndex = 19;
            this.lblStep.Text = "1";
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseSerial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial.Location = new System.Drawing.Point(577, 222);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(95, 34);
            this.btnCloseSerial.TabIndex = 48;
            this.btnCloseSerial.Text = "Close";
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // cboxPort
            // 
            this.cboxPort.AllowDrop = true;
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(577, 21);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(96, 31);
            this.cboxPort.TabIndex = 46;
            this.cboxPort.Text = "Port";
            this.cboxPort.Leave += new System.EventHandler(this.cboxPort_Leave);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud.Location = new System.Drawing.Point(577, 87);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(96, 31);
            this.cboxBaud.TabIndex = 47;
            this.cboxBaud.Text = "Baud";
            this.cboxBaud.Leave += new System.EventHandler(this.cboxBaud_Leave);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenSerial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Location = new System.Drawing.Point(577, 153);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(95, 34);
            this.btnOpenSerial.TabIndex = 49;
            this.btnOpenSerial.Text = "Open";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Port";
            // 
            // FormSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 276);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseSerial);
            this.Controls.Add(this.cboxPort);
            this.Controls.Add(this.cboxBaud);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.tbarStepDistance);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnHead90);
            this.Controls.Add(this.btnHead180);
            this.Controls.Add(this.btnHead270);
            this.Controls.Add(this.btnHead0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeadingTrue);
            this.Controls.Add(this.tbarHeading);
            this.Controls.Add(this.nudHz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNMEA);
            this.Name = "FormSim";
            this.Text = "GPS Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSim_FormClosing);
            this.Load += new System.EventHandler(this.FormSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtNMEA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHz;
        private System.Windows.Forms.TrackBar tbarHeading;
        private System.Windows.Forms.Label lblHeadingTrue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHead0;
        private System.Windows.Forms.Button btnHead270;
        private System.Windows.Forms.Button btnHead180;
        private System.Windows.Forms.Button btnHead90;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Label label3;
    }
}

