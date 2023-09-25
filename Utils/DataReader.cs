using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Utils
{
    public class DataReader
    {
        public static List<string> getDataFromFile(string filePath)
        {
            List<string> dataList = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                dataList.AddRange(lines);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }

            return dataList;
        }
    }
}
