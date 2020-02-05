// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ComputerScienceCalculator
{
    [Register ("ViewController")]
    partial class ViewController
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
        UIKit.UIView Converter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CSC_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Decimal_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Decimal_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Hex_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Hexadecimal_label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Octal_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Octal_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TwosComplamentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch TwosComplamentSwitch { get; set; }

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

        [Action ("Octal_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Octal_Changed (UIKit.UITextField sender);

        [Action ("Switch_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Switch_Changed (UIKit.UISwitch sender);

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

            if (Converter != null) {
                Converter.Dispose ();
                Converter = null;
            }

            if (CSC_Label != null) {
                CSC_Label.Dispose ();
                CSC_Label = null;
            }

            if (Decimal_Label != null) {
                Decimal_Label.Dispose ();
                Decimal_Label = null;
            }

            if (Decimal_TextBox != null) {
                Decimal_TextBox.Dispose ();
                Decimal_TextBox = null;
            }

            if (Hex_TextBox != null) {
                Hex_TextBox.Dispose ();
                Hex_TextBox = null;
            }

            if (Hexadecimal_label != null) {
                Hexadecimal_label.Dispose ();
                Hexadecimal_label = null;
            }

            if (Octal_Label != null) {
                Octal_Label.Dispose ();
                Octal_Label = null;
            }

            if (Octal_TextBox != null) {
                Octal_TextBox.Dispose ();
                Octal_TextBox = null;
            }

            if (TwosComplamentLabel != null) {
                TwosComplamentLabel.Dispose ();
                TwosComplamentLabel = null;
            }

            if (TwosComplamentSwitch != null) {
                TwosComplamentSwitch.Dispose ();
                TwosComplamentSwitch = null;
            }
        }
    }
}