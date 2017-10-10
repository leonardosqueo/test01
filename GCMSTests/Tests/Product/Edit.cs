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
    public partial class Edit : UserControl
    {
        public int ItemId = 0;
        public GCMSTests.Classes.Item Item { get; set; }


        public Edit()
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
            /*if (this.Item.Id != 0)
            {*/
                this.Item.Code = this.Code.Text;
            //}
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
            Item.PublishingStatus = (Published.Checked ? (short)1 : (short)0);
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


        public void LoadItem(GCMSTests.Classes.Item it)
        {
            this.Item = it;
            this.ItemName.Text = it.Name;
            this.Code.Text = it.Code;
            this.ParentId.Text = it.ParentId.ToString();
            this.BoxHeight.Text = (it.BoxHeight != null ? it.BoxHeight.Value.ToString() : string.Empty);
            this.BoxLength.Text = (it.BoxLength != null ? it.BoxLength.Value.ToString() : string.Empty);
            this.BoxWeight.Text = (it.BoxWeight != null ? it.BoxWeight.Value.ToString() : string.Empty);
            this.BoxWidth.Text = (it.BoxWidth != null ? it.BoxWidth.Value.ToString() : string.Empty);
            this.DefaultStock.Text = it.DefaultStock.ToString();
            this.DefaultOfferPrice.Text = it.DefaultOfferPrice != null ? it.DefaultOfferPrice.Value.ToString() : string.Empty;
            this.DefaultMinStock.Text = it.DefaultMinStock.ToString();
            this.DefaultPrice.Text = it.DefaultPrice.ToString();
            this.Description.Text = it.Description;
            this.ForSale.Checked = it.ForSale;
            this.FreeShipping.Checked = it.FreeShipping;
            this.Keywords.Text = it.Keywords;
            this.Published.Checked = it.PublishingStatus == (short)1;
            
        }
    }
}
