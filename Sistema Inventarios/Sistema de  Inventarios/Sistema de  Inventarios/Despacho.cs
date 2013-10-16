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
    public partial class Despacho : Form
    {
        BaseDatos DB = new BaseDatos();
        List<Producto> listaProductos;
        String codigoRequerimiento;

        public Despacho()
        {
            InitializeComponent();
            dgrid_lista.Hide();
            btn_Confirmar.Hide();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            codigoRequerimiento = tbox_requerimiento.Text.ToString().Trim();

            if (codigoRequerimiento.Length > 0)
            {
                listaProductos = DB.getRequerimiento(codigoRequerimiento);
                if (listaProductos.Count > 0)
                {
                    //mostrar la tabla y el boton
                    btn_Confirmar.Show();
                    DataTable tablaVisitante = new DataTable();

                    DataRow Renglon;
                    tablaVisitante.Columns.Add(new DataColumn("Codigo Producto"));
                    tablaVisitante.Columns.Add(new DataColumn("Nombre"));
                    tablaVisitante.Columns.Add(new DataColumn("Marca"));
                    tablaVisitante.Columns.Add(new DataColumn("Precio"));
                    tablaVisitante.Columns.Add(new DataColumn("Stock"));
                    for (int i = 0; i < listaProductos.Count(); i++)
                    {
                        Renglon = tablaVisitante.NewRow();
                        Renglon[0] = listaProductos[i].codigo;
                        Renglon[1] = listaProductos[i].nombre;
                        Renglon[2] = listaProductos[i].marca;
                        Renglon[3] = listaProductos[i].precio;
                        Renglon[4] = listaProductos[i].stock;
                        tablaVisitante.Rows.Add(Renglon);
                    }
                    dgrid_lista.DataSource = tablaVisitante;
                    dgrid_lista.Show();
                }
                else
                {
                    dgrid_lista.Hide();
                    btn_Confirmar.Hide();
                    MessageBox.Show("No se encontró el requerimiento");
                    
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor para el codigo del requerimiento");
            }


        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Confirmar y disminuir stock, luego guardar en una tabla extra
            DialogResult result = MessageBox.Show("Seguro que desea generar?", "Generar Orden Salida", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Descontar Stock
                DB.doDocumentoVenta(listaProductos);
            }
        }
    }
}
