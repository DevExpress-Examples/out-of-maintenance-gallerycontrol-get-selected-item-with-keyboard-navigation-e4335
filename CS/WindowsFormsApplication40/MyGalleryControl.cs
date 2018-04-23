using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication40
{
    class MyGalleryControl : GalleryControl
    {
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (KeyboardSelectedItemChanged != null)
                if (e.KeyCode == Keys.Left ||
                    e.KeyCode == Keys.Right ||
                    e.KeyCode == Keys.Up||
                    e.KeyCode ==Keys.Down)
            { StandaloneGalleryViewInfo View =(this.Gallery as MyGalleryControlGallery).MyViewInfo;
            KeyboardSelectionEventArgs args = new KeyboardSelectionEventArgs(
                View.KeyboardSelectedItemIndex,
                View.KeyboardSelectedItem,
                View.KeyboardSelectedGroupIndex,
                View.KeyboardSelectedGroup);
                KeyboardSelectedItemChanged(this, args);
            }
        }
        protected override DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery CreateGallery()
        {
            return new MyGalleryControlGallery(this);
        }
        public delegate void KeyboardSelectedItemChangedHandler(Object sender,KeyboardSelectionEventArgs e);
        
        public event KeyboardSelectedItemChangedHandler KeyboardSelectedItemChanged;

    }
}
