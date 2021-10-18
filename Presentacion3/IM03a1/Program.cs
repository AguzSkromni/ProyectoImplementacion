using System;
using System.Data.SqlClient;


namespace IM03a1
{
    class Program
    {
        static void Main(string[] args)
        {
            DBContext _dbContext = new DBContext();
            _dbContext.conexion();
        }
    }
}