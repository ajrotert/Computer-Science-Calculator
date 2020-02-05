using System;
using System.Linq;
namespace ComputerScienceCalculator
{
    public class Subnetting : IPAddress
    {
        public Subnetting(ref string[] IP, ref string[] mask, int subnets) : base(ref IP, ref mask, true)
        {
            _IP = "";
            _mask = "";
            for (int a = 0; a < IPConversions.octet; a++)
            {
                _IP += IP[a];
                _mask += mask[a];
                if (a < IPConversions.octet - 1)
                {
                    _IP += ".";
                    _mask += ".";
                }
            }
            _subnets = subnets;

            LogicalAndcalculate();
        }
        private IPConversions converter;

        private string _IP;
        private string _mask;
        private int _subnets;
        private int _startingLocation;
        private int _byteSpace;
        private const int IPAddressSize = 35;
        private bool _validated = false;
        private string[,] subnetArray;
        private string[] DecimalID;
        private string[] BroadcastID;
        private string[] HostRange;
        private string[] StolenBits;
        private string[] TotalHosts;

        public string[,] makeSubnets()
        {
            if (_validated)
            {
                subnetArray = new string[_subnets, 3];
                DecimalID = new string[_subnets];
                BroadcastID = new string[_subnets];
                HostRange = new string[_subnets];
                StolenBits = new string[_subnets];
                TotalHosts = new string[_subnets];

                for (int i = 0; i < _subnets; i++)
                {
                    string subnetID = Decimal.Convert_To_Binary(_byteSpace, i);
                    int count = 0;
                    subnetArray[i, 0] = "";
                    for (int j = 0; j < IPAddressSize; j++)
                    {
                        if (subnetAddress[j] == '.')
                        {
                            subnetArray[i, 0] += '.';
                        }
                        else if (j >= _startingLocation + 1 && count < subnetID.Length)
                        {
                            subnetArray[i, 0] += subnetID[count];
                            count++;
                        }
                        else
                        {
                            subnetArray[i, 0] += subnetAddress[j];
                        }
                    }

                    string[] temp = getFormattedString(subnetArray[i, 0], getDecimalSubnet(i), getBroadcast(i), getHostRange(i), i, _subnets);
                    subnetArray[i, 0] = temp[0];
                    subnetArray[i, 1] = temp[1];
                    subnetArray[i, 2] = temp[2];
                }
                return subnetArray;
            }
            return null;
        }

        private string[] getFormattedString(string SubnetID, string DecimalSubnet, string BroadCastAddress, string HostIdRange, int index, int length)
        {
            string[] output = new string[3];
            string fmt = index.ToString();
            for (int a = 0; fmt.Length < length.ToString().Length; a++)
                fmt = ' ' + fmt;

            output[0] = fmt + ": " + SubnetID + " (" + DecimalSubnet + ")";

            output[1] = "\t\t" + "Broadcast ID: " + BroadCastAddress;

            output[2] = "\t\t" + "Host Range: " + HostIdRange;

            return output;
        }

