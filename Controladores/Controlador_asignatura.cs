using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Controladores;
using UNIVERSIDAD.Modelos;

namespace Controladores
{
    public class Controlador_asignatura
    {
        public string Insertar(int SesionId, MAsignatura asignatura)
        {
            string rpt = "";
            try
            {
                string Query = asignatura.id == 0 ? "Asignaturas_Insertar" : "Asignaturas_UPDATE";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (asignatura.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", asignatura.id);
                        }
                        cmd.Parameters.AddWithValue("@Nombre", asignatura.nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", asignatura.descripcion);
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


        public string ELIMINAR(int SesionId, MAsignatura asignatura)
        {
            string rpt = "";
            try
            {
                string Query = "Asignaturas_DELETE";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", asignatura.id);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        cmd.ExecuteNonQuery();
                        rpt = "OK";

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


        public DataTable Buscar(int SesionId, string Texto)
        {

            DataTable rpt = new DataTable();

            try
            {
                string Query = "Asignaturas_SEARCH";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TextoBuscar", Texto);
                        cmd.Parameters.AddWithValue("@SesionId", SesionId);
                        SqlDataAdapter sqldt = new SqlDataAdapter(cmd);
                        sqldt.Fill(rpt);

                    }
                    sqlcon.Dispose();

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









    }
}
