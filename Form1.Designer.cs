
namespace DNSeriesConfig
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
            this.btGetCFfile = new System.Windows.Forms.Button();
            this.tbBackupFilePath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostIP = new System.Windows.Forms.TextBox();
            this.tbHostPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMachineIP = new System.Windows.Forms.TextBox();
            this.tbMachineSubnet = new System.Windows.Forms.TextBox();
            this.tbMachineDFgateway = new System.Windows.Forms.TextBox();
            this.tbMachineNo = new System.Windows.Forms.TextBox();
            this.tbLuno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btSetCF = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btGetCFMachine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGetCFfile
            // 
            this.btGetCFfile.Location = new System.Drawing.Point(344, 120);
            this.btGetCFfile.Name = "btGetCFfile";
            this.btGetCFfile.Size = new System.Drawing.Size(110, 29);
            this.btGetCFfile.TabIndex = 0;
            this.btGetCFfile.Text = "GetCFFromFile";
            this.btGetCFfile.UseVisualStyleBackColor = true;
            this.btGetCFfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBackupFilePath
            // 
            this.tbBackupFilePath.BackColor = System.Drawing.SystemColors.Info;
            this.tbBackupFilePath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBackupFilePath.Location = new System.Drawing.Point(127, 12);
            this.tbBackupFilePath.Name = "tbBackupFilePath";
            this.tbBackupFilePath.Size = new System.Drawing.Size(237, 26);
            this.tbBackupFilePath.TabIndex = 1;
            this.tbBackupFilePath.Text = "D:\\DNSeriesConfig\r\n";
            this.tbBackupFilePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(379, 12);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 26);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browser";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOST IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbHostIP
            // 
            this.tbHostIP.Location = new System.Drawing.Point(77, 56);
            this.tbHostIP.Name = "tbHostIP";
            this.tbHostIP.Size = new System.Drawing.Size(189, 20);
            this.tbHostIP.TabIndex = 4;
            this.tbHostIP.TextChanged += new System.EventHandler(this.tbHostIP_TextChanged);
            // 
            // tbHostPort
            // 
            this.tbHostPort.Location = new System.Drawing.Point(344, 56);
            this.tbHostPort.Name = "tbHostPort";
            this.tbHostPort.Size = new System.Drawing.Size(110, 20);
            this.tbHostPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PORT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbMachineIP
            // 
            this.tbMachineIP.Location = new System.Drawing.Point(106, 120);
            this.tbMachineIP.Name = "tbMachineIP";
            this.tbMachineIP.Size = new System.Drawing.Size(185, 20);
            this.tbMachineIP.TabIndex = 8;
            // 
            // tbMachineSubnet
            // 
            this.tbMachineSubnet.Location = new System.Drawing.Point(106, 146);
            this.tbMachineSubnet.Name = "tbMachineSubnet";
            this.tbMachineSubnet.Size = new System.Drawing.Size(185, 20);
            this.tbMachineSubnet.TabIndex = 9;
            // 
            // tbMachineDFgateway
            // 
            this.tbMachineDFgateway.Location = new System.Drawing.Point(106, 172);
            this.tbMachineDFgateway.Name = "tbMachineDFgateway";
            this.tbMachineDFgateway.Size = new System.Drawing.Size(185, 20);
            this.tbMachineDFgateway.TabIndex = 10;
            // 
            // tbMachineNo
            // 
            this.tbMachineNo.Location = new System.Drawing.Point(106, 226);
            this.tbMachineNo.Name = "tbMachineNo";
            this.tbMachineNo.Size = new System.Drawing.Size(185, 20);
            this.tbMachineNo.TabIndex = 11;
            // 
            // tbLuno
            // 
            this.tbLuno.Location = new System.Drawing.Point(106, 252);
            this.tbLuno.Name = "tbLuno";
            this.tbLuno.Size = new System.Drawing.Size(184, 20);
            this.tbLuno.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "IP Máy";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Subnet mask";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Default Gateway";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Machine No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Luno";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btSetCF
            // 
            this.btSetCF.Location = new System.Drawing.Point(344, 214);
            this.btSetCF.Name = "btSetCF";
            this.btSetCF.Size = new System.Drawing.Size(110, 60);
            this.btSetCF.TabIndex = 19;
            this.btSetCF.Text = "SET CONFIG";
            this.btSetCF.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Đường dẫn lưu config";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btGetCFMachine
            // 
            this.btGetCFMachine.Location = new System.Drawing.Point(344, 159);
            this.btGetCFMachine.Name = "btGetCFMachine";
            this.btGetCFMachine.Size = new System.Drawing.Size(110, 29);
            this.btGetCFMachine.TabIndex = 21;
            this.btGetCFMachine.Text = "GetCFFromMachine";
            this.btGetCFMachine.UseVisualStyleBackColor = true;
            this.btGetCFMachine.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 292);
            this.Controls.Add(this.btGetCFMachine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btSetCF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLuno);
            this.Controls.Add(this.tbMachineNo);
            this.Controls.Add(this.tbMachineDFgateway);
            this.Controls.Add(this.tbMachineSubnet);
            this.Controls.Add(this.tbMachineIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHostPort);
            this.Controls.Add(this.tbHostIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbBackupFilePath);
            this.Controls.Add(this.btGetCFfile);
            this.Name = "Form1";
            this.Text = "DVN cfg tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGetCFfile;
        private System.Windows.Forms.TextBox tbBackupFilePath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostIP;
        private System.Windows.Forms.TextBox tbHostPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMachineIP;
        private System.Windows.Forms.TextBox tbMachineSubnet;
        private System.Windows.Forms.TextBox tbMachineDFgateway;
        private System.Windows.Forms.TextBox tbMachineNo;
        private System.Windows.Forms.TextBox tbLuno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSetCF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btGetCFMachine;
    }
}

