using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio15
{
   abstract class Electrodomestico
    {
        protected double Peso = 5;
        protected String color = "blanco";
        protected String consumoEnergetico = "F";
        protected double precioBase=100;

        protected Electrodomestico()
        {
        }

        public Electrodomestico(double precioBase, double pes, string color, string consumoEnergetico)
        {
            this.precioBase = precioBase;
            this.Peso = pes;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            //ComprobarConsumo(consumoEnergetico);
           // ComprobarColor(color);
        }

        public Electrodomestico(double precioBas, double pes)
        {
            this.precioBase = precioBas;
            this.Peso = pes;
            ComprobarConsumo(consumoEnergetico);
            ComprobarColor(color);
        }

        public Electrodomestico(double peso)
        {
            this.Peso = peso;
        }
        private void ComprobarConsumo(String a)
        {
            if (a == "a" || a == "A" || a == "b" ||a == "B"  ||a == "C" || a == "c" || a == "D" || a == "d" || a == "e" || a == "E" || a == "F" || a == "f")
            {
                Console.WriteLine("El valor de consumo introducido es correcto");                
            }else consumoEnergetico = "F";
        }
        private void ComprobarColor(String a)
        {
            if (a == "blanco" || a == "BLANCO" || a == "negro" || a == "NEGRO" || a == "rojo" || a == "ROJO" || a == "azul" || a == "AZUL" || a == "gris" || a == "GRIS")
            {
                a = a;
            }
            else color = "blanco";
        }

        public abstract void precioFinal();

      

    }
}
