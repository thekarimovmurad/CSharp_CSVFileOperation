using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CSVFileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/theka/OneDrive/Desktop/addresses.csv";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split();
                foreach (string field in fields)
                {
                    Console.Write(field + "\t");
                }
            }
        }
    }
}
