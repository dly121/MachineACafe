using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineACafe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Initialisation des boissons
            MachineACafe machine = new MachineACafe();

            foreach (var boissons in machine.boissonDico)
            {
                Console.WriteLine(machine.boissonDico.Values.ToString());
            }

            Console.ReadLine();
        }
    }
}
