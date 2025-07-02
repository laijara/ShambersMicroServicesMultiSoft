using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class Status
    {
        public string statusWork = "off";
        public string statusText = null;
        public void CheckStatus()
        {
            switch (statusWork)
            {
                case "off":
                    statusText = "ПРОГРАММА ВЫКЛЮЧЕНА";
                    break;
                case "on":
                    statusText = "ПРОГРАММА ВКЛЮЧЕНА";
                    break;
                case "attention":
                    statusText = "ТРЕВОГА!!!";
                    break;
                case "test":
                    statusText = "ОТЛАДКА ПРОГРАММЫ";
                    break;
                default:
                    statusText = null;
                    break;
            }
        }
    }
}
