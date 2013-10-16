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
    public partial class Login : Form
    {
        TextBox user;
        TextBox password;
        Usuario usuarioBean;
        BaseDatos DB = new BaseDatos();
        AgregarProducto agregar;
        DataTable Tabla;
        public static Boolean isOpen = false;

        public Login()
        {
            InitializeComponent();
            user = txt_user;
            password = txt_password;
           
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuarioBean = new Usuario();
            usuarioBean.user = user.Text;
            usuarioBean.password = password.Text;
            int typePerson = verificarAxeso(usuarioBean);
            if (typePerson == 1)
            {
                //Personal Almacen almacen
                MessageBox.Show("Almacen");
            }
            else if (typePerson == 2)
            {
                //Administrador User: Master master
                MessageBox.Show("Administrador");
                mostrarpanel_Master();
            }
            else
            {
                MessageBox.Show("Usuario y password no coinciden");
            }
        }

        private int verificarAxeso(Usuario usuario)
        {
            int valor = 0;
            if (usuario.user.Equals("") && usuario.password.Equals(""))
            {
                MessageBox.Show("Debe ingresar usuario y password");
            }else
            {
                valor =existeBaseDatos(usuario);
            }
            return valor;
        }

        private int existeBaseDatos(Usuario usuario)
        {
            int valor = 0;
            List<Usuario> lista = DB.getAllList();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].user.Equals(usuario.user) &&
                        lista[i].password.Equals(usuario.password))
                    {
                        valor = lista[i].type;
                        break;
                        
                    }
                }
                
            }
            return valor;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            user.Clear();
            password.Clear();

        }

        /***************** Panel del VISITANTE **************************/

        private void btn_Visitante_Click(object sender, EventArgs e)
        {
            //  dataGridView.DataSource = DB.getTAble();
            this.Text = "Bienvenido al sistema";
            ocultarBotones();
            panelVisitante.Show();

          //  DataTable Tabla = ObtenerTablaProductos();
          
          //  dataGridView.DataSource = Tabla; 
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String codigoProducto = txt_codigoProducto.Text.ToString();
            String codigoRequerimiento = txt_codigoRequerimiento.Text.ToString();

            if (codigoProducto.Length == 0 && codigoRequerimiento.Length == 0)
            {
                MessageBox.Show("Debe ingresar por lo menos un campo");
            }
            else
            {
                List<Producto> lista = DB.getProductoRequerimiento(codigoProducto, codigoRequerimiento);
                DataTable tablaVisitante = new DataTable();

                DataRow Renglon;
                tablaVisitante.Columns.Add(new DataColumn("Codigo Requerimiento"));
                tablaVisitante.Columns.Add(new DataColumn("Codigo Producto"));
                tablaVisitante.Columns.Add(new DataColumn("Nombre"));
                tablaVisitante.Columns.Add(new DataColumn("Marca"));
                tablaVisitante.Columns.Add(new DataColumn("Precio"));
                tablaVisitante.Columns.Add(new DataColumn("Stock"));
                for (int i = 0; i < lista.Count(); i++)
                {
                    Renglon = tablaVisitante.NewRow();
                    Renglon[0] = lista[i].codigoRequerimiento;
                    Renglon[1] = lista[i].codigo;
                    Renglon[2] = lista[i].nombre;
                    Renglon[3] = lista[i].marca;
                    Renglon[4] = lista[i].precio;
                    Renglon[5] = lista[i].stock;
                    tablaVisitante.Rows.Add(Renglon);
                }
                dataGridView.DataSource = tablaVisitante;
            }
           
        }


        private void ocultarBotones() {
             
            txt_password.Hide();
            txt_user.Hide();
            label1.Hide();
            label2.Hide();
            btn_cancelar.Hide();
            btn_Visitante.Hide();
            btnIngresar.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            user.Clear();
            password.Clear();
            panelVisitante.Hide();
            mostrarBotones();
            this.Text = "Ingreso al sistema";
        }
       
        private void mostrarBotones()
        {
            txt_password.Show();
            txt_user.Show();
            label1.Show();
            label2.Show();
            btn_cancelar.Show();
            btn_Visitante.Show();
            btnIngresar.Show();
        }

        /************************ Panel del MASTER ************************/

        private void mostrarpanel_Master () {
            this.Text = "Bienvenido al sistema Usuario MAster";
           // Tabla = ObtenerTablaProductos();
            ocultarBotones();
            panelVisitante.Show();
            panel_Master.Show();
            //dataGridProductos.DataSource = Tabla;

        }

        private void btn_cerrarSessionMaster_Click(object sender, EventArgs e)
        {
            user.Clear();
            password.Clear();
            panelVisitante.Hide();
            panel_Master.Hide();
            mostrarBotones();
            this.Text = "Ingreso al sistema";
        }

        private void btn_despacho_Click(object sender, EventArgs e)
        {
            Despacho despacho = new Despacho();
            despacho.ShowDialog(this);
        }

     /*   private void btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            agregar = new AgregarProducto();
            agregar.ShowDialog(this);
            
        }

        private void btn_Mostrar_ProductosSinStock_Click(object sender, EventArgs e)
        {

        }

        private void btn_salida_Productos_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingreso_Productos_Click(object sender, EventArgs e)
        {

        }
        */

       /* private void dataGridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0  && e.ColumnIndex == 0)
            {
                object value = dataGridProductos.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value; //obtiene el nombre del producto

                ModificarProducto modificar = new ModificarProducto((string)value);
                modificar.ShowDialog(this);
            }           
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Tabla = ObtenerTablaProductos();
            dataGridProductos.DataSource = Tabla;
        }*/

        /***************************** PANEL ALMACEN      ************************************/

        /*****************************  FUNCIONES GENERAL **************************************/

        private DataTable ObtenerTablaProductos()
        {
            DataTable tabla = new DataTable();
            List<Producto> lista = DB.getListProducts();
            DataRow Renglon;
            tabla.Columns.Add(new DataColumn("Codigo"));
            tabla.Columns.Add(new DataColumn("Nombre"));
            tabla.Columns.Add(new DataColumn("Descripcion"));
            tabla.Columns.Add(new DataColumn("Stock"));
            for (int i = 0; i < lista.Count(); i++)
            {
                Renglon = tabla.NewRow();
                Renglon[0] = lista[i].codigo;
                Renglon[1] = lista[i].nombre;
                tabla.Rows.Add(Renglon);
            }
            return tabla;
        }

        private void panel_Master_Paint(object sender, PaintEventArgs e)
        {
            if (isOpen)
            {
                //Tabla = ObtenerTablaProductos();
                //dataGridProductos.DataSource = Tabla;
                isOpen = false;
            }
          
        }

       

        

      

       
        
    }
}
