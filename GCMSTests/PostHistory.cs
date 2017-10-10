using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCMSTests
{
    public partial class PostHistory : UserControl
    {

        List<GCMSTests.PmanActionRecord> _RecList;

        public List<GCMSTests.PmanActionRecord> RecList {
            get { return _RecList; }
            set { _RecList = value; }
        }

        public PostHistory()
        {
            InitializeComponent();
            this.RecList = new List<PmanActionRecord>();

            Pman.SendData += Pman_SendData;
            listView1.AutoResizeColumn(listView1.Columns.Count - 1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Pman_SendData(object sender, EventArgs e)
        {
            PmanActionRecord pmar = (PmanActionRecord)sender;
          //  RecList.Add(pmar);

            ListViewItem lvi = new ListViewItem() { Text = pmar.Ordinal.ToString(), Tag = pmar };
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, pmar.Url));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, pmar.Method));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, pmar.Status));
            lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, pmar.Date.ToString()));
            this.listView1.Items.Add(lvi);
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {

                

                

                    Sniffer df = new Sniffer();
                df.LoadData((PmanActionRecord)listView1.SelectedItems[0].Tag);
                df.ShowDialog();
            }
        }
    }
}
