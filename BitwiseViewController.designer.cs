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
    [Register ("BitwiseViewController")]
    partial class BitwiseViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView BitView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CS_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Input1Binary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Input2Binary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InputLabel1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InputNumber2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputTextbox1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputTextbox2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Results { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ResultsTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl SegementedControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TypeLabel { get; set; }

        [Action ("ClearButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClearButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("Input1Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Input1Changed (UIKit.UITextField sender);

        [Action ("Input2Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Input2Changed (UIKit.UITextField sender);

        [Action ("SegementedPicker:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SegementedPicker (UIKit.UISegmentedControl sender);

        void ReleaseDesignerOutlets ()
        {
            if (BitView != null) {
                BitView.Dispose ();
                BitView = null;
            }

            if (ClearButton != null) {
                ClearButton.Dispose ();
                ClearButton = null;
            }

            if (CS_Label != null) {
                CS_Label.Dispose ();
                CS_Label = null;
            }

            if (Input1Binary != null) {
                Input1Binary.Dispose ();
                Input1Binary = null;
            }

            if (Input2Binary != null) {
                Input2Binary.Dispose ();
                Input2Binary = null;
            }

            if (InputLabel1 != null) {
                InputLabel1.Dispose ();
                InputLabel1 = null;
            }

            if (InputNumber2 != null) {
                InputNumber2.Dispose ();
                InputNumber2 = null;
            }

            if (InputTextbox1 != null) {
                InputTextbox1.Dispose ();
                InputTextbox1 = null;
            }

            if (InputTextbox2 != null) {
                InputTextbox2.Dispose ();
                InputTextbox2 = null;
            }

            if (Results != null) {
                Results.Dispose ();
                Results = null;
            }

            if (ResultsTextbox != null) {
                ResultsTextbox.Dispose ();
                ResultsTextbox = null;
            }

            if (SegementedControl != null) {
                SegementedControl.Dispose ();
                SegementedControl = null;
            }

            if (TypeLabel != null) {
                TypeLabel.Dispose ();
                TypeLabel = null;
            }
        }
    }
}