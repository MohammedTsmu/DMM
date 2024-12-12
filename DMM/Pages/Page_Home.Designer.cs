
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
            this.txt_datetime = new System.Windows.Forms.Label();
            this.txt_companytitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_datetime
            // 
            this.txt_datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_datetime.AutoSize = true;
            this.txt_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.ForeColor = System.Drawing.Color.DimGray;
            this.txt_datetime.Location = new System.Drawing.Point(3, 560);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(0, 67);
            this.txt_datetime.TabIndex = 0;
            // 
            // txt_companytitle
            // 
            this.txt_companytitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_companytitle.Font = new System.Drawing.Font("LBC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_companytitle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_companytitle.Location = new System.Drawing.Point(3, 323);
            this.txt_companytitle.Name = "txt_companytitle";
            this.txt_companytitle.Size = new System.Drawing.Size(955, 143);
            this.txt_companytitle.TabIndex = 0;
            this.txt_companytitle.Text = "اسم الشركة";
            this.txt_companytitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DMM.Properties.Resources.DMM_PNG_1_Compressed;
            this.pictureBox1.Location = new System.Drawing.Point(351, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Page_Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_companytitle);
            this.Controls.Add(this.txt_datetime);
            this.Name = "Page_Home";
            this.Size = new System.Drawing.Size(961, 627);
            this.Load += new System.EventHandler(this.Page_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_datetime;
        private System.Windows.Forms.Label txt_companytitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
