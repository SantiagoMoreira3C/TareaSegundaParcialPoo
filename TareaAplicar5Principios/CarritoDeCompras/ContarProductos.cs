using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{
    class ContarProductos  
     {

        public ContarProductos()
        {

        }

        //PRINCIPIO OPEN/CLOSED

        /*Se  presenta el principio de OPEN/CLOSED  
         * para crear una nueva función 
         * y en esta clase permite contar
         * el total de productos que se lleva el usuario

        */
        public void ContarTotalProductos()
        {
            StockProductos contador = new StockProductos();
            contador.ListaStockProductos.Count();

        }

    }
}
