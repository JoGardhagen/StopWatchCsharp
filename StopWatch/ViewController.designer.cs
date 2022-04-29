// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace StopWatch
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField clock { get; set; }

		[Action ("resetButton:")]
		partial void resetButton (Foundation.NSObject sender);

		[Action ("startButton:")]
		partial void startButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (clock != null) {
				clock.Dispose ();
				clock = null;
			}
		}
	}
}
