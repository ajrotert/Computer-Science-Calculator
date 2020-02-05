using Foundation;
using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class TextView : UIViewController
    {
        public TextView (IntPtr handle) : base (handle)
        {
        }
        UIToolbar toolbar;
        UIToolbar generic;
        UIToolbar generic2;
        UIToolbar genericB;
        StringConverter SC;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CS_Label.Text = "Computer Science" + Environment.NewLine + "Converter";
            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));
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
                this.Hexadecimal_TextBox.ResignFirstResponder();
            })
            };
            Hexadecimal_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Hexadecimal_TextBox.InputAccessoryView = toolbar;
            //**************************************************************

            generic = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            generic.TintColor = UIColor.White;
            generic.BarStyle = UIBarStyle.Black;
            generic.Translucent = true;
            var myButtong = new UIBarButtonItem("String: ",
                 UIBarButtonItemStyle.Bordered, AddNull);
            generic.Items = new UIBarButtonItem[]{
          myButtong,

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                String_TextBox.ResignFirstResponder();
            })
            };
            String_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            String_TextBox.InputAccessoryView = generic;

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

            genericB = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            genericB.TintColor = UIColor.White;
            genericB.BarStyle = UIBarStyle.Black;
            genericB.Translucent = true;
            var myButtonB = new UIBarButtonItem("Binary: ",
                 UIBarButtonItemStyle.Bordered, AddNull);
            genericB.Items = new UIBarButtonItem[]{
          myButtonB,

          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                Binary_TextBox.ResignFirstResponder();
            })
            };
            Binary_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Binary_TextBox.InputAccessoryView = genericB;

        }
        partial void Binary_Changed(UITextField sender)
        {
            try
            {
                if (Binary_TextBox.Text != "" && Binary_TextBox.Text[Binary_TextBox.Text.Length - 1] > '1')
                {
                    Binary_TextBox.Text = Binary_TextBox.Text.Substring(0, Binary_TextBox.Text.Length - 1);
                    Decimal_TextBox.Text = "";
                    String_TextBox.Text = "";
                    Hexadecimal_TextBox.Text = "";
                }
                else
                {
                    SC = new StringConverter(BIN: Binary_TextBox.Text);
                    SC.convert();
                    String_TextBox.Text = SC.String;
                    Decimal_TextBox.Text = SC.Decimal;
                    Hexadecimal_TextBox.Text = SC.Hexadecimal;
                }

            }
            catch
            {
                Decimal_TextBox.Text = "";
                String_TextBox.Text = "";
                Hexadecimal_TextBox.Text = "";
                Binary_TextBox.Text = "";
            }
        }
        partial void Decimal_Changed(UITextField sender)
        {
            try
            {
                if (Decimal_TextBox.Text != "" && Convert.ToInt64(Decimal_TextBox.Text) < 256 && Convert.ToInt64(Decimal_TextBox.Text) > 31)
                {
                    SC = new StringConverter(DECIMAL: Decimal_TextBox.Text);
                    SC.convert();
                    String_TextBox.Text = SC.String;
                    Hexadecimal_TextBox.Text = SC.Hexadecimal;
                    Binary_TextBox.Text = SC.Binary;
                }
                else
                {
                    String_TextBox.Text = "";
                    Hexadecimal_TextBox.Text = "";
                    Binary_TextBox.Text = "";
                }
            }
            catch
            { 
                Decimal_TextBox.Text = "";
                String_TextBox.Text = "";
                Hexadecimal_TextBox.Text = "";
                Binary_TextBox.Text = "";
            }
        }

        partial void Hexadecimal_Changed(UITextField sender)
        {
            try
            {
                if (Hexadecimal_TextBox.Text.Length % 2 == 0)
                {
                    SC = new StringConverter(HEX: Hexadecimal_TextBox.Text);
                    SC.convert();
                    String_TextBox.Text = SC.String;
                    Decimal_TextBox.Text = SC.Decimal;
                    Binary_TextBox.Text = SC.Binary;
                }
                else
                {
                    Decimal_TextBox.Text = "";
                    String_TextBox.Text = "";
                    Binary_TextBox.Text = "";
                }
            }
            catch
            {
                Decimal_TextBox.Text = "";
                String_TextBox.Text = "";
                Hexadecimal_TextBox.Text = "";
                Binary_TextBox.Text = "";
            }
        }

        partial void String_Changed(UITextField sender)
        {
            try
            {
                SC = new StringConverter(STRING: String_TextBox.Text);
                SC.convert();
                Decimal_TextBox.Text = SC.Decimal;
                Hexadecimal_TextBox.Text = SC.Hexadecimal;
                Binary_TextBox.Text = SC.Binary;
            }
            catch
            {
                Decimal_TextBox.Text = "";
                String_TextBox.Text = "";
                Hexadecimal_TextBox.Text = "";
                Binary_TextBox.Text = "";
            }
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
                Hexadecimal_TextBox.Text = Hexadecimal_TextBox.Text + txt;
                Hexadecimal_Changed(Hexadecimal_TextBox);
            }
        }

        partial void Clear_Button_TouchUpInside(UIButton sender)
        {
            Decimal_TextBox.Text = "";
            String_TextBox.Text = "";
            Hexadecimal_TextBox.Text = "";
            Binary_TextBox.Text = "";
        }

        private void AddNull(object sender, EventArgs e)
        {
            return;
        }

    }
}