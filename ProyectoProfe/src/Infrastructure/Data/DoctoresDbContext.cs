using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure
{
    public class DoctoresDbContext
    {
        private readonly string _connectionString;
        public DoctoresDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Doctor> List()
        {
            var data = new List<Doctor>();
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

        public Doctor Details(Guid id)
        {
            var data = new Doctor();
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

        public void Create(Doctor data)
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

        public void Edit(Doctor data)
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
