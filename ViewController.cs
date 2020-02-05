using System;
using Foundation;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        UIToolbar toolbar;
        UIToolbar generic;
        UIToolbar generic2;
        UIToolbar generic3;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));

            CSC_Label.Text = "Computer Science" + Environment.NewLine + "Converter";

            TwosComplamentSwitch.On = false;

            // Perform any additional setup after loading the view, typically from a nib.
            toolbar = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbar.TintColor = UIColor.White;
            toolbar.BarStyle = UIBarStyle.Black;
            toolbar.Translucent = true;
            var myButton = new UIBarButtonItem("Hex:",
                 UIBarButtonItemStyle.Bordered, AddTLD);
            toolbar.Items = new UIBarButtonItem[]{
          myButton,
          new UIBarButtonItem("A",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem("B",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem("C",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem("D",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem("E",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem("F",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.Hex_TextBox.ResignFirstResponder();
            })
            };
            Hex_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Hex_TextBox.InputAccessoryView = toolbar;

            //**************************************************************

            generic = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            generic.TintColor = UIColor.White;
            generic.BarStyle = UIBarStyle.Black;
            generic.Translucent = true;
            var myButtong = new UIBarButtonItem("Binary: ",
                 UIBarButtonItemStyle.Bordered, AddNull);
            generic.Items = new UIBarButtonItem[]{
          myButtong,

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                Binary_TextBox.ResignFirstResponder();
            })
            };
            Binary_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Binary_TextBox.InputAccessoryView = generic;

            //**************************************************************

            generic2 = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            generic2.TintColor = UIColor.White;
            generic2.BarStyle = UIBarStyle.Black;
            generic2.Translucent = true;
            var myButtong2 = new UIBarButtonItem("Decimal: ",
                 UIBarButtonItemStyle.Bordered, AddNull);
            generic2.Items = new UIBarButtonItem[]{
          myButtong2,

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                Decimal_TextBox.ResignFirstResponder();
            })
            };
            Decimal_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Decimal_TextBox.InputAccessoryView = generic2;

            //**************************************************************

            generic3 = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            generic3.TintColor = UIColor.White;
            generic3.BarStyle = UIBarStyle.Black;
            generic3.Translucent = true;
            var myButtong3 = new UIBarButtonItem("Octal: ",
                 UIBarButtonItemStyle.Bordered, AddNull);
            generic3.Items = new UIBarButtonItem[]{
          myButtong3,

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                Octal_TextBox.ResignFirstResponder();
            })
            };
            Octal_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Octal_TextBox.InputAccessoryView = generic3;
        }

        partial void Switch_Changed(UISwitch sender)
        {
            //TwosComplamentSwitch.On = false;
        }

        private void clear()
        {
            Octal_TextBox.Text = "";
            Hex_TextBox.Text = "";
            Binary_TextBox.Text = "";
            Decimal_TextBox.Text = "";
        }
        partial void Clear_Button_TouchUpInside(UIButton sender)
        {
            clear();
        }

        partial void Octal_Changed(UITextField sender)
        {
            if (Octal_TextBox.Text != "" && Octal_TextBox.Text[Octal_TextBox.Text.Length - 1] > '7')
                Octal_TextBox.Text = Octal_TextBox.Text.Substring(0, Octal_TextBox.Text.Length - 1);
            else if (Octal_TextBox.Text != "")
            {
                if (Octal_TextBox.Text[Octal_TextBox.Text.Length - 1] > '7')
                    Octal_TextBox.Text = Octal_TextBox.Text.Substring(0, Octal_TextBox.Text.Length - 1);
                Decimal d = new Decimal(OCTAL: Octal_TextBox.Text);
                d.convert();
                Decimal_TextBox.Text = d._decimal;
                Binary_TextBox.Text = d.binary;
                Hex_TextBox.Text = d.hex;
            }
            else
                clear();
        }

        partial void Hexadecimal_Changed(UITextField sender)
        {
            if (Hex_TextBox.Text != "")
            {
                Decimal d = new Decimal(HEX: Hex_TextBox.Text);
                d.convert();
                Decimal_TextBox.Text = d._decimal;
                Binary_TextBox.Text = d.binary;
                Octal_TextBox.Text = d.octal;
            }
            else
                clear();
        }

        partial void Binary_Changed(UITextField sender)
        {
            if (Binary_TextBox.Text != "" && Binary_TextBox.Text[Binary_TextBox.Text.Length - 1] > '1')
                Binary_TextBox.Text = Binary_TextBox.Text.Substring(0, Binary_TextBox.Text.Length - 1);
            else if (Binary_TextBox.Text != "")
            {
                if (Binary_TextBox.Text[Binary_TextBox.Text.Length - 1] > '1')
                    Binary_TextBox.Text = Binary_TextBox.Text.Substring(0, Binary_TextBox.Text.Length - 1);
                Decimal d = new Decimal(BINARY: Binary_TextBox.Text);
                d.convert();
                Decimal_TextBox.Text = d._decimal;
                Hex_TextBox.Text = d.hex;
                Octal_TextBox.Text = d.octal;
            }
            else
                clear();
        }

        partial void Decimal_Changed(UITextField sender)
        {
            if (Decimal_TextBox.Text != "" )
            {
                Decimal d = new Decimal(DECIMAL: Decimal_TextBox.Text);
                d.convert();
                Binary_TextBox.Text = d.binary;
                Hex_TextBox.Text = d.hex;
                Octal_TextBox.Text = d.octal;
            }
            else
                clear();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }



        private void AddTLD(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt.Length > 0) && (txt != "Hex:"))
            {
                Hex_TextBox.Text = Hex_TextBox.Text + txt;
                Hexadecimal_Changed(Hex_TextBox);
            }
        }
        private void AddNull(object sender, EventArgs e)
        {
            return;
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            bool temp = TwosComplamentSwitch.On;

            if (segueIdentifier == "SwitchSegue")
            {
                //TwosComplamentSwitch.On = false;
                return temp;
            }
                
            return base.ShouldPerformSegue(segueIdentifier, sender);
        }
        public override void ViewDidDisappear(bool animated)
        {
            TwosComplamentSwitch.On = false;
            base.ViewDidDisappear(animated);
        }
    }
}