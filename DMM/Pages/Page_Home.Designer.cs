namespace DMM.Pages
{
    partial class Page_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Home));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_datetime = new System.Windows.Forms.Label();
            this.txt_companytitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_datetime
            // 
            this.txt_datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_datetime.AutoSize = true;
            this.txt_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.ForeColor = System.Drawing.Color.DimGray;
            this.txt_datetime.Location = new System.Drawing.Point(3, 653);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(341, 67);
            this.txt_datetime.TabIndex = 3;
            this.txt_datetime.Text = "Home Page";
            // 
            // txt_companytitle
            // 
            this.txt_companytitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_companytitle.AutoSize = true;
            this.txt_companytitle.Font = new System.Drawing.Font("LBC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companytitle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_companytitle.Location = new System.Drawing.Point(400, 425);
            this.txt_companytitle.Name = "txt_companytitle";
            this.txt_companytitle.Size = new System.Drawing.Size(280, 64);
            this.txt_companytitle.TabIndex = 2;
            this.txt_companytitle.Text = "اسم الشركة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Page_Home
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_companytitle);
            this.Controls.Add(this.txt_datetime);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Page_Home";
            this.Size = new System.Drawing.Size(1080, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txt_datetime;
        private System.Windows.Forms.Label txt_companytitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
