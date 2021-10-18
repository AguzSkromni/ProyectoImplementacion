using System;
using System.Data.SqlClient;

public class DBContext
{
    public void conexion()
        {
            //String _connectionString = "Data Source=unitec-db.database.windows.net;Initial Catalog=im;User ID=AdminDB;Password=P@$$w0rd;";
            String _connectionString = "Data Source = SKR-PC; Initial Catalog = Test; Integrated Security = True";
            var con = new SqlConnection(_connectionString);

            try
            {
                 con.Open();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            finally
            {
                con.Close();
            }   
        }

    public void Create(){

    }

    public void Edit(){

    }

    public void Delete(){
        
    }
}