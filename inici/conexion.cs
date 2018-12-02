using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
    

namespace inici
{
    class conexion
    {
       string cadenaconex = " Data Source = MARLON; Initial Catalog = prueba; Integrated Security = True";

        public SqlConnection conex = new SqlConnection();

        private SqlCommandBuilder scb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter sda;
        public SqlCommand sc;

        public   conexion()
        {
            conex.ConnectionString = cadenaconex;
           

        }
        public void abrir()
        {
            try
            {
                conex.Open();
                
                MessageBox.Show("conexion correcta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error de conexion" + ex.Message);


            }
        }
        public void cerrar()
        {
            conex.Close();
        }
        public void consulta(string sql,string tabla)
        {
            ds.Tables.Clear();
            sda = new SqlDataAdapter(sql, tabla);
            scb = new SqlCommandBuilder(sda);
            sda.Fill(ds, tabla);



        }
        public int login(string name, string contra)
        {
            sc = new SqlCommand("sp_login", conex);

            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@name", name);
            sc.Parameters.AddWithValue("@contra", contra);
            int i = Convert.ToInt32(sc.ExecuteScalar());

            return i;
        }

            
       
        
    }
}
