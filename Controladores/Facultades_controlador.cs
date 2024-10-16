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
    public class Facultades_controlador
    {
        public string Insertar(int SesionId,MFacultades facultades)
        {
            string rpt = "";
            try
            {
                string Query = facultades.Id == 0 ? "Facultades_Insertar" : "Facultades_Update";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (facultades.Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", facultades.Id);
                        }
                        cmd.Parameters.AddWithValue("@Nombre", facultades.Nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", facultades.Descripcion);
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



        public string ELIMINAR(int SesionId,MFacultades facultades)
        {
            string rpt = "";
            try
            {
                string Query = "Facultades_Delete";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", facultades.Id);
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


        public DataTable Buscar(int SesionId,string Texto)
        {

            DataTable rpt = new DataTable();

            try
            {
                string Query = "Facultades_Search";
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
