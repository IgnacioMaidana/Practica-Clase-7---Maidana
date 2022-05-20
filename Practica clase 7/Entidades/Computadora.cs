using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora : Producto
    {
        //Computadoras: del cual conocemos la descripción del procesador,
        //la cantidad de memoria RAM (que es un valor entre los siguientes; 2GB, 4GB, 8GB, 16GB) y el nombre del fabricante.
        public string Procesador { get; set; }
        public Enumeradores.TamañoRam CantRAM { get; set; }
        public string NombreFabricante { get; set; }

        public Computadora(string modelo, string marca, int nroSerie, string id, string procesador,int cantRAM string nombreFabricante)
        {
            Modelo = modelo;
            Marca = marca;
            NroSerie = nroSerie;
            Id = id;
            Procesador = procesador;
            CantRAM = DefinirRAM(cantRAM);
            NombreFabricante = nombreFabricante;
        }

        
    }
}
