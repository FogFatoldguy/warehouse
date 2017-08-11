using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Warehouse
{
    public partial class NewItem : UserControl
    {
        public NewItem()
        {
            InitializeComponent();
        }
        private int width;
        private string todaysdate = DateTime.Today.ToString("MM-dd-yyyy");
        private Size start;
        private Size center = new Size(0, 0);
        //  private Size start = new Size(970, 238);
        //  private Size open = new Size(721, 415);
        private Size open;
        public string prd;
        public string det;
        public string nam;
        public string fp;
        public string OrderName
        {
            get { return nam; }
            set { nam = value; }
        }
        public string Product
        {
            get { return prd; }
            set { prd = value; }
        }
        public string Details
        {
            get { return det; }
            set { det = value; }
        }
        public string FullPath
        {
            get { return fp; }
            set { fp = value; }
        }
        public string Nav;
        private string Longpath = @"F:\Internal Jobs\Therm-Air Files\Program\P3\Data\";

        private void JobImage_Click(object sender, EventArgs e)
        {
            if (this.Size == start)
            {
                this.Size = open;
                B1.Visible = true;
                Panel1.Visible = true;
               
            }
            else
            {
                this.Size = start;
                B1.Visible = false;
                Panel1.Visible = false;
                Panel1.Controls.Clear();
            }
        }

        private void Item_Load(object sender, EventArgs e)
        {
            
           
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {



        }








        private void miAmt_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void PName_TextChanged(object sender, EventArgs e)
        {
            jJobName.Text = lblJobName.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Panel1.GoBack();
        }
        #region Option Buttons
        private int f;
        private int d;
        public string selTakeOffitem = "";
        public string selPriceitem = "";
        public string selCapsitem = "";
        public string NewJob = @"F:\Internal Jobs\Jobs\";
        private void btnPrice_Click(object sender, EventArgs e)
        {
           
        }
        private void Pricepricingexist(object sender, EventArgs e)
        {
           
        }

        private void tmrPrice_Tick(object sender, EventArgs e)
        {

           

        }

        private void menuPrice_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }
        private void Item_Click2(object sender, EventArgs e)
        {
            
        }

        #endregion
        #region Caps Pricing
        private void btnCaps_Click(object sender, EventArgs e)
        {
          
            
        }
        private void MenuCaps_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void tmrCaps_Tick(object sender, EventArgs e)
        {

            
        }
        private void capspricingexist(object sender, EventArgs e)
        {
           
        }
        private void Item_Click1(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Take Off Job Menu 
        private int c;
        private void button4_Click(object sender, EventArgs e)
        {


            Nav = Path.GetFullPath(FullPath);
            tfdropdown.Items.Clear();


            try
            {

                foreach (string file in Directory.GetFiles(@Nav + @"\2-Take Off", "*.xlsm"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click;
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    tfdropdown.Items.Add(item);

                }
                ToolStripItem item2 = new ToolStripMenuItem();
                item2.Click += takeoffsepricingexist;
                item2.Text = "+ New Take Off";
                item2.ForeColor = Color.Red;
                tfdropdown.Items.Add(item2);

            }
            catch
            { }
            tfdropdown.Show(btnTakeOff, 0, -btnTakeOff.Height);

        }
        private void takeoffsepricingexist(object sender, EventArgs e)
        {
            takeoffexist.Start();
        }


        private void tfdropdown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            selTakeOffitem = e.ClickedItem.ToString();

        }

        
        private void takeoffexist_Tick(object sender, EventArgs e)
        {

            
            if (!File.Exists(@Nav + @"\2-Take Off\" + todaysdate + " - " + c + ".xlsm"))
            {
                File.Copy((@"F:\Internal Jobs\Therm-Air Files\ThermAirProgram\Take Offs.xlsm"),
              (@Nav + @"\2-Take Off\" + todaysdate + " - " + c + ".xlsm"));

                takeoffexist.Stop();

            }

            c += 1;


        }
        private void Item_Click(object sender, EventArgs e)
        {
            Process.Start(@Nav + @"\2-Take Off\" + selTakeOffitem + ".xlsm");
        }

        #endregion

        private void lblLocation_TextChanged(object sender, EventArgs e)
        {
            jLocation.Text = lblLocation.Text;
        }

        private void lblBidDate_TextChanged(object sender, EventArgs e)
        {
            jBidDate.Text = lblBidDate.Text;
        }
        private void htmlLink()
        {
            if (lblContact.Text.Contains("Chad Evert"))
                lblContact.Text.Replace("Chad Evert", "7");


            HtmlDocument doc = tasJob.Document;

            

            HtmlElement wbJobName = doc.GetElementById("Name"); //lblcontact.text
            HtmlElement wbEngineer = doc.GetElementById("engineer-lookup"); //
            HtmlElement wbSalesEng = doc.GetElementById("SalesEngineerUserId");
            HtmlElement wbLocation = doc.GetElementById("Location");
            HtmlElement wbBidDate = doc.GetElementById("BidDate");
            HtmlElement wbPriorApproval = doc.GetElementById("PriorApproval"); //True or False
            HtmlElement wbTakeOff = doc.GetElementById("TakeOffComplete"); //True or False
            HtmlElement wbProject = doc.GetElementById("RoleType"); //Design/Build or Plan/Spec
            HtmlElement element = doc.GetElementById("ftitle");

            HtmlElementCollection classButton = tasJob.Document.All;


            
                wbJobName.SetAttribute("value", lblJobName.Text);



                if (lblContact.Text.Contains("Dan Lenertz"))
                    wbSalesEng.SetAttribute("value", "2");
                if (lblContact.Text.Contains("Kelley Lenertz"))
                    wbSalesEng.SetAttribute("value", "3");
                if (lblContact.Text.Contains("Erv Ratajczak"))
                    wbSalesEng.SetAttribute("value", "4");
                if (lblContact.Text.Contains("Marc Ratajczak"))
                    wbSalesEng.SetAttribute("value", "5");
                if (lblContact.Text.Contains("Terry Steiner"))
                    wbSalesEng.SetAttribute("value", "6");
                if (lblContact.Text.Contains("Chad Evert"))
                    wbSalesEng.SetAttribute("value", "7");
                if (lblContact.Text.Contains("Jacob Lenertz"))
                    wbSalesEng.SetAttribute("value", "10");
                if (lblContact.Text.Contains("Terry Miller"))
                    wbSalesEng.SetAttribute("value", "11");
                if (lblContact.Text.Contains("Nate Kirkeby"))
                    wbSalesEng.SetAttribute("value", "12");

                wbLocation.SetAttribute("value", lblLocation.Text);
                wbBidDate.SetAttribute("value", lblBidDate.Text);

                if (lblPriorApp.Text.Contains("Yes"))
                    wbPriorApproval.SetAttribute("value", "true");
                if (lblPriorApp.Text.Contains("No"))
                    wbPriorApproval.SetAttribute("value", "false");
                if (lblTakeOff.Text.Contains("Done"))
                    wbTakeOff.SetAttribute("value", "true");
                if (lblTakeOff.Text.Contains("Not Done"))
                    wbTakeOff.SetAttribute("value", "false");

                wbEngineer.SetAttribute("value", lblEngineer.Text);
                wbProject.SetAttribute("value", lblProject.Text);

            }
        
        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (btnExpand.Text == "Expand") 
            {
                tasJob.BringToFront();
                tasJob.Location = new Point(3, 112);
                tasJob.Size = new Size(1056, 329);
                tasJob.Visible = true;
                
                htmlLink();
               // tasJob.Navigate("http://thermairdc/projects/Project/Entry/" + lblJobNumber.Text);

                btnExpand.Text = "Close";
            }
            else
            {
                tasJob.Visible = false;
                btnExpand.Text = "Expand";
                tasJob.Navigate("http://thermairdc/projects/Project/Entry/");
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {try
            {if (btnNotes.Text == "Notes")
                {
                    Notes.BringToFront();
                    Notes.Location = new Point(3, 112);
                    Notes.Size = new Size(960, 329);
                    Notes.Visible = true;
                    Notes.Text = File.ReadAllText(FullPath + @"\Properties\Notes\NNotes.txt");
                    btnNotes.Text = "Close";
                }
            else
                {
                    btnNotes.Text = "Notes";
                    Notes.Visible = false;
                    File.WriteAllText(FullPath + @"\Properties\Notes\NNotes.txt", Notes.Text);
                }
            }
            catch { }
        }

        private void lblEngineer_TextChanged(object sender, EventArgs e)
        {
            jEngineer.Text = lblEngineer.Text;
        }
        private string contact;
        public void WriteToPropertiesNJ()
        {

            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Contact.txt", lblContact.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\JobName.txt", lblJobName.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\BidDate.txt", lblBidDate.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Engineer.txt", lblEngineer.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\TakeOff.txt", lblTakeOff.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Location.txt", lblLocation.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\PriorApp.txt", lblPriorApp.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Received.txt", lblRecieved.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Project.txt", lblProject.Text);         
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Notes\NNotes.txt", Notes.Text);          
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\thisJobNumber.txt", lblJobNumber.Text);

            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Contact.txt", lblContact.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\JobName.txt", lblJobName.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\BidDate.txt", lblBidDate.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Engineer.txt", lblEngineer.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\TakeOff.txt", lblTakeOff.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Location.txt", lblLocation.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\PriorApp.txt", lblPriorApp.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Received.txt", lblRecieved.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Project.txt", lblProject.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\Notes\NNotes.txt", Notes.Text);
            File.WriteAllText(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\2-Take Off\Properties\thisJobNumber.txt", lblJobNumber.Text);
        }
        
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lblContact.Text.Contains("Chad"))
                { contact = "Chad"; }
                if (lblContact.Text.Contains("Miller"))
                { contact = "Miller"; }
                if (lblContact.Text.Contains("Erv"))
                { contact = "Erv"; }
                if (lblContact.Text.Contains("Terry"))
                { contact = "Terry"; }
                if (lblContact.Text.Contains("Nate"))
                { contact = "Nate"; }
                if (lblContact.Text.Contains("Jacob"))
                { contact = "Jacob"; }
                if (lblContact.Text.Contains("Dan"))
                { contact = "Dan"; }

                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text);



                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\0-Submittals"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\0-Submittals");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\1-Pricing"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\1-Pricing");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off" + "\\Properties"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off" + "\\Properties");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off" + "\\Properties\\Notes"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\2-Take Off" + "\\Properties\\Notes");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\3-Files"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\3-Files");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\4-Plans"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\4-Plans");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\\4-Plans" + "\\Listings"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\\4-Plans" + "\\Listings");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\5-Specs"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\5-Specs");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\6-Emails"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\6-Emails");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\Properties"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + "\\Properties");
                if (!Directory.Exists(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Notes"))
                    Directory.CreateDirectory(@NewJob + "\\" + contact + @"\Jobs\" + lblJobName.Text + @"\Properties\Notes");
                WriteToPropertiesNJ();

            }
            catch { }
            lblBidDate.Text = "";
            lblContact.Text = "";
            lblJobName.Text = "Create New Job";
            lblJobNumber.Text = "";
            lblPriorApp.Text = "";
            lblLocation.Text = "";
            lblRecieved.Text = "";
            lblTakeOff.Text = "";
            lblEngineer.Text = "";
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(lblContact, 0, lblContact.Height);
        }
        private void chadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblContact.Text = "Chad Evert";
        }
        private void danToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblContact.Text = "Dan Lenertz";
        }
        private void terrySToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblContact.Text = "Terry Steiner";
        }
        private void terryMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblContact.Text = "Terry Miller";
        }
        private void jacobToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblContact.Text = "Jacob Lenertz";
        }
        private void ervToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblContact.Text = "Erv Ratajczak";
        }
        private void nateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lblContact.Text = "Nate Kirkeby";
        }
        #region Properties Buttons
        private void designBuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblProject.Text = "Design/Build";
        }
        private void planSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblProject.Text = "Plan/Spec";
        }
        private void lblProject_Click(object sender, EventArgs e)
        {
            opProject.Show(lblProject, 0, lblProject.Height);
        }
        private void lblTakeOff_Click_1(object sender, EventArgs e)
        {
            opTakeOff.Show(lblTakeOff, 0, lblTakeOff.Height);
        }
        private void dontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTakeOff.Text = "Done";
        }
        private void notDoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTakeOff.Text = "Not Done";
        }
        private void lblPriorApp_Click(object sender, EventArgs e)
        {
            opPriorApp.Show(lblPriorApp, 0, lblPriorApp.Height);
        }
        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPriorApp.Text = "No";
        }
        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblPriorApp.Text = "Yes";
        }
        #endregion

        private void tasJob_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void NewItem_SizeChanged(object sender, EventArgs e)
        {
            width = this.Width;
            start = new Size(this.Width, 110);
            open = new Size(this.Width, 512);
        }

        private void lblJobNumber_TextChanged(object sender, EventArgs e)
        {
            jJobNumber.Text = lblJobNumber.Text;
        }
    }
}