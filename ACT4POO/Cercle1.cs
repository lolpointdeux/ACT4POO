using System;
using System.Collections.Generic;
using System.Text;

namespace ACT4POO
{
    class Cercle1
    {
        private double rayon;
        private bool ok = false;
        private char retry;
        private double air = 0;
        private double per = 0;

        public void CalculerAire()
        {
            
            
            while (ok != true)
            {
                {
                    Console.WriteLine("Entrer l'air :");
                    rayon = double.Parse(Console.ReadLine());
                    air = calcAir(rayon);
                    per = calcPer(rayon);
                    ok = true;
                    Console.WriteLine($"Le cecle de rayon {rayon} a un périmètre {per} et une aire {air}. Avec un cercle de rayon");




                }
            }

            {

            }

              
            

        }
        private double calcAir(double rayon)
        {
            return Math.PI * (rayon * rayon);
        }

        private double calcPer(double rayon)
        {
            return rayon * Math.PI;
        }
    }
}
}
