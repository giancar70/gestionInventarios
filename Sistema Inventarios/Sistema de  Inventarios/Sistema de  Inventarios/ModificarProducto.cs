using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sistema_de__Inventarios.Bean;

namespace Sistema_de__Inventarios
{
    public partial class ModificarProducto : Form
    {

        Producto producto;
        BaseDatos db;

        public ModificarProducto(String codigo)
        {
            db = new BaseDatos();
            InitializeComponent();
            producto = db.getProducto(codigo);
            txt_codigo.Text = producto.codigo;
            txt_nombre.Text = producto.nombre;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            db = new BaseDatos();

            //Producto producto = new Producto();
            if (isCorrect())
            {
                producto.nombre = txt_nombre.Text;
           

                int estado = db.saveModifyProduct(producto);
                if (estado == 1)
                {
                    Login.isOpen = true;
                    this.Close();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean isCorrect()
        {
            return true;
        }


    }
}
