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
    public partial class Form1 : Form
    {
        
     


        protected void ChekConnStatus() {

            if (!string.IsNullOrEmpty(Pman.LastHash)) {
                connectLabelStatus.Text = "Estado de Conexión: Conectado!";
            } else
            {
                connectLabelStatus.Text = "Estado de Conexión: Desconectado";
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeConnection mk = new MakeConnection();

            if (mk.ShowDialog() == DialogResult.OK) {
                ChekConnStatus();
            }
        }

        private void listarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckConnection(true))
            {
                return;
            }
            Loader.Controls.Clear();
            Loader.Text = "Listado de Categorias";
            Loader.Visible = true;
            GCMSTests.Tests.Category.List lc = new GCMSTests.Tests.Category.List();
            lc.EditData += Lc_EditData;
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
            

        }

        private void Lc_EditData(object sender, EventArgs e)
        {
            Loader.Controls.Clear();
            Loader.Text = "Editar Categorias";
            Loader.Visible = true;
            GCMSTests.Tests.Category.Edit lc = new GCMSTests.Tests.Category.Edit();            
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
        }

        protected bool CheckConnection(bool vervose) {

            if (string.IsNullOrEmpty(Pman.LastHash))
            {
                if (vervose) {
                    MessageBox.Show("No esta conectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
            
        }





        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (requestsToolStripMenuItem.Checked)
            {                
                splitContainer1.Panel2Collapsed = true;                
                requestsToolStripMenuItem.Checked = false;
            }
            else
            {             
                splitContainer1.Panel2Collapsed = false;
                requestsToolStripMenuItem.Checked = true;
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckConnection(true))
            {
                return;
            }
            Loader.Controls.Clear();
            Loader.Text = "Crear artículo";
            Loader.Visible = true;
            GCMSTests.Tests.Product.Create lc = new GCMSTests.Tests.Product.Create();            
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckConnection(true))
            {
                return;
            }
            Loader.Controls.Clear();
            Loader.Text = "Listado de Articulos";
            Loader.Visible = true;
            GCMSTests.Tests.Product.List lc = new GCMSTests.Tests.Product.List();
            lc.EditData += La_EditData;
            lc.Delete += La_Delete;
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
        }

        private void La_Delete(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el articulo ?", "Achtung", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                GCMSTests.Classes.Item it = (GCMSTests.Classes.Item)sender;
                string h = Pman.GenerateNewHash();

                
                string getResult =  Pman.Get("Product/" + it.Id.ToString() + "?hash=" + h, "DELETE",null);
                Loader.Controls.Clear();
                
            }

        }

        private void La_EditData(object sender, EventArgs e)
        {
            Loader.Controls.Clear();
            Loader.Text = "Editar Articulo";
            Loader.Visible = true;
            GCMSTests.Tests.Product.Edit lc = new GCMSTests.Tests.Product.Edit();
            lc.LoadItem((GCMSTests.Classes.Item)sender);
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckConnection(true))
            {
                return;
            }
            Loader.Controls.Clear();
            Loader.Text = "Listado de Operaciones";
            Loader.Visible = true;
            GCMSTests.Tests.Sale.List lc = new GCMSTests.Tests.Sale.List();
           /* lc.EditData += La_EditData;
            lc.Delete += La_Delete;*/
            Loader.Controls.Add(lc);
            Loader.Controls[0].Dock = DockStyle.Fill;
        }
    }
}
