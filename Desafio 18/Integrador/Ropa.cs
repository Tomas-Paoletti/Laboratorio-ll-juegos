using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    abstract class Ropa
    {
        protected int _cantidad;
        protected double _precio;
        protected bool _standard;
        protected bool _premium;

        protected Ropa(int _cantidad, double _precio)
        {
            this._cantidad = _cantidad;
            this._precio = _precio;
        }
        protected Ropa(int _cantidad, double _precio, bool _standard, bool _premium)
        {
            this._cantidad = _cantidad;
            this._precio = _precio;
            this._standard = _standard;
            this._premium = _premium;
        }

        public abstract double CalcularPrecioFinal();
    }
}
