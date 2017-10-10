using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCMSTests.Tests.Category
{
    public partial class List : UserControl
    {

        public event EventHandler EditData;
        public event EventHandler EditCode;
        public event EventHandler Delete;


        private void OnEditData(EventArgs e, object sender)
        {
            if (EditData != null)
                EditData(sender, e);
        }

        private void OnEditCode(EventArgs e, object sender)
        {
            if (EditCode != null)
                EditCode(sender, e);
        }

        private void OnDelete(EventArgs e, object sender)
        {
            if (Delete != null)
                Delete(sender, e);
        }


        public List()
        {
            InitializeComponent();

            /*
            string getResult = Get(this.tUrl.Text + "Category?hash=" + resAuth.data + "&parentId=0", "GET", null);
            List<Item> rsDer = Deserialise<List<Item>>(getResult);*/



            LoadCats();
        }

        protected void LoadCats() {
            string h = Pman.GenerateNewHash();

            Pman.RequestSend += Pman_RequestSend;
            Pman.ResponseRecieve += Pman_ResponseRecieve;
            Pman.Error += Pman_Error;

            string getResult = Pman.Get("Category?hash=" + h + "&parentId=0", "GET", null);

            List<GCMSTests.Classes.Item> rsDer = GCMSTests.Classes.Base.Deserialise<List<GCMSTests.Classes.Item>>(getResult);
            this.treeView1.Nodes.Clear();
            LoadTree(0, rsDer, null);
            Pman.RequestSend -= Pman_RequestSend;
            Pman.ResponseRecieve -= Pman_ResponseRecieve;
            Pman.Error -= Pman_Error;
        }


        private void LoadTree(int parent, List<GCMSTests.Classes.Item> tree, TreeNode parentNode) {

            var l = (from i in tree where i.ParentId == parent select i).ToArray();
            if(l.Length > 0) {
                foreach (var r in l) {

                    TreeNode tn = new TreeNode(r.Name);
                    tn.Tag = r.ToString();
                    if (parentNode == null) {
                        treeView1.Nodes.Add(tn);
                    }
                    else
                    {
                        parentNode.Nodes.Add(tn);
                    }
                    LoadTree(r.Id, tree, tn);
                }
            }
            


        }


        private void Pman_Error(object sender, EventArgs e)
        {
            MessageBox.Show((string)sender, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Pman_ResponseRecieve(object sender, EventArgs e)
        {
            responseRequestTabs1.Response = (string)sender;
        }

        private void Pman_RequestSend(object sender, EventArgs e)
        {
            responseRequestTabs1.Request = (string)sender;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadCats();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null) {

                DetailsForm df = new DetailsForm();
                df.LoadData(treeView1.SelectedNode.Tag.ToString());
                df.ShowDialog();
           
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                OnEditData(EventArgs.Empty, treeView1.SelectedNode.Tag.ToString());
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                OnDelete(EventArgs.Empty, treeView1.SelectedNode.Tag.ToString());
            }
        }
    }
}
