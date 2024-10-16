using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
namespace UNIVERSIDAD.Vistas
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }




        void Mostrar()
        {

        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            int userid = Comparar_datos();
            string ip = Utilidades.GetIp();
            string Pcname = Utilidades.GetComputerName();
            DateTime fecha = DateTime.Now;

            if (userid > 0)
            {
                int rpt = new Sesiones_controles().Login(userid, fecha, ip, Pcname);
                if (rpt > 0)
                {
                    Frm_MAIN frm = new Frm_MAIN();
                    Variables.UsuarioId = userid;
                    Variables.SesionId = rpt;
                    Variables.ComputerIp = ip;
                    Variables.ComputerName = Pcname;
                    Variables.fechaInicio = fecha;
                    mostrarusuario(rpt);
                    frm.Show();
                    this.Hide();
                    
                }
                else
                {
                    Utilidades.Mensaje("Ocurrieron errores al iniciar la sesion");
                }
            }
            else
            {
                Utilidades.Mensaje("Usuario o contraseña Incorrecta.");
            }

        }

        int Comparar_datos()
        {
            return new Sesiones_controles().CompararUsuario(
                new Modelos.MEmpleados
                {
                    Login = tex_nombre.Text.Trim(),
                    Password = tex_id.Text.Trim()
                });

        }
        void mostrarusuario(int idsesion)
        {
            Variables.Rol= new Sesiones_controles().ObtenerUsuario(idsesion);

        }
        private void Form_login_Load(object sender, EventArgs e)
        {

        }
    }
}
