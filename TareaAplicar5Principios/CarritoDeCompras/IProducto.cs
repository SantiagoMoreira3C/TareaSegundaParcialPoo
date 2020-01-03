using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{

    //PRINCIPIO DE SEGREGACIÓN  DE INTERFACES
    interface IProducto
    {

        public int Identificador { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }


        DateTime getReleaseData();

    }
}
