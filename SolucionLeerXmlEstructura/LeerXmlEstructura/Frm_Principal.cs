using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LeerXmlEstructura
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImprimirCol(DataSet dataSet)
        {
            // For each table in the DataSet, print the row values.
            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        objListView.Items.Add(row[column].ToString());
                    }
                }
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }

            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog carpeta = new OpenFileDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                var path = carpeta.FileName;

                try
                {
                    //-------------------------------------------------------------------------------------

                    XmlReader xRead = XmlReader.Create(path);
                    XElement xEle = XElement.Load(xRead);
                    objTextBox.Text = (xEle.ToString());
                    xRead.Close();

                    //-------------------------------------------------------------------------------------

                    DataSet dt = new DataSet();
                    dt.ReadXml(path);
                    objDataGridView.DataSource = dt.Tables[1];

                    //-------------------------------------------------------------------------------------

                    ImprimirCol(dt);

                    //-------------------------------------------------------------------------------------
                    // SECTION 1. Create a DOM Document and load the XML data into it.
                    XmlDocument dom = new XmlDocument();
                    dom.Load(path);
                    // SECTION 2. Initialize the TreeView control.
                    objTreeView.Nodes.Clear();
                    objTreeView.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                    TreeNode tNode = new TreeNode();
                    tNode = objTreeView.Nodes[0];
                    // SECTION 3. Populate the TreeView with the DOM nodes.
                    AddNode(dom.DocumentElement, tNode);
                    objTreeView.ExpandAll();
                    //------------------------------------------------------------------------------------
                }
                catch (XmlException xmlEx)
                {
                    MessageBox.Show(xmlEx.Message + "   XmlExeption");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "   Exception");
                }
            }
        }
    }
}
