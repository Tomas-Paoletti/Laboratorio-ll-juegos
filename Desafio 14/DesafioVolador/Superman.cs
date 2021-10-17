using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Superman: Ivolador
    {
        private int xp = 0;
        public void volador()
        {
            Console.WriteLine("Estoy volando como un campeon");
            xp += 3;
        }
    }
}
