using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Controladores;
using UNIVERSIDAD.Modelos;

namespace Controladores
{
    public class Control_carreras
    {

        public string Insertar(int SesionId, MCarreras carreras)
        {
            string rpt = " ";
            try
            {
                string Query = carreras.Id == 0 ? "carreras_Insertar" : "carreras_Update";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (carreras.Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", carreras.Id);
                        }
                        cmd.Parameters.AddWithValue("@Id_Facultad", carreras.Id_Facultates);
                        cmd.Parameters.AddWithValue("@Nombre", carreras.Nombre);
                        cmd.Parameters.AddWithValue("@Aranceles", carreras.Aranceles);
                        cmd.Parameters.AddWithValue("@Precio_Matricula", carreras.Precio_Matricula);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";

                    }
                    sqlcon.Dispose();

                }

            }
            catch (Exception ex)
            {
                rpt = ex.Message;
                throw;
            }
            return rpt;
        }

        public string Eliminar(int SesionId, MCarreras carreras)
        {

            string rpt = " ";
            try
            {
                string Query = "carreras_Delete";
                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", carreras.Id);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                    }
                    slqcon.Dispose();

                }

            }
            catch (Exception ex)
            {
                rpt = ex.Message;
                throw;
            }

            return rpt;

        }
        public DataTable Buscar(int SesionId, string Texto)
        {
            DataTable rpt = new DataTable();

            try
            {
                string Query = "carreras_Search";

                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TextoBuscar", Texto);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
                        sqldt.Fill(rpt);

                    }
                    slqcon.Dispose();
                }
            }
            catch (Exception ex)
            {
                rpt.Columns.Clear();
                if (ex.Message.Equals("Porfavor inicie sesion para acceder a los datos"))
                {
                    rpt.Columns.Add("Autorizacion", typeof(string));
                    DataRow row = rpt.NewRow();
                    row["Autorizacion"] = ex.Message;
                    rpt.Rows.Add(row);
                }
                else
                {
                    rpt.Columns.Add("Error", typeof(string));
                    DataRow row = rpt.NewRow();
                    row["Error"] = ex.Message;
                    rpt.Rows.Add(row);
                }
            }
            return rpt;
        }

        public DataTable Buscarpor_facultad(int SesionId, int FacultadId)
        {
            DataTable rpt = new DataTable();

            try
            {
                string Query = "carreras_Search_facultad";

                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Facultadid", FacultadId);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
                        sqldt.Fill(rpt);

                    }
                    slqcon.Dispose();
                }
            }
            catch (Exception ex)
            {
                rpt.Columns.Clear();
                if (ex.Message.Equals("Porfavor inicie sesion para acceder a los datos"))
                {
                    rpt.Columns.Add("Autorizacion", typeof(string));
                    DataRow row = rpt.NewRow();
                    row["Autorizacion"] = ex.Message;
                    rpt.Rows.Add(row);
                }
                else
                {
                    rpt.Columns.Add("Error", typeof(string));
                    DataRow row = rpt.NewRow();
                    row["Error"] = ex.Message;
                    rpt.Rows.Add(row);
                }
            }
            return rpt;
        }

        //public DataTable Buscar(string Texto)
        //{
        //    DataTable rpt = new DataTable();

        //    try
        //    {
        //        string Query = "Estudiantes_Search";

        //        using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
        //        {
        //            sqlcon.Open();
        //            using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@TextoBuscar", Texto);

        //                SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
        //                sqldt.Fill(rpt);
        //            }
        //            sqlcon.Dispose();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        rpt = null;
        //    }

        //    return rpt;
        //}



    }






}

