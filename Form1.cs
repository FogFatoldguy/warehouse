using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Warehouse
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            this.lls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        }
      

        private System.Windows.Forms.ColumnHeader lls;
        private System.Windows.Forms.ColumnHeader bls;
        public string ChadJ = @"F:\Internal Jobs\Jobs\Chad\Jobs";
        public string ErvJ = @"F:\Internal Jobs\Jobs\Erv\Jobs";
        public string DanJ = @"F:\Internal Jobs\Jobs\Dan\Jobs";
        public string TerryJ = @"F:\Internal Jobs\Jobs\Terry\Jobs";
        public string MillerJ = @"F:\Internal Jobs\Jobs\Miller\Jobs";
        public string NateJ = @"F:\Internal Jobs\Jobs\Nate\Jobs";
        public string CLOC = "";

        private void Navigate(string Nav)
        {
            table1.Enabled = false;
            Panel.Controls.Clear();
            
            OrderControl oc = new OrderControl();
            if (btnJobDisplay.Text == "All Jobs")
            { oc.Switchs = "on"; }
                oc.Pathsearch = Nav;
            oc.Visible = false;
            this.Controls.Add(oc);
            oc.Show();
            oc.button1.PerformClick();
            

           
           

            


                foreach (object x in oc.ls.Items)
                {
                    string w = ((ListViewItem)x).Text;

                    Item itm = new Item();
                    itm.Product = Path.GetFileName(w);
                    itm.FullPath = w;
                itm.Name = w;
                    itm.btnSchedule.Click += DisplaySchedule;
                    Panel.Controls.Add(itm);


                }

            this.Controls.Remove(oc);
                table1.Enabled = true;
            }
        
        private void Navigate(string Nav, string navs)
        {


            OrderControl oc = new OrderControl();
            table1.Enabled = false;
            
           
            if (btnJobDisplay.Text == "All Jobs")
            { oc.Switchs = "on"; }
            oc.Pathsearch = Nav;
            oc.ajobs = "on";
            this.Controls.Add(oc);
            oc.Show();
            oc.button1.PerformClick();






          
        
    }

        private void Stock_Load(object sender, EventArgs e)
        {
            newItem1.Width = Panel.Width;
            
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

        }
        private void DisplaySchedule(object sender, EventArgs e)
        {
            PDFViewer.BringToFront();
            btnClose.BringToFront();
            PDFViewer.Visible = true;
            btnClose.Visible = true;
            if (sender is Button)
            {
                var button = (Button)sender;
                CLOC = button.Parent.Parent.Name.ToString();
            }
            Control[] controls = this.Controls.Find(CLOC, true);
            if (controls.Length == 1) // 0 means not found, more - there are several controls with the same name
            {
                Item control = controls[0] as Item;
                if (control != null)
                {

                }
                MessageBox.Show(control.FullPath);
                PDFViewer.Navigate(control.FullPath + @"\4-Plans\Listings\1.pdf");
                btnClose.BringToFront();
            }

        }
        private void allJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnJobDisplay.Text = "All Jobs";
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnJobDisplay.Text = "Current Jobs";
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLoc1_Click(object sender, EventArgs e)
        {
            Navigate(ChadJ);
        }

        private void Floc2_Click(object sender, EventArgs e)
        {
            Navigate(ErvJ);
        }

        private void Floc3_Click(object sender, EventArgs e)
        {
            Navigate(DanJ);
        }

        private void FLoc8_Click(object sender, EventArgs e)
        {try
            {
                OrderControl oc = new OrderControl();
                table1.Enabled = false;
                Panel.Controls.Clear();
                
                
                string NavAll = "";
                foreach (string file in Directory.GetFiles(@"C:\ThermAirSales\CustomLocation"))
                {
                    NavAll = File.ReadAllText(file);
                    if (NavAll != "")
                    { Navigate(NavAll, ""); }
                }
                foreach (string file in Directory.GetFiles(@"C:\ThermAirSales\Main"))
                {
                    NavAll = File.ReadAllText(file);
                    if (NavAll != "")
                    { Navigate(NavAll, ""); }
                }
                ColumnClickEventArgs eArgs = new ColumnClickEventArgs(oc.BidDate.DisplayIndex);
                listView1_ColumnClick(oc.ls, eArgs);
                foreach (object x in oc.ls.Items)
                {
                    string w = ((ListViewItem)x).Text;

                    Item itm = new Item();
                    itm.Product = Path.GetFileName(w);
                    itm.FullPath = w;
                    itm.btnSchedule.Click += DisplaySchedule;
                    Panel.Controls.Add(itm);


                }
                this.Controls.Remove(oc);

                
                table1.Enabled = true;
            }
            catch { }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            PDFViewer.Visible = false;
            btnClose.Visible = false;
            PDFViewer.Navigate("");
            PDFViewer.Stop();
        }
        private string CustomGo;
        private void CustomNavigate()
        {

            CustomNav.Items.Clear();
            try
            {

                foreach (string file in Directory.GetFiles(@"C:\ThermAirSales\CustomLocation"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click;
                    item.Name = Path.GetFileName(file);
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    CustomNav.Items.Add(item);

                }
                ToolStripItem item2 = new ToolStripMenuItem();
                item2.Click += CreateNewLocation;
                item2.Text = "+ Job Location";
                item2.ForeColor = Color.Red;
                CustomNav.Items.Add(item2);
            }
            catch
            { }
            CustomNav.Show(FLoc9, 0, -FLoc9.Height + 30);
        }
        private string CustomItem;
        private void Item_Click(object sender, EventArgs e)
        { 
             CustomGo = File.ReadAllText(@"C:\ThermAirSales\CustomLocation\" + CustomItem + ".txt");
            Navigate(CustomGo);
        }
        private int f;
        private void CreateNewLocation(object sender, EventArgs e)
        {
            tmrCustomL.Start();
        }
        private void FLoc9_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\ThermAirSales"))
            {
                Directory.CreateDirectory(@"C:\ThermAirSales");
                if (!Directory.Exists(@"C:\ThermAirSales\CustomLocation"))
                {
                    Directory.CreateDirectory(@"C:\ThermAirSales\CustomLocation");
                }
                else
                {
                    CustomNavigate();
                }
            }
            else
            {
                if (!Directory.Exists(@"C:\ThermAirSales\CustomLocation"))
                {
                    Directory.CreateDirectory(@"C:\ThermAirSales\CustomLocation");
                }
                else
                {
                    CustomNavigate();
                }
            }
        }
        private void CreatingJobLocation()
        {
            tmrCustomL.Stop();
            
                FolderBrowserDialog fb = new FolderBrowserDialog();
                fb.ShowDialog();
                CustomGo = fb.SelectedPath.ToString();

                File.WriteAllText(@"C:\ThermAirSales\CustomLocation\" + f + ".txt", CustomGo);
                
            
            
              
            
        }



        private void tmrCustomL_Tick(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\ThermAirSales\CustomLocation\" + f + ".txt"))
            {
                CreatingJobLocation();

            }
            else
            {
                f += 1;
            }


        }
       
        private void CustomNav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            CustomItem = e.ClickedItem.ToString();
        }

        private void btnJobDisplay_Click(object sender, EventArgs e)
        {
            if (btnJobDisplay.Text == "Current Jobs") 
            {
                btnJobDisplay.Text = "All Jobs";
            }
            else
            {
                btnJobDisplay.Text = "Current Jobs";
            }
        }
        private void textBox1_TextChanged()
        {
            try
            {
                foreach (Item c in Panel.Controls)
                {
                    if (c.lblJobName.Text.Contains(sJN.Text))
                    {
                        c.Visible = true;

                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }

            catch { }

        }
        private void sL_TextChanged()
        {
            try
            {
                foreach (Item c in Panel.Controls)
                {
                    if (c.lblLocation.Text.Contains(sL.Text))
                    {
                        c.Visible = true;

                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }

            catch { }
        }

        private void sC_TextChanged()
        {
            try
            {
                foreach (Item c in Panel.Controls)
                {
                    if (c.lblContact.Text.Contains(sC.Text))
                    {
                        c.Visible = true;

                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }

            catch { }
        }

        private void sE_TextChanged()
        {
            try
            {
                foreach (Item c in Panel.Controls)
                {
                    if (c.lblEngineer.Text.Contains(sE.Text))
                    {
                        c.Visible = true;

                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }

            catch { }
        }

        private void sJobN_TextChanged()
        {
            try
            {
                foreach (Item c in Panel.Controls)
                {
                    if (c.lblJobNumber.Text.Contains(sJobN.Text))
                    {
                        c.Visible = true;

                    }
                    else
                    {
                        c.Visible = false;
                    }
                }
            }

            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sJN.Text != "")
            { textBox1_TextChanged(); }
            else
            {
                if (sC.Text == "")
                { if (sE.Text == "") { if (sL.Text == "") { if (sJobN.Text == "") { sC_TextChanged(); } } }
                }
            }
            if (sC.Text != "")
            { sC_TextChanged(); }
            if (sE.Text != "")
            { sE_TextChanged(); }
            if (sL.Text != "")
            { sL_TextChanged(); }
            if (sJobN.Text != "")
            { sJobN_TextChanged(); }
            
            
          
            
           

        }

        private void FLoc4_Click(object sender, EventArgs e)
        {
            Navigate(@"F:\Internal Jobs\Jobs\Jacob\Jobs");
        }

        private void FLoc5_Click(object sender, EventArgs e)
        {
            Navigate(@"F:\Internal Jobs\Jobs\Nate\Jobs");
        }

        private void FLoc6_Click(object sender, EventArgs e)
        {
            Navigate(@"F:\Internal Jobs\Jobs\Miller\Jobs");
        }

        private void FLoc7_Click(object sender, EventArgs e)
        {
            Navigate(@"F:\Internal Jobs\Jobs\Terry\Jobs");
        }
       
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            OrderControl oc = new OrderControl();

            oc.ls.ListViewItemSorter = new ListViewItemComparer(e.Column);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
//class ListViewItemComparer : IComparer
//{
//    private int col;
//    public ListViewItemComparer()
//    {
//        col = 0;

//    }
//    public ListViewItemComparer(int column)
//    {
//        col = column;
//    }
//    public int Compare(object x, object y)
//    {
//        {

//            string a = ((ListViewItem)x).SubItems[col].Text;
//            string b = ((ListViewItem)y).SubItems[col].Text;

//            DateTime t = DateTime.Parse(a);
//            DateTime tt = DateTime.Parse(b);
//            return DateTime.Compare(t, tt);


//        }

//    }
//}