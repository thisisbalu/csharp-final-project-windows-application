using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class Lotto
    {
        public String GeneratedNumbersString { get; private set; }
        public String Extra { get; private set; }
        public String MainNumbers { get; private set; }
        private String Type;

        public Lotto(String Type)
        {
            this.Type = Type;
        }

        public void Generate()
        {
            if(Type.Equals("Max"))
            {
                generateLottoMaxNumbers();
            } else
            {
                generateLotto369Numbers();
            }
        }

        private void generateLottoMaxNumbers()
        {
            int[] numbers = new int[8];
            int[] mainNumbers = new int[7];
            int i = 0;
            while (i < 8)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 50);
                if(!numbers.Contains(randomNumber))
                {
                    numbers[i++] = randomNumber;
                }
            }
            i = 0;
            while(i < 7)
            {
                mainNumbers[i] = numbers[i];
                i++;
            }
            Extra = numbers[7].ToString();
            GeneratedNumbersString = String.Join(Environment.NewLine, numbers);
            MainNumbers = String.Join(", ", mainNumbers);
        }

        public String GetDataToSave()
        {
            String data = Type + "|";
            DateTime dateTime = DateTime.Now;
            data = data + dateTime.ToString() + "|" + MainNumbers + "|Extra " + Extra;
            return data;
        }

        private void generateLotto369Numbers()
        {
            int[] numbers = new int[7];
            int[] mainNumbers = new int[6];
            int i = 0;
            while (i < 7)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 49);
                if (!numbers.Contains(randomNumber))
                {
                    numbers[i++] = randomNumber;
                }
            }
            i = 0;
            while (i < 6)
            {
                mainNumbers[i] = numbers[i];
                i++;
            }
            Extra = numbers[6].ToString();
            GeneratedNumbersString = String.Join(Environment.NewLine, numbers);
            MainNumbers = String.Join(", ", mainNumbers);
        }
    }
}
