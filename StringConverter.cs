using System;
namespace ComputerScienceCalculator
{
    public class StringConverter
    {
        public StringConverter(string DECIMAL = "", string STRING = "", string HEX = "", string BIN = "")
        {
            Decimal = DECIMAL;
            String = STRING;
            Hexadecimal = HEX;
            Binary = BIN;
        }

        public string Decimal;
        public string Hexadecimal;
        public string String;
        public string Binary;
        private Decimal d;

        public void convert()
        {
            if (Decimal != "")
                convertD_H();
            else if (Hexadecimal != "")
                convertH_S();
            else if (String != "")
                convertS_H();
            else if (Binary != "")
                convertB_H();

        }
        private void convertD_H()
        {
            d = new Decimal(DECIMAL: Decimal);
            d.convert();
            String = "" + Convert.ToChar(Convert.ToInt32(Decimal));
            Hexadecimal = d.hex;
            Binary = d.binary;
        }
        private void convertH_S()
        {
            for (int a = 0; a < Hexadecimal.Length; a += 2)
            {
                d = new Decimal(HEX: Hexadecimal.Substring(a,2));
                d.convert();
                Decimal += d._decimal + " ";
                String += Convert.ToChar(Convert.ToInt32(d._decimal));
                Binary += d.binary + " ";
            }
        }
        private void convertS_H()
        { 
            for(int a =0; a< String.Length; a++)
            {
                Decimal += Convert.ToInt32(String[a]) + " ";
                d = new Decimal(DECIMAL: "" + Convert.ToInt32(String[a]));
                d.convert();
                Hexadecimal += d.hex + " ";
                Binary += d.binary += " ";
            }
        }
        private void convertB_H()
        {
            d = new Decimal(BINARY: Binary);
            d.convert();
            String += "" + Convert.ToChar(Convert.ToInt32(d._decimal));
            Hexadecimal = d.hex;
            Decimal = d._decimal;
        }
    }
}
