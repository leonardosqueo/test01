﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCMSTests.Tests.Product
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
            LoadItems();
        }


        private void LoadItems()
        {
            string h = Pman.GenerateNewHash();

            Pman.RequestSend += Pman_RequestSend;
            Pman.ResponseRecieve += Pman_ResponseRecieve;
            Pman.Error += Pman_Error;

            string getResult = Pman.Get("Product?hash=" + h + "&parentId=0&order=&ascending=&term=&mode=&status=&fields=&filtersand&filtersor", "GET", null);
            
            List<GCMSTests.Classes.Item> rsDer = GCMSTests.Classes.Base.Deserialise<List<GCMSTests.Classes.Item>>(getResult);
            this.listView1.Items.Clear();
            foreach(var it in rsDer)
            {
                ListViewItem lvi = new ListViewItem() { Text = it.Id.ToString(), Tag = it };
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, it.Code));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, it.Name));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, it.DefaultPrice.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, it.DefaultStock.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, it.DefaultMinStock.ToString()));
                this.listView1.Items.Add(lvi);

            }
            /*this.treeView1.Nodes.Clear();
            LoadTree(0, rsDer, null);
            */
            Pman.RequestSend -= Pman_RequestSend;
            Pman.ResponseRecieve -= Pman_ResponseRecieve;
            Pman.Error -= Pman_Error;

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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems != null)
            {

                DetailsForm df = new DetailsForm();
                df.LoadData(listView1.SelectedItems[0].Tag.ToString());
                df.ShowDialog();

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            if (listView1.SelectedItems != null)
            {

                DetailsForm df = new DetailsForm();
                df.LoadData(listView1.SelectedItems[0].Tag.ToString());
                df.ShowDialog();

            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {

                OnEditData(EventArgs.Empty, listView1.SelectedItems[0].Tag);

            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {

                OnDelete(EventArgs.Empty, listView1.SelectedItems[0].Tag);

            }

            
        }
    }
}
