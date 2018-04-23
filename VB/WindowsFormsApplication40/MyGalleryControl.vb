Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Windows.Forms
Imports System.Drawing

Namespace WindowsFormsApplication40
	Friend Class MyGalleryControl
		Inherits GalleryControl
		Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
			MyBase.OnKeyDown(e)
			If KeyboardSelectedItemChangedEvent IsNot Nothing Then
				If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Up OrElse e.KeyCode =Keys.Down Then
				Dim View As StandaloneGalleryViewInfo =(TryCast(Me.Gallery, MyGalleryControlGallery)).MyViewInfo
			Dim args As New KeyboardSelectionEventArgs(View.KeyboardSelectedItemIndex, View.KeyboardSelectedItem, View.KeyboardSelectedGroupIndex, View.KeyboardSelectedGroup)
				RaiseEvent KeyboardSelectedItemChanged(Me, args)
				End If
			End If
		End Sub
		Protected Overrides Function CreateGallery() As DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery
			Return New MyGalleryControlGallery(Me)
		End Function
		Public Delegate Sub KeyboardSelectedItemChangedHandler(ByVal sender As Object, ByVal e As KeyboardSelectionEventArgs)

		Public Event KeyboardSelectedItemChanged As KeyboardSelectedItemChangedHandler

	End Class
End Namespace
