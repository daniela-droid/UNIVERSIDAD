using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
   public class Sesiones_controles
    {
        public int CompararUsuario(MEmpleados Data)
        {
            int rpt = 0;

               
                try
                {
                    string Query = "Sesiones_Login";

                    using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                    {
                        sqlcon.Open();
                        using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                           
                            cmd.Parameters.AddWithValue("@user",Data.Login);
                            cmd.Parameters.AddWithValue("@Pass", Data.Password);
                            SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            rpt = (int)reader.GetValue(0);
                        }
                          
                        }
                        sqlcon.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    rpt = 0;
                    throw;
                }
                return rpt;
            
        }

        public int Login(int userid,DateTime fecha,string ip,string Pcname)
        {
            int rpt = 0;


            try
            {
                string Query = "Sesiones_Iniciar";

                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter SesionId = new SqlParameter();
                        SesionId.ParameterName = "@SesionId";
                        SesionId.Direction = ParameterDirection.Output;
                        SesionId.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(SesionId);
                       
                        cmd.Parameters.AddWithValue("@UserId", userid);
                        cmd.Parameters.AddWithValue("@inicio", fecha);
                         cmd.Parameters.AddWithValue("@Ip", ip);
                        cmd.Parameters.AddWithValue("@Pcname", Pcname);
                        cmd.ExecuteNonQuery();

                        rpt = (int)cmd.Parameters["@SesionId"].Value; 

                    }
                    sqlcon.Dispose();
                }

            }
            catch (Exception )
            {
                rpt = 0;
                throw;
            }
            return rpt;

        }

        public string ObtenerUsuario(int Idusuario)
        {
            string rpt = "";


            try
            {
                string Query = "select r.Nombre from empleados E join Rol R on e.Id_Rol= r.Id join Sesiones S on s.UserId=e.Id where s.Id = @idusuario";

                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlcon))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;


                        cmd.Parameters.AddWithValue("@idusuario", Idusuario);
                        rpt = cmd.ExecuteScalar().ToString();
                        

                    }
                    sqlcon.Dispose();
                }

            }
            catch (Exception ex)
            {
                rpt = ex.Message;
            }
            return rpt;

        }




    }
}
