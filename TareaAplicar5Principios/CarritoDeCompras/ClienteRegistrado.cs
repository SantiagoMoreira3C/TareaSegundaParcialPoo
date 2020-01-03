using System;
namespace CarritoDeCompras
{

    //  APLICACION PRINCIPIO DE SUSTITUCIÓN DE  LISKOV
    public class ClienteRegistrado:Cliente, ICliente
    {
        public ClienteRegistrado()
        {
        }

        public decimal Descuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal OfrecerDescuento()
        {
            throw new NotImplementedException();
        }
    }
}
