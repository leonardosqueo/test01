namespace GCMSTests
{
    partial class ResponseRequestTabs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tRequest = new System.Windows.Forms.TabPage();
            this.requestOutput = new System.Windows.Forms.TextBox();
            this.tResponse = new System.Windows.Forms.TabPage();
            this.responseOutput = new System.Windows.Forms.TextBox();
            this.tJSON = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tRequest.SuspendLayout();
            this.tResponse.SuspendLayout();
            this.tJSON.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tRequest);
            this.tabControl1.Controls.Add(this.tResponse);
            this.tabControl1.Controls.Add(this.tJSON);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1069, 689);
            this.tabControl1.TabIndex = 1;
            // 
            // tRequest
            // 
            this.tRequest.Controls.Add(this.requestOutput);
            this.tRequest.Location = new System.Drawing.Point(4, 22);
            this.tRequest.Name = "tRequest";
            this.tRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tRequest.Size = new System.Drawing.Size(1061, 663);
            this.tRequest.TabIndex = 1;
            this.tRequest.Text = "Request";
            this.tRequest.UseVisualStyleBackColor = true;
            // 
            // requestOutput
            // 
            this.requestOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestOutput.Location = new System.Drawing.Point(3, 3);
            this.requestOutput.Multiline = true;
            this.requestOutput.Name = "requestOutput";
            this.requestOutput.ReadOnly = true;
            this.requestOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestOutput.Size = new System.Drawing.Size(1055, 657);
            this.requestOutput.TabIndex = 0;
            this.requestOutput.WordWrap = false;
            // 
            // tResponse
            // 
            this.tResponse.Controls.Add(this.responseOutput);
            this.tResponse.Location = new System.Drawing.Point(4, 22);
            this.tResponse.Name = "tResponse";
            this.tResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tResponse.Size = new System.Drawing.Size(1061, 663);
            this.tResponse.TabIndex = 2;
            this.tResponse.Text = "Response";
            this.tResponse.UseVisualStyleBackColor = true;
            // 
            // responseOutput
            // 
            this.responseOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responseOutput.Location = new System.Drawing.Point(3, 3);
            this.responseOutput.Multiline = true;
            this.responseOutput.Name = "responseOutput";
            this.responseOutput.ReadOnly = true;
            this.responseOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseOutput.Size = new System.Drawing.Size(1055, 657);
            this.responseOutput.TabIndex = 0;
            this.responseOutput.WordWrap = false;
            // 
            // tJSON
            // 
            this.tJSON.Controls.Add(this.treeView1);
            this.tJSON.Location = new System.Drawing.Point(4, 22);
            this.tJSON.Name = "tJSON";
            this.tJSON.Size = new System.Drawing.Size(1061, 663);
            this.tJSON.TabIndex = 3;
            this.tJSON.Text = "JSON";
            this.tJSON.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1061, 663);
            this.treeView1.TabIndex = 0;
            // 
            // ResponseRequestTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ResponseRequestTabs";
            this.Size = new System.Drawing.Size(1069, 689);
            this.tabControl1.ResumeLayout(false);
            this.tRequest.ResumeLayout(false);
            this.tRequest.PerformLayout();
            this.tResponse.ResumeLayout(false);
            this.tResponse.PerformLayout();
            this.tJSON.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tRequest;
        private System.Windows.Forms.TextBox requestOutput;
        private System.Windows.Forms.TabPage tResponse;
        private System.Windows.Forms.TextBox responseOutput;
        private System.Windows.Forms.TabPage tJSON;
        private System.Windows.Forms.TreeView treeView1;
    }
}
