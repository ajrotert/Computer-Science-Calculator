using System;
namespace ComputerScienceCalculator
{
    public class IPAddress
    {
        public IPAddress(ref string[] address1, ref string[] address2, bool isDecimal)
        {
            if (isDecimal)
            {
                IPConversions IPC = new IPConversions(ref address1, IPType.Decimal);
                IPC.ConvertAddress();
                _address1 = IPC.GetBinaryIp().Split('.', ':', ' ');
                FirstOctet = address1[0];
                IPC = new IPConversions(ref address2, IPType.Decimal);
                IPC.ConvertAddress();
                _address2 = IPC.GetBinaryIp().Split('.', ':', ' ');
                _subnetMaskAddress = IPC.GetBinaryIp();
            }
            else
            {
                IPConversions IPC = new IPConversions(ref address1, IPType.Binary);
                IPC.ConvertAddress();
                FirstOctet = IPC.GetDecimalIp().Split('.', ':', ' ')[0];
                _address1 = address1;
                IPC = new IPConversions(ref address2, IPType.Binary);
                IPC.ConvertAddress();
                _address2 = address2;
                _subnetMaskAddress = IPC.GetBinaryIp();
            }
        }

        private string[] _address1;
        private string[] _address2;
        protected string _subnetMaskAddress;
        protected string FirstOctet;

        public string subnetAddress;
        public void LogicalAndcalculate()
        {
            subnetAddress = "";

            for (int i = 0; i < IPConversions.octet; i++)
            {
                string tmp;
                tmp = logicalAND(_address1[i], _address2[i]);
                subnetAddress += tmp;
                if (i != 3)
                    subnetAddress += '.';
            }
        }

        private string logicalAND(string top, string bottom)
        {
            string output = "";

            for (int i = 0; i < IPConversions.octet_size; i++)
            {
                if (top[i] == '1' && bottom[i] == '1')
                    output += "1";
                else
                    output += "0";
            }
            return output;
        }
    }
}
