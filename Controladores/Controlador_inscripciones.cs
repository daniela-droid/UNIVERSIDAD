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
    public class Controlador_inscripciones
    {

        public string Insertar(Int32 SesionId, Minscripciones inscripciones)
        {
            string rpt = " ";
            try
            {
                string Query = inscripciones.id == 0 ? "Inscripciones_Insertar" : "Inscripciones_UPDATE";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (inscripciones.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", inscripciones.id);
                        }
                        cmd.Parameters.AddWithValue("@Estudiantes_id", inscripciones.id_Estudiante);
                        cmd.Parameters.AddWithValue("@Empleados_id", inscripciones.Empleado_id);
                        cmd.Parameters.AddWithValue("@Matricula_id", inscripciones.Matricula_id);
                        cmd.Parameters.AddWithValue("@Asignaturas_id", inscripciones.Asignatura_id);
                        cmd.Parameters.AddWithValue("@Cuatrimestre", inscripciones.cuatrimestre);
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

        public string Eliminar(Int32 SesionId, Minscripciones inscripciones)
        {
            string rpt = "";
            try
            {

                string Query = "Inscripciones_Delete";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", inscripciones.id);
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


        public DataTable Buscar(Int32 SesionId, string Texto)
        {
            DataTable rpt = new DataTable();
            try
            {
                string Query = "Inscripciones_SEARCH";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TextoBuscar",Texto);
                        cmd.Parameters.AddWithValue("@SesionId",SesionId);

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
