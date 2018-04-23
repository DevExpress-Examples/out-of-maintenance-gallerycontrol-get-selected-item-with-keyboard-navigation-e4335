Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsFormsApplication40
	Friend Class MyGalleryControlGallery
		Inherits GalleryControlGallery
		Public Sub New()

		End Sub
		Public Sub New(ByVal galleryControl As DevExpress.XtraBars.Ribbon.GalleryControl)
			MyBase.New(galleryControl)

		End Sub
		Public ReadOnly Property MyViewInfo() As StandaloneGalleryViewInfo
			Get
				Return Me.ViewInfo
			End Get
		End Property
	End Class
End Namespace
