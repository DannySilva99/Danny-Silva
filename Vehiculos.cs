using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Vehiculos
    {
        private int id;
        private string nombre;
        private string marca;
        private string tipo;
        private int año;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int Ano
        {
            get { return año; }
            set { año = value; }
        }
    }
}
