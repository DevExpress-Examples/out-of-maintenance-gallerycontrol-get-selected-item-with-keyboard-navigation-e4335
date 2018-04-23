Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication40
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myGalleryControl1 = New WindowsFormsApplication40.MyGalleryControl()
			Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
			CType(Me.myGalleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myGalleryControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' myGalleryControl1
			' 
			Me.myGalleryControl1.Controls.Add(Me.galleryControlClient1)
			Me.myGalleryControl1.DesignGalleryGroupIndex = 0
			Me.myGalleryControl1.DesignGalleryItemIndex = 0
			Me.myGalleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGalleryControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGalleryControl1.Name = "myGalleryControl1"
			Me.myGalleryControl1.Size = New System.Drawing.Size(557, 399)
			Me.myGalleryControl1.TabIndex = 0
			Me.myGalleryControl1.Text = "myGalleryControl1"
			' 
			' galleryControlClient1
			' 
			Me.galleryControlClient1.GalleryControl = Me.myGalleryControl1
			Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
			Me.galleryControlClient1.Size = New System.Drawing.Size(536, 395)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(557, 399)
			Me.Controls.Add(Me.myGalleryControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myGalleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myGalleryControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myGalleryControl1 As MyGalleryControl
		Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient


	End Class
End Namespace

