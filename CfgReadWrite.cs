using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;

namespace DNSeriesConfig
{
    class CfgReadWrite
    {
        const string szRegHostValue = "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\WINCOR NIXDORF\\PROTOPAS\\CURRENTVERSION\\CCOPEN\\COMMUNICATION\\TCPIP\\PROJECT";
        const string szRegParameter = "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\WINCOR NIXDORF\\PROTOPAS\\CURRENTVERSION\\LYNXCI\\PARAMETER";
        const string szHostIPRegName = "REMOTEPEER";
        const string szHostPortRegName = "PORTNUMBER";
        const string szLunoRegName = "LUNO";
        public string szHostIP;
        public string szHostPort;
        public string szLuno;
        public void ReadCfFromMachine(string szCfgFilePath)
        {
            szHostIP = (string)Registry.GetValue(szRegHostValue, szHostIPRegName, "");
            szHostPort = (string)Registry.GetValue(szRegHostValue, szHostPortRegName, "");
            szLuno = (string)Registry.GetValue(szRegParameter, szLunoRegName,"");
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
