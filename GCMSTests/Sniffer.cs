using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GCMSTests
{
    public partial class Sniffer : Form
    {
        public Sniffer()
        {
            InitializeComponent();
        }

        public void LoadData(PmanActionRecord pmar) {

            tbRequest.Text = string.Empty;
            tbResponse.Text = string.Empty;
            treeView1.Nodes.Clear();
            
            tbRequest.Text = "URL: " + pmar.Url;
            tbRequest.Text += Environment.NewLine + "METHOD: " + pmar.Method;
            tbRequest.Text += Environment.NewLine + "Headers:";
            foreach (string k in pmar.Headers.Keys)
            {
                tbRequest.Text += Environment.NewLine + "   "+k+": "+pmar.Headers[k];
            }
            tbRequest.Text += Environment.NewLine;
            tbRequest.Text += Environment.NewLine+"BODY:";
            try {
                tbRequest.Text += Environment.NewLine + new Classes.JsonFormatter(pmar.Body).Format() ;
            } catch {
                 tbRequest.Text += Environment.NewLine + pmar.Body;
            }

            tbResponse.Text = "Status: " + pmar.Status;
            tbResponse.Text += Environment.NewLine;
            try {
                tbResponse.Text += Environment.NewLine + new Classes.JsonFormatter(pmar.Response).Format();
            }
            catch { 
            tbResponse.Text += pmar.Response;
            }

            try
            {
                LoadJsonToTreeView(this.treeView1, pmar.Response);
            }
            catch { }


        
        }


        void LoadJsonToTreeView(TreeView treeView, string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            if (json.Trim().StartsWith("["))
            {
                var @object = JArray.Parse(json);
                AddArrayNodes(@object, "JSON", treeView.Nodes);

            }
            else
            {

                var @object = JObject.Parse(json);
                /*   AddObjectNodes(@object, "JSON", treeView.Nodes);*/
                foreach (var property in @object.Properties())
                {
                    AddTokenNodes(property.Value, property.Name, treeView.Nodes);
                }
            }
        }

        void AddObjectNodes(JObject @object, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode(name);
            parent.Add(node);

            foreach (var property in @object.Properties())
            {
                AddTokenNodes(property.Value, property.Name, node.Nodes);
            }
        }

        void AddArrayNodes(JArray array, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode(name);
            parent.Add(node);

            for (var i = 0; i < array.Count; i++)
            {
                AddTokenNodes(array[i], string.Format("[{0}]", i), node.Nodes);
            }
        }

        void AddTokenNodes(JToken token, string name, TreeNodeCollection parent)
        {
            if (token is JValue)
            {
                parent.Add(new TreeNode(string.Format("{0}: {1}", name, ((JValue)token).Value)));
            }
            else if (token is JArray)
            {
                AddArrayNodes((JArray)token, name, parent);
            }
            else if (token is JObject)
            {
                AddObjectNodes((JObject)token, name, parent);
            }
        }
    }
}
