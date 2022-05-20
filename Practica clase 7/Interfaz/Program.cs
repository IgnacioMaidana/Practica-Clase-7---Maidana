using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;


namespace Interfaz
{
    internal class Program
    {          
        static void Main(string[] args)
        {            
            LogicaPrincipal logica = new LogicaPrincipal();
            logica.OperacionEvent += OperacionHandler;

            Console.WriteLine("LOL!");
            int flag;

            flag = int.Parse(Console.ReadLine());

            string modelo = Console.ReadLine();

            string marca = Console.ReadLine();

            int nroSerie = int.Parse(Console.ReadLine());

            string id = Console.ReadLine();

            switch (flag)
            {
                case 1: //Ingresar Compu

                    string procesador = Console.ReadLine();
                    int cantRAM = int.Parse(Console.ReadLine()); //aplicar metodo extension
                    string nombreFabricante = Console.ReadLine();

                    logica.CargarLista(modelo, marca, nroSerie, id, procesador, cantRAM, nombreFabricante);
                    break;

                case 2: //Ingresar Pantalla
                    int AñoFab = int.Parse(Console.ReadLine());
                    int Pulgadas = int.Parse(Console.ReadLine());

                    logica.CargarLista(modelo, marca, nroSerie, id, AñoFab, Pulgadas);
                    break;
            }
        }

        static void OperacionHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Operacion Concluida");
        }
    
    }
}
