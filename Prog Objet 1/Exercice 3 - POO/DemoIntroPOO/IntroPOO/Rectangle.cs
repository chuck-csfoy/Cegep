using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Rectangle
    {
        private int largeur;
        private int hauteur;

        public Rectangle(int hauteur, int largeur)
        {
            this.Hauteur = hauteur;
            this.Largeur = largeur;
        }

        public int Largeur
        {
            get => largeur;
            set {
                if (value >= 0)
                {
                    largeur = value;
                }
                else
                {
                    largeur = 0;
                }
                
            }
        }
        public int Hauteur
        {
            get { return hauteur; }
            set {
                hauteur = value;
                if (value < 0)
                {
                    hauteur = 0;
                }
            }

        }

        public int CalculerAire()
        {
            int aire;

            aire = Hauteur * Largeur;
            //aire = this.hauteur * this.largeur;

            return aire;

        }

    }
}
