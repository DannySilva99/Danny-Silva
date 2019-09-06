using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class ReportarVehiculo
    {
        public void Ver_Vehiculo(Vehiculos Carros)
        {
            Console.WriteLine("Numero de auto: {0}-" +
                " Nombre: {1}-" +
                " Marca {2}-" +
                " Tipo {3}-" +
                " Año {4}-", Carros.ID, Carros.Nombre, Carros.Marca, Carros.Tipo, Carros.Ano);
        }
        public void Enlistar_Vehiculo(Vehiculos[] c)
        {
            foreach (Vehiculos Carros in c)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" Numero de auto: {0}-" +
                " Nombre: {1}-" +
                " Marca {2}-" +
                " Tipo {3}-" +
                " Año {4}-", Carros.ID, Carros.Nombre, Carros.Marca, Carros.Tipo, Carros.Ano);
            }
        }
    }
}
