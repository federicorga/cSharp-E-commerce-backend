using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Modelos.Ventas
{
    internal class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public Venta() { }

       
    }
}
