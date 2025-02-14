using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclarer des objets
            Rectangle unRect = new Rectangle(180,25);
            Console.WriteLine(unRect.Hauteur + " x " + unRect.Largeur);
            unRect.Hauteur = -45;
            Console.WriteLine(unRect.Hauteur);



            int aireDuRect;

            aireDuRect = unRect.CalculerAire();
            Console.WriteLine("L'aire du rectangle est " + aireDuRect);

            
        }
    }
}
