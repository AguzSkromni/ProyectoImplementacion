using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Application;

namespace Infrastructure
{
    public class PacientesDbContext
    {
        private readonly string _connectionString;
        public PacientesDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Paciente> List()
        {
            var data = new List<Paciente>();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [Id], [Nombre], [Edad], [Direccion], [Telefono], [Correo], [Expediente], [Foto] FROM [Paciente]", con);
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    data.Add(new Paciente
                    {
                        Id = (Guid)dr["Id"],
                        Nombre = (String)dr["Nombre"],
                        Edad = (int)dr["Edad"],
                        Direccion = (String)dr["Direccion"],
                        Telefono = (String)dr["Telefono"],
                        Correo = (String)dr["Correo"],
                        Foto = dr["Foto"] as string ?? FileConverterService.PlaceHolder
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

        public Paciente Details(Guid id)
        {
            var data = new Paciente();

            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [Id], [Nombre], [Edad], [Direccion], [Telefono], [Correo], [Expediente], [Foto] FROM [Paciente] WHERE [Id] = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;


            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Id = (Guid)dr["Id"];
                    data.Nombre = (String)dr["Nombre"];
                    data.Edad = (int)dr["Edad"];
                    data.Direccion = (String)dr["Direccion"];
                    data.Telefono = (String)dr["Telefono"];
                    data.Correo = (String)dr["Correo"];
                    data.Expediente = dr["Expediente"] as string ?? FileConverterService.PlaceHolder;
                    data.Foto = dr["Foto"] as string ?? FileConverterService.PlaceHolder;
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

        public void Create(Paciente data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [PACIENTE] ([ID], [NOMBRE], [EDAD], [DIRECCION], [TELEFONO], [CORREO], [EXPEDIENTE], [FOTO]) VALUES (@id, @nombre, @edad, @direccion, @telefono, @correo, @expediente, @foto)", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direccion", SqlDbType.NVarChar, 521).Value = data.Direccion;
            cmd.Parameters.Add("telefono", SqlDbType.NVarChar, 128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar, 256).Value = data.Correo;
            cmd.Parameters.Add("expediente", SqlDbType.NVarChar).Value = (object)data.Expediente ?? DBNull.Value;
            cmd.Parameters.Add("foto", SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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

        public void Edit(Paciente data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [PACIENTE] SET [NOMBRE] = @nombre, [EDAD] = @edad, [DIRECCION] = @direccion, [TELEFONO] = @telefono, [CORREO] = @correo, [EXPEDIENTE] = @expediente, [FOTO] = @foto WHERE [ID] = @id", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direccion", SqlDbType.NVarChar, 521).Value = data.Direccion;
            cmd.Parameters.Add("telefono", SqlDbType.NVarChar, 128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar, 256).Value = data.Correo;
            cmd.Parameters.Add("expediente", SqlDbType.NVarChar).Value = (object)data.Expediente ?? DBNull.Value;
            cmd.Parameters.Add("foto", SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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

        public void Delete(Guid id)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("DELETE FROM [PACIENTE] WHERE [ID] = @id",con);
            cmd.Parameters.Add("id",SqlDbType.UniqueIdentifier).Value = id;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
    }
}
