using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210217
{
    class Program
    {
        static void Main()
        {
            Lakcim();
            Console.ReadKey();
        }

        private static void Lakcim()
        {
            Console.Write("irányítószám: ");
            string iranyitoSzam = Console.ReadLine();
            Console.Write("település neve: ");
            string telepulesNeve = Console.ReadLine();
            Console.Write("kozterület neve: ");
            string kozteruletNeve = Console.ReadLine();
            Console.Write("közterület jellege: ");
            string kozteruletJellege = Console.ReadLine();
            Console.Write("házszám: ");
            string hazszam = Console.ReadLine();

            Console.WriteLine(iranyitoSzam + " " + telepulesNeve + " " + kozteruletNeve + " " + kozteruletJellege + " " + hazszam + ".");
            Console.WriteLine("{0} {1} {2} {3} {4}.", iranyitoSzam, telepulesNeve, kozteruletNeve, kozteruletJellege, hazszam);
            Console.WriteLine($"{iranyitoSzam} {telepulesNeve} {kozteruletNeve} {kozteruletJellege} {hazszam}.");
        }
    }
}
