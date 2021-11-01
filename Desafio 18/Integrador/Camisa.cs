using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Camisa : Ropa
    {
        private bool _mangaCorta;

        public Camisa(int _cantidad, double _precio )
            : base(_cantidad, _precio)
        {          
            this._cantidad = _cantidad;
            this._precio = _precio;
        }

        public Camisa (bool _mangaCorta, int _cantidad, double _precio, bool _standard, bool _premium)
            :base(_cantidad, _precio,_standard, _premium)
        {
            this._mangaCorta = _mangaCorta;
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

            if(_mangaCorta == true)
            {
                _precioFinal = _precioFinal * 0.9;
            } 

            if (_premium == true)
            {
                _precioFinal = _precioFinal * 1.3;
            }

            _precioFinal = _precioFinal * _cantidad;

            return (double)_precioFinal;
        }

    }
}
