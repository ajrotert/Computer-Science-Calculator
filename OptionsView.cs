using Foundation;
using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class OptionsView : UIViewController
    {
        public OptionsView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CS_Label.Text = "Computer Science" + Environment.NewLine + "Converter";
            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));

        }

    }
}