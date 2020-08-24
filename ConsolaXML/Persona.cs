using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaXML
{
    class Persona
    {
        public Persona()
        {
        }

        public Persona(string nombre, string apellidos, string telefono, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Edad = edad;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellidos + " " + Edad + " " + Telefono;
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
    }
}
