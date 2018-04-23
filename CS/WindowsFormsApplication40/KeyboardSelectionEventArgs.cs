using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsFormsApplication40
{
    public class KeyboardSelectionEventArgs : EventArgs
    {
        public KeyboardSelectionEventArgs(int _selectedItemIndex, GalleryItemViewInfo _selectedItem, int _selectedGroupIndex, GalleryItemGroupViewInfo _selectedGroup)
        {
            SelectedItemIndex = _selectedItemIndex;
            SelectedItem = _selectedItem;
            SelectedGroupIndex = _selectedGroupIndex;
            SelectedGroup = _selectedGroup;
        
        }
        public GalleryItemGroupViewInfo SelectedGroup;
        public int SelectedGroupIndex;
        public GalleryItemViewInfo SelectedItem;
        public int SelectedItemIndex;
    }
}
