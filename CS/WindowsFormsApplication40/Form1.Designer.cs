namespace WindowsFormsApplication40
{
    partial class Form1
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
            this.myGalleryControl1 = new WindowsFormsApplication40.MyGalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.myGalleryControl1)).BeginInit();
            this.myGalleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGalleryControl1
            // 
            this.myGalleryControl1.Controls.Add(this.galleryControlClient1);
            this.myGalleryControl1.DesignGalleryGroupIndex = 0;
            this.myGalleryControl1.DesignGalleryItemIndex = 0;
            this.myGalleryControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGalleryControl1.Location = new System.Drawing.Point(0, 0);
            this.myGalleryControl1.Name = "myGalleryControl1";
            this.myGalleryControl1.Size = new System.Drawing.Size(557, 399);
            this.myGalleryControl1.TabIndex = 0;
            this.myGalleryControl1.Text = "myGalleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.myGalleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(536, 395);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 399);
            this.Controls.Add(this.myGalleryControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myGalleryControl1)).EndInit();
            this.myGalleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyGalleryControl myGalleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;


    }
}

