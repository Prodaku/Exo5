using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Veuillez renseignez votre NOM.");
            string nom = Console.ReadLine();

            Console.WriteLine("Veuillez renseignez votre PRENOM.");
            string prenom = Console.ReadLine();

            Console.WriteLine("Bonjour Monsieur " + nom + " " + prenom + ", nous sommes le " + DateTime.Now.ToShortDateString() + " comment allez vous ?");

        }
    }
}
