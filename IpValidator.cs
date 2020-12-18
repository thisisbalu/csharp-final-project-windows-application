using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class IpValidator
    {

        public String IP { get; set; }

        FileReadWrite fileReadWrite = new FileReadWrite();

        public IpValidator(String ip)
        {
            this.IP = ip;
        }

        private void SaveDataToFile(bool isValid)
        {
            fileReadWrite = new FileReadWrite();
            DateTime now = DateTime.Now;
            String data = IP + "|" + (isValid ? "Valid" : "InValid") + "|" + now.ToString();
            fileReadWrite.SaveIPData(data);
        }

        public bool validateIP()
        {
            String[] ips = IP.Split('.');
            if (ips.Length == 4)
            {
                try
                {
                    for (int i = 0; i < ips.Length; i++)
                    {
                        int part = int.Parse(ips[i]);
                        if (!(part >= 0 && part <= 255))
                        {
                            SaveDataToFile(false);
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    SaveDataToFile(false);
                    return false;
                }
            } else
            {
                SaveDataToFile(false);
                return false;
            }
            SaveDataToFile(true);
            return true;
        }
    }
}
