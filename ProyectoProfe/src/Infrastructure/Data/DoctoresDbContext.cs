using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Application;

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
            
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [Id], [Nombre], [Edad], [Direccion], [Telefono], [Correo], [Cedula], [Foto] FROM [Doctor]", con);
            
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                     data.Add(new Doctor
                     {
                        Id = (Guid)dr["Id"],
                        Nombre = (String)dr["Nombre"],
                        Edad = (int)dr["Edad"],
                        Direccion = (String)dr["Direccion"],
                        Telefono = (String)dr["Telefono"],
                        Correo = (String)dr["Correo"],
                        Cedula = (String)dr["Cedula"],
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

        public Doctor Details(Guid id)
        {
            var data = new Doctor();
            
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [Id], [Nombre], [Edad], [Direccion], [Telefono], [Correo], [Cedula], [Foto] FROM [Doctor] WHERE [Id] = @id", con);
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
                    data.Cedula = (String)dr["Cedula"];
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

        public void Create(Doctor data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [Doctor] ([ID], [NOMBRE], [EDAD], [DIRECCION], [TELEFONO], [CORREO], [CEDULA], [FOTO]) VALUES (@id, @nombre, @edad, @direccion, @telefono, @correo, @cedula, @foto)", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direccion", SqlDbType.NVarChar, 521).Value = data.Direccion;
            cmd.Parameters.Add("telefono", SqlDbType.NVarChar, 128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar, 256).Value = data.Correo;
            cmd.Parameters.Add("cedula", SqlDbType.NVarChar, 256).Value = data.Cedula;
            cmd.Parameters.Add("foto", SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                con.Close();
            }
        }

        public void Edit(Doctor data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [DOCTOR] SET [NOMBRE] = @nombre, [EDAD] = @edad, [DIRECCION] = @direccion, [TELEFONO] = @telefono, [CORREO] = @correo, [CEDULA] = @cedula, [FOTO] = @foto WHERE [ID] = @id", con);
            cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("nombre", SqlDbType.NVarChar, 256).Value = data.Nombre;
            cmd.Parameters.Add("edad", SqlDbType.Int).Value = data.Edad;
            cmd.Parameters.Add("direccion", SqlDbType.NVarChar, 521).Value = data.Direccion;
            cmd.Parameters.Add("telefono", SqlDbType.NVarChar, 128).Value = data.Telefono;
            cmd.Parameters.Add("correo", SqlDbType.NVarChar, 256).Value = data.Correo;
            cmd.Parameters.Add("cedula", SqlDbType.NVarChar,256).Value = data.Cedula;
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
            var cmd = new SqlCommand("DELETE FROM [DOCTOR] WHERE [ID] = @id",con);
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
