using System;
using System.Linq;
namespace ComputerScienceCalculator
{
    public enum IPType
    {
        Decimal,
        Binary
    };
    public class IPConversions
    {
        public const int octet = 4;
        public const int octet_size = 8;

        public IPConversions(ref string[] IPAdressArray, IPType type)
        {
            DecimalIPAddress = new byte[octet];
            BinaryIPAddress = new string[octet];
            if(type == IPType.Decimal)
                DecimalIPAddress = (from ip in IPAdressArray
                                    select Convert.ToByte(ip)).ToArray();
            else
                BinaryIPAddress = IPAdressArray;
            IPaddress = IPAdressArray;
            this.type = type;
            converted = false;
        }
        byte[] DecimalIPAddress;
        string[] BinaryIPAddress;
        string[] IPaddress;
        IPType type;
        bool converted;

        public void ConvertAddress()
        {
            if (type == IPType.Decimal)
                ConvertDecToBin();
            else
                ConvertBinToDec();
            converted = true;
        }
        private void ConvertDecToBin()
        {
            Decimal d;
            for(int a = 0; a<octet; a++)
            {
                d = new Decimal(DECIMAL: IPaddress[a]);
                d.convert();
                string binary = d.binary;
                while (binary.Length < octet_size)
                    binary = '0' + binary;
                BinaryIPAddress[a] = binary;
            }
        }
        private void ConvertBinToDec()
        {
            Decimal d;
            for (int a = 0; a < octet; a++)
            {
                d = new Decimal(BINARY: IPaddress[a]);
                d.convert();
                byte number = 0;
                byte.TryParse(d._decimal, out number);
                DecimalIPAddress[a] = number;
            }
        }
        public string GetBinaryIp()
        {
            string ip = "";
            if (!converted)
                return ip;
            for(int i =0; i<octet; i++)
            {
                ip += BinaryIPAddress[i];
                if (i != 3)
                    ip += '.';
            }
            return ip;
        }
        public string GetDecimalIp()
        {
            string ip = "";
            if (!converted)
                return ip;
            for(int i =0; i<octet; i++)
            {
                ip += DecimalIPAddress[i];
                if (i != 3)
                    ip += '.';
            }
            return ip;
        }
    }
}
