using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using TakeIo.NetworkAddress;

namespace Core
{
    public class AddressInfo
    {
        private IPNetworkAddress address;
        public AddressInfo(IPNetworkAddress address)
        {
            this.address = address;
        }

        public static IPNetworkAddress Parse(string address)
        {
            return IPNetworkAddress.Parse(address);
        }

        public string[] getAllInfo()
        {
            string[] info = new string[5];

            info[0] = getClass().ToString();
            info[1] = address.Network.ToString();
            info[2] = address.Mask.ToString();
            info[3] = $"{address.MinAddress.ToString()}-{address.MaxAddress.ToString()}";
            info[4] = address.Broadcast.ToString();

            return info;
        }

        private char getClass()
        {
            byte[] mask = address.Mask.GetAddressBytes();
            char[] classes = new char[] { 'A', 'B', 'C'};
            for (int i = 0; i <= 3; i++)
            {
                if (mask[i] != 255)
                    return classes[--i];
            }
            return '�';
        }
    }
}
