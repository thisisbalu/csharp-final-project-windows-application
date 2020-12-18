using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class Calculator
    {
        public double Currentvalue { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public String Op { get; set; }
        FileReadWrite fileReadWrite = new FileReadWrite();

        public void Add(String displayValue)
        {
            double displayNumber = Convert.ToDouble(displayValue);
            Currentvalue = displayNumber;
            Operand1 = displayNumber;
            Op = "+";
        }

        public void Subtract(String displayValue)
        {
            double displayNumber = Convert.ToDouble(displayValue);
            Currentvalue = displayNumber;
            Operand1 = displayNumber;
            Op = "-";
        }

        public void Multiply(String displayValue)
        {
            double displayNumber = Convert.ToDouble(displayValue);
            Currentvalue = displayNumber;
            Operand1 = displayNumber;
            Op = "*";
        }

        public void Divide(String displayValue)
        {
            double displayNumber = Convert.ToDouble(displayValue);
            Currentvalue = displayNumber;
            Operand1 = displayNumber;
            Op = "/";
        }

        public void Equals()
        {
            DateTime currentTime = DateTime.Now;
            String data = currentTime.ToString() + "|";
            try
            {
                data = data + Operand1.ToString() + Op + Operand2.ToString() + "=";
                switch (Op)
                {
                    case "+":
                        Operand1 = Operand1 + Operand2;
                        data = data + Operand1;
                        break;
                    case "-":
                        Operand1 = Operand1 - Operand2;
                        data = data + Operand1;
                        break;
                    case "*":
                        Operand1 = Operand1 * Operand2;
                        data = data + Operand1;
                        break;
                    case "/":
                        Operand1 = Operand1 / Operand2;
                        data = data + Operand1;
                        break;
                }
                fileReadWrite.SaveCalcData(data);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Equals(String displayValue)
        {
            double displayNumber = Convert.ToDouble(displayValue);
            Operand2 = displayNumber;
            DateTime currentTime = DateTime.Now;
            String data = currentTime.ToString() + "|";
            try
            {
                data = data + Operand1.ToString() + Op + Operand2.ToString() + "=";
                switch (Op)
                {
                    case "+":
                        Operand1 = Operand1 + Operand2;
                        data = data + Operand1;
                        break;
                    case "-":
                        Operand1 = Operand1 - Operand2;
                        data = data + Operand1;
                        break;
                    case "*":
                        Operand1 = Operand1 * Operand2;
                        data = data + Operand1;
                        break;
                    case "/":
                        Operand1 = Operand1 / Operand2;
                        data = data + Operand1;
                        break;
                }
                fileReadWrite.SaveCalcData(data);
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public void Clear()
        {
            Operand1 = 0;
            Operand2 = 0;
            Op = null;
            Currentvalue = 0;
        }
    }
}
