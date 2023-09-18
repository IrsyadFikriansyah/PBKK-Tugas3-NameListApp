// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NameList
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField inputNameArea { get; set; }

		[Outlet]
		AppKit.NSTextField listArea { get; set; }

		[Action ("addNameButton:")]
		partial void addNameButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (inputNameArea != null) {
				inputNameArea.Dispose ();
				inputNameArea = null;
			}

			if (listArea != null) {
				listArea.Dispose ();
				listArea = null;
			}
		}
	}
}
