using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de__Inventarios.Bean
{
    class Producto
    {
        public int id;
        public string codigo;
        public string nombre;
        public string proveedor;
        public string marca;
        public int stockminimo;
        public double ultimoprecio;
        public int stockTotal;

        public int stock;
        public double precio;
        public string codigoRequerimiento;
        public int idRequerimiento;

        public List<Requerimiento> listarequerimiento = new List<Requerimiento>();
    }
}
