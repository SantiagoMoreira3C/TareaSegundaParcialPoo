using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    interface IFactura
    {

        public decimal Descuento { get; set; }

        public decimal CalcularDescuento();

    }
}
