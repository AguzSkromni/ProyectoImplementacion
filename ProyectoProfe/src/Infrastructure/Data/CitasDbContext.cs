using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class CitasDbContext
    {
        private readonly string _connectionString;
        public CitasDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Cita> List()
        {
            var data = new List<Cita>();
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

        public Cita Details(Guid id)
        {
            var data = new Cita();
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

        public void Create(Cita data)
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

        public void Edit(Cita data)
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
