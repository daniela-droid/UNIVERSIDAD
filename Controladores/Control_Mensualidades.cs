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
 public  class Control_Mensualidades
    {
        public string Insertar(int SesionId,Mmensualidades mensualidad)
        {
            string rpt = " ";
            try
            {
                string Query = mensualidad.id == 0 ? "Mensualidades_INSERTAR" : "Mensualidades_UPDATE";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (mensualidad.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", mensualidad.id);
                        }

                        cmd.Parameters.AddWithValue("@Estudiantes_id", mensualidad.idEstudiante);
                        cmd.Parameters.AddWithValue("@Empleado_id", mensualidad.idEmpleado);
                        //cmd.Parameters.AddWithValue("@Fecha", mensualidad.fecha);
                        cmd.Parameters.AddWithValue("@Tipo_pago", mensualidad.tipoPago);
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

        public string Eliminar(int SesionId, Mmensualidades mensualidad)
        {

            string rpt = " ";
            try
            {
                string Query = "Mensualidades_DELETE";
                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", mensualidad.id);
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
                string Query = "Mensualidades_SEARCH";

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



    }
}
