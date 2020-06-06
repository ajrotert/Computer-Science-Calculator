using Foundation;
using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class BitwiseViewController : UIViewController
    {
        public BitwiseViewController (IntPtr handle) : base (handle)
        {
        }
        private int input1, input2;
        private string[] type = { "Bitwise AND", "Bitwise OR", "Bitwise XOR", "Bitwise NOT", "Bitwise LEFT", "Bitwise RIGHT" };
        UIToolbar toolbar;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CS_Label.Text = "Computer Science" + Environment.NewLine + "Converter";
            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));


            //Input1, and Input2  share the same toolbar
            toolbar = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbar.TintColor = UIColor.White;
            toolbar.BarStyle = UIBarStyle.Black;
            toolbar.Translucent = true;
            toolbar.Items = new UIBarButtonItem[]{
          new UIBarButtonItem("Bitwise:", UIBarButtonItemStyle.Bordered, AddTLD),
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
          new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.InputTextbox1.ResignFirstResponder();
                InputTextbox2.ResignFirstResponder();
            })
        };
            InputTextbox1.KeyboardAppearance = UIKeyboardAppearance.Default;
            InputTextbox1.InputAccessoryView = toolbar;
            InputTextbox2.KeyboardAppearance = UIKeyboardAppearance.Default;
            InputTextbox2.InputAccessoryView = toolbar;


        }

        partial void ClearButton_TouchUpInside(UIButton sender)
        {
            InputTextbox1.Text = "";
            InputTextbox2.Text = "";
            ResultsTextbox.Text = "";
            Input2Binary.Text = "";
            Input1Binary.Text = "";
        }

        partial void SegementedPicker(UISegmentedControl sender)
        {
            TypeLabel.Text = type[sender.SelectedSegment];
            InputVerifier();
        }

        partial void Input1Changed(UITextField sender)
        {
            InputVerifier();
        }

        partial void Input2Changed(UITextField sender)
        {
            InputVerifier();
        }
        private void InputVerifier()
        {
            bool completed = false;
            if (InputTextbox1.Text != "" && Int32.TryParse(InputTextbox1.Text, out input1))
            {
                completed = true;
                TwoComplament convert = new TwoComplament(DECIMAL32: input1.ToString());
                convert.convert();
                Input1Binary.Text = $"({input1}) - {convert.binary}";
            }
            else
            {
                completed = false;
                Input1Binary.Text = "";
            }
            if (completed && InputTextbox2.Text != "" && Int32.TryParse(InputTextbox2.Text, out input2))
            {
                completed = true;
            }
            else
            {
                completed = false;
                if (SegementedControl.SelectedSegment == 3 && InputTextbox1.Text != "")
                    completed = true;
                Input2Binary.Text = "";
            }

            if (completed)
            {
                int bitwise = Convert.ToInt32(SegementedControl.SelectedSegment);
                int results = 0;
                switch (bitwise)
                {
                    case 0:
                        results = AND();
                        TwoComplament convert0 = new TwoComplament(DECIMAL32: input2.ToString());
                        convert0.convert();
                        Input2Binary.Text = $"({input2}) - {convert0.binary}";
                        break;
                    case 1:
                        results = OR();
                        TwoComplament convert1 = new TwoComplament(DECIMAL32: input2.ToString());
                        convert1.convert();
                        Input2Binary.Text = $"({input2}) - {convert1.binary}";
                        break;
                    case 2:
                        results = XOR();
                        TwoComplament convert2 = new TwoComplament(DECIMAL32: input2.ToString());
                        convert2.convert();
                        Input2Binary.Text = $"({input2}) - {convert2.binary}";
                        break;
                    case 3:
                        results = NOT();
                        TwoComplament convert3 = new TwoComplament(DECIMAL32: results.ToString());
                        convert3.convert();
                        Input2Binary.Text = $"({results}) - {convert3.binary}";
                        break;
                    case 4:
                        results = LEFT_SHIFT();
                        Input2Binary.Text = $"LEFT SHIFT BY: {input2}";
                        break;
                    case 5:
                        results = RIGHT_SHIFT();
                        Input2Binary.Text = $"RIGHT SHIFT BY: {input2}";
                        break;
                }
                TwoComplament converts = new TwoComplament(DECIMAL32: results.ToString());
                converts.convert();
                ResultsTextbox.Text = $"({results}) - {converts.binary}";
            }
            else
            {
                ResultsTextbox.Text = "";
            }

        }

        private int AND()
        {
            return input1 & input2;
        }
        private int OR()
        {
            return input1 | input2;
        }
        private int XOR()
        {
            return input1 ^ input2;
        }
        private int NOT()
        {
            return ~input1;
        }
        private int LEFT_SHIFT()
        {
            return input1 << input2;
        }
        private int RIGHT_SHIFT()
        {
            return input1 >> input2;
        }

        private void AddTLD(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
        }
    }
}