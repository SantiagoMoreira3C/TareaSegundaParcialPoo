using System;
namespace CarritoDeCompras
{
    //Clase se convierte en abstracta, no se pueden crear instancias de esta clase
    public class Producto 
    {
        public Producto()
        {
        }

        public int Identificador { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        
        

    }
}
