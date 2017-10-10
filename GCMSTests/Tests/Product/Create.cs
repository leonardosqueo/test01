using System;
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
    public partial class Create : UserControl
    {
        public int ItemId = 0;
        public GCMSTests.Classes.Item Item { get; set; }


        public Create()
        {
            InitializeComponent();
            this.ParentId.Text = "0";
            this.DefaultPrice.Text = decimal.Zero.ToString();
            this.DefaultMinStock.Text = "0";
            this.DefaultStock.Text = "-1";
            this.Published.Checked = true;
            this.ForSale.Checked = true;
            this.FreeShipping.Checked = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(this.Item == null)
            {
                /*default data*/
                this.Item = new Classes.Item();
                Item.AutoMeta = true;
                Item.Brand = string.Empty;
                Item.Sync = true;
                Item.SyncPrice = true;
                Item.Id = 0;
                Item.Author = string.Empty;
                Item.ContentDisplay = 0;
                Item.ContentOrder = 0;
                Item.ContentRecsPerPage = 0;
                Item.ContentSort = true;
                Item.IncludeOnRss = true;
                Item.IncludeOnSitemap = true;
                Item.IsCombo = false;
                Item.UnitsMultiplier = 1;
                Item.Vigency = false;
                Item.MetaLang = string.Empty;
                
            }

            this.Item.Name = this.ItemName.Text;
            if (this.Item.Id == 0)
            {
                this.Item.Code = this.Code.Text;
            }
            this.Item.ParentId = int.Parse(this.ParentId.Text);
            Item.BoxHeight = (!string.IsNullOrEmpty(BoxHeight.Text) ? (decimal?)decimal.Parse(BoxHeight.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) : null);
            Item.BoxLength = (!string.IsNullOrEmpty(BoxLength.Text) ? (decimal?)decimal.Parse(BoxLength.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) : null);
            Item.BoxWeight = (!string.IsNullOrEmpty(BoxWeight.Text) ? (decimal?)decimal.Parse(BoxWeight.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) : null);
            Item.BoxWidth = (!string.IsNullOrEmpty(BoxWidth.Text) ? (decimal?)decimal.Parse(BoxWidth.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) : null);
            Item.DefaultMinStock = int.Parse(DefaultMinStock.Text);
            Item.DefaultOfferPrice = (!string.IsNullOrEmpty(DefaultOfferPrice.Text) ? (decimal?)decimal.Parse(DefaultOfferPrice.Text.Replace(",","."),System.Globalization.CultureInfo.InvariantCulture) : null);
            Item.DefaultPrice = decimal.Parse(DefaultPrice.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            Item.DefaultStock = int.Parse(DefaultStock.Text);
            Item.Description = Description.Text;
            Item.ForSale = ForSale.Checked;
            Item.FreeShipping = FreeShipping.Checked;
            Item.Keywords = this.Keywords.Text;

            string h = Pman.GenerateNewHash();

            Pman.RequestSend += Pman_RequestSend;
            Pman.ResponseRecieve += Pman_ResponseRecieve;
            Pman.Error += Pman_Error;
            string getResult = string.Empty;
            if (Item.Id > 0)
            {
                getResult = Pman.Get("Product/" + Item.Id.ToString()+"?hash="+h, "PUT", Item.ToString());
            }
            else
            {
                getResult = Pman.Get("Product/?hash=" + h, "POST", Item.ToString());

            }

            Item = GCMSTests.Classes.Base.Deserialise<GCMSTests.Classes.Item>(getResult);
            
            
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

    }
}
