using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.Models
{
    public class SettingModel
    {
        public string LoadIP()
        {
            string ipaddress = Properties.Settings.Default.ServerIP;
            return ipaddress;
        }

        public int LoadPort()
        {
            int port = Properties.Settings.Default.Port;
            return port;
        }

        public void SaveSettingIP(string serverIP)
        {
            Properties.Settings.Default.ServerIP = serverIP;
            Properties.Settings.Default.Save();
        }

        public void SaveSettingPort(string port)
        {
            int portNumber;
            if (int.TryParse(port, out portNumber))
            {
                Properties.Settings.Default.Port = portNumber;
                Properties.Settings.Default.Save();
            }
        }
    }
}