        private string getDecimalSubnet(int index)
        {
            string[] subnetAddressArray = subnetArray[index, 0].Split('.', ' ', ':');
            converter = new IPConversions(ref subnetAddressArray, IPType.Binary);
            converter.ConvertAddress();

            DecimalID[index] = converter.GetDecimalIp();
            return converter.GetDecimalIp();
        }
        private string getBroadcast(int index)
        {
            int bitChangeCount = _startingLocation;
            char[] tmp = subnetArray[index, 0].ToCharArray();

            int counter = 0;
            for (int i = bitChangeCount + 1; i < IPAddressSize; i++)
            {
                if (counter >= _byteSpace)
                {
                    if (tmp[i] != '.')
                        tmp[i] = '1';
                }
                if (tmp[i] != '.')
                    counter++;
            }

            string[] binaryAddressArray = (new string(tmp)).Split('.', ':', ' ');
            converter = new IPConversions(ref binaryAddressArray, IPType.Binary);
            converter.ConvertAddress();

            BroadcastID[index] = converter.GetDecimalIp();
            return converter.GetDecimalIp();
        }
        private string getHostRange(int index)
        {
            char[] subnet = subnetArray[index, 0].ToCharArray();

            subnet[IPAddressSize - 1] = '1';

            string[] decimalAddressArray = BroadcastID[index].Split('.', ':', ' ');
            converter = new IPConversions(ref decimalAddressArray, IPType.Decimal);
            converter.ConvertAddress();

            char[] subnet2 = converter.GetBinaryIp().ToCharArray();

            subnet2[IPAddressSize - 1] = '0';

            string[] binaryAddressArray = (new string(subnet)).Split('.', ' ', ':');
            converter = new IPConversions(ref binaryAddressArray, IPType.Binary);
            converter.ConvertAddress();

            string lowRange = converter.GetDecimalIp();

            string[] binaryAddressArray2 = (new string(subnet2)).Split('.', ':', ' ');
            converter = new IPConversions(ref binaryAddressArray2, IPType.Binary);
            converter.ConvertAddress();

            string highRange = converter.GetDecimalIp();

            HostRange[index] = lowRange + " - " + highRange;
            return lowRange + " - " + highRange;
        }
        public string getBitsStolen()
        {
            return _byteSpace.ToString();
        }
        public string getTotalNumberOfHosts()
        {
            //Method 1 May be Flawed
            /*
            int starting = _startingLocation;

            if (starting < 9)
                starting++;
            if (starting < 18)
                starting++;
            if (starting < 27)
                starting++;

            int numberOfHostBits = IPAddressSize - starting - _byteSpace - 1;

            int numberOfHosts = (int)Math.Pow(2, numberOfHostBits) - 2;

            return numberOfHosts.ToString();
            */
            int numberOfHostBits = findHostSpace();
            numberOfHostBits = (IPConversions.octet_size * IPConversions.octet) - numberOfHostBits;

            int numberOfHosts = (int)Math.Pow(2, numberOfHostBits) - 2;

            return numberOfHosts.ToString();
        }
        public string getIPAddressClass()
        {
            int First_Octet;
            if (int.TryParse(FirstOctet, out First_Octet))
            {
                if (First_Octet > 0 && First_Octet < 127)
                    return "Class A";
                else if (First_Octet >= 127 && First_Octet < 192)
                    return "Class B";
                else if (First_Octet >= 192 && First_Octet < 224)
                    return "Class C";
                else if (First_Octet >= 224 && First_Octet < 240)
                    return "Class D";
                else if (First_Octet >= 240 && First_Octet < 255)
                    return "Class E";
            }
            return "Unknown Class";
        }

        private int findStartPosition()
        {
            int position = 0;
            for (int i = 0; i < _subnetMaskAddress.Length; i++)
            {
                if (_subnetMaskAddress[i] == '1')
                {
                    position = i;
                    if (_subnetMaskAddress[i + 1] == '.')
                        position++;
                }
            }
            return position;
        }
        private int findHostSpace()
        {
            int position = 0;
            int counter = 1;
            for(int i =0; i < _subnetMaskAddress.Length; i++)
            {
                if (_subnetMaskAddress[i] == '1')
                    position = counter;
                else if (_subnetMaskAddress[i] == '.')
                    counter--;
                counter++;
            }
            return position + _byteSpace;
        }

        public bool validSubnetAmount()
        {
            int startPosition = findStartPosition();

            _startingLocation = startPosition;

            int byteNumber = (int)Math.Ceiling(Math.Log(_subnets, 2));

            _byteSpace = byteNumber;

            if (byteNumber + startPosition > IPAddressSize - 1 || _subnets == 1)
                return false;
            _validated = true;
            return true;
        }
    }
}
