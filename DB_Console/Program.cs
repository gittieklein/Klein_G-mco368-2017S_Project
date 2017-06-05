using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var test = context.ITEMs.Where(i => i.price > 0);
                foreach(var t in test)
                {
                    Console.WriteLine(t.title + " " + t.price);
                }
            }

            Console.ReadKey();
        }
    }
}
