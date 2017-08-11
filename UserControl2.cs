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

namespace Warehouse
{
    public partial class jord2 : UserControl
    {
        public jord2()
        {
            InitializeComponent();
        }
        public string prd;
        public string det;
        public string nam;
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
        private string Longpath = @"F:\Internal Jobs\Therm-Air Files\Program\P3\Data\";
        private void Order_Load(object sender, EventArgs e)
        {
            
          oAmount.Text = File.ReadAllText(OrderName + "\\AOrder.txt");
            oDetails.Text = File.ReadAllText(OrderName + @"\DOrder.txt");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            File.WriteAllText(OrderName + @"\AOrder.txt", oAmount.Text);
            File.WriteAllText(OrderName + @"\DOrder.txt", oDetails.Text);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Directory.Move(Longpath + Product + @"\" + OrderName, Longpath + Product + @"\Archive\" + OrderName);
        }
    }
}
