using Foundation;
using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class TCController : UIViewController
    {
        public TCController (IntPtr handle) : base (handle)
        {

        }

        UIToolbar toolbar;
        UIToolbar toolbartc;
        UIToolbar toolbartc2;
        UIToolbar generic;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));

            CSC_Label.Text = "Computer Science" + Environment.NewLine + "Converter";
            
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
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
          new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.Hex_TextBox.ResignFirstResponder();
            })
        };
            Hex_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Hex_TextBox.InputAccessoryView = toolbar;


            //**************************************************************

            toolbartc = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbartc.TintColor = UIColor.White;
            toolbartc.BarStyle = UIBarStyle.Black;
            toolbartc.Translucent = true;
            var myButtontc = new UIBarButtonItem("Decimal: ",
                 UIBarButtonItemStyle.Bordered, AddNeg);
            toolbartc.Items = new UIBarButtonItem[]{
          myButtontc,
          new UIBarButtonItem("-",
               UIBarButtonItemStyle.Plain, AddNeg),

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.Decimal16_TextBox.ResignFirstResponder();
            })
            };
            Decimal16_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Decimal16_TextBox.InputAccessoryView = toolbartc;

            //**************************************************************

            toolbartc2 = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            toolbartc2.TintColor = UIColor.White;
            toolbartc2.BarStyle = UIBarStyle.Black;
            toolbartc2.Translucent = true;
            var myButtontc2 = new UIBarButtonItem("Decimal: ",
                 UIBarButtonItemStyle.Bordered, AddNeg2);
            toolbartc2.Items = new UIBarButtonItem[]{
          myButtontc2,
          new UIBarButtonItem("-",
               UIBarButtonItemStyle.Plain, AddNeg2),

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.Decimal32_TextBox.ResignFirstResponder();
            })
            };
            Decimal32_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Decimal32_TextBox.InputAccessoryView = toolbartc2;

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

        }

        partial void Hexadecimal_Changed(UITextField sender)
        {
            if (sender.Text.Length == 4 || sender.Text.Length == 8)
            {
                TwoComplament tc = new TwoComplament(HEXADECIMAL: Hex_TextBox.Text);
                tc.convert();
                Binary_TextBox.Text = tc.binary;
                if (sender.Text.Length == 4)
                {
                    Decimal16_TextBox.Text = tc.dec16;
                    tc = new TwoComplament(HEXADECIMAL: ("0000" + Hex_TextBox.Text));
                    tc.convert();
                }
                else
                    Decimal16_TextBox.Text = "";
                Decimal32_TextBox.Text = tc.dec32;
            }
            else
            {
                Binary_TextBox.Text = "";
                Decimal16_TextBox.Text = "";
                Decimal32_TextBox.Text = "";
            }
        }

        partial void Binary_Changed(UITextField sender)
        {
            if (Binary_TextBox.Text != "" && Binary_TextBox.Text[Binary_TextBox.Text.Length - 1] > '1')
                Binary_TextBox.Text = Binary_TextBox.Text.Substring(0, Binary_TextBox.Text.Length - 1);
            else if (sender.Text.Length == 16 || sender.Text.Length == 32)
            {
                TwoComplament tc = new TwoComplament(BINARY: Binary_TextBox.Text);
                tc.convert();
                Hex_TextBox.Text = tc.hexadecimal;
                if (sender.Text.Length == 16)
                {
                    Decimal16_TextBox.Text = tc.dec16;
                    tc = new TwoComplament(BINARY: "0000000000000000" + Binary_TextBox.Text);
                    tc.convert();
                }
                else
                    Decimal16_TextBox.Text = "";
                Decimal32_TextBox.Text = tc.dec32;
            }
            else
            {
                Hex_TextBox.Text = "";
                Decimal16_TextBox.Text = "";
                Decimal32_TextBox.Text = "";
            }
        }

        partial void Decimal32_Changed(UITextField sender)
        {
            try
            {
                if (Decimal32_TextBox.Text != "" && Decimal32_TextBox.Text != "-" && Convert.ToInt64(Decimal32_TextBox.Text) <= 2147483647 && Convert.ToInt64(Decimal32_TextBox.Text) >= -2147483648)
                {
                    TwoComplament tc = new TwoComplament(DECIMAL32: Decimal32_TextBox.Text);
                    tc.convert();

                    Decimal16_TextBox.Text = "";
                    Binary_TextBox.Text = tc.binary;
                    Hex_TextBox.Text = tc.hexadecimal;
                }
                else
                {
                    Decimal16_TextBox.Text = "";
                    Binary_TextBox.Text = "";
                    Hex_TextBox.Text = "";
                }
            }
            catch
            {
                UIAlertView alert = new UIAlertView()
                {
                    Title = "Number to Large",
                    Message = "The number being converted is to large"
                };


                alert.AddButton("OK");
                alert.Show();
            }
        }

        partial void Decimal16_Changed(UITextField sender)
        {
            try
            {
                if (Decimal16_TextBox.Text != "" && Decimal16_TextBox.Text != "-" && Convert.ToInt32(Decimal16_TextBox.Text) <= 32767 && Convert.ToInt32(Decimal16_TextBox.Text) >= -32768)
                {
                    TwoComplament tc = new TwoComplament(DECIMAL16: Decimal16_TextBox.Text);
                    tc.convert();

                    Decimal32_TextBox.Text = "";
                    Binary_TextBox.Text = tc.binary;
                    Hex_TextBox.Text = tc.hexadecimal;
                }
                else
                {
                    Decimal32_TextBox.Text = "";
                    Binary_TextBox.Text = "";
                    Hex_TextBox.Text = "";
                }
            }
            catch
            {
                UIAlertView alert = new UIAlertView()
                {
                    Title = "Number to Large",
                    Message = "The number being converted is to large"
                };


                alert.AddButton("OK");
                alert.Show();
            }
        }

        private void clear()
        {
            Decimal16_TextBox.Text = "";
            Hex_TextBox.Text = "";
            Binary_TextBox.Text = "";
            Decimal32_TextBox.Text = "";
        }
        partial void Clear_Clicked(UIButton sender)
        {
            clear();
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
        private void AddNeg(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt.Length > 0) && (txt == "-"))
            {
                if (Decimal16_TextBox.Text != "")
                {
                    if (Decimal16_TextBox.Text[0] == '-')
                        Decimal16_TextBox.Text = Decimal16_TextBox.Text.Substring(1);
                    else
                        Decimal16_TextBox.Text = txt + Decimal16_TextBox.Text;
                        
                    Decimal16_Changed(Decimal16_TextBox);
                }
                else
                    Decimal16_TextBox.Text = "-";
            }
        }
        private void AddNeg2(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt.Length > 0) && (txt == "-"))
            {
                if (Decimal32_TextBox.Text != "")
                {
                    if (Decimal32_TextBox.Text[0] == '-')
                        Decimal32_TextBox.Text = Decimal32_TextBox.Text.Substring(1);
                    else
                        Decimal32_TextBox.Text = txt + Decimal32_TextBox.Text;

                    Decimal32_Changed(Decimal32_TextBox);
                }
                else
                    Decimal32_TextBox.Text = "-";
            }
        }
        private void AddNull(object sender, EventArgs e)
        {
            return;
        }

    }
}