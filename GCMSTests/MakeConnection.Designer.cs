namespace GCMSTests
{
    partial class MakeConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url Site";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(77, 9);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(395, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "http://cmsv3.e3ecommerce.com/api/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(77, 35);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(125, 20);
            this.tUsername.TabIndex = 4;
            this.tUsername.Text = "admin";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(77, 64);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(125, 20);
            this.tPassword.TabIndex = 5;
            this.tPassword.Text = "123456";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(397, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tCancel
            // 
            this.tCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tCancel.Location = new System.Drawing.Point(294, 57);
            this.tCancel.Name = "tCancel";
            this.tCancel.Size = new System.Drawing.Size(75, 23);
            this.tCancel.TabIndex = 7;
            this.tCancel.Text = "Cancelar";
            this.tCancel.UseVisualStyleBackColor = true;
            // 
            // MakeConnection
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tCancel;
            this.ClientSize = new System.Drawing.Size(492, 94);
            this.ControlBox = false;
            this.Controls.Add(this.tCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeConnection";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeConnection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MakeConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button tCancel;
    }
}