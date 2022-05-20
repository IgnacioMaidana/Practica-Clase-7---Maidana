using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pantalla : Producto
    {
        //Monitores: del cual conocemos su año de fabricación, si es nuevo o usado (esto es determinado por el año de fabricación = año actual),
        //pulgadas (esta información es un número entero pero en algunos casos puede no tener valor)
        public int AnioFabricacion { get; set; }
        public bool Estado { get; set; }
        public int? Pulgadas { get; set; }

        public Pantalla(string modelo, string marca, int nroSerie, string id, int anioFabricacion, int pulgadas)
        {
            Modelo = modelo;
            Marca = marca;
            NroSerie = nroSerie;
            Id = id;
            AnioFabricacion = anioFabricacion;
            //Estado = determinado por el año;
            Pulgadas = pulgadas;
        }

        
    }
}
