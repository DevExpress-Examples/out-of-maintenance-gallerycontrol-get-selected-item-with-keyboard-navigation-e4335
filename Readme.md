<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615861/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4335)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication40/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication40/Form1.vb))
* [KeyboardSelectionEventArgs.cs](./CS/WindowsFormsApplication40/KeyboardSelectionEventArgs.cs) (VB: [KeyboardSelectionEventArgs.vb](./VB/WindowsFormsApplication40/KeyboardSelectionEventArgs.vb))
* [MyGalleryControl.cs](./CS/WindowsFormsApplication40/MyGalleryControl.cs) (VB: [MyGalleryControlGallery.vb](./VB/WindowsFormsApplication40/MyGalleryControlGallery.vb))
* [MyGalleryControlGallery.cs](./CS/WindowsFormsApplication40/MyGalleryControlGallery.cs) (VB: [MyGalleryControlGallery.vb](./VB/WindowsFormsApplication40/MyGalleryControlGallery.vb))
* [Program.cs](./CS/WindowsFormsApplication40/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication40/Program.vb))
<!-- default file list end -->
# GalleryControl - get selected item with keyboard navigation


<p>This example describes how to implement the KeyboardSelectedItemChanged event.</p><p>To implement this feature, we created a custom GalleryControl with a custom Gallery and added the KeyboardSelectedItemChanged event to the control.</p><br />
<p>In a GalleryControlGallery descendant we implemented a public MyViewInfo property in order to grant the user access to protected ViewInfo.</p><br />
<p>In a GalleryControl descendant, we implemented the KeyboardSelectedItemChanged event, and overrode the CreateGallery and OnKeyDown methods.</p><p>The CreateGallery method now returns a gallery of the MyGalleryControlGallery type.</p><p>In the OnKeyDown method, after the base method has been called, KeyboardSelectionEventArgs are created and the KeyboardSelectedItemChanged event is raised</p><br />
<p>The KeyboardSelectionEventArgs class contains itemViewInfo, itemIndex, GroupViewInfo, GroupIndex.</p>

<br/>


