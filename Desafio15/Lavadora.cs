using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio15
{
    class Lavadora : Electrodomestico
    {
        private double carga;
        public double Carga { get => carga; }
        

        public Lavadora() 
        {

        }
        
        public Lavadora(double carga, double Peso, double precioBase, String color, String consumoEnergetico )
            :base(Peso, precioBase,color ,consumoEnergetico)
        {
            this.carga = carga;
            this.Peso = Peso;
           
        }

        public Lavadora(double carga, double Peso, String col, String consumo)
            :base(Peso)
        {
            this.carga = carga;
            this.Peso = Peso;
            this.color = col;
            this.consumoEnergetico = consumo;
            
          

        }
        public override void precioFinal()
        {
            int price = 0;
            if (Peso <= 0 & Peso >= 19)
            {
                price = 10;
                if (consumoEnergetico == "a" || consumoEnergetico == "A")
                {
                    price += 100;
                }
                else if (consumoEnergetico == "b" || consumoEnergetico == "B")
                {
                    price += 80;
                }
                else if (consumoEnergetico == "c" || consumoEnergetico == "C")
                {
                    price += 60;
                }
                else if (consumoEnergetico == "D" || consumoEnergetico == "d")
                {
                    price += 50;
                }
                else if (consumoEnergetico == "E" || consumoEnergetico == "e")
                {
                    price += 30;
                }
                else if (consumoEnergetico == "f" || consumoEnergetico == "F")
                {
                    price += 10;
                }
            }
            else if (Peso < 20 & Peso > 49)
            {
                price += 50;
                if (consumoEnergetico == "a" || consumoEnergetico == "A")
                {
                    price += 100;
                }
                else if (consumoEnergetico == "b" || consumoEnergetico == "B")
                {
                    price += 80;
                }
                else if (consumoEnergetico == "c" || consumoEnergetico == "C")
                {
                    price += 60;
                }
                else if (consumoEnergetico == "D" || consumoEnergetico == "d")
                {
                    price += 50;
                }
                else if (consumoEnergetico == "E" || consumoEnergetico == "e")
                {
                    price += 30;
                }
                else if (consumoEnergetico == "f" || consumoEnergetico == "F")
                {
                    price += 10;
                }

            }
            else if (Peso < 50 & Peso > 79)
            {
                price += 80;
                if (consumoEnergetico == "a" || consumoEnergetico == "A")
                {
                    price += 100;
                }
                else if (consumoEnergetico == "b" || consumoEnergetico == "B")
                {
                    price += 80;
                }
                else if (consumoEnergetico == "c" || consumoEnergetico == "C")
                {
                    price += 60;
                }
                else if (consumoEnergetico == "D" || consumoEnergetico == "d")
                {
                    price += 50;
                }
                else if (consumoEnergetico == "E" || consumoEnergetico == "e")
                {
                    price += 30;
                }
                else if (consumoEnergetico == "f" || consumoEnergetico == "F")
                {
                    price += 10;
                }
            }
            else if (Peso < 80)
            {
                price += 100;
                if (consumoEnergetico == "a" || consumoEnergetico == "A")
                {
                    price += 100;
                }
                else if (consumoEnergetico == "b" || consumoEnergetico == "B")
                {
                    price += 80;
                }
                else if (consumoEnergetico == "c" || consumoEnergetico == "C")
                {
                    price += 60;
                }
                else if (consumoEnergetico == "D" || consumoEnergetico == "d")
                {
                    price += 50;
                }
                else if (consumoEnergetico == "E" || consumoEnergetico == "e")
                {
                    price += 30;
                }
                else if (consumoEnergetico == "f" || consumoEnergetico == "F")
                {
                    price += 10;
                }
               
            }
            else price = 100;
            Console.WriteLine("El precio de la lavadora es : " + price);
        }




    }
}
