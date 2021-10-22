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
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [C].[Id],[P].[Id] AS [PacienteId],[P].[Nombre],[P].[Edad],[P].[Direccion],[P].[Telefono],[P].[Expediente],[P].[Foto],[C].[Estatus],[C].[Fecha] FROM [Cita] [C] JOIN [Paciente][P] ON [C].[PacienteId] = [P].[Id]", con);
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data.Add(new Cita
                    {
                        Id = (Guid)dr["Id"],
                        Paciente = new Paciente
                        {
                            Id = (Guid)dr["PacienteId"],
                            Nombre = (string)dr["Nombre"],
                            Edad = (int)dr["Edad"],
                            Direccion = (string)dr["Direccion"],
                            Telefono = (string)dr["Telefono"],
                            Expediente = (string)dr["Expediente"],
                            Foto = (string)dr["Foto"]
                        },
                        Estatus = (short)dr["Estatus"],
                        Fecha = (DateTime)dr["Fecha"]
                    });
                }
                return data;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
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
