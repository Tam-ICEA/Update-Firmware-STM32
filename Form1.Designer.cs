
namespace Update_Firmware_STM32
{
    partial class Form1
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
            this.btnOpenHexFile = new System.Windows.Forms.Button();
            this.tBoxFilename = new System.Windows.Forms.TextBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnEraseFlash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateFirmware = new System.Windows.Forms.Button();
            this.progressBar_WriteFirmware = new System.Windows.Forms.ProgressBar();
            this.btnSetFlag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenHexFile
            // 
            this.btnOpenHexFile.Location = new System.Drawing.Point(205, 26);
            this.btnOpenHexFile.Name = "btnOpenHexFile";
            this.btnOpenHexFile.Size = new System.Drawing.Size(75, 25);
            this.btnOpenHexFile.TabIndex = 0;
            this.btnOpenHexFile.Text = "Open";
            this.btnOpenHexFile.UseVisualStyleBackColor = true;
            this.btnOpenHexFile.Click += new System.EventHandler(this.btnOpenHexFile_Click);
            // 
            // tBoxFilename
            // 
            this.tBoxFilename.Location = new System.Drawing.Point(56, 29);
            this.tBoxFilename.Name = "tBoxFilename";
            this.tBoxFilename.Size = new System.Drawing.Size(123, 20);
            this.tBoxFilename.TabIndex = 1;
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(86, 20);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(93, 21);
            this.cBoxComPort.TabIndex = 56;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(205, 83);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 25);
            this.btnDisconnect.TabIndex = 54;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(205, 18);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 25);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cboParity.Location = new System.Drawing.Point(86, 85);
            this.cboParity.Margin = new System.Windows.Forms.Padding(4);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(93, 21);
            this.cboParity.TabIndex = 52;
            this.cboParity.Text = "None";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.cboBaudrate.Location = new System.Drawing.Point(86, 52);
            this.cboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(93, 21);
            this.cboBaudrate.TabIndex = 53;
            this.cboBaudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Port";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(86, 125);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 58;
            this.lblStatus.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Status :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.cboBaudrate);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cboParity);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 149);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tBoxFilename);
            this.groupBox2.Controls.Add(this.btnOpenHexFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 68);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetFlag);
            this.groupBox3.Controls.Add(this.btnVerify);
            this.groupBox3.Controls.Add(this.btnEraseFlash);
            this.groupBox3.Location = new System.Drawing.Point(12, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 112);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(205, 50);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 25);
            this.btnVerify.TabIndex = 59;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnEraseFlash
            // 
            this.btnEraseFlash.Location = new System.Drawing.Point(205, 19);
            this.btnEraseFlash.Name = "btnEraseFlash";
            this.btnEraseFlash.Size = new System.Drawing.Size(75, 25);
            this.btnEraseFlash.TabIndex = 58;
            this.btnEraseFlash.Text = "Erase Flash";
            this.btnEraseFlash.UseVisualStyleBackColor = true;
            this.btnEraseFlash.Click += new System.EventHandler(this.btnEraseFlash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateFirmware);
            this.groupBox4.Controls.Add(this.progressBar_WriteFirmware);
            this.groupBox4.Location = new System.Drawing.Point(12, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 95);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btnUpdateFirmware
            // 
            this.btnUpdateFirmware.Location = new System.Drawing.Point(70, 54);
            this.btnUpdateFirmware.Name = "btnUpdateFirmware";
            this.btnUpdateFirmware.Size = new System.Drawing.Size(145, 25);
            this.btnUpdateFirmware.TabIndex = 58;
            this.btnUpdateFirmware.Text = "Update Firmware";
            this.btnUpdateFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateFirmware.Click += new System.EventHandler(this.btnWriteFirmware_Click);
            // 
            // progressBar_WriteFirmware
            // 
            this.progressBar_WriteFirmware.Location = new System.Drawing.Point(6, 19);
            this.progressBar_WriteFirmware.Name = "progressBar_WriteFirmware";
            this.progressBar_WriteFirmware.Size = new System.Drawing.Size(282, 23);
            this.progressBar_WriteFirmware.Step = 1;
            this.progressBar_WriteFirmware.TabIndex = 0;
            // 
            // btnSetFlag
            // 
            this.btnSetFlag.Location = new System.Drawing.Point(205, 81);
            this.btnSetFlag.Name = "btnSetFlag";
            this.btnSetFlag.Size = new System.Drawing.Size(75, 25);
            this.btnSetFlag.TabIndex = 60;
            this.btnSetFlag.Text = "SetFlag";
            this.btnSetFlag.UseVisualStyleBackColor = true;
            this.btnSetFlag.Click += new System.EventHandler(this.btnSetFlag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "STM32 Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHexFile;
        private System.Windows.Forms.TextBox tBoxFilename;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateFirmware;
        private System.Windows.Forms.ProgressBar progressBar_WriteFirmware;
        private System.Windows.Forms.Button btnEraseFlash;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnSetFlag;
    }
}

