using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNaming_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] st = { "doc", "doc", "image", "doc(1)", "doc" };
            string[] st2 = fileNaming(st);
            foreach (var item in st2)
            {
                Console.WriteLine(item);
            }
        }

        static string[] fileNaming(string[] names)
        {
            var results = new List<string>();
            foreach (var name in names)
            {
                if (results.Any(n => n == name))
                {
                    int k = 1;
                    while (results.Any(n => n == name + "(" + k + ")")) k++;
                    results.Add(name + "(" + k + ")");
                }
                else
                {
                    results.Add(name);
                }
            }
            return results.ToArray();
        }
    }
}
