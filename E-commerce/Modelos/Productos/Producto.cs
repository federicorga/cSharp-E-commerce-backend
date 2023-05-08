using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Modelos.Productos
{
    internal class Producto
    {
        private int _id; 
        private string _descripcion;
        private string _costo;
        private string _precioVenta;
        private string _stock;
        private int _idUsuario;

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Costo { get => _costo; set => _costo = value; }
        public string PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public string Stock { get => _stock; set => _stock = value; }
        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public Producto() { }
    }
}
