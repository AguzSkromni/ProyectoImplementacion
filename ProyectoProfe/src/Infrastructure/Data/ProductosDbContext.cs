using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Application;

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
            
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [CANTIDAD], [FOTO] FROM [PRODUCTO]", con);

            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                     data.Add(new Producto{
                        Id = (Guid)dr["Id"],
                        Nombre = (String)dr["Nombre"],
                        Descripcion = (String)dr["Descripcion"],
                        Tipo = (Int16)dr["Tipo"],
                        Precio = (Double)dr["Precio"],
                        Cantidad = (int)dr["Cantidad"],
                        Foto = dr["Foto"] as String ?? FileConverterService.PlaceHolder
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

        public Producto Details(Guid id)
        {
            var data = new Producto();
            
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [CANTIDAD], [FOTO] FROM [PRODUCTO] WHERE [ID] = @id",con);
            cmd.Parameters.Add("@id",SqlDbType.UniqueIdentifier).Value = id;

            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Id = (Guid)dr["Id"];
                    data.Nombre = (String)dr["Nombre"];
                    data.Descripcion = (String)dr["Descripcion"];
                    data.Tipo = (Int16)dr["Tipo"];
                    data.Precio = (double)dr["Precio"];
                    data.Cantidad = (int)dr["Cantidad"];
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

        public void Create(Producto data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [PRODUCTO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [CANTIDAD], [PRECIO] ,[FOTO]) VALUES (@id, @nombre, @descripcion, @tipo, @cantidad, @precio ,@foto)", con);
            cmd.Parameters.Add("id",SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("nombre",SqlDbType.NVarChar,128).Value = data.Nombre;
            cmd.Parameters.Add("descripcion",SqlDbType.NVarChar,512).Value = data.Descripcion;
            cmd.Parameters.Add("tipo",SqlDbType.SmallInt).Value = data.Tipo;
            cmd.Parameters.Add("precio",SqlDbType.Float).Value = data.Precio;
            cmd.Parameters.Add("cantidad",SqlDbType.Int).Value = data.Cantidad;
            cmd.Parameters.Add("foto",SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;
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

        public void Edit(Producto data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [PRODUCTO] SET [NOMBRE] = @nombre, [DESCRIPCION] = @descripcion, [TIPO] = @tipo, [CANTIDAD] = @cantidad, [PRECIO] = @precio ,[FOTO] = @foto WHERE [ID] = @id",con);

            cmd.Parameters.Add("id",SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("nombre",SqlDbType.NVarChar,128).Value = data.Nombre;
            cmd.Parameters.Add("descripcion",SqlDbType.NVarChar,512).Value = data.Descripcion;
            cmd.Parameters.Add("tipo",SqlDbType.SmallInt).Value = data.Tipo;
            cmd.Parameters.Add("precio",SqlDbType.Float).Value = data.Precio;
            cmd.Parameters.Add("cantidad",SqlDbType.Int).Value = data.Cantidad;
            cmd.Parameters.Add("foto",SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;

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
            var cmd = new SqlCommand("DELETE FROM [PRODUCTO] WHERE [ID] = @id",con);
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
