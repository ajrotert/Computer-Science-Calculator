using System;
using UIKit;
namespace ComputerScienceCalculator
{
    public class TwoComplament
    {
        public TwoComplament(string DECIMAL16 ="", string DECIMAL32="", string BINARY="", string HEXADECIMAL="")
        {
            dec16 = DECIMAL16;
            dec32 = DECIMAL32;
            binary = BINARY;
            hexadecimal = HEXADECIMAL;
        }
        private Decimal d;
        private string mult="";
        public string dec16;

        public string dec32;

        public string binary;
        public string hexadecimal;

        public void convert()
        {
            try
            {
                if (binary != "")
                    convertB_D();
                else if (hexadecimal != "")
                    ConvertH_D();
                else if (dec16 == "0")
                {
                    dec32 = "0";
                    binary = "0000000000000000";
                    hexadecimal = "0000";
                }
                else if (dec32 == "0")
                {
                    dec16 = "0";
                    binary = "00000000000000000000000000000000";
                    hexadecimal = "00000000";
                }
                else if (dec16 != "")
                {
                    dec32 = dec16;
                    ConvertD16_B();
                }
                else if (dec32 != "")
                {
                    ConvertD32_H();
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
        private char[] flipBits(char[] temp)
        {
            int carry = 1;
            int pos = temp.Length-1;
            for (int a = 0; a < binary.Length; a++)
            {
                if (temp[a] == '1')
                    temp[a] = '0';
                else
                    temp[a] = '1';
            }
            while (carry > 0 && pos >= 0)
            {
                if (temp[pos] == '0')
                {
                    temp[pos] = '1';
                    carry--;
                }
                else
                {
                    temp[pos] = '0';
                }
                pos--;
            }
            return temp;
        }
        private void convertB_D()
        {
            char[] temp = binary.ToCharArray();
            d = new Decimal(BINARY: binary);
            d.convert();
            hexadecimal = d.hex;
            for (int a = hexadecimal.Length; a < 4; a++)
                hexadecimal = "0" + hexadecimal;
            if (binary[0] == '1')
            {
                mult = "-";
                temp = flipBits(binary.ToCharArray());
            }
            else
                mult = "";
            d = new Decimal(BINARY: new string(temp));
            d.convert();
            if(binary.Length<=16)
                dec16 = mult + d._decimal;
            else
                dec32 = mult + d._decimal;

        }
        private void ConvertH_D()
        {
            d = new Decimal(HEX: hexadecimal);
            d.convert();
            binary = d.binary;
            for (int a = binary.Length; a < hexadecimal.Length *4;a++)
                binary = "0" + binary;
            convertB_D();
            d = new Decimal(BINARY: binary);
            d.convert();
            hexadecimal = d.hex;
            for (int a = hexadecimal.Length; a < 4; a++)
                hexadecimal = "0" + hexadecimal;
        }
        private void ConvertD16_B()
        {
            if (dec16[0] == '-')
            {
                mult = "-";
                dec16 = dec16.Substring(1);
            }
            else
                mult = "";
            d = new Decimal(DECIMAL: dec16);
            d.convert();
            binary = d.binary;
            for (int a = binary.Length; a < 16; a++)
                binary = "0" + binary;
            if (mult=="-")
            {
                binary = new string(flipBits(binary.ToCharArray()));
            }
            d = new Decimal(BINARY: binary);
            d.convert();
            dec16 = mult + dec16;
            hexadecimal = d.hex;
            for (int a = hexadecimal.Length; a < 4; a++)
                hexadecimal = "0" + hexadecimal;
        }
        private void ConvertD32_H()
        {
            if (dec32[0] == '-')
            {
                mult = "-";
                dec32 = dec32.Substring(1);
            }
            else
                mult = "";
            d = new Decimal(DECIMAL: dec32);
            d.convert();
            binary = d.binary;
            for (int a = binary.Length; a < 32; a++)
                binary = "0" + binary;
            if (mult == "-")
            {
                binary = new string(flipBits(binary.ToCharArray()));
            }
            d = new Decimal(BINARY: binary);
            d.convert();
            hexadecimal = d.hex;
            for (int a = hexadecimal.Length; a < 8; a++)
                hexadecimal = "0" + hexadecimal;
        }
    }
}
