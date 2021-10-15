using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Carrito_de_compras
{
    class Camisa
    {
        private double precio = 1000;
        private double _cantCamisas=0;
        private double _subtotal=0;

        public void agregarCamisa()
        {
            _cantCamisas += 1;
            _subtotal += 1000;
            Console.WriteLine(" Se agrego una ca,isa al carrito de compras");
            Thread.Sleep(300);
            Console.Clear();


        }

        public void eliminarCamisa()
        {
            _cantCamisas -= 1;
            _subtotal -= 1000;
            Console.WriteLine(" Se elimino una ca,isa al carrito de compras");
            Thread.Sleep(300);
            Console.Clear();


        }

        public void sacarTotalMenu()
        {
            double descuento;
            double total;
            Console.WriteLine("Cantidad de camisas en el carrito: " + _cantCamisas);
            Console.WriteLine("Precio por cada prenda: " + precio);
            
            Console.WriteLine("El subtotal sin descuento es: " + _subtotal);
            if(_cantCamisas>2 && _cantCamisas <= 5)
            {

                descuento = _subtotal * 0.10;
                total = _subtotal - descuento;
                Console.WriteLine("El descuento es de 10%");
                Console.WriteLine("El total con descuento es: "+ total);
            }else if (_cantCamisas > 5)
            {
                descuento = _subtotal * 0.20;
                total = _subtotal - descuento;
                Console.WriteLine("El descuento es de 20%");
                Console.WriteLine("El total con descuento es: " +total);
            }
            else
            {

                total = _subtotal;
                Console.WriteLine("Sin descuento");
                Console.WriteLine("El total con descuento es: "+ total);
            }
            
        }






    }
   

    
}
