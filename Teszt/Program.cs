using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain app = AppDomain.CreateDomain("Second");

            Console.WriteLine(app.FriendlyName);

            AppDomain.Unload(app);


            Console.ReadKey();

        }
    }
}
