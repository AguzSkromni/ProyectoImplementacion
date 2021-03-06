using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Application;

namespace Infrastructure
{
    public class PagosDbContext
    {
        private readonly string _connectionString;
        public PagosDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Pago> List()
        {
            var data = new List<Pago>();
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [ID], [DESCRIPCION], [TOTAL], [FECHA], [FOTO] FROM [PAGOS]", con);

            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                     data.Add(new Pago{
                        Id = (Guid)dr["Id"],
                        Descripcion = (String)dr["Descripcion"],
                        Total = (Double)dr["Total"],
                        Fecha = (DateTime)dr["Fecha"],
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

        public Pago Details(Guid id)
        {
            var data = new Pago();
            
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT [ID],[DESCRIPCION], [TOTAL], [FECHA], [FOTO] FROM [PAGOS] WHERE [ID] = @id",con);
            cmd.Parameters.Add("@id",SqlDbType.UniqueIdentifier).Value = id;
            
            try
            {
                con.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    data.Id = (Guid)dr["Id"];
                    data.Descripcion = (String)dr["Descripcion"];
                    data.Total = (double)dr["Total"];
                    data.Fecha = (DateTime)dr["Fecha"];
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

        public void Create(Pago data)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO [PAGOS] ([ID], [DESCRIPCION], [TOTAL],[Fecha],[FOTO]) VALUES (@id, @descripcion, @TOTAL,@Fecha, @foto  )", con);
            cmd.Parameters.Add("id",SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
            cmd.Parameters.Add("descripcion",SqlDbType.NVarChar,250).Value = data.Descripcion;
            cmd.Parameters.Add("total",SqlDbType.Float).Value = data.Total;
            cmd.Parameters.Add("@Fecha", SqlDbType.SmallDateTime).Value = data.Fecha;
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

        public void Edit(Pago data)
        {
             var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("UPDATE [PAGOS] SET [DESCRIPCION] = @descripcion, [TOTAL] = @total,  [Fecha] = @Fecha, [FOTO] = @foto WHERE [ID] = @id",con);

            cmd.Parameters.Add("id",SqlDbType.UniqueIdentifier).Value = data.Id;
            cmd.Parameters.Add("descripcion",SqlDbType.NVarChar,250).Value = data.Descripcion;
            cmd.Parameters.Add("total",SqlDbType.Float).Value = data.Total;
            cmd.Parameters.Add("fecha", SqlDbType.SmallDateTime).Value = data.Fecha;
            cmd.Parameters.Add("foto",SqlDbType.NVarChar).Value = (object)data.Foto ?? DBNull.Value;

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

        public void Delete(Guid id)
        {
            var con = new SqlConnection(_connectionString);
            var cmd = new SqlCommand("DELETE FROM [PAGOS] WHERE [Id] = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
            
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
