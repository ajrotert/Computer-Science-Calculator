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
    [Register ("TextView")]
    partial class TextView
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
        UIKit.UILabel CS_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Decimal_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Decimal_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Hexadecimal_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hexadecimal_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel String_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField String_TextBox { get; set; }

        [Action ("Binary_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Binary_Changed (UIKit.UITextField sender);

        [Action ("Clear_Button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Clear_Button_TouchUpInside (UIKit.UIButton sender);

        [Action ("Decimal_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Decimal_Changed (UIKit.UITextField sender);

        [Action ("Hexadecimal_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Hexadecimal_Changed (UIKit.UITextField sender);

        [Action ("String_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void String_Changed (UIKit.UITextField sender);

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

            if (CS_Label != null) {
                CS_Label.Dispose ();
                CS_Label = null;
            }

            if (Decimal_Label != null) {
                Decimal_Label.Dispose ();
                Decimal_Label = null;
            }

            if (Decimal_TextBox != null) {
                Decimal_TextBox.Dispose ();
                Decimal_TextBox = null;
            }

            if (Hexadecimal_Label != null) {
                Hexadecimal_Label.Dispose ();
                Hexadecimal_Label = null;
            }

            if (Hexadecimal_TextBox != null) {
                Hexadecimal_TextBox.Dispose ();
                Hexadecimal_TextBox = null;
            }

            if (String_Label != null) {
                String_Label.Dispose ();
                String_Label = null;
            }

            if (String_TextBox != null) {
                String_TextBox.Dispose ();
                String_TextBox = null;
            }
        }
    }
}