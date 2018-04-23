using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsFormsApplication40
{
    class MyGalleryControlGallery : GalleryControlGallery
    { 
        public MyGalleryControlGallery()
        {

        }
        public MyGalleryControlGallery(DevExpress.XtraBars.Ribbon.GalleryControl galleryControl)
            : base(galleryControl)
        {
            
        }
        public StandaloneGalleryViewInfo MyViewInfo { get { return this.ViewInfo; } }
    }
}
