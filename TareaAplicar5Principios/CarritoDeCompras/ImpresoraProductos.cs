using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class ImpresoraProductos: StockProductos
    {

        //PRINCIPIO RESPONSABILIDAD ÚNICA

        /*Se  presenta el principio de responsablidad única  porque en la Clase StockProducto
         * es exclusivamente para crear una lista producto
         * y en esta clase se imprime los productos
         * del producto , permite que el codigo evolucione  sin que afecte 
         * su función principal.

        */


        public void ImprimirStockProductos()
        {
            CrearProductos();
            Producto producto = new Producto();
            Console.WriteLine("Stock de Productos");
            Console.WriteLine("Identificador\tDescripción\tPrecio");
            foreach (var item in this.ListaStockProductos)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}",
                item.Identificador, item.Descripcion, item.Precio);

            }

        }
    }
}
