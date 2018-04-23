Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsFormsApplication40
	Public Class KeyboardSelectionEventArgs
		Inherits EventArgs
		Public Sub New(ByVal _selectedItemIndex As Integer, ByVal _selectedItem As GalleryItemViewInfo, ByVal _selectedGroupIndex As Integer, ByVal _selectedGroup As GalleryItemGroupViewInfo)
			SelectedItemIndex = _selectedItemIndex
			SelectedItem = _selectedItem
			SelectedGroupIndex = _selectedGroupIndex
			SelectedGroup = _selectedGroup

		End Sub
		Public SelectedGroup As GalleryItemGroupViewInfo
		Public SelectedGroupIndex As Integer
		Public SelectedItem As GalleryItemViewInfo
		Public SelectedItemIndex As Integer
	End Class
End Namespace
