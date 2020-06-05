// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ComputerScienceCalculator
{
    [Register ("OptionsView")]
    partial class OptionsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Convert_IP_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Convert_Numbers_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Convert_Text_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertBitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CS_Label { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Convert_IP_TextBox != null) {
                Convert_IP_TextBox.Dispose ();
                Convert_IP_TextBox = null;
            }

            if (Convert_Numbers_TextBox != null) {
                Convert_Numbers_TextBox.Dispose ();
                Convert_Numbers_TextBox = null;
            }

            if (Convert_Text_TextBox != null) {
                Convert_Text_TextBox.Dispose ();
                Convert_Text_TextBox = null;
            }

            if (ConvertBitButton != null) {
                ConvertBitButton.Dispose ();
                ConvertBitButton = null;
            }

            if (CS_Label != null) {
                CS_Label.Dispose ();
                CS_Label = null;
            }
        }
    }
}