using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UNIVERSIDAD.Modelos;

namespace UNIVERSIDAD.Controladores
{
    public class Control_Empleados
    {

        public string Insertar(Int32 SesionId, MEmpleados Empleado)
        {
            string rpt = " ";
            try
            {
                string Query = Empleado.Id == 0 ? "Empleados_Insertar" : "Empleados_Update";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        if (Empleado.Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", Empleado.Id);
                        }
                        cmd.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
                        cmd.Parameters.AddWithValue("@Sexo", Empleado.Sexo);
                        cmd.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
                        cmd.Parameters.AddWithValue("@INS", Empleado.INS);
                        cmd.Parameters.AddWithValue("@Celular", Empleado.Celular);
                        cmd.Parameters.AddWithValue("@Direccion", Empleado.Direccion);
                        cmd.Parameters.AddWithValue("@Id_Rol", Empleado.Id_Rol);
                        cmd.Parameters.AddWithValue("@Login", Empleado.Login);
                        cmd.Parameters.AddWithValue("@Password", Empleado.Password);
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



        public string Eliminar(Int32 SesionId, MEmpleados Empleado)
        {
            string rpt = "";
            try
            {

                string Query = "Empleados_Delete";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", Empleado.Id);
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


        public DataTable Buscar(Int32 SesionId,string Texto)
        {
            DataTable rpt = new DataTable();
            try
            {
                string Query = "Empleados_Search";
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


        public string Insertar_Rol(Int32 SesionId, MRol Rol)
        {
            string rpt = " ";
            try
            {
                string Query = Rol.Id <= 0 ? "Rol_Insertar" : "Rol_Update";
                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (Rol.Id > 0)
                        {
                            cmd.Parameters.AddWithValue("@id", Rol.Id);
                        }

                        cmd.Parameters.AddWithValue("@Nombre", Rol.Nombre);
                        cmd.Parameters.AddWithValue("@Salario", Rol.Salario);
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


        public DataTable buscar_Rol(Int32 SesionId, string Texto)
        {
            DataTable rpt = new DataTable();
            try
            {
                string Query = "Rol_Search";
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