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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.io;
using iTextSharp.xmp.impl.xpath;
namespace Warehouse
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }
        WebBrowser Panel1 = new WebBrowser();
        private string todaysdate = DateTime.Today.ToString("MM-dd-yyyy");
        private Size start = new Size(1157, 110);
        private Size center = new Size(0, 0);
      //  private Size start = new Size(970, 238);
      //  private Size open = new Size(721, 415);
        private Size open = new Size(1157, 512);
        public string prd;
        public string det;
        public string nam;
        public string fp;
        private string pdfLocation;
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
        
        private void JobImage_Click(object sender, EventArgs e)
        {
            if (this.Size == start)
            {
                this.Size = open;
                B1.Visible = true;
                WebLocation.Controls.Add(Panel1);
                Panel1.ScriptErrorsSuppressed = true;
                Panel1.Show();
                Panel1.Dock = DockStyle.Fill;
                Panel1.Visible = true;
                Nav = Path.GetFullPath(FullPath);
                Panel1.Navigate(Nav);
                
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
           
            
            string Nav = Path.GetFullPath(FullPath);
          
            try
            {
                lblJobName.Text = File.ReadAllText(FullPath + @"\Properties\JobName.txt");
                lblBidDate.Text = File.ReadAllText(FullPath + @"\Properties\BidDate.txt");
                lblLocation.Text = File.ReadAllText(FullPath + @"\Properties\Location.txt");
                lblEngineer.Text = File.ReadAllText(FullPath + @"\Properties\Engineer.txt");
                lblProject.Text = File.ReadAllText(FullPath + @"\Properties\Project.txt");
                lblRecieved.Text = File.ReadAllText(FullPath + @"\Properties\Received.txt");
                lblJobNumber.Text = File.ReadAllText(FullPath + @"\Properties\thisJobNumber.txt");
                lblPriorApp.Text = File.ReadAllText(FullPath + @"\Properties\PriorApp.txt");
                lblContact.Text = File.ReadAllText(FullPath + @"\Properties\Contact.txt");
                lblTakeOff.Text = File.ReadAllText(FullPath + @"\Properties\TakeOff.txt");
                
               
                if (lblContact.Text.Contains("Chad"))
                {  
                      button1.ForeColor = Color.MediumPurple;  
                    
                }
                if (lblContact.Text.Contains("Erv"))
                {
                    button1.ForeColor = Color.Lime;
                   
                }
                if (lblContact.Text.Contains("Dan"))
                {
                    button1.ForeColor = Color.DeepSkyBlue;
                    
                }
                if (lblContact.Text.Contains("Jacob"))
                {
                    button1.ForeColor = Color.Yellow;
                    
                }
                if (lblContact.Text.Contains("Steiner"))
                {
                    button1.ForeColor = Color.OrangeRed;
                    
                }
                if (lblContact.Text.Contains("Nate"))
                {
                    button1.ForeColor = Color.Cyan;
                    
                }
                if (lblContact.Text.Contains("Miller"))
                {
                    button1.ForeColor = Color.Cyan;
                 
                }
            }
            catch{  }
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
        private void btnPrice_Click(object sender, EventArgs e)
        {
            Nav = Path.GetFullPath(FullPath);
            menuPrice.Items.Clear();
            try
            {

                foreach (string file in Directory.GetFiles(@Nav + @"\1-Pricing", "*.aio-projx"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click2;
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    menuPrice.Items.Add(item);

                }
                ToolStripItem item2 = new ToolStripMenuItem();
                item2.Click += Pricepricingexist;
                item2.Text = "+ New Price Pricing";
                item2.ForeColor = Color.Red;
                menuPrice.Items.Add(item2);
            }
            catch
            { }
            menuPrice.Show(btnPrice, 0, -btnPrice.Height);
        }
        private void Pricepricingexist(object sender, EventArgs e)
        {
            tmrPrice.Start();
        }

        private void tmrPrice_Tick(object sender, EventArgs e)
        {

            if (!File.Exists(@Nav + @"\1-Pricing\" + todaysdate + " - " + f + ".aio-projx"))
            {
                File.Copy((@"F:\Internal Jobs\Therm-Air Files\ThermAirProgram\TemJob.aio-projx"),
              (@Nav + @"\1-Pricing\" + todaysdate + " - " + f + ".aio-projx"));

                tmrPrice.Stop();

            }

            f += 1;

        }

        private void menuPrice_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            selPriceitem = e.ClickedItem.ToString();
        }
        private void Item_Click2(object sender, EventArgs e)
        {
            Process.Start(@Nav + @"\1-Pricing\" + selPriceitem + ".aio-projx");
        }

        #endregion
        #region Caps Pricing
        private void btnCaps_Click(object sender, EventArgs e)
        {
            Nav = Path.GetFullPath(FullPath);
            MenuCaps.Items.Clear();
            try
            {

                foreach (string file in Directory.GetFiles(@Nav + @"\1-Pricing", "*.gfcj"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click1;
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    MenuCaps.Items.Add(item);

                }
                ToolStripItem item2 = new ToolStripMenuItem();
                item2.Click += capspricingexist;
                item2.Text = "+ New Greenheck Pricing";
                item2.ForeColor = Color.Red;
                MenuCaps.Items.Add(item2);

            }
            catch
            { }
            MenuCaps.Show(btnCaps, 0, -btnCaps.Height);
            
        }
        private void MenuCaps_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            selCapsitem = e.ClickedItem.ToString();
        }
        private void tmrCaps_Tick(object sender, EventArgs e)
        {

            if (!File.Exists(@Nav + @"\1-Pricing\" + todaysdate + " - " + d + ".gfcj"))
            {
                File.Copy((@"F:\Internal Jobs\Therm-Air Files\ThermAirProgram\TempJob.gfcj"),
              (@Nav + @"\1-Pricing\" + todaysdate + " - " + d + ".gfcj"));

                tmrCaps.Stop();

            }

            d += 1;
        }
        private void capspricingexist(object sender, EventArgs e)
        {
            tmrCaps.Start();
        }
        private void Item_Click1(object sender, EventArgs e)
        {
            Process.Start(@Nav + @"\1-Pricing\" + selCapsitem + ".gfcj");
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
        #region Options
        private void btnExpand_Click(object sender, EventArgs e)
        {


            if (btnExpand.Text == "Expand")
            {
                tasw.BringToFront();
                tasw.Location = new Point(3, 112);
                tasw.Size = new Size(this.Width, 329);
                tasw.Visible = true;


                tasw.Navigate("http://thermairdc/projects/Project/Entry/" + lblJobNumber.Text);

                btnExpand.Text = "Close";
            }
            else
            {
                tasw.Visible = false;
                btnExpand.Text = "Expand";
                
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

        
        public void WriteToPropertiesED()
        {

            File.WriteAllText(@Nav + @"\Properties\Contact.txt", lblContact.Text);
            File.WriteAllText(@Nav + @"\Properties\JobName.txt", lblJobName.Text);
            File.WriteAllText(@Nav + @"\Properties\BidDate.txt", lblBidDate.Text);
            File.WriteAllText(@Nav + @"\Properties\Engineer.txt", lblEngineer.Text);
            File.WriteAllText(@Nav + @"\Properties\TakeOff.txt", lblTakeOff.Text);
            File.WriteAllText(@Nav + @"\Properties\Location.txt", lblLocation.Text);
            File.WriteAllText(@Nav + @"\Properties\PriorApp.txt", lblPriorApp.Text);
            File.WriteAllText(@Nav + @"\Properties\Received.txt", lblRecieved.Text); 
            File.WriteAllText(@Nav + @"\Properties\Project.txt", lblProject.Text);
            File.WriteAllText(@Nav + @"\Properties\Notes\NNotes.txt", Notes.Text);
            File.WriteAllText(@Nav + @"\Properties\thisJobNumber.txt", lblJobNumber.Text);

        }
        
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            WriteToPropertiesED();
        }
        #endregion
        #region Create PDF
        public string PDFItem;
        public string PDFItemPath = "";
        private void CaptureScreen()
        {
            PdfReader reader = new PdfReader(PDFItemPath);

            PdfStamper stamper = new PdfStamper(reader, new FileStream(PDFItem, FileMode.Create));
            int x = reader.NumberOfPages;
            int[] a = Enumerable.Range(1, x).ToArray();


            foreach (int n in a)

            {
                BaseFont customfont = FontFactory.GetFont(@"C:\Windows\Fonts\bgothm.ttf", BaseFont.CP1252, true).BaseFont;
                PdfContentByte canvas = stamper.GetOverContent(n);




                ColumnText.ShowTextAligned(canvas, Element.ALIGN_LEFT, new Phrase(lblJobName.Text, new iTextSharp.text.Font(customfont, 21)), 15, 755, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_LEFT, new Phrase(lblEngineer.Text, new iTextSharp.text.Font(customfont, 21)), 15, 15, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_RIGHT, new Phrase(lblBidDate.Text, new iTextSharp.text.Font(customfont, 21)), 1200, 15, 0);
                ColumnText.ShowTextAligned(canvas, Element.ALIGN_RIGHT, new Phrase(lblLocation.Text, new iTextSharp.text.Font(customfont, 21)), 1200, 755, 0);
            }
            stamper.Close();

            var PrintPDF = new ProcessStartInfo();

            PrintPDF.WindowStyle = ProcessWindowStyle.Normal;
            PrintPDF.FileName = PDFItem;

            Process.Start(PrintPDF);


        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            opPDF.Items.Clear();

            try
            {

                foreach (string file in Directory.GetFiles(@Nav + @"\4-Plans", "*.pdf"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click4;
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    opPDF.Items.Add(item);

                }
                foreach (string file in Directory.GetFiles(@Nav + @"\4-Plans\Listings", "*.pdf"))
                {

                    ToolStripItem item = new ToolStripMenuItem();

                    item.Click += Item_Click4;
                    item.Text = Path.GetFileNameWithoutExtension(file);

                    opPDF.Items.Add(item);

                }

            }
            catch
            { }
            opPDF.Show(btnPDF, 0, -btnPDF.Height);
            
        }

        private void tmrPDF_Tick(object sender, EventArgs e)
        {

        }
        
        private void menuPDF_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            PDFItem = e.ClickedItem.ToString();

        }
        private void Item_Click4(object sender, EventArgs e)
        {
            string iPath = Directory.EnumerateFiles(@Nav + @"\4-Plans\", PDFItem + ".pdf", SearchOption.AllDirectories).ToString();
            if (File.Exists(@Nav + @"\4-Plans\Listings\" + PDFItem + ".pdf"))
            {
                PDFItemPath = @Nav + @"\4-Plans\Listings\" + PDFItem + ".pdf";
                
            }
            else
            {
                PDFItemPath = @Nav + @"\4-Plans\" + PDFItem + ".pdf";
                
            }
            timer1.Start();





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!File.Exists(@Nav + "\\" + todaysdate + " - " + f + ".pdf"))
            {
                PDFItem = Nav + "\\" + todaysdate + " - " + f + ".pdf";



                timer1.Stop();
                CaptureScreen();
            }

            f += 1;
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

        private void lblJobName_TextChanged(object sender, EventArgs e)
        {
            jJobName.Text = lblJobName.Text;
        }

        private void lblJobNumber_TextChanged(object sender, EventArgs e)
        {
            jJobNumber.Text = lblJobNumber.Text;
                
        }

        private void lblProject_TextChanged(object sender, EventArgs e)
        {
            jProject.Text = lblProject.Text;
        }

        private void jProject_TextChanged(object sender, EventArgs e)
        {
            if(jProject.Text.Contains("Design"))
            {
                jProject.ForeColor = Color.Cyan;
            }
        }
    }
    #endregion
}
