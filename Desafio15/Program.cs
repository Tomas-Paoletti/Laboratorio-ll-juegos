using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaElectrodomesticos = new ArrayList();

            Television tvPlana = new Television(42, true);
            Lavadora electrolux = new Lavadora(10,20,100,"blanco", "A");
            Television smartTV = new Television(60,true, "negro", "A", 20,100);

            listaElectrodomesticos.Add(tvPlana);
            listaElectrodomesticos.Add(smartTV);
            listaElectrodomesticos.Add(electrolux);
           
            foreach(Electrodomestico i in listaElectrodomesticos)
            {
                
                i.precioFinal();
            }
            Console.ReadKey();
        
        }
    }
}
