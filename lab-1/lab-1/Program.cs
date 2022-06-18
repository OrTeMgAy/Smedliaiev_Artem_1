using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\\1\\1.txt";
                string[] Arr = File.ReadAllLines(path);

                var C = new List<int>();
                foreach(string n in Arr)
                {
                    C.Add(Convert.ToInt32(n));
                }

                var C1 = C.TakeWhile(s => s > 0).OrderBy(s=>s);
                var C2 = C.SkipWhile(s => s > 0).Skip(1);

                var result = C1.Concat(C2);
                            
                foreach(int n in result)
                {
                    Console.WriteLine(n);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
