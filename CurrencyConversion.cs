using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class CurrencyConversion
    {
        private const String CAD = "CAD";
        private const String USD = "USD";
        private const String GBP = "GBP";
        private const String EUR = "EUR";
        private const String INR = "INR";

        public String From { get; set; }
        public String To { get; set; }
        public double FromRate { get; set; }
        public double ToRate { get; set; }

        private FileReadWrite fileReadWrite;

        public CurrencyConversion(String from, String to, double fromRate)
        {
            this.From = from;
            this.To = to;
            this.FromRate = fromRate;
        }

        private void SaveDataToFile()
        {
            fileReadWrite = new FileReadWrite();
            DateTime now = DateTime.Now;
            String data = FromRate.ToString() + " " + From + " = " + ToRate.ToString() + " " + To + "|" + now.ToString();
            fileReadWrite.SaveCurrencyData(data);
        }

        public String ReadDataFromFile()
        {
            return fileReadWrite.ReadCurrencyFile();
        }

        public double GetConversion()
        {
            double conversion = 0;
            switch(From)
            {
                case CAD:
                    conversion = ConvertFromCAD();
                    break;
                case USD:
                    conversion = ConvertFromUSD();
                    break;
                case EUR:
                    conversion = ConvertFromEUR();
                    break;
                case GBP:
                    conversion = ConvertFromGBP();
                    break;
                case INR:
                    conversion = ConvertFromINR();
                    break;
            }
            ToRate = conversion;
            SaveDataToFile();
            return conversion;
        }

        private double ConvertFromUSD()
        {
            double conversion = 0;
            switch(To) {
                case CAD:
                    conversion = FromRate * 1.35;
                    break;
                case USD:
                    conversion = FromRate * 1;
                    break;
                case GBP:
                    conversion = FromRate * 0.80;
                    break;
                case EUR:
                    conversion = FromRate * 0.88;
                    break;
                case INR:
                    conversion = FromRate * 75.21;
                    break;
            }
            return conversion;
        }

        private double ConvertFromCAD()
        {
            double conversion = 0;
            switch (To)
            {
                case CAD:
                    conversion = FromRate * 1;
                    break;
                case USD:
                    conversion = FromRate * 0.74;
                    break;
                case GBP:
                    conversion = FromRate * 0.59;
                    break;
                case EUR:
                    conversion = FromRate * 0.65;
                    break;
                case INR:
                    conversion = FromRate * 55.69;
                    break;
            }
            return conversion;
        }

        private double ConvertFromGBP()
        {
            double conversion = 0;
            switch (To)
            {
                case CAD:
                    conversion = FromRate * 1.70;
                    break;
                case USD:
                    conversion = FromRate * 1.26;
                    break;
                case GBP:
                    conversion = FromRate * 1;
                    break;
                case EUR:
                    conversion = FromRate * 1.10;
                    break;
                case INR:
                    conversion = FromRate * 94.41;
                    break;
            }
            return conversion;
        }

        private double ConvertFromEUR()
        {
            double conversion = 0;
            switch (To)
            {
                case CAD:
                    conversion = FromRate * 1.54;
                    break;
                case USD:
                    conversion = FromRate * 1.14;
                    break;
                case GBP:
                    conversion = FromRate * 0.91;
                    break;
                case EUR:
                    conversion = FromRate * 1;
                    break;
                case INR:
                    conversion = FromRate * 85.77;
                    break;
            }
            return conversion;
        }

        private double ConvertFromINR()
        {
            double conversion = 0;
            switch (To)
            {
                case CAD:
                    conversion = FromRate * 0.018;
                    break;
                case USD:
                    conversion = FromRate * 0.013;
                    break;
                case GBP:
                    conversion = FromRate * 0.011;
                    break;
                case EUR:
                    conversion = FromRate * 0.012;
                    break;
                case INR:
                    conversion = FromRate * 1;
                    break;
            }
            return conversion;
        }
    }
}
