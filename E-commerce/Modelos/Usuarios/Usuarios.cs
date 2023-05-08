using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Modelos.Usuarios
{
    internal class Usuarios
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private int _contraseña;
        private string _email;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public int Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Email { get => _email; set => _email = value; }

        public Usuarios() { }

       
    }
}
