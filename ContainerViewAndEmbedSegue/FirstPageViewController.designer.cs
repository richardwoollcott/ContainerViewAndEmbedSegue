// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ContainerViewAndEmbedSegue
{
    [Register ("FirstPageViewController")]
    partial class FirstPageViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        ContainerViewAndEmbedSegue.FirstPageViewController FirstPage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FirstPage != null) {
                FirstPage.Dispose ();
                FirstPage = null;
            }
        }
    }
}