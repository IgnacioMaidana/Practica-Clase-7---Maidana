using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Args;

namespace Logica
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;

        private Singleton()
        {            
        }

        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Singleton();

                return instancia;
            }
        }
    }

    public class LogicaPrincipal
    {
        public EventHandler<EventoArgs> OperacionEvent;
        //1)
        public virtual void CargarLista(string modelo, string marca, int nroSerie, string id, string procesador, string nombreFabricante) 
        {
            //Pido la ram usando la extension
            
            Computadora compu = new Computadora(modelo, marca, nroSerie, id, procesador,cantRAM, nombreFabricante);            
            Listas.ListaCompus.Add(compu);
            this.OperacionEvent(this, new EventoArgs(/*poner cosas*/));
        }

        public virtual void CargarLista(string modelo, string marca, int nroSerie, string id, int anioFabricacion, int pulgadas) 
        {
            Pantalla monitor = new Pantalla(modelo, marca, nroSerie, id, anioFabricacion, pulgadas);
            Listas.ListaPantallas.Add(monitor);
            this.OperacionEvent(this, new EventoArgs(/*poner cosas*/));
        }

        //2)
        public void Eliminar(string id)
        {
            List<Producto> Deposito = new List<Producto>(); 
            if (Deposito.Exists(x => x.Id == id)) 
            {
                if (Deposito.Find(x => x.Id == id).GetType().ToString() == "Pantalla")
                    Listas.ListaPantallas.RemoveAll(x => x.Id == id);
                else
                    Listas.ListaCompus.RemoveAll(x => x.Id == id);

                this.OperacionEvent(this, new EventoArgs(/*poner cosas*/));
            }
        }

        //3)
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

        //4)
        public List<Producto> ObtenerListaDeposito()
        {
            List<Producto> Deposito = new List<Producto>();
            Deposito.AddRange(Listas.ListaCompus);
            Deposito.AddRange(Listas.ListaPantallas);
            return Deposito;
        }
    }

    public static class Extensiones
    {
        public static Enumeradores.TamañoRam DefinirRAM(this int tamaño) //revisar
        {
            switch (tamaño)
            {
                case 2:
                    return Enumeradores.TamañoRam.dosGB;
                case 4:
                    return Enumeradores.TamañoRam.cuatroGB;
                case 8:
                    return Enumeradores.TamañoRam.ochoGB;
                case 16:
                    return Enumeradores.TamañoRam.dieciseisGB;
                default:
                    return Enumeradores.TamañoRam.dosGB; //revisar
            }
        }
    }

    

    
}
