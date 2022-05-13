using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        //Cada elemento de computación cuenta con: modelo, marca, número de serie,
        //identificador (este valor no puede cargarse, ya que es el resultado de unir modelo-marca-número serie).” 

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int NroSerie { get; set; }
        public string Id { get; set; }

    }
}
