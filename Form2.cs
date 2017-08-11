using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }
        
        private void ChildForm_Load(object sender, EventArgs e)
        {
            //string filePath = "";
            //List<WItem> Products = new List<WItem>();
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach(var line in lines)
            //{
            //    string[] entries = line.Split(',');
            //    WItem wNewItem = new WItem();
            //    wNewItem.wAmount = entries[0];
            //    wNewItem.wTag = entries[1];
            //    Products.Add(wNewItem);
            //}
            //foreach(var product in Products)
            //{

            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
