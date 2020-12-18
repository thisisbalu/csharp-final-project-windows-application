using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class TemperatureConversion
    {
        private const String CELSUIS = "C";
        private const String FARENHEIT = "F";

        public String FromType { get; set; }
        public String ToType { get; set; }
        public float FromValue { get; set; }
        public float ToValue { get; set; }
        public String Message { get; set; }

        FileReadWrite fileReadWrite = new FileReadWrite();

        public TemperatureConversion(String fromType, String toType)
        {
            this.FromType = fromType;
            this.ToType = toType;
        }

        public void Convert(float fromValue)
        {
            this.FromValue = fromValue;
            if(FromType.Equals(CELSUIS) && ToType.Equals(FARENHEIT))
            {
                ConvertCTOF();
            } else
            {
                ConvertFTOC();
            }
        }

        public void ConvertCTOF()
        {
            float c = 9/5f;
            ToValue = (FromValue * c) + 32;
            SaveDataToFile();
            if(FromValue == 100)
            {
                Message = "Water boils";
            }
            else if(FromValue == 40)
            {
                Message = "Hot Bath";
            }
            else if(FromValue == 37)
            {
                Message = "Body temperature";
            }
            else if(FromValue == 30)
            {
                Message = "Beach weather";
            }
            else if(FromValue == 21)
            {
                Message = "Room temperature";
            }
            else if(FromValue == 10)
            {
                Message = "Cool Day";
            }
            else if(FromValue == 0)
            {
                Message = "Freezing point of water";
            }
            else if(FromValue == -18)
            {
                Message = "Very Cold Day";
            }
            else if(FromValue == -40)
            {
                Message = "Extremely Cold Day (and the same number!)";
            }
        }

        public void ConvertFTOC()
        {
            float c = 5/9f;
            ToValue = (FromValue - 32) * (c);
            SaveDataToFile();
            if (FromValue == 212)
            {
                Message = "Water boils";
            }
            else if (FromValue == 104)
            {
                Message = "Hot Bath";
            }
            else if (FromValue == 98.6f)
            {
                Message = "Body temperature";
            }
            else if (FromValue == 86)
            {
                Message = "Beach weather";
            }
            else if (FromValue == 70)
            {
                Message = "Room temperature";
            }
            else if (FromValue == 50)
            {
                Message = "Cool Day";
            }
            else if (FromValue == 32)
            {
                Message = "Freezing point of water";
            }
            else if (FromValue == 0)
            {
                Message = "Very Cold Day";
            }
            else if (FromValue == -40)
            {
                Message = "Extremely Cold Day (and the same number!)";
            }
        }

        private void SaveDataToFile()
        {
            fileReadWrite = new FileReadWrite();
            DateTime now = DateTime.Now;
            String data = FromValue.ToString() + " " + FromType + " = " + ToValue.ToString() + " " + ToType + "|" + now.ToString();
            fileReadWrite.SaveTemperatureData(data);
        }

        public String ReadDataFromFile()
        {
            return fileReadWrite.ReadTemperatureFile();
        }
    }
}
