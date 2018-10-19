using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti
{
    class Program
    {
        static void Main(string[] args)
        {
            int valore1 = 65555;
            short numero = (short)valore1;
            Console.WriteLine(numero);
            




            Task t = new Task(Write);
            t.Start();

            int i = 1000;
            while (i > 0)
            {
                Console.Write("Settembre");
                i--;
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static void Write()
        {
            int i = 1000;
            while (i > 0)
            {
                Console.Write(i);
                i--;
            }
        }
        

    }
}
