using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.View
{
    public interface ISettingView
    {
        public string ipaddress { get; set; }
        public string portaddress { get; set; }

        event EventHandler SaveIPSettings;
        event EventHandler SavePortSettings;
        event EventHandler LoadIP;
        event EventHandler LoadPort;

        void DisplayIP(string IPaddress);
        void DisplayPort(int Port);
    }
}
