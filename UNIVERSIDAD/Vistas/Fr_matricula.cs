using Controladores;
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
    public partial class Fr_matricula : Form
    {
        public Fr_matricula()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fr_matricula_Load(object sender, EventArgs e)
        {
            Buscarmatricula(" ");
            limpiar();
            habilitar(false);
            panel_edicion.Visible = false;
        }
        bool Insertar()
        {
            bool rpt = false;

            try
            {
                Mmatricula matricula = new Mmatricula()
                {
                    Id = Convert.ToInt32(txt_id.Text.Trim()),
                    id_Carrera = (int)cmb_carrera.SelectedValue,
                    id_Estudiante = (int)cmb_estudents.SelectedValue,
                    id_Turno = (int)cmb_turno.SelectedValue,
                    anio = Convert.ToInt32(txt_id.Text.Trim()),
                    Semestre = txt_semestre.Text.Trim()

                };
                string r = new Controles_Matricula().Insertar(Variables.SesionId, matricula);
                rpt = r.Equals("OK") ? true : false;
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                rpt = false;
            }
            return rpt;
        }
        public void Buscarmatricula(string Texto)
        {
            data_matricula.DataSource = new Controles_Matricula().Buscar(Variables.SesionId, Texto);
            data_matricula.Refresh();
            Utilidades.Personalizareldatagriedvied(data_matricula);

            try
            {
                if (data_matricula.Columns.Count > 0)
                {
                    data_matricula.Columns[2].Visible = false; // Esto oculta la primera columna
                }
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                throw;
            }
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (panel_edicion.Visible == true)
            {
                txt_id.Text = "0";
                panel_edicion.Visible = false;
                limpiar();
                habilitar(false);
                //btn_nuevo.Image = Resources.chevron_arriba;


            }
            else
            {
                panel_edicion.Visible = true;
                limpiar();
                habilitar(true);
                txt_id.Text = "0";

                // btn_nuevo.Image = Resources.flecha_hacia_abajo;
                Cargarestudiante();
                Cargarcarrera();
                Cargarturno();
            }


        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

            Buscarmatricula(txt_buscar.Text.Trim());

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (Insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(txt_id.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscarmatricula(txt_buscar.Text.Trim());
                habilitar(false);
                limpiar();


            }
            else
            {
                Utilidades.Mensaje("Ocurrieron errores al insertar Estudiante.");
            }

        }
        void limpiar()
        {
            txt_id.Clear();
            cmb_carrera.Text = " ";
            cmb_estudents.Text = " ";
            cmb_turno.Text = " ";
            txt_año.Text = " ";
            txt_semestre.Text = " ";



        }
        void habilitar(bool valor)
        {
            txt_id.Enabled = false;
            cmb_carrera.Enabled = valor;
            cmb_estudents.Enabled = valor;
            cmb_turno.Enabled = valor;
            txt_año.Enabled = valor;
            txt_semestre.Enabled = valor;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_edicion.Visible = false;



        }
        void Cargarestudiante()
        {
            cmb_estudents.DataSource = new Controles_Estudiante().Buscar(Variables.UsuarioId, " ");
            cmb_estudents.Refresh();

            cmb_estudents.DisplayMember = "Nombre";
            cmb_estudents.ValueMember = "Id";
        }
        public static bool actualizestudiante = false;

        void Cargarcarrera()
        {
            cmb_carrera.DataSource = new Control_carreras().Buscar(Variables.UsuarioId, "");
            cmb_carrera.Refresh();

            cmb_carrera.DisplayMember = "Nombre";
            cmb_carrera.ValueMember = "Id";
        }
        public static bool actualizCarrera = false;

        void Cargarturno()
        {
            try
            {
                cmb_turno.DataSource = new Control_turno().Buscar(Variables.UsuarioId, "");
                cmb_turno.Refresh();

                //cmb_turno.DisplayMember = "Nombre";
                //cmb_turno.ValueMember = "Id";

                cmb_turno.ValueMember = "Id";
                cmb_turno.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
            }


        }
        public static bool actualizarturno = false;
        //eliminar
        void Eliminarmatricula(Int32 Id)
        {
            string rpt;

            Mmatricula obj = new Mmatricula()
            {
                Id = Id
            };
            rpt = new Controles_Matricula().Eliminar(Variables.SesionId, obj);

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscarmatricula(txt_buscar.Text.Trim());
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void data_matricula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = data_matricula.CurrentRow.Cells["Id"].Value.ToString();
                cmb_carrera.Text = data_matricula.CurrentRow.Cells["id_Carrera"].Value.ToString();
                cmb_estudents.Text = data_matricula.CurrentRow.Cells["id_Estudiante"].Value.ToString();
                cmb_turno.Text = data_matricula.CurrentRow.Cells["id_Turno"].Value.ToString();
                txt_año.Text = data_matricula.CurrentRow.Cells["Anio"].Value.ToString();
                txt_semestre.Text = data_matricula.CurrentRow.Cells["Semestre"].Value.ToString();


            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void data_matricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Eliminarmatricula((Int32)data_matricula.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitar(true);
                txt_id.Text = data_matricula.CurrentRow.Cells["Id"].Value.ToString();
                cmb_carrera.Text = data_matricula.CurrentRow.Cells["id_Carrera"].Value.ToString();
                cmb_estudents.Text = data_matricula.CurrentRow.Cells["id_Estudiante"].Value.ToString();
                cmb_turno.Text = data_matricula.CurrentRow.Cells["id_Turno"].Value.ToString();
                txt_año.Text = data_matricula.CurrentRow.Cells["Anio"].Value.ToString();
                txt_semestre.Text = data_matricula.CurrentRow.Cells["Semestre"].Value.ToString();

            }



        }
    }
}
