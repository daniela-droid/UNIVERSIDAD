using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Modelos;


namespace UNIVERSIDAD.Controladores
{
    public class Controles_Estudiante
    {

        public string Insertar(int SesionId, Mestudiante Estudiante)
        {
            string rpt = " ";
            try
            {
                string Query = Estudiante.id == 0 ? "Estudiantes_Insertar" : "Estudiantes_UPDATE";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (Estudiante.id > 0)
                        {
                           cmd.Parameters.AddWithValue("@id", Estudiante.id);
                        }

                        cmd.Parameters.AddWithValue("@Nombre",Estudiante.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Estudiante.Apellido);
                        cmd.Parameters.AddWithValue("@Sexo", Estudiante.Sexo);
                        cmd.Parameters.AddWithValue("@Cedula", Estudiante.Cedula);
                        cmd.Parameters.AddWithValue("@Carnet", Estudiante.Carnet);
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

        public string Eliminar(int SesionId, Mestudiante Estudiante)
        {

            string rpt = " ";
            try
            {
                string Query = "Estudiantes_Delete";
                using (SqlConnection slqcon= new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Estudiante.id);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        cmd.ExecuteNonQuery();
                        rpt = "Ok";
                    }
                    slqcon.Dispose();

                }

            }
            catch(Exception ex)
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
                string Query = "Estudiantes_Search";

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