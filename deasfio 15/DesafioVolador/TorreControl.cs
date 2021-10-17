using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class TorreControl
    {
        
        ArrayList TControl = new ArrayList();


        public void agregarVolador(Ivolador a)
        {
            TControl.Add(a);
        }

        public void vuelanTodos()
        {
            foreach( Ivolador i in TControl)
            {
                i.volador();
            }
        }

    }
}
