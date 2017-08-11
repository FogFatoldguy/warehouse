namespace Warehouse
{
    partial class OrderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ls = new System.Windows.Forms.ListView();
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BidDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ls
            // 
            this.ls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Location,
            this.BidDate});
            this.ls.FullRowSelect = true;
            this.ls.GridLines = true;
            this.ls.Location = new System.Drawing.Point(177, 71);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(121, 97);
            this.ls.TabIndex = 0;
            this.ls.UseCompatibleStateImageBehavior = false;
            this.ls.View = System.Windows.Forms.View.Details;
            this.ls.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ls);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(75, 60);
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListView ls;
        public System.Windows.Forms.ColumnHeader Location;
        public System.Windows.Forms.ColumnHeader BidDate;
        public System.Windows.Forms.Button button1;
    }
}
