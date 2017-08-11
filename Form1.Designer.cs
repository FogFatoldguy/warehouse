namespace Warehouse
{
    partial class Stock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuJobType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.FFLoc7 = new System.Windows.Forms.Button();
            this.FFLoc6 = new System.Windows.Forms.Button();
            this.FFLoc5 = new System.Windows.Forms.Button();
            this.FFLoc4 = new System.Windows.Forms.Button();
            this.FFLoc3 = new System.Windows.Forms.Button();
            this.FFLoc2 = new System.Windows.Forms.Button();
            this.FFLoc9 = new System.Windows.Forms.Button();
            this.FFLoc8 = new System.Windows.Forms.Button();
            this.FFLoc1 = new System.Windows.Forms.Button();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.sJN = new System.Windows.Forms.TextBox();
            this.PDFViewer = new System.Windows.Forms.WebBrowser();
            this.btnClose = new System.Windows.Forms.Button();
            this.CustomNav = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmrCustomL = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sL = new System.Windows.Forms.TextBox();
            this.sC = new System.Windows.Forms.TextBox();
            this.sE = new System.Windows.Forms.TextBox();
            this.sJobN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.newItem1 = new Warehouse.NewItem();
            this.FLoc9 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc8 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc7 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc6 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc5 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc4 = new WindowsFormsApp4.RoundedButton2();
            this.Floc3 = new WindowsFormsApp4.RoundedButton2();
            this.Floc2 = new WindowsFormsApp4.RoundedButton2();
            this.FLoc1 = new WindowsFormsApp4.RoundedButton2();
            this.btnJobDisplay = new WindowsFormsApp4.RoundedButton2();
            this.menuJobType.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.table1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Maroon;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Location = new System.Drawing.Point(322, 199);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1112, 574);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // menuJobType
            // 
            this.menuJobType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allJobsToolStripMenuItem,
            this.currentToolStripMenuItem});
            this.menuJobType.Name = "menuJobType";
            this.menuJobType.Size = new System.Drawing.Size(115, 48);
            // 
            // allJobsToolStripMenuItem
            // 
            this.allJobsToolStripMenuItem.Name = "allJobsToolStripMenuItem";
            this.allJobsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.allJobsToolStripMenuItem.Text = "All Jobs";
            this.allJobsToolStripMenuItem.Click += new System.EventHandler(this.allJobsToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.FFLoc7, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc5, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc9, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc8, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.FFLoc1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1440, 199);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(50, 683);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // FFLoc7
            // 
            this.FFLoc7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc7.Location = new System.Drawing.Point(3, 465);
            this.FFLoc7.Name = "FFLoc7";
            this.FFLoc7.Size = new System.Drawing.Size(44, 44);
            this.FFLoc7.TabIndex = 9;
            this.FFLoc7.UseVisualStyleBackColor = true;
            // 
            // FFLoc6
            // 
            this.FFLoc6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc6.Location = new System.Drawing.Point(3, 390);
            this.FFLoc6.Name = "FFLoc6";
            this.FFLoc6.Size = new System.Drawing.Size(44, 44);
            this.FFLoc6.TabIndex = 8;
            this.FFLoc6.UseVisualStyleBackColor = true;
            // 
            // FFLoc5
            // 
            this.FFLoc5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc5.Location = new System.Drawing.Point(3, 315);
            this.FFLoc5.Name = "FFLoc5";
            this.FFLoc5.Size = new System.Drawing.Size(44, 44);
            this.FFLoc5.TabIndex = 7;
            this.FFLoc5.UseVisualStyleBackColor = true;
            // 
            // FFLoc4
            // 
            this.FFLoc4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc4.Location = new System.Drawing.Point(3, 240);
            this.FFLoc4.Name = "FFLoc4";
            this.FFLoc4.Size = new System.Drawing.Size(44, 44);
            this.FFLoc4.TabIndex = 6;
            this.FFLoc4.UseVisualStyleBackColor = true;
            // 
            // FFLoc3
            // 
            this.FFLoc3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc3.Location = new System.Drawing.Point(3, 165);
            this.FFLoc3.Name = "FFLoc3";
            this.FFLoc3.Size = new System.Drawing.Size(44, 44);
            this.FFLoc3.TabIndex = 5;
            this.FFLoc3.UseVisualStyleBackColor = true;
            // 
            // FFLoc2
            // 
            this.FFLoc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc2.Location = new System.Drawing.Point(3, 90);
            this.FFLoc2.Name = "FFLoc2";
            this.FFLoc2.Size = new System.Drawing.Size(44, 44);
            this.FFLoc2.TabIndex = 4;
            this.FFLoc2.UseVisualStyleBackColor = true;
            // 
            // FFLoc9
            // 
            this.FFLoc9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc9.Location = new System.Drawing.Point(3, 619);
            this.FFLoc9.Name = "FFLoc9";
            this.FFLoc9.Size = new System.Drawing.Size(44, 44);
            this.FFLoc9.TabIndex = 3;
            this.FFLoc9.UseVisualStyleBackColor = true;
            // 
            // FFLoc8
            // 
            this.FFLoc8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc8.Location = new System.Drawing.Point(3, 540);
            this.FFLoc8.Name = "FFLoc8";
            this.FFLoc8.Size = new System.Drawing.Size(44, 44);
            this.FFLoc8.TabIndex = 2;
            this.FFLoc8.UseVisualStyleBackColor = true;
            // 
            // FFLoc1
            // 
            this.FFLoc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FFLoc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FFLoc1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.FFLoc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FFLoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FFLoc1.Location = new System.Drawing.Point(3, 15);
            this.FFLoc1.Name = "FFLoc1";
            this.FFLoc1.Size = new System.Drawing.Size(44, 44);
            this.FFLoc1.TabIndex = 1;
            this.FFLoc1.UseVisualStyleBackColor = true;
            // 
            // table1
            // 
            this.table1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table1.ColumnCount = 1;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.Controls.Add(this.FLoc9, 0, 8);
            this.table1.Controls.Add(this.FLoc8, 0, 7);
            this.table1.Controls.Add(this.FLoc7, 0, 6);
            this.table1.Controls.Add(this.FLoc6, 0, 5);
            this.table1.Controls.Add(this.FLoc5, 0, 4);
            this.table1.Controls.Add(this.FLoc4, 0, 3);
            this.table1.Controls.Add(this.Floc3, 0, 2);
            this.table1.Controls.Add(this.Floc2, 0, 1);
            this.table1.Controls.Add(this.FLoc1, 0, 0);
            this.table1.Location = new System.Drawing.Point(1488, 199);
            this.table1.Name = "table1";
            this.table1.RowCount = 9;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.Size = new System.Drawing.Size(346, 683);
            this.table1.TabIndex = 26;
            this.table1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // sJN
            // 
            this.sJN.BackColor = System.Drawing.Color.Black;
            this.sJN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sJN.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sJN.ForeColor = System.Drawing.Color.White;
            this.sJN.Location = new System.Drawing.Point(3, 35);
            this.sJN.Name = "sJN";
            this.sJN.Size = new System.Drawing.Size(216, 25);
            this.sJN.TabIndex = 28;
            // 
            // PDFViewer
            // 
            this.PDFViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFViewer.Location = new System.Drawing.Point(12, 199);
            this.PDFViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.PDFViewer.Name = "PDFViewer";
            this.PDFViewer.ScriptErrorsSuppressed = true;
            this.PDFViewer.Size = new System.Drawing.Size(1822, 683);
            this.PDFViewer.TabIndex = 29;
            this.PDFViewer.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("BankGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 25);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomNav
            // 
            this.CustomNav.Name = "CustomNav";
            this.CustomNav.Size = new System.Drawing.Size(61, 4);
            this.CustomNav.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CustomNav_ItemClicked);
            // 
            // tmrCustomL
            // 
            this.tmrCustomL.Tick += new System.EventHandler(this.tmrCustomL_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sJN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sC, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sE, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sJobN, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(322, 818);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 64);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(942, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Job Number";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Job Name";
            // 
            // sL
            // 
            this.sL.BackColor = System.Drawing.Color.Black;
            this.sL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sL.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sL.ForeColor = System.Drawing.Color.White;
            this.sL.Location = new System.Drawing.Point(225, 35);
            this.sL.Name = "sL";
            this.sL.Size = new System.Drawing.Size(216, 25);
            this.sL.TabIndex = 29;
            // 
            // sC
            // 
            this.sC.BackColor = System.Drawing.Color.Black;
            this.sC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sC.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sC.ForeColor = System.Drawing.Color.White;
            this.sC.Location = new System.Drawing.Point(447, 35);
            this.sC.Name = "sC";
            this.sC.Size = new System.Drawing.Size(216, 25);
            this.sC.TabIndex = 30;
            // 
            // sE
            // 
            this.sE.BackColor = System.Drawing.Color.Black;
            this.sE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sE.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sE.ForeColor = System.Drawing.Color.White;
            this.sE.Location = new System.Drawing.Point(669, 35);
            this.sE.Name = "sE";
            this.sE.Size = new System.Drawing.Size(216, 25);
            this.sE.TabIndex = 31;
            // 
            // sJobN
            // 
            this.sJobN.BackColor = System.Drawing.Color.Black;
            this.sJobN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sJobN.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sJobN.ForeColor = System.Drawing.Color.White;
            this.sJobN.Location = new System.Drawing.Point(891, 35);
            this.sJobN.Name = "sJobN";
            this.sJobN.Size = new System.Drawing.Size(218, 25);
            this.sJobN.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(290, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Location";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(733, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Engineer";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BankGothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(514, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(463, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Search Jobs";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(322, 779);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1112, 33);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("BankGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 27);
            this.button1.TabIndex = 37;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newItem1
            // 
            this.newItem1.AllowDrop = true;
            this.newItem1.BackColor = System.Drawing.Color.Black;
            this.newItem1.Details = null;
            this.newItem1.FullPath = null;
            this.newItem1.Location = new System.Drawing.Point(325, 83);
            this.newItem1.Name = "newItem1";
            this.newItem1.OrderName = null;
            this.newItem1.Product = null;
            this.newItem1.Size = new System.Drawing.Size(1056, 110);
            this.newItem1.TabIndex = 38;
            this.newItem1.Load += new System.EventHandler(this.newItem1_Load);
            // 
            // FLoc9
            // 
            this.FLoc9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc9.BoarderColor = System.Drawing.Color.White;
            this.FLoc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc9.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc9.ForeColor = System.Drawing.Color.White;
            this.FLoc9.Location = new System.Drawing.Point(39, 612);
            this.FLoc9.Name = "FLoc9";
            this.FLoc9.Radius = 30;
            this.FLoc9.Size = new System.Drawing.Size(268, 59);
            this.FLoc9.TabIndex = 8;
            this.FLoc9.Text = "Custom";
            this.FLoc9.UseVisualStyleBackColor = true;
            this.FLoc9.Click += new System.EventHandler(this.FLoc9_Click);
            // 
            // FLoc8
            // 
            this.FLoc8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc8.BoarderColor = System.Drawing.Color.White;
            this.FLoc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc8.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc8.ForeColor = System.Drawing.Color.White;
            this.FLoc8.Location = new System.Drawing.Point(39, 533);
            this.FLoc8.Name = "FLoc8";
            this.FLoc8.Radius = 30;
            this.FLoc8.Size = new System.Drawing.Size(268, 59);
            this.FLoc8.TabIndex = 7;
            this.FLoc8.Text = "All Jobs";
            this.FLoc8.UseVisualStyleBackColor = true;
            this.FLoc8.Click += new System.EventHandler(this.FLoc8_Click);
            // 
            // FLoc7
            // 
            this.FLoc7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc7.BoarderColor = System.Drawing.Color.White;
            this.FLoc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc7.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc7.ForeColor = System.Drawing.Color.White;
            this.FLoc7.Location = new System.Drawing.Point(39, 458);
            this.FLoc7.Name = "FLoc7";
            this.FLoc7.Radius = 30;
            this.FLoc7.Size = new System.Drawing.Size(268, 59);
            this.FLoc7.TabIndex = 6;
            this.FLoc7.Text = "Terry";
            this.FLoc7.UseVisualStyleBackColor = true;
            this.FLoc7.Click += new System.EventHandler(this.FLoc7_Click);
            // 
            // FLoc6
            // 
            this.FLoc6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc6.BoarderColor = System.Drawing.Color.White;
            this.FLoc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc6.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc6.ForeColor = System.Drawing.Color.White;
            this.FLoc6.Location = new System.Drawing.Point(39, 383);
            this.FLoc6.Name = "FLoc6";
            this.FLoc6.Radius = 30;
            this.FLoc6.Size = new System.Drawing.Size(268, 59);
            this.FLoc6.TabIndex = 5;
            this.FLoc6.Text = "Miller";
            this.FLoc6.UseVisualStyleBackColor = true;
            this.FLoc6.Click += new System.EventHandler(this.FLoc6_Click);
            // 
            // FLoc5
            // 
            this.FLoc5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc5.BoarderColor = System.Drawing.Color.White;
            this.FLoc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc5.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc5.ForeColor = System.Drawing.Color.White;
            this.FLoc5.Location = new System.Drawing.Point(39, 308);
            this.FLoc5.Name = "FLoc5";
            this.FLoc5.Radius = 30;
            this.FLoc5.Size = new System.Drawing.Size(268, 59);
            this.FLoc5.TabIndex = 4;
            this.FLoc5.Text = "Nate";
            this.FLoc5.UseVisualStyleBackColor = true;
            this.FLoc5.Click += new System.EventHandler(this.FLoc5_Click);
            // 
            // FLoc4
            // 
            this.FLoc4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc4.BoarderColor = System.Drawing.Color.White;
            this.FLoc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc4.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc4.ForeColor = System.Drawing.Color.White;
            this.FLoc4.Location = new System.Drawing.Point(39, 233);
            this.FLoc4.Name = "FLoc4";
            this.FLoc4.Radius = 30;
            this.FLoc4.Size = new System.Drawing.Size(268, 59);
            this.FLoc4.TabIndex = 3;
            this.FLoc4.Text = "Jacob";
            this.FLoc4.UseVisualStyleBackColor = true;
            this.FLoc4.Click += new System.EventHandler(this.FLoc4_Click);
            // 
            // Floc3
            // 
            this.Floc3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Floc3.BoarderColor = System.Drawing.Color.White;
            this.Floc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floc3.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floc3.ForeColor = System.Drawing.Color.White;
            this.Floc3.Location = new System.Drawing.Point(39, 158);
            this.Floc3.Name = "Floc3";
            this.Floc3.Radius = 30;
            this.Floc3.Size = new System.Drawing.Size(268, 59);
            this.Floc3.TabIndex = 2;
            this.Floc3.Text = "Dan";
            this.Floc3.UseVisualStyleBackColor = true;
            this.Floc3.Click += new System.EventHandler(this.Floc3_Click);
            // 
            // Floc2
            // 
            this.Floc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Floc2.BoarderColor = System.Drawing.Color.White;
            this.Floc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Floc2.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floc2.ForeColor = System.Drawing.Color.White;
            this.Floc2.Location = new System.Drawing.Point(39, 83);
            this.Floc2.Name = "Floc2";
            this.Floc2.Radius = 30;
            this.Floc2.Size = new System.Drawing.Size(268, 59);
            this.Floc2.TabIndex = 1;
            this.Floc2.Text = "Erv";
            this.Floc2.UseVisualStyleBackColor = true;
            this.Floc2.Click += new System.EventHandler(this.Floc2_Click);
            // 
            // FLoc1
            // 
            this.FLoc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLoc1.BoarderColor = System.Drawing.Color.White;
            this.FLoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FLoc1.Font = new System.Drawing.Font("BankGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLoc1.ForeColor = System.Drawing.Color.White;
            this.FLoc1.Location = new System.Drawing.Point(39, 8);
            this.FLoc1.Name = "FLoc1";
            this.FLoc1.Radius = 30;
            this.FLoc1.Size = new System.Drawing.Size(268, 59);
            this.FLoc1.TabIndex = 0;
            this.FLoc1.Text = "Chad";
            this.FLoc1.UseVisualStyleBackColor = true;
            this.FLoc1.Click += new System.EventHandler(this.FLoc1_Click);
            // 
            // btnJobDisplay
            // 
            this.btnJobDisplay.BoarderColor = System.Drawing.Color.White;
            this.btnJobDisplay.Location = new System.Drawing.Point(12, 12);
            this.btnJobDisplay.Name = "btnJobDisplay";
            this.btnJobDisplay.Radius = 15;
            this.btnJobDisplay.Size = new System.Drawing.Size(209, 43);
            this.btnJobDisplay.TabIndex = 2;
            this.btnJobDisplay.Text = "Current Jobs";
            this.btnJobDisplay.UseVisualStyleBackColor = true;
            this.btnJobDisplay.Click += new System.EventHandler(this.btnJobDisplay_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1846, 894);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.newItem1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.btnJobDisplay);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PDFViewer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.menuJobType.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.table1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsApp4.RoundedButton2 btnJobDisplay;
        private System.Windows.Forms.ContextMenuStrip menuJobType;
        private System.Windows.Forms.ToolStripMenuItem allJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button FFLoc7;
        private System.Windows.Forms.Button FFLoc6;
        private System.Windows.Forms.Button FFLoc5;
        private System.Windows.Forms.Button FFLoc4;
        private System.Windows.Forms.Button FFLoc3;
        private System.Windows.Forms.Button FFLoc2;
        private System.Windows.Forms.Button FFLoc9;
        private System.Windows.Forms.Button FFLoc8;
        private System.Windows.Forms.Button FFLoc1;
        private System.Windows.Forms.TableLayoutPanel table1;
        private WindowsFormsApp4.RoundedButton2 FLoc9;
        private WindowsFormsApp4.RoundedButton2 FLoc8;
        private WindowsFormsApp4.RoundedButton2 FLoc7;
        private WindowsFormsApp4.RoundedButton2 FLoc6;
        private WindowsFormsApp4.RoundedButton2 FLoc5;
        private WindowsFormsApp4.RoundedButton2 FLoc4;
        private WindowsFormsApp4.RoundedButton2 Floc3;
        private WindowsFormsApp4.RoundedButton2 Floc2;
        private WindowsFormsApp4.RoundedButton2 FLoc1;
        private System.Windows.Forms.TextBox sJN;
        private System.Windows.Forms.WebBrowser PDFViewer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip CustomNav;
        private System.Windows.Forms.Timer tmrCustomL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sL;
        private System.Windows.Forms.TextBox sC;
        private System.Windows.Forms.TextBox sE;
        private System.Windows.Forms.TextBox sJobN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private NewItem newItem1;
        public System.Windows.Forms.FlowLayoutPanel Panel;
    }
}

