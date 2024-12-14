using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda
{
    public class Usuario
    {
        private string nombre;
        private string contraseña;
        private bool administrador;

        public Usuario() { }
        public Usuario(string Nombre, string Contraseña, bool Administrador) 
        {
            nombre = Nombre;
            contraseña = Contraseña;
            administrador = Administrador;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
    }
}
