using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class ProductosDbContext
    {
        private readonly string _connectionString;
        public ProductosDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Producto> List()
        {
            var data = new List<Producto>();
            // ToDo
            try
            {
                // ToDo
                return data;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // ToDo
            }
        }

        public Producto Details(Guid id)
        {
            var data = new Producto();
            // ToDo
            try
            {
                // ToDo
                return data;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // ToDo
            }
        }

        public void Create(Producto data)
        {
            // ToDo
            try
            {
                // ToDo
            }
            catch (Exception) { throw; }
            finally
            {
                // ToDo
            }
        }

        public void Edit(Producto data)
        {
            // ToDo
            try
            {
                // ToDo
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // ToDo
            }
        }

        public void Delete(Guid id)
        {
            // ToDo
            try
            {
                // ToDo
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // ToDo
            }
        }
    }
}
