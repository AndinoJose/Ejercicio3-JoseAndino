using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos.Entidades
{
    public class Usuarios
    {
        public String IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
      
        }

        public Usuarios(string idUsuario, string nombre, string apellido, int edad, string clave)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Clave = clave;
        }
    }
}
