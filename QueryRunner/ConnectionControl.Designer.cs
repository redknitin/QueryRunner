namespace QueryRunner
{
    partial class ConnectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSqlAuth = new System.Windows.Forms.RadioButton();
            this.rdoWinAuth = new System.Windows.Forms.RadioButton();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(78, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(198, 20);
            this.txtServer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoSqlAuth);
            this.groupBox1.Controls.Add(this.rdoWinAuth);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(106, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(141, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // rdoSqlAuth
            // 
            this.rdoSqlAuth.AutoSize = true;
            this.rdoSqlAuth.Checked = true;
            this.rdoSqlAuth.Location = new System.Drawing.Point(17, 42);
            this.rdoSqlAuth.Name = "rdoSqlAuth";
            this.rdoSqlAuth.Size = new System.Drawing.Size(117, 17);
            this.rdoSqlAuth.TabIndex = 1;
            this.rdoSqlAuth.TabStop = true;
            this.rdoSqlAuth.Text = "SQL Authentication";
            this.rdoSqlAuth.UseVisualStyleBackColor = true;
            this.rdoSqlAuth.CheckedChanged += new System.EventHandler(this.rdoSqlAuth_CheckedChanged);
            // 
            // rdoWinAuth
            // 
            this.rdoWinAuth.AutoSize = true;
            this.rdoWinAuth.Location = new System.Drawing.Point(17, 19);
            this.rdoWinAuth.Name = "rdoWinAuth";
            this.rdoWinAuth.Size = new System.Drawing.Size(140, 17);
            this.rdoWinAuth.TabIndex = 0;
            this.rdoWinAuth.Text = "Windows Authentication";
            this.rdoWinAuth.UseVisualStyleBackColor = true;
            this.rdoWinAuth.CheckedChanged += new System.EventHandler(this.rdoWinAuth_CheckedChanged);
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(78, 186);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(198, 20);
            this.txtDb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(78, 222);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(159, 222);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 265);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "-";
            // 
            // ConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "ConnectionControl";
            this.Size = new System.Drawing.Size(295, 296);
            this.Load += new System.EventHandler(this.ConnectionControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSqlAuth;
        private System.Windows.Forms.RadioButton rdoWinAuth;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
    }
}
