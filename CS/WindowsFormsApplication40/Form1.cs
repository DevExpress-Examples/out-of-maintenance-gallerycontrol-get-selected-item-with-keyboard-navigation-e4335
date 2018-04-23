using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GalleryItemGroup Group = new GalleryItemGroup();
            Group.Items.Add(new DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("1.jpg"), "1", "1"));
            Group.Items.Add(new DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("2.jpg"), "2", "2"));
            Group.Items.Add(new DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("3.jpg"), "3", "3"));
            myGalleryControl1.Gallery.Groups.Add(Group);
            myGalleryControl1.Gallery.ImageSize = new Size(100, 100);
            myGalleryControl1.KeyboardSelectedItemChanged += new MyGalleryControl.KeyboardSelectedItemChangedHandler(myGalleryControl1_KeyboardSelectedItemChanged);
        }

        void myGalleryControl1_KeyboardSelectedItemChanged(object sender, EventArgs e)
        {
            { }
        }

        public Image GetImage(string name)
        {
            Assembly executed = Assembly.GetExecutingAssembly();
            Stream stream = executed.GetManifestResourceStream("WindowsFormsApplication40." + name);
            return Image.FromStream(stream);
        }
    }
}
