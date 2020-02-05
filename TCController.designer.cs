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
    [Register ("TCController")]
    partial class TCController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Binary_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Binary_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Clear_Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CSC_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Decimal16_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Decimal16_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Decimal32_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Decimal32_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hex_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Hexadecimal_Label { get; set; }

        [Action ("Binary_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Binary_Changed (UIKit.UITextField sender);

        [Action ("Clear_Clicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Clear_Clicked (UIKit.UIButton sender);

        [Action ("Decimal16_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Decimal16_Changed (UIKit.UITextField sender);

        [Action ("Decimal32_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Decimal32_Changed (UIKit.UITextField sender);

        [Action ("Hexadecimal_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Hexadecimal_Changed (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (Binary_Label != null) {
                Binary_Label.Dispose ();
                Binary_Label = null;
            }

            if (Binary_TextBox != null) {
                Binary_TextBox.Dispose ();
                Binary_TextBox = null;
            }

            if (Clear_Button != null) {
                Clear_Button.Dispose ();
                Clear_Button = null;
            }

            if (CSC_Label != null) {
                CSC_Label.Dispose ();
                CSC_Label = null;
            }

            if (Decimal16_Label != null) {
                Decimal16_Label.Dispose ();
                Decimal16_Label = null;
            }

            if (Decimal16_TextBox != null) {
                Decimal16_TextBox.Dispose ();
                Decimal16_TextBox = null;
            }

            if (Decimal32_Label != null) {
                Decimal32_Label.Dispose ();
                Decimal32_Label = null;
            }

            if (Decimal32_TextBox != null) {
                Decimal32_TextBox.Dispose ();
                Decimal32_TextBox = null;
            }

            if (Hex_TextBox != null) {
                Hex_TextBox.Dispose ();
                Hex_TextBox = null;
            }

            if (Hexadecimal_Label != null) {
                Hexadecimal_Label.Dispose ();
                Hexadecimal_Label = null;
            }
        }
    }
}