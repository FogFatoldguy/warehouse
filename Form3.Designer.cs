namespace Warehouse
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel = new System.Windows.Forms.Panel();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPrev = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSoldTo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.TextBox();
            this.lblDO = new System.Windows.Forms.TextBox();
            this.lblShipTo = new System.Windows.Forms.TextBox();
            this.lblPO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPU = new System.Windows.Forms.TextBox();
            this.lblShipVIA = new System.Windows.Forms.TextBox();
            this.lblTransto = new System.Windows.Forms.TextBox();
            this.lblTransfrom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(856, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(872, 846);
            this.panel.TabIndex = 0;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printdoc1_PrintPage);
            // 
            // printPrev
            // 
            this.printPrev.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPrev.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPrev.ClientSize = new System.Drawing.Size(400, 300);
            this.printPrev.Enabled = true;
            this.printPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("printPrev.Icon")));
            this.printPrev.Name = "printPrev";
            this.printPrev.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSoldTo
            // 
            this.lblSoldTo.Location = new System.Drawing.Point(103, 3);
            this.lblSoldTo.Name = "lblSoldTo";
            this.lblSoldTo.Size = new System.Drawing.Size(94, 20);
            this.lblSoldTo.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTransfrom, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblTransto, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblShipVIA, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPU, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSoldTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPO, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDO, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblShipTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTag, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(427, 271);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 478);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sold To:";
            // 
            // lblTag
            // 
            this.lblTag.Location = new System.Drawing.Point(103, 56);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(94, 20);
            this.lblTag.TabIndex = 4;
            // 
            // lblDO
            // 
            this.lblDO.Location = new System.Drawing.Point(103, 215);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(94, 20);
            this.lblDO.TabIndex = 5;
            // 
            // lblShipTo
            // 
            this.lblShipTo.Location = new System.Drawing.Point(103, 109);
            this.lblShipTo.Name = "lblShipTo";
            this.lblShipTo.Size = new System.Drawing.Size(94, 20);
            this.lblShipTo.TabIndex = 6;
            // 
            // lblPO
            // 
            this.lblPO.Location = new System.Drawing.Point(103, 162);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(94, 20);
            this.lblPO.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tag:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ship To:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PO#:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Ordered:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Picked Up:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ship VIA:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Transfer To:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Transfer From:";
            // 
            // lblPU
            // 
            this.lblPU.Location = new System.Drawing.Point(103, 268);
            this.lblPU.Name = "lblPU";
            this.lblPU.Size = new System.Drawing.Size(94, 20);
            this.lblPU.TabIndex = 6;
            // 
            // lblShipVIA
            // 
            this.lblShipVIA.Location = new System.Drawing.Point(103, 321);
            this.lblShipVIA.Name = "lblShipVIA";
            this.lblShipVIA.Size = new System.Drawing.Size(94, 20);
            this.lblShipVIA.TabIndex = 6;
            // 
            // lblTransto
            // 
            this.lblTransto.Location = new System.Drawing.Point(103, 374);
            this.lblTransto.Name = "lblTransto";
            this.lblTransto.Size = new System.Drawing.Size(94, 20);
            this.lblTransto.TabIndex = 6;
            // 
            // lblTransfrom
            // 
            this.lblTransfrom.Location = new System.Drawing.Point(103, 427);
            this.lblTransfrom.Name = "lblTransfrom";
            this.lblTransfrom.Size = new System.Drawing.Size(94, 20);
            this.lblTransfrom.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 898);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPrev;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox lblSoldTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblTransfrom;
        private System.Windows.Forms.TextBox lblTransto;
        private System.Windows.Forms.TextBox lblShipVIA;
        private System.Windows.Forms.TextBox lblPU;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblPO;
        private System.Windows.Forms.TextBox lblDO;
        private System.Windows.Forms.TextBox lblShipTo;
        private System.Windows.Forms.TextBox lblTag;
        private System.Windows.Forms.Label label8;
    }
}