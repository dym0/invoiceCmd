using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("to day is {0},This is my sweet string! :D", DateTime.Now);

            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
