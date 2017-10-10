using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCMSTests
{
    public partial class MakeConnection : Form
    {
        public string ConnectionHash { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public MakeConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            this.ConnectionHash = string.Empty;
            this.Url = tbUrl.Text;
            this.Username = tUsername.Text;
            this.Password = tPassword.Text;

            GCMSTests.Pman.Error += Pman_Error;
            string hash = Pman.Connect(this.Url, this.Username, this.Password);
            if (!string.IsNullOrEmpty(hash))
            {
                this.DialogResult = DialogResult.OK;
            }            
            GCMSTests.Pman.Error -= Pman_Error;
            

        }

        private void Pman_Error(object sender, EventArgs e)
        {
            MessageBox.Show("Error en conexión: " + Environment.NewLine + (string)sender, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MakeConnection_Load(object sender, EventArgs e)
        {
            

        }
    }
}
