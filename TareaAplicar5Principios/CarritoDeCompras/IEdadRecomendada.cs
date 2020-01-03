using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras
{

    //PRINCIPIO DE SEGREGACIÓN  DE INTERFACES
   /*se utiliza este prinpicio , ya que la compañía  hizo un contrato con 
    * una empresa que ofertaran sus productos,  a usuarios de mayor especialidad
    * Entonces se crea clases de los principales productos nuevos agregados, con una 
    * interfaz de producto donde se guardan sus propiedades
    * y  otra interfaz donde se solicita la edad, ya que estos productos no 
    * pueden ser para personas menores de edad
    * 
    * 
    * 
    */
    
    interface IEdadRecomendada


    {
        public int getRecommendesAge();

    }
}
