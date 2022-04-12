using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;
namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test test = new test(6.5f);
            test test1 = new test(4.3f);
            test test2 = new test(2.9f);
            List<test> list = new List<test>() {test,test1,test2};
            list = list.OrderBy(o => o.member).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].member);
            }
            Console.ReadKey();
        }
    }
}
