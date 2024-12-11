
namespace DMM
{
    partial class FRM_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pn_progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_restore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pn_progress);
            this.groupBox1.Controls.Add(this.pic_logo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عام";
            // 
            // pn_progress
            // 
            this.pn_progress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_progress.Appearance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pn_progress.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.pn_progress.Appearance.Options.UseBackColor = true;
            this.pn_progress.Appearance.Options.UseFont = true;
            this.pn_progress.AppearanceCaption.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_progress.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.pn_progress.AppearanceCaption.Options.UseFont = true;
            this.pn_progress.AppearanceCaption.Options.UseForeColor = true;
            this.pn_progress.AppearanceDescription.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold);
            this.pn_progress.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.pn_progress.AppearanceDescription.Options.UseFont = true;
            this.pn_progress.AppearanceDescription.Options.UseForeColor = true;
            this.pn_progress.AppearanceDescription.Options.UseTextOptions = true;
            this.pn_progress.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pn_progress.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pn_progress.AppearanceDescription.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pn_progress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pn_progress.Caption = "الرجاء الانتظار ...";
            this.pn_progress.Description = "نحتاج بعض الوقت لاتمام العملية";
            this.pn_progress.Location = new System.Drawing.Point(127, 87);
            this.pn_progress.Name = "pn_progress";
            this.pn_progress.Size = new System.Drawing.Size(352, 187);
            this.pn_progress.TabIndex = 3;
            this.pn_progress.Text = "الرجاء الانتظار";
            this.pn_progress.Visible = false;
            // 
            // pic_logo
            // 
            this.pic_logo.EditValue = ((object)(resources.GetObject("pic_logo.EditValue")));
            this.pic_logo.Location = new System.Drawing.Point(173, 223);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_logo.Size = new System.Drawing.Size(191, 121);
            this.pic_logo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "لوكو";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(20, 83);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(450, 123);
            this.txt_desc.TabIndex = 1;
            this.txt_desc.Text = "وصف عام ";
            this.txt_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "الوصف";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(20, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(450, 33);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "اسم الشركة";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الشركة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_backup);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قاعدة البيانات";
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_restore.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.Appearance.Options.UseFont = true;
            this.btn_restore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_restore.Location = new System.Drawing.Point(20, 59);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(256, 58);
            this.btn_restore.TabIndex = 5;
            this.btn_restore.Text = "استعادة النسخة الاحتياطية";
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_backup.Location = new System.Drawing.Point(345, 59);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(256, 58);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "اخذ نسخة احتياطية";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(219, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "يجب تشغيل البرنامج كمسؤول";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(389, 568);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(256, 58);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الاعدادات";
            this.Load += new System.EventHandler(this.FRM_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.PictureEdit pic_logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_restore;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraWaitForm.ProgressPanel pn_progress;
    }
}