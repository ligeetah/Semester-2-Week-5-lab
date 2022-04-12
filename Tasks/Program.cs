using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> str_list = new List<string>() {"saqib_single","mateen_legend","dr_khadim","ibrahim_programer"};
            str_list.Sort();
            for (int i = 0; i < str_list.Count; i++)
            {
                Console.WriteLine(str_list[i]);
            }
            Console.ReadKey();
        }
    }
}
