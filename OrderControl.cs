using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace Warehouse
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }
        private string all;
        public string ajobs
        {
            get { return all; }
            set { all = value; }
        }
        private string sw;
            public string Switchs
        {
            get { return sw; }
            set { sw = value; }
        }
        private string Searchpath;
        public string Pathsearch
        {
            get { return Searchpath; }
            set { Searchpath = value; }
        }
        public List<string> nav
        {
            get { return nl; }
            set { nl = value; }
        }
        private List<string> nl = new List<string>();
        private void OrderControl_Load(object sender, EventArgs e)
        {
            
        
    }
        private string navv;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            try
            {
                this.ls.ListViewItemSorter = new ListViewItemComparer(e.Column);
            }
            catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories(Pathsearch);
            this.SendToBack();

            foreach (string Job in dirs)
            {
                if (!Job.Contains("Archive"))
                {
                    if (!Job.Contains("Properties"))
                    {

                        if (File.Exists(Job + @"\Properties\JobName.txt"))
                        {
                            string BadJob = File.ReadAllText(Job + @"\Properties\JobName.txt");
                            if (BadJob != "")
                            {
                                string tt = File.ReadAllText(Job + @"\Properties\BidDate.txt");


                                if (tt != "")
                                { ls.Items.Add(Job).SubItems.Add(tt); }


                            }

                        }

                        

                    }


                }
            }
            if (Switchs == "on")
            {
                if (Directory.Exists(Pathsearch + @"/Archive"))
                {

                    string[] Adyears = Directory.GetDirectories(Pathsearch + @"/Archive");
                    foreach (string year in Adyears)
                    {
                        if (!year.Contains("Properties"))
                        {
                            string[] months = Directory.GetDirectories(year);
                            foreach (string month in months)
                            {
                                if (!months.Contains("Properties"))
                                {
                                    string[] jobs = Directory.GetDirectories(month);
                                    foreach (string job in jobs)
                                    {
                                        if (!job.Contains("Properties"))
                                        {
                                            try
                                            {
                                                string BadJob = File.ReadAllText(job + @"\Properties\JobName.txt");
                                                if (BadJob != "")
                                                {
                                                    string tt = File.ReadAllText(job + @"\Properties\BidDate.txt");


                                                    if (tt != "")
                                                    { ls.Items.Add(job).SubItems.Add(tt); }
                                                }

                                            }

                                            catch { }


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (ajobs != "on")
            {
                ColumnClickEventArgs eArgs = new ColumnClickEventArgs(BidDate.DisplayIndex);
                listView1_ColumnClick(ls, eArgs);
            }
            foreach (object x in ls.Items)
            {
                string w = ((ListViewItem)x).Text;
                nl.Add(w);


            }
        }
    }
}
class ListViewItemComparer : IComparer
{
    private int col;
    public ListViewItemComparer()
    {
        col = 0;

    }
    public ListViewItemComparer(int column)
    {
        col = column;
    }
    public int Compare(object x, object y)
    {
        {
            
                string a = ((ListViewItem)x).SubItems[col].Text;
                string b = ((ListViewItem)y).SubItems[col].Text;

                DateTime t = DateTime.Parse(a);
                DateTime tt = DateTime.Parse(b);
                return DateTime.Compare(t, tt);
            
          
        }

    }
}