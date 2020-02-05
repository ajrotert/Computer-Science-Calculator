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
    [Register ("IPConversionsView")]
    partial class IPConversionsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearText_Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CS_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel IPAddress_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField IPAddress_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView IPView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NumberOfSubnetsTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NumberSubnetsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Results_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Results_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Subnet_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SubnetMask_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubnetMask_TextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Subnetting_Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch Subnetting_Slider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SubnettingResultsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView SubnettingResultsView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SubnettingView { get; set; }

        [Action ("ClearText_Button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClearText_Button_TouchUpInside (UIKit.UIButton sender);

        [Action ("IPAddress_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void IPAddress_Changed (UIKit.UITextField sender);

        [Action ("NumberSubnetsChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NumberSubnetsChanged (UIKit.UITextField sender);

        [Action ("SubnetMaskChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SubnetMaskChanged (UIKit.UITextField sender);

        [Action ("Subnetting_Slider_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Subnetting_Slider_Changed (UIKit.UISwitch sender);

        [Action ("SubnettingIPAddress_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SubnettingIPAddress_Changed (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClearText_Button != null) {
                ClearText_Button.Dispose ();
                ClearText_Button = null;
            }

            if (CS_Label != null) {
                CS_Label.Dispose ();
                CS_Label = null;
            }

            if (IPAddress_Label != null) {
                IPAddress_Label.Dispose ();
                IPAddress_Label = null;
            }

            if (IPAddress_TextBox != null) {
                IPAddress_TextBox.Dispose ();
                IPAddress_TextBox = null;
            }

            if (IPView != null) {
                IPView.Dispose ();
                IPView = null;
            }

            if (NumberOfSubnetsTextbox != null) {
                NumberOfSubnetsTextbox.Dispose ();
                NumberOfSubnetsTextbox = null;
            }

            if (NumberSubnetsLabel != null) {
                NumberSubnetsLabel.Dispose ();
                NumberSubnetsLabel = null;
            }

            if (Results_Label != null) {
                Results_Label.Dispose ();
                Results_Label = null;
            }

            if (Results_TextBox != null) {
                Results_TextBox.Dispose ();
                Results_TextBox = null;
            }

            if (Subnet_TextBox != null) {
                Subnet_TextBox.Dispose ();
                Subnet_TextBox = null;
            }

            if (SubnetMask_Label != null) {
                SubnetMask_Label.Dispose ();
                SubnetMask_Label = null;
            }

            if (SubnetMask_TextBox != null) {
                SubnetMask_TextBox.Dispose ();
                SubnetMask_TextBox = null;
            }

            if (Subnetting_Label != null) {
                Subnetting_Label.Dispose ();
                Subnetting_Label = null;
            }

            if (Subnetting_Slider != null) {
                Subnetting_Slider.Dispose ();
                Subnetting_Slider = null;
            }

            if (SubnettingResultsLabel != null) {
                SubnettingResultsLabel.Dispose ();
                SubnettingResultsLabel = null;
            }

            if (SubnettingResultsView != null) {
                SubnettingResultsView.Dispose ();
                SubnettingResultsView = null;
            }

            if (SubnettingView != null) {
                SubnettingView.Dispose ();
                SubnettingView = null;
            }
        }
    }
}