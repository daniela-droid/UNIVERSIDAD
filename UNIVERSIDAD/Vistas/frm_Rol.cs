using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIVERSIDAD.Controladores;
using UNIVERSIDAD.Modelos;
namespace UNIVERSIDAD.Vistas
{
    public partial class frm_Rol : Form
    {
        public frm_Rol()
        {
            InitializeComponent();
        }

        void limpiarrol()
        {
            // txt_id.Clear();
            txt_nombre.Clear();
            txt_salario.Clear();

        }

        void habilitarrol(bool valor)
        {

            txt_nombre.Enabled = valor;
            txt_salario.Enabled = valor;

        }
        private void pn_edicionrol_Paint(object sender, PaintEventArgs e)
        {

        }
        void ocultarpaneledicionrol()
        {
            //pn_edicionrol.Visible = false;
        }
        //boton de cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void frm_Rol_Load(object sender, EventArgs e)
        {
            //Buscar("");
            limpiarrol();
            habilitarrol(true);


        }



        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            //Buscar(txt_buscar.Text.Trim());
        }
        void mostrrpaneledicionrol()
        {
            //pn_edicionrol.Visible = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiarrol();
            habilitarrol(true);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //nuevo
            string Rpt;
            if (txt_nombre.Text != string.Empty && txt_salario.Text != string.Empty)
            {
                Rpt = new Control_Empleados().Insertar_Rol(Variables.UsuarioId,
                    new Modelos.MRol
                    {
                        Id = 0,
                        Nombre = txt_nombre.Text.Trim(),
                        Salario = txt_salario.Text.Trim()
                    });
                if (Rpt.Equals("Ok"))
                {
                    Utilidades.Mensaje("Registro insertado correctamente");
                    form_Empleado.actualizarRor = true;
                    this.Dispose();
                }
                else
                {
                    Utilidades.Mensaje(Rpt, true);
                    txt_nombre.Clear();
                    txt_salario.Clear();
                }
            }
        }


    }


}
