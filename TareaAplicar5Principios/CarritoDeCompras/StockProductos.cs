using System;
using System.Collections.Generic;

namespace CarritoDeCompras
{
    public class StockProductos
    {
        public StockProductos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

       public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
               
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" +letra + numero + i;                
                producto.Precio = numero;
                this.ListaStockProductos.Add(producto);
           }
       }

  
      
        

       

    }
}
