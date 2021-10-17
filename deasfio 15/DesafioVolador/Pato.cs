using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Pato: Ivolador 
    {
        private int energia=100;
        public void volador()
        {
            energia -= 3;
            Console.WriteLine("estoy volando soy un pato cuak");
        }

    }
}
