using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string s in drives)
            {
                TreeNode tn = treeView1.Nodes.Add(s);
                tn.Nodes.Add("");
                tn.Tag = "";

            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeExpand(e.Node);
        }

        private void NodeExpand(TreeNode tn)
        {
            if (tn.Nodes.Count != 0)
            {

                if (((string)tn.Tag) == "")
                {
                    tn.Nodes.RemoveAt(0);
                    AddTreeNodes(tn);
                    tn.Tag = "+";
                }
            }
        }

        private String GetFullPath(TreeNode tn)
        {
            TreeNode currNode = tn;
            String fullPath = currNode.Text;

            while (currNode.Parent != null)
            {
                currNode = currNode.Parent;
                fullPath = currNode.Text + @"\" + fullPath;
            }

            return fullPath + @"\";
        }

        private void AddTreeNodes(TreeNode tn)
        {
            TreeNode aux;
            DirectoryInfo d = new DirectoryInfo(GetFullPath(tn));
            DirectoryInfo[] ds;

            try
            {
                ds = d.GetDirectories();

                foreach (DirectoryInfo s in ds)
                {
                    aux = tn.Nodes.Add(s.Name);
                    aux.Tag = "";

                    try
                    {
                        // Если она не пуста,
                        if (s.GetDirectories().GetLength(0) != 0)
                        {
                            aux.Nodes.Add("");
                        }
                    }

                    catch (UnauthorizedAccessException) { }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
