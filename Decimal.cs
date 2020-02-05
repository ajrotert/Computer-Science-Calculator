using System;
using UIKit;

namespace ComputerScienceCalculator
{
    public class Decimal
    {
        public Decimal(string DECIMAL = "", string BINARY = "", string HEX = "", string OCTAL = "")
        {
            _decimal = DECIMAL;
            binary = BINARY;
            hex = HEX;
            octal = OCTAL;
        }
        public string _decimal;
        public string hex;
        public string binary;
        public string octal;
        public void convert()
        {
            try
            {
                if (binary != "")
                    B_convert();
                else if (hex != "")
                    H_convert();
                else if (octal != "")
                    O_convert();

                if (_decimal != "0")
                {
                    convert_B();
                    convert_H();
                    convert_O();
                }
                else
                {
                    binary = "0";
                    hex = "0";
                    octal = "0";
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

        private void B_convert()
        {
            int power = 0;
            ulong val =0;
            for (int end = binary.Length - 1; end >= 0; end--)
            {
                val += Convert.ToUInt64(binary[end] - 48) * Convert.ToUInt64(Math.Pow(2, power));
                power++;
            }
            _decimal = val.ToString();
        }
        private void H_convert()
        {
            int power = 0;
            ulong val = 0;
            for (int end = hex.Length - 1; end >= 0; end--)
            {
                if (Convert.ToUInt64(hex[end] - 48) <= 9)
                    val += Convert.ToUInt64(hex[end] - 48) * Convert.ToUInt64(Math.Pow(16, power));
                else
                {
                    if(hex[end] == 'A')
                        val += 10 * Convert.ToUInt64(Math.Pow(16, power));
                    else if (hex[end] == 'B')
                        val += 11 * Convert.ToUInt64(Math.Pow(16, power));
                    else if (hex[end] == 'C')
                        val += 12 * Convert.ToUInt64(Math.Pow(16, power));
                    else if (hex[end] == 'D')
                        val += 13 * Convert.ToUInt64(Math.Pow(16, power));
                    else if (hex[end] == 'E')
                        val += 14 * Convert.ToUInt64(Math.Pow(16, power));
                    else if (hex[end] == 'F')
                        val += 15 * Convert.ToUInt64(Math.Pow(16, power));
                }

                power++;
            }
            _decimal = val.ToString();
        }
        private void O_convert()
        {
            int power = 0;
            ulong val = 0;
            for (int end = octal.Length - 1; end >= 0; end--)
            {
                val += Convert.ToUInt64(octal[end] - 48) * Convert.ToUInt64(Math.Pow(8, power));
                power++;
            }
            _decimal = val.ToString();
        }
        private void convert_B()
        {            
            ulong val = Convert.ToUInt64(_decimal);
            ulong remander;
            while(val != 0)
            {
                remander = val%2;
                val /= 2;
                binary = Convert.ToChar(remander + 48) + binary;
            }
        }
        public static string Convert_To_Binary(int size, int decimal_value)
        {
            string bin = Convert_Number_To_Binary(decimal_value);
            while (bin.Length < size)
            {
                bin = "0" + bin;
            }
            return bin;
        }
        private static string Convert_Number_To_Binary(int decimal_value)
        {
            string static_binary = "";
            int value = decimal_value;
            int remander;
            while(value != 0)
            {
                remander = value % 2;
                value /= 2;
                static_binary = Convert.ToChar(remander + 48) + static_binary;
            }
            return static_binary;
        }
        private void convert_H()
        {
            ulong val = Convert.ToUInt64(_decimal);
            ulong remander;
            while (val != 0)
            {
                remander = val % 16;
                val /= 16;
                if(remander<=9)
                    hex = Convert.ToChar(remander + 48) + hex;
                else
                    hex = hex = Convert.ToChar(remander-9 + 64) + hex;
            }
        }
        private void convert_O()
        {
            ulong val = Convert.ToUInt64(_decimal);
            ulong remander;
            while (val != 0)
            {
                remander = val % 8;
                val /= 8;
                octal = Convert.ToChar(remander + 48) + octal;
            }
        }
    }
}
