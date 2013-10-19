using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace Sistema_de__Inventarios.Bean
{
    class BaseDatos
    {
        private string StrConexion;
        private OleDbConnection Conexion;
        private OleDbDataAdapter Adapter;
        private DataSet miDataSet = new DataSet();

        public void IniciarConexion()
        {
            String DataBase = "./baseDatos.accdb";
            //Creo la cadena de conexion para Office 2007
            StrConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + DataBase;
            //Objeto conexion
            Conexion = new OleDbConnection(StrConexion);
        }

        /************************* USUARIO **********************************/
        public List<Usuario> getAllList()
        {
            List<Usuario> list = new List<Usuario>();
            //String name, apellido, user, pass;
            Usuario user;
            try
            {
                //OleDbConnection MyConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; User ID=;Password=; Data Source=DataBase.mdb;Persist Security Info=False");
                IniciarConexion();
                Adapter = new OleDbDataAdapter("Select * from Usuario", Conexion);
                DataSet MyDataSet = new DataSet();
                Conexion.Open();
                Adapter.Fill(MyDataSet);

                if (MyDataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < MyDataSet.Tables[0].Rows.Count; i++)
                    {
                        DataRow campo = MyDataSet.Tables[0].Rows[i];
                        user = new Usuario();
                        user.name = campo["Nombre"].ToString();
                        user.apellido = campo["Apellido"].ToString();
                        user.user = campo["user"].ToString();
                        user.password = campo["password"].ToString();
                        user.type = (int)campo["tipo"];
                        list.Add(user);
                    }
                }
                Conexion.Close();
            }
            catch { list = new List<Usuario>(); }
            return list;
        }

        /************************* PRODUCTOS **********************************/
        public List<Producto> getListProducts()
        {
            List<Producto> list = new List<Producto>();
            Producto producto;
            try
            {
                //OleDbConnection MyConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; User ID=;Password=; Data Source=DataBase.mdb;Persist Security Info=False");
                IniciarConexion();
                Adapter = new OleDbDataAdapter("Select * from Producto", Conexion);
                DataSet MyDataSet = new DataSet();
                Conexion.Open();
                Adapter.Fill(MyDataSet);

                if (MyDataSet.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < MyDataSet.Tables[0].Rows.Count; i++)
                    {
                        DataRow campo = MyDataSet.Tables[0].Rows[i];
                        producto = new Producto();
                        producto.codigo = campo["codigo"].ToString();
                        producto.nombre = campo["nombre"].ToString();
                   

                        list.Add(producto);
                    }
                }
                Conexion.Close();
            }
            catch { list = new List<Producto>(); }
            return list;
        }

        public DataTable getTAble()
        {
            IniciarConexion();
            Adapter = new OleDbDataAdapter("Select * from Producto", Conexion);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            return dt;
        }

        public int saveProducto(Producto producto)
        {
            int estado = 0;
            try
            {
                IniciarConexion();
                Conexion.Open();
                string sql;
                sql = "INSERT INTO Producto(nombre,descripcion,precio,cantidad,stock)";
                sql += "VALUES('" + producto.nombre + "'" + ",'" + producto.nombre + "','" + producto.nombre + "'";
                sql += ",'" + producto.nombre + "','" + producto.nombre + "')";
                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                estado = cmd.ExecuteNonQuery();

            }
            catch { }
            finally
            {
                Conexion.Close();
            }
            return estado;
        }

        public Producto getProducto(string codigo)
        {
            Producto prod = new Producto();
            IniciarConexion();
            Conexion.Open();
            string sql;

            sql = "SELECT * FROM Producto WHERE codigo='" + codigo + "'";
            OleDbCommand cmd = new OleDbCommand(sql, Conexion);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prod.codigo = (reader["codigo"].ToString());
                prod.nombre = (reader["nombre"].ToString());
                prod.nombre = (reader["descripcion"].ToString());
           

            }
            reader.Close();
            Conexion.Close();
            return prod;
        }

        public int saveModifyProduct(Producto producto)
        {
            int estado = 0;
            try
            {
                IniciarConexion();
                Conexion.Open();
                string sql;
                sql = "UPDATE Producto SET nombre='" + producto.nombre + "',";
                sql += " descripcion='" + producto.nombre + "',precio='" + producto.nombre + "',";
                sql += "stock='" + producto.nombre + "'";
                sql += " WHERE codigo='" + producto.codigo + "'";

                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                estado = cmd.ExecuteNonQuery();

            }
            catch { }
            Conexion.Close();
            return estado;
        }


        /************************* PRODUCTO Y/O REQUERIMIENTO ***********************/

        public List<Producto> getProductoRequerimiento(String idProducto, String idRequerimiento)
        {
            String sql = "";
           // int type =0;
            sql = "select a.nombre, a.Id, a.ultimoprecio, b.Codigo, c.precio, c.stock, " +  
                "a.codigo, a.proveedor, a.marca from " +
                "Producto a, Requerimiento b, RequerimientoxProducto c where " +
                "a.Id = c.idProducto and b.Id =c.idRequerimiento and ";
            if (idProducto.Length > 0 && idRequerimiento.Length == 0)
            {
              //  type = 1;
                sql = sql + " a.codigo = '"+idProducto+"'";
            }
            else if (idProducto.Length == 0 && idRequerimiento.Length > 0)
            {
                //type = 2;
                sql = sql + " b.Codigo = '" + idRequerimiento + "'";
            }
            else if (idProducto.Length > 0 && idRequerimiento.Length > 0)
            {
                sql = sql + " b.Codigo = '" + idRequerimiento + "'" +
                      " and a.codigo = '" + idProducto + "'";
                //type = 3;
            }
            OleDbDataReader reader = null;
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                IniciarConexion();
                Conexion.Open();               

                Producto prod = new Producto();
                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prod = new Producto();
                    prod.nombre = (reader[0].ToString());
                    prod.id = (Int32)(reader[1]);
                    prod.ultimoprecio = Convert.ToDouble(reader[2]);
                    prod.codigoRequerimiento = (reader[3].ToString()); 
                    prod.precio = Convert.ToDouble(reader[4]);
                    prod.stock = (Int32)(reader[5]);
                    prod.codigo = (reader[6].ToString());
                    prod.proveedor = (reader[7].ToString());
                    prod.marca = (reader[8].ToString());

                    listaProductos.Add(prod);
                }
            }catch (Exception e){
                
            }
            finally
            {
                reader.Close();
                Conexion.Close();
            }

            return listaProductos;
        }

        /******************************** PARA DESPACHO *****************************/
        public List<Producto> getRequerimiento(String codigoRequerimiento)
        {
            List<Producto> listaProductos = new List<Producto>();
            String sql = "";

            sql = "select a.nombre, a.Id, a.ultimoprecio, b.Codigo, c.precio, c.stock, " +
                  "a.codigo, a.proveedor, a.marca, a.stockactual, b.Id from " +
                  "Producto a, Requerimiento b, RequerimientoxProducto c where " +
                  "a.Id = c.idProducto and b.Id = c.idRequerimiento and " +
                  " b.Codigo = '" + codigoRequerimiento + "'";
           
            OleDbDataReader reader = null;
            try
            {
                IniciarConexion();
                Conexion.Open();

                Producto prod = new Producto();
                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prod = new Producto();
                    prod.nombre = (reader[0].ToString());
                    prod.id = (Int32)(reader[1]);
                    prod.ultimoprecio = Convert.ToDouble(reader[2]);
                    prod.codigoRequerimiento = (reader[3].ToString());
                    prod.precio = Convert.ToDouble(reader[4]);
                    prod.stock = (Int32)(reader[5]);
                    prod.codigo = (reader[6].ToString());
                    prod.proveedor = (reader[7].ToString());
                    prod.marca = (reader[8].ToString());
                    prod.stockTotal = (Int32)(reader[9]);
                    prod.idRequerimiento = (Int32)(reader[10]);
                    listaProductos.Add(prod);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                reader.Close();
                Conexion.Close();
            }


            return listaProductos;
        }

        public Boolean doDocumentoVenta(List<Producto> listaProductos)
        {
            Boolean isOk = true;
            List<Producto> listaProductoError = new List<Producto>();
            List<int> listStock = new List<int>();
            try
            {
                IniciarConexion();
                Conexion.Open();
                Producto producto = new Producto();
                String sql = "";
                int stock = 0;
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    producto = listaProductos[i];
                    stock = getStockActual(producto.id) - producto.stock;
                    if (stock > 0)
                    {
                        listStock.Add(stock);
                    }
                    else
                    {
                        isOk = false;
                    }
                }
                if (isOk)
                {
                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        producto = listaProductos[i];
                        stock = listStock[i];
                        listStock.Add(stock);
                        sql = "UPDATE Producto SET stockactual=" + stock + "";
                        sql += " WHERE codigo='" + producto.codigo + "'";
                        OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                        cmd.ExecuteNonQuery();
                    }
                    insertDataSalida(producto.idRequerimiento, producto.codigoRequerimiento);
                }
            }
            catch (Exception e)
            {
                isOk = false;
            }
            finally
            {
                Conexion.Close();
            }
            return isOk;
        }

        private int getStockActual(int idProducto)
        {
            String sql = "";
            int stockActual = 0,stockminimo = 0;
            sql = "select a.stockactual, a.stockminimo from Producto a where " +
                      "a.Id = " + idProducto;

            OleDbDataReader reader = null;
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, Conexion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   stockActual = (Int32)(reader[0]);
                   stockminimo = (Int32)(reader[1]);
                }
                if (!(stockActual > 2 * stockminimo))
                {
                    stockActual = -1;
                }
            }
            catch (Exception e)
            {
                stockActual = -1;
            }
            return stockActual;
        }

        private void insertDataSalida(int idRequerimiento, String codigoRequerimiento)
        {
            String sql = "";
            sql = "INSERT INTO SalidaProductos(fecha,idRequerimiento,codigoRequerimiento) " +
                  "VALUES ('" + DateTime.Now +"',"+idRequerimiento +",'" + codigoRequerimiento +"')";
            OleDbCommand cmd = new OleDbCommand(sql, Conexion);
            int stado = cmd.ExecuteNonQuery();
        }
    }

}
