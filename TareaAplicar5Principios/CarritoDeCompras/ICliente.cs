using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CarritoDeCompras
{

    /* PRINCIPIO DE SUSTITUCIÓN DE  LISKOV
     *  Se crea una interfaz, con un método poliformico
     * para que actue de manera diferente en las clases cliente Registrado
     * Cliente Premium, para ofrecerle. 
     * Nota: Solo esta establecido el método, y no sus propiedades con el algoritmo
     *
     * 
     */
    interface ICliente
    {

        public decimal Descuento { get; set; }

        public decimal OfrecerDescuento();
    }
}
