using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_2014356
{
    class FileReadWrite
    {
        private static String DIR_PATH = @".\TxtFiles\";
        private String LOTTO_FILE_PATH = DIR_PATH + "LottoNbrs.txt";
        private String CALC_FILE_PATH = DIR_PATH + "Calculator.txt";
        private String TEMP_CONVERSIONS_FILE_PATH = DIR_PATH + "TempConversions.txt";
        private String CURRENCY_CONVERSIONS_FILE_PATH = DIR_PATH + "MoneyConversions.txt";
        private String IP_VALIDATION_FILE_PATH = DIR_PATH + "IpValidations.txt";


        public void DeleteDirectoryIfExists()
        {
            DirectoryInfo directoryInfo = null;
            if (Directory.Exists(DIR_PATH))
            {
                Directory.Delete(DIR_PATH, true);
                directoryInfo = CreateDirectory();
            }
            else
            {
                directoryInfo = CreateDirectory();
            }
            if(directoryInfo != null && directoryInfo.Exists)
            {
                CreateFileIfNotExists(LOTTO_FILE_PATH);
                CreateFileIfNotExists(CALC_FILE_PATH);
                CreateFileIfNotExists(TEMP_CONVERSIONS_FILE_PATH);
                CreateFileIfNotExists(CURRENCY_CONVERSIONS_FILE_PATH);
                CreateFileIfNotExists(IP_VALIDATION_FILE_PATH);
            }
        }

        private void CreateFileIfNotExists(String FILE_PATH)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(FILE_PATH, FileMode.Create, FileAccess.Write);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                fs.Close();
            }
        }

        private DirectoryInfo CreateDirectory()
        {
            DirectoryInfo directoryInfo = null;
            if (!Directory.Exists(DIR_PATH))
            {
                directoryInfo = Directory.CreateDirectory(DIR_PATH);
            }
            return directoryInfo;
        }

        public void SaveLottoData(String data)
        {
            try
            {
                AppendDataToFile(data, LOTTO_FILE_PATH);
            } 
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveCalcData(String data)
        {
            try
            {
                AppendDataToFile(data, CALC_FILE_PATH);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveCurrencyData(String data)
        {
            try
            {
                AppendDataToFile(data, CURRENCY_CONVERSIONS_FILE_PATH);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveTemperatureData(String data)
        {
            try
            {
                AppendDataToFile(data, TEMP_CONVERSIONS_FILE_PATH);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveIPData(String data)
        {
            try
            {
                AppendDataToFile(data, IP_VALIDATION_FILE_PATH);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void AppendDataToFile(String data, String FILE_PATH)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(FILE_PATH, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);

                textOut.WriteLine(data);
                textOut.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                throw fnfe;
            }
            catch (DirectoryNotFoundException dnfe)
            {
                throw dnfe;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        public String ReadLottoFile()
        {
            return ReadFromLottoFile(LOTTO_FILE_PATH);
        }

        public String ReadCurrencyFile()
        {
            return ReadFromCurrencyFile(CURRENCY_CONVERSIONS_FILE_PATH);
        }

        public String ReadTemperatureFile()
        {
            return ReadFromTemperatureFile(TEMP_CONVERSIONS_FILE_PATH);
        }

        private String ReadFromTemperatureFile(String FILE_PATH)
        {
            String data = "";
            FileStream fs = null;
            try
            {
                fs = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    if (columns.Length > 1)
                    {
                        data = data + columns[0] + "    " + columns[1] + "\n";
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return data;
        }

        private String ReadFromCurrencyFile(String FILE_PATH)
        {
            String data = "";
            FileStream fs = null;
            try
            {
                fs = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    if (columns.Length > 1)
                    {
                        data = data + columns[0] + "    " + columns[1] + "\n";
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return data;
        }

        private String ReadFromLottoFile(String FILE_PATH)
        {
            String data = "";
            FileStream fs = null;
            try
            {
                fs = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    if(columns.Length > 1)
                    {
                        data = data + columns[0] + "    " + columns[1] + "    " + columns[2] + "    " + columns[3] + "\n";
                    }
                }
            } 
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(fs!=null)
                    fs.Close();
            }
            return data;
        }
    }
}
