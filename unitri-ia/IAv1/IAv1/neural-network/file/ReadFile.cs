using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAv1.neural_network.file
{
    class ReadFile
    {
        private static String file1 = @"neural-network\file\File1.txt";
        private static String file2 = @"neural-network\file\File2.txt";
        private static String file3 = @"neural-network\file\File3.txt";

        public List<String> getInput1()
        {
            List<String> input = new List<String>();

            string[] lines = System.IO.File.ReadAllLines(file1);

            foreach (String line in lines)
            {
                input.Add(line);
            }

            return input;
        }
    }
}
