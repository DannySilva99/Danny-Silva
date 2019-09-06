using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculos CarroNum1 = new Vehiculos();
            CarroNum1.ID = 664;
            CarroNum1.Marca = "Ford";
            CarroNum1.Nombre = "Mustang";
            CarroNum1.Tipo = "Deportivo";
            CarroNum1.Ano = 1968;

            Vehiculos CarroNum2 = new Vehiculos();
            CarroNum2.ID = 663;
            CarroNum2.Marca = "Chevrolet";
            CarroNum2.Nombre = "Camaro";
            CarroNum2.Tipo = "Deportivo";
            CarroNum2.Ano = 2019;

            Vehiculos CarroNum3 = new Vehiculos();
            CarroNum3.ID = 662;
            CarroNum3.Marca = "Honda";
            CarroNum3.Nombre = "Civic";
            CarroNum3.Tipo = "Sedan";
            CarroNum3.Ano = 2010;

            Vehiculos CarroNum4 = new Vehiculos();
            CarroNum4.ID = 661;
            CarroNum4.Marca = "Volkswagen";
            CarroNum4.Nombre = "Jetta";
            CarroNum4.Tipo = "Deportivo";
            CarroNum4.Ano = 2018;

            Vehiculos CarroNum5 = new Vehiculos();
            CarroNum5.ID = 660;
            CarroNum5.Marca = "Dodge";
            CarroNum5.Nombre = "Challenger";
            CarroNum5.Tipo = "Deportivo";
            CarroNum5.Ano = 1970;

            Vehiculos[] c = { CarroNum1, CarroNum2, CarroNum3, CarroNum4, CarroNum5 };

            ReportarVehiculo RV = new ReportarVehiculo();

            RV.Ver_Vehiculo(CarroNum1);
            RV.Enlistar_Vehiculo(c);

            Console.ReadKey();
        }
    }
}
