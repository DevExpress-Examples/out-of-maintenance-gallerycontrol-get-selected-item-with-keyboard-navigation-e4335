Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsFormsApplication40
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim Group As New GalleryItemGroup()
			Group.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("1.jpg"), "1", "1"))
			Group.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("2.jpg"), "2", "2"))
			Group.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(GetImage("3.jpg"), "3", "3"))
			myGalleryControl1.Gallery.Groups.Add(Group)
			myGalleryControl1.Gallery.ImageSize = New Size(100, 100)
			AddHandler myGalleryControl1.KeyboardSelectedItemChanged, AddressOf myGalleryControl1_KeyboardSelectedItemChanged
		End Sub

		Private Sub myGalleryControl1_KeyboardSelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Public Function GetImage(ByVal name As String) As Image
			Dim executed As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = executed.GetManifestResourceStream("" & name)
			Return Image.FromStream(stream)
		End Function
	End Class
End Namespace
