using Foundation;
using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public partial class IPConversionsView : UIViewController
    {
        public IPConversionsView (IntPtr handle) : base (handle)
        {
        }

        private UIToolbar IPaddressToolbarItem;
        private UIToolbar subnettingToolbarItem;
        private UIToolbar subnetMaskToolbarItem;
        private UIToolbar numberTootlbarItem;

        private const char space_bar = '\u23B5';
        private const int text_height = 18;
        private const int number_lines = 3;
        private const string resultsText = "Results: ";
        private const string defaultSubnet = "Convert IP Address (Decimal)";
        private const string defaultMask = "Subnet Mask (Decimal)";
        private const string defaultNumber = "Number of Subnets";

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CS_Label.Text = "Computer Science" + Environment.NewLine + "Converter";
            View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("ConverterBackground.png"));
            Subnetting_Slider.On = false;
            Enable_Conversions();

            IPaddressToolbarItem = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            IPaddressToolbarItem.TintColor = UIColor.White;
            IPaddressToolbarItem.BarStyle = UIBarStyle.Black;
            IPaddressToolbarItem.Translucent = true;

            var myButton = new UIBarButtonItem("IP Address:",
                 UIBarButtonItemStyle.Bordered, AddTLD);
            IPaddressToolbarItem.Items = new UIBarButtonItem[]{
          myButton,
          new UIBarButtonItem(".",
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem(space_bar.ToString(),
               UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem(":",
                UIBarButtonItemStyle.Plain, AddTLD),
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.IPAddress_TextBox.ResignFirstResponder();
            })
            };
            IPAddress_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            IPAddress_TextBox.InputAccessoryView = IPaddressToolbarItem;
            //******Subnet IPAddress

            subnettingToolbarItem = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            subnettingToolbarItem.TintColor = UIColor.White;
            subnettingToolbarItem.BarStyle = UIBarStyle.Black;
            subnettingToolbarItem.Translucent = true;

            var myButton2 = new UIBarButtonItem("IP Address:",
                 UIBarButtonItemStyle.Bordered, AddTLD2);
            subnettingToolbarItem.Items = new UIBarButtonItem[]{
          myButton2,
          new UIBarButtonItem(".",
               UIBarButtonItemStyle.Plain, AddTLD2),
          new UIBarButtonItem(space_bar.ToString(),
               UIBarButtonItemStyle.Plain, AddTLD2),
          new UIBarButtonItem(":",
                UIBarButtonItemStyle.Plain, AddTLD2),
          new UIBarButtonItem("/",
               UIBarButtonItemStyle.Plain, AddTLD2),
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.Subnet_TextBox.ResignFirstResponder();
            })
            };
            Subnet_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            Subnet_TextBox.InputAccessoryView = subnettingToolbarItem;

            //********Subnet Mask
            subnetMaskToolbarItem = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            subnetMaskToolbarItem.TintColor = UIColor.White;
            subnetMaskToolbarItem.BarStyle = UIBarStyle.Black;
            subnetMaskToolbarItem.Translucent = true;

            var myButton3 = new UIBarButtonItem("IP Address:",
                 UIBarButtonItemStyle.Bordered, AddTLD3);
            subnetMaskToolbarItem.Items = new UIBarButtonItem[]{
          myButton3,
          new UIBarButtonItem(".",
               UIBarButtonItemStyle.Plain, AddTLD3),
          new UIBarButtonItem(space_bar.ToString(),
               UIBarButtonItemStyle.Plain, AddTLD3),
          new UIBarButtonItem(":",
                UIBarButtonItemStyle.Plain, AddTLD3),
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                this.SubnetMask_TextBox.ResignFirstResponder();
            })
            };
            SubnetMask_TextBox.KeyboardAppearance = UIKeyboardAppearance.Default;
            SubnetMask_TextBox.InputAccessoryView = subnetMaskToolbarItem;

            //********Number
            numberTootlbarItem = new UIToolbar(new CoreGraphics.CGRect(new nfloat(0.0f), new nfloat(0.0f), this.View.Frame.Size.Width, new nfloat(44.0f)));
            numberTootlbarItem.TintColor = UIColor.White;
            numberTootlbarItem.BarStyle = UIBarStyle.Black;
            numberTootlbarItem.Translucent = true;

            var myButton4 = new UIBarButtonItem("IP Address:",
                 UIBarButtonItemStyle.Bordered, AddTLDNull);
            numberTootlbarItem.Items = new UIBarButtonItem[]{
          myButton4,
          new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
            new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate
            {
                NumberOfSubnetsTextbox.ResignFirstResponder();
            })
            };
            NumberOfSubnetsTextbox.KeyboardAppearance = UIKeyboardAppearance.Default;
            NumberOfSubnetsTextbox.InputAccessoryView = numberTootlbarItem;
        }

        partial void IPAddress_Changed(UITextField sender)
        {
            if(IPAddress_TextBox.Text != "")
            {
                string[] inputSplit = IPAddress_TextBox.Text.Split('.', ' ', ':');
                if(inputSplit.Length == 4)
                {
                    if(ConvertsToDecimal(ref inputSplit))
                    {
                        IPConversions ip = new IPConversions(ref inputSplit, IPType.Decimal);
                        ip.ConvertAddress();
                        Results_TextBox.Text = ip.GetBinaryIp();
                        IPAddress_TextBox.Text = ip.GetDecimalIp();
                    }
                    else if(ConvertsToBinary(ref inputSplit))
                    {
                        IPConversions ip = new IPConversions(ref inputSplit, IPType.Binary);
                        ip.ConvertAddress();
                        Results_TextBox.Text = ip.GetDecimalIp();
                        IPAddress_TextBox.Text = ip.GetBinaryIp();
                    }
                    else
                    {
                        Results_TextBox.Text = "";
                    }

                }
            }
        }

        private bool ConvertsToDecimal(ref string[] array)
        {
            byte number;
            for (int a = 0; a < IPConversions.octet; a++)
            {
                if (array[a] != null && array[a] != "" && array[a].Length <=3)
                {
                    if (!byte.TryParse(array[a], out number))
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private bool ConvertsToBinary(ref string[] array)
        {
            for (int a = 0; a < IPConversions.octet; a++)
            {
                if (array[a].Length == IPConversions.octet_size)
                {
                    for (int b = 0; b < IPConversions.octet_size; b++)
                    {
                        if (array[a] != null && array[a] != "")
                        {
                            if (array[a][b] != '0' && array[a][b] != '1')
                                return false;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        partial void ClearText_Button_TouchUpInside(UIButton sender)
        {
            IPAddress_TextBox.Text = "";
            Results_TextBox.Text = "";
            SubnetMask_TextBox.Text = "";
            Subnet_TextBox.Text = "";
            NumberOfSubnetsTextbox.Text = "";
            SubnettingResultsLabel.Text = resultsText;
        }

        private void AddTLD(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt == "." || txt == space_bar.ToString() || txt == ":") && IPAddress_TextBox.Text != "" && IPAddress_TextBox.Text[IPAddress_TextBox.Text.Length - 1] != '.' && IPAddress_TextBox.Text[IPAddress_TextBox.Text.Length - 1] != ' ' && IPAddress_TextBox.Text[IPAddress_TextBox.Text.Length - 1] != ':')
            {
                if (txt == space_bar.ToString())
                    IPAddress_TextBox.Text += ' ';
                else
                    IPAddress_TextBox.Text += txt;
            }
        }
        private void AddTLD2(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt == "." || txt == space_bar.ToString() || txt == ":") && Subnet_TextBox.Text != "" && Subnet_TextBox.Text[Subnet_TextBox.Text.Length - 1] != '.' && Subnet_TextBox.Text[Subnet_TextBox.Text.Length - 1] != ' ' && Subnet_TextBox.Text[Subnet_TextBox.Text.Length - 1] != ':')
            {
                if (txt == space_bar.ToString())
                    Subnet_TextBox.Text += ' ';
                else
                    Subnet_TextBox.Text += txt;
            }
            else if (txt == "/" && !Subnet_TextBox.Text.Contains("/"))
            {
                Subnet_TextBox.Text += '/';
            }
        }
        private void AddTLD3(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            var txt = ((UIBarButtonItem)sender).Title;
            if ((txt == "." || txt == space_bar.ToString() || txt == ":") && SubnetMask_TextBox.Text != "" && SubnetMask_TextBox.Text[SubnetMask_TextBox.Text.Length - 1] != '.' && SubnetMask_TextBox.Text[SubnetMask_TextBox.Text.Length - 1] != ' ' && SubnetMask_TextBox.Text[SubnetMask_TextBox.Text.Length - 1] != ':')
            {
                if (txt == space_bar.ToString())
                    SubnetMask_TextBox.Text += ' ';
                else
                    SubnetMask_TextBox.Text += txt;
            }
        }
        private void AddTLDNull(object sender, EventArgs e)
        {
            return;
        }

        private void SetResultsSize(int Number_Of_Subnets)
        {
            int height = Number_Of_Subnets * number_lines * text_height + 4;
            CoreGraphics.CGSize size = new CoreGraphics.CGSize(SubnettingResultsView.Frame.Width, height);
            SubnettingResultsView.ContentSize = size;
            SubnettingResultsLabel.Lines = Number_Of_Subnets * number_lines + 4 + 1;
        }

        private void AddNull(object sender, EventArgs e)
        {
            return;
        }

        private void Enable_Subnetting()
        {
            SubnettingView.Hidden = false;
            IPView.Hidden = true;
            SubnettingResultsView.Hidden = false;
        }
        private void Enable_Conversions()
        {
            IPView.Hidden = false;
            SubnettingView.Hidden = true;
            SubnettingResultsView.Hidden = true;
        }

        partial void Subnetting_Slider_Changed(UISwitch sender)
        {
            if(sender.On)
            {
                Enable_Subnetting();
            }
            else
            {
                Enable_Conversions();
            }
        }

        private string GetSubnetMask(int bits)
        {
            char[] mask = "00000000.00000000.00000000.00000000".ToCharArray();
            int counter = 0;
            for (int a = 0; a < 35 && counter < bits; a++)
            {
                counter++;
                if (mask[a] != '.')
                    mask[a] = '1';
                else
                    counter--;
            }
            string[] binaryAddressArray = (new string(mask)).Split('.', ':', ' ');
            IPConversions IPC = new IPConversions(ref binaryAddressArray, IPType.Binary);
            IPC.ConvertAddress();
            return IPC.GetDecimalIp();
        }
        private bool validateDecimal(string input)
        {
            string[] inputSplit = input.Split('.', ' ', ':');
            if (inputSplit.Length != 4)
                return false;

            bool canConvert;
            for (int a = 0; a < inputSplit.Length; a++)
            {
                int number;

                canConvert = int.TryParse(inputSplit[a], out number);

                if (!canConvert)
                    return false;
                else if (number < 0 || number > 255)
                    return false;
            }
            return true;
        }

        partial void SubnettingIPAddress_Changed(UITextField sender)
        {
            SubnettingResultsLabel.Text = resultsText;
            NumberOfSubnetsTextbox.Text = "";
            if (Subnet_TextBox.Text.Contains("/"))
            {
                string[] inputSplit = Subnet_TextBox.Text.Split('/');
                int x;
                if (int.TryParse(inputSplit[1], out x))
                    SubnetMask_TextBox.Text = GetSubnetMask(x);
            }
        }
        partial void SubnetMaskChanged(UITextField sender)
        {
            SubnettingResultsLabel.Text = resultsText;
            NumberOfSubnetsTextbox.Text = "";
        }
        partial void NumberSubnetsChanged(UITextField sender)
        {
            string[] inputSplit = Subnet_TextBox.Text.Split('/');
            Subnet_TextBox.Text = inputSplit[0];

            SubnettingResultsLabel.Text = resultsText;

            if(validateDecimal(Subnet_TextBox.Text))
            {
                Subnet_TextBox.Placeholder = defaultSubnet;
                if(validateDecimal(SubnetMask_TextBox.Text))
                {
                    SubnetMask_TextBox.Placeholder = defaultMask;
                    int SubnetNums;
                    if(int.TryParse(NumberOfSubnetsTextbox.Text, out SubnetNums) && SubnetNums < 1000)
                    {
                        NumberOfSubnetsTextbox.Placeholder = defaultNumber;

                        string[] IP = Subnet_TextBox.Text.Split('.', ':', ' ');
                        string[] MASK = SubnetMask_TextBox.Text.Split('.', ':', ' ');

                        Subnetting subnetter = new Subnetting(ref IP, ref MASK, SubnetNums);
                        if(subnetter.validSubnetAmount())
                        {
                            SetResultsSize(SubnetNums);
                            SubnettingResultsLabel.Text = "IP Address: " + subnetter.getIPAddressClass() + Environment.NewLine;
                            SubnettingResultsLabel.Text += "#\tSubnet ID"+Environment.NewLine;
                            string[,] results = subnetter.makeSubnets();
                            for(int i = 0; i<results.Length/3; i++)
                            {
                                SubnettingResultsLabel.Text += (results[i, 0] + Environment.NewLine);
                                SubnettingResultsLabel.Text += (results[i, 1] + Environment.NewLine);
                                SubnettingResultsLabel.Text += (results[i, 2] + Environment.NewLine);
                            }
                            SubnettingResultsLabel.Text += ("Bits Stolen: " + subnetter.getBitsStolen() + Environment.NewLine);
                            SubnettingResultsLabel.Text += ("Total Hosts: " + subnetter.getTotalNumberOfHosts());
                        }
                        else
                        {
                            NumberOfSubnetsTextbox.Placeholder = "Not a valid amount";
                        }
                    }
                    else
                    {
                        NumberOfSubnetsTextbox.Placeholder = "Not a valid amount";
                        NumberOfSubnetsTextbox.Text = "";
                    }
                }
                else
                {
                    SubnetMask_TextBox.Placeholder = "Not a valid mask";
                    SubnetMask_TextBox.Text = "";
                }
            }
            else
            {
                Subnet_TextBox.Placeholder = "Not a valid IP Address";
                Subnet_TextBox.Text = "";
                SubnetMask_TextBox.Placeholder = defaultMask;
            }
        }


    }
}
