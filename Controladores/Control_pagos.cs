using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Controladores;

namespace Controladores
{
    public class Control_pagos
    {

        public string Insertar(int SesionId, Mpagos pagos)
        {
            string rpt = "";
            try
            {
                string Query = pagos.id == 0 ? "Pagos_Insertar" : "Pagos_Update";
               
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (pagos.id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id_Pagos", pagos.id);
                        }

                        cmd.Parameters.AddWithValue("@Origen", pagos.origen);
                        cmd.Parameters.AddWithValue("@Concepto", pagos.concepto);
                        cmd.Parameters.AddWithValue("@Monto", pagos.monto);
                        //cmd.Parameters.AddWithValue("@Fecha", pagos.Fecha);
                        cmd.Parameters.AddWithValue("@Moneda", pagos.moneda);
                        cmd.Parameters.AddWithValue("@Tipo_de_cambio", pagos.tipocambio);
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


        public string Eliminar(int SesionId, Mpagos pagos)
        {

            string rpt = " ";
            try
            {
                string Query = "Pagos_DELETE";
                using (SqlConnection slqcon = new SqlConnection(Conexion.Cn))
                {
                    slqcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, slqcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_Pagos", pagos.id);
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
                string Query = "Pagos_SEARCH";

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
