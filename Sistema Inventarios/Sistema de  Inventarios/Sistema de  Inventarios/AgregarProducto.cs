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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            if(isCorrect()){
                producto.nombre = tbx_nombre.Text;

                BaseDatos baseDatos = new BaseDatos();
                int estado = baseDatos.saveProducto(producto);
                if (estado == 1)
                {
                    Login.isOpen = true;
                    this.Close();
                }
            }

        }

        private Boolean isCorrect()
        {
            return true;
        }



    }
}
