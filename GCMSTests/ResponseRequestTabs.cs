using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GCMSTests
{
    public partial class ResponseRequestTabs : UserControl
    {
        public ResponseRequestTabs()
        {
            InitializeComponent();
        }

        public string Response {
            get { return this.responseOutput.Text; }
            set { this.responseOutput.Text = new Classes.JsonFormatter(value).Format();
                /*try
                {*/
                    this.treeView1.Nodes.Clear();
                    LoadJsonToTreeView(this.treeView1, value);
                /*}
                catch { }*/
            }
        }

        public string Request {
            get { return this.requestOutput.Text; }
            set { requestOutput.Text = value;
               
            }
        }


        void LoadJsonToTreeView(TreeView treeView, string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            if (json.Trim().StartsWith("[")){
                var @object = JArray.Parse(json);
                AddArrayNodes(@object, "JSON", treeView.Nodes);
                
            }else{ 

            var @object = JObject.Parse(json);
            AddObjectNodes(@object, "JSON", treeView.Nodes);
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
