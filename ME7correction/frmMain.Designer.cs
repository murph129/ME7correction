﻿namespace ME7correction
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheckStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCorrectStatus = new System.Windows.Forms.Label();
            this.lblCorrectedCheckStatus = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtSW = new System.Windows.Forms.TextBox();
            this.txtENG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(585, 39);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.White;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileName.Location = new System.Drawing.Point(12, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(567, 23);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(586, 9);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "\".bin\" select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Checksum Validation:";
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            this.lblCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckStatus.ForeColor = System.Drawing.Color.White;
            this.lblCheckStatus.Location = new System.Drawing.Point(138, 12);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(30, 13);
            this.lblCheckStatus.TabIndex = 6;
            this.lblCheckStatus.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Checksum Correction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(403, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Corrected Checksum Validation:\r\n";
            // 
            // lblCorrectStatus
            // 
            this.lblCorrectStatus.AutoSize = true;
            this.lblCorrectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectStatus.ForeColor = System.Drawing.Color.White;
            this.lblCorrectStatus.Location = new System.Drawing.Point(334, 12);
            this.lblCorrectStatus.Name = "lblCorrectStatus";
            this.lblCorrectStatus.Size = new System.Drawing.Size(30, 13);
            this.lblCorrectStatus.TabIndex = 9;
            this.lblCorrectStatus.Text = "N/A";
            // 
            // lblCorrectedCheckStatus
            // 
            this.lblCorrectedCheckStatus.AutoSize = true;
            this.lblCorrectedCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectedCheckStatus.ForeColor = System.Drawing.Color.White;
            this.lblCorrectedCheckStatus.Location = new System.Drawing.Point(597, 12);
            this.lblCorrectedCheckStatus.Name = "lblCorrectedCheckStatus";
            this.lblCorrectedCheckStatus.Size = new System.Drawing.Size(30, 13);
            this.lblCorrectedCheckStatus.TabIndex = 10;
            this.lblCorrectedCheckStatus.Text = "N/A";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtOutput.Location = new System.Drawing.Point(12, 73);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(729, 301);
            this.txtOutput.TabIndex = 11;
            this.txtOutput.Text = "Please select a .bin file and press \"Check\" to begin.";
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(666, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLog
            // 
            this.btnLog.Enabled = false;
            this.btnLog.Location = new System.Drawing.Point(666, 39);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 14;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ECU PN#:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ECU SW:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(416, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Engine:";
            // 
            // txtPN
            // 
            this.txtPN.BackColor = System.Drawing.Color.White;
            this.txtPN.Location = new System.Drawing.Point(87, 42);
            this.txtPN.Name = "txtPN";
            this.txtPN.ReadOnly = true;
            this.txtPN.Size = new System.Drawing.Size(160, 20);
            this.txtPN.TabIndex = 18;
            this.txtPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSW
            // 
            this.txtSW.BackColor = System.Drawing.Color.White;
            this.txtSW.Location = new System.Drawing.Point(337, 41);
            this.txtSW.Name = "txtSW";
            this.txtSW.ReadOnly = true;
            this.txtSW.Size = new System.Drawing.Size(64, 20);
            this.txtSW.TabIndex = 19;
            this.txtSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtENG
            // 
            this.txtENG.BackColor = System.Drawing.Color.White;
            this.txtENG.Location = new System.Drawing.Point(472, 42);
            this.txtENG.Name = "txtENG";
            this.txtENG.ReadOnly = true;
            this.txtENG.Size = new System.Drawing.Size(107, 20);
            this.txtENG.TabIndex = 20;
            this.txtENG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblCheckStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCorrectStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCorrectedCheckStatus);
            this.panel1.Location = new System.Drawing.Point(12, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 37);
            this.panel1.TabIndex = 22;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(668, 12);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 13);
            this.lblVersion.TabIndex = 23;
            this.lblVersion.Text = "V000000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(754, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtENG);
            this.Controls.Add(this.txtSW);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnCheck);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ME7.x Correction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheckStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCorrectStatus;
        private System.Windows.Forms.Label lblCorrectedCheckStatus;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtSW;
        private System.Windows.Forms.TextBox txtENG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timer1;
    }
}

