using System;
namespace CarritoDeCompras
{//  APLICACION DE PRINCIPIO DE SUSTITUCIÓN DE  LISKOV
    public class ClientePremium:Cliente, ICliente
    {
        public ClientePremium () 
        {
        }

        public decimal Descuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       

        public decimal OfrecerDescuento()
        {
            throw new NotImplementedException();
        }
    }
}
