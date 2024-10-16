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
    public class Controles_Matricula
    {
        public string Insertar(int SesionId, Mmatricula matricula)
        {
            string rpt = " ";
            try
            {
                string Query = matricula.Id == 0 ? "Matricula_INSERTAR" : "Matricula_Update";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (matricula.Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", matricula.Id);
                        }

                        cmd.Parameters.AddWithValue("@id_Carrera", matricula.id_Carrera);
                        cmd.Parameters.AddWithValue("@id_Estudiante", matricula.id_Estudiante);
                        cmd.Parameters.AddWithValue("@id_Turno", matricula.id_Turno);
                        cmd.Parameters.AddWithValue("@Anio", matricula.anio);
                        cmd.Parameters.AddWithValue("@Semestre", matricula.Semestre);
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


        public string Eliminar(int SesionId, Mmatricula matricula)
        {

            string rpt = " ";
            try
            {
                string Query = "Matricula_delete";
                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id",matricula.Id);
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
                string Query = "Matricula_SEARCH";

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
