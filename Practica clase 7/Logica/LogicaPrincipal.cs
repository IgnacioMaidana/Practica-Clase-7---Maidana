using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class LogicaPrincipal
    {
        public void CargarLista(Pantalla monitor)
        {
            //Monitor monitor = new Monitor();
            Listas.ListaPantallas.Add(monitor);
        }

        public void CargarLista(Computadora compu) // <- hacer constructores
        {
            //Computadora Compu = new Computadora();
            Listas.ListaCompus.Add(compu);
        }

        public void Eliminar(string id)
        {
            List<Producto> Deposito = new List<Producto>(); 
            if (Deposito.Exists(x => x.Id == id)) //revisar destructor ?
            {
                if (Deposito.Find(x => x.Id == id).GetType().ToString() == "Pantalla")
                    Listas.ListaPantallas.RemoveAll(x => x.Id == id);
                else
                    Listas.ListaCompus.RemoveAll(x => x.Id == id);

            }
        }

        public string ObtenerDescripcion(Computadora compu)
        {
            //Computadoras: “PC {modelo} - {marca} - {cpu} {ram} RAM - {fabricante}”.               
            return $"PC {compu.Modelo} - {compu.Marca} - {compu.Procesador} {compu.CantRAM} RAM - {compu.NombreFabricante}";
        }
        public string ObtenerDescripcion(Pantalla pantalla)
        {
            //Monitores: “MONITOR {marca} - {modelo} {pulgadas}‘’ ”. En el caso que no tenga definido un valor para pulgadas no debería mostrar nada
            return $"PANTALLA {pantalla.Marca} - {pantalla.Modelo} {pantalla.Pulgadas}";
        }

        public List<Producto> ObtenerListaDeposito()
        {
            List<Producto> Deposito = new List<Producto>();
            Deposito.AddRange(Listas.ListaCompus);
            Deposito.AddRange(Listas.ListaPantallas);
            return Deposito;
        }
    }
}
