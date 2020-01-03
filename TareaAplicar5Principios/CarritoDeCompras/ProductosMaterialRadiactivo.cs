using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{

    //PRINCIPIO DE SEGREGACIÓN  DE INTERFACES

    class ProductosMaterialRadiactivo : IProducto
    {
        public int Identificador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Descripcion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TipoDeProducto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime getReleaseData()
        {
            throw new NotImplementedException();
        }
    }
}
