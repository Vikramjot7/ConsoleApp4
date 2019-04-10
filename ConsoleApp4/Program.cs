using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
        }
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            //Read file using StreamReader. Reads file line by line
            using (StreamReader file = new StreamReader(@"U:\U:\Users\726863.STUDENT/beowulf.txt"))
            {
                int counter = 0;

                int number = 0;

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    if (line.Contains("Sea") && line.Contains("Fare") || line.Contains("sea") && line.Contains("fare"))

                    {

                        int x = counter - 1;

                        number++;

                    }

                    counter++;

                }

                Console.WriteLine($"The number of lines that contains *Sea* and *Fare* are {number}");



                file.Close();
            }
        }
    }
}



