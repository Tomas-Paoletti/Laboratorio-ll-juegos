using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Pantalon : Ropa
    {
        private bool _bermuda;

        public Pantalon(int _cantidad, double _precio)
            : base(_cantidad, _precio)
        {
            this._cantidad = _cantidad;
            this._precio = _precio;
        }
        
        public Pantalon(bool _bermuda, int _cantidad, double _precio, bool _standard, bool _premium)
            : base(_cantidad, _precio, _standard, _premium)
        {
            this._bermuda = _bermuda;
            this._cantidad = _cantidad;
            this._precio = _precio;
            this._standard = _standard;
            this._premium = _premium;
        }

        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        override
        public double CalcularPrecioFinal()
        {
            double _precioFinal = _precio;

            if (_bermuda)
            {
                _precioFinal = _precioFinal * 0.8;  
            }

            if (_premium)
            {
                _precioFinal = _precioFinal * 1.3;
            } 
 
            _precioFinal = _precioFinal * _cantidad;

            return (double)_precioFinal;
        }
    }
}
