using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public enum addressInfo
    {
        ipClass,
        network,
        netmask,
        ipRange,
        broadcast
    }

    public class AddressInfo
    {
        private IPAddress IP;
        private IPAddress NETMASK;

        private char ipClass;
        private string network;
        private string netmask;
        private string ipRange;
        private string broadcast;

        public AddressInfo(string IP, string NETMASK)
        {
            
        }

        public static IPAddress parse(string value, string senderName)
        {
            try
            {
                return IPAddress.Parse(value);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show($"Se debe introducir un valor como {senderName.Split('_')[0]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (FormatException)
            {
                MessageBox.Show($"El valor introducido como {senderName.Split('_')[0]} no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
