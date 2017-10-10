namespace GCMSTests
{
    partial class PostHistory
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ordinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mehtod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Requests = new System.Windows.Forms.GroupBox();
            this.Requests.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ordinal,
            this.Url,
            this.Mehtod,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1210, 193);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Ordinal
            // 
            this.Ordinal.Text = "";
            this.Ordinal.Width = 36;
            // 
            // Url
            // 
            this.Url.Text = "Url";
            this.Url.Width = 795;
            // 
            // Mehtod
            // 
            this.Mehtod.Text = "Metodo";
            this.Mehtod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mehtod.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estado";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 169;
            // 
            // Requests
            // 
            this.Requests.Controls.Add(this.listView1);
            this.Requests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Requests.Location = new System.Drawing.Point(0, 0);
            this.Requests.Name = "Requests";
            this.Requests.Size = new System.Drawing.Size(1216, 212);
            this.Requests.TabIndex = 2;
            this.Requests.TabStop = false;
            this.Requests.Text = "Requests";
            // 
            // PostHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Requests);
            this.Name = "PostHistory";
            this.Size = new System.Drawing.Size(1216, 212);
            this.Requests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ordinal;
        private System.Windows.Forms.ColumnHeader Url;
        private System.Windows.Forms.ColumnHeader Mehtod;
        private System.Windows.Forms.GroupBox Requests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
