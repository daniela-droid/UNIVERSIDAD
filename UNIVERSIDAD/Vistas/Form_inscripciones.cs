using Controladores;
using Modelos;
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

namespace UNIVERSIDAD.Vistas
{
    public partial class Form_inscripciones : Form
    {
        public Form_inscripciones()
        {
            InitializeComponent();
        }

        private void Form_inscripciones_Load(object sender, EventArgs e)
        {
            Buscarinscricion("");
            limpiar();
            habilitar(false);
            panel_edicion.Visible = false;
        }

        public void Buscarinscricion(string Texto)
        {
            try
            {
                data_inscripciones.DataSource = new Controlador_inscripciones().Buscar(Variables.SesionId, Texto);
                data_inscripciones.Refresh();
                Utilidades.Personalizareldatagriedvied(data_inscripciones);
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                throw;
            }
            try
            {
                if (data_inscripciones.Columns.Count > 0)
                {
                    data_inscripciones.Columns[2].Visible = false; // Esto oculta la primera columna
                }
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                throw;
            }
        }
        bool Insertar()
        {

            bool rpt = false;
            try
            {
                Minscripciones inscripciones = new Minscripciones()
                {
                    id = Convert.ToInt32(txt_id.Text.Trim()),
                    id_Estudiante = (int)cmb_estudiante.SelectedValue,
                    Empleado_id = (int)cmb_empleado.SelectedValue,
                    Matricula_id = (int)cmb_matricula.SelectedValue,
                    Asignatura_id = (int)cmb_asignatura.SelectedValue,
                    cuatrimestre = cMBCUATRIMESTRE.Text.Trim()

                    // Nombre = tex_Nombre.Text.Trim()

                };
                string r = new Controlador_inscripciones().Insertar(Variables.SesionId, inscripciones);
                rpt = r.Equals("OK") ? true : false;
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                rpt = false;
            }
            return rpt;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (Insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(txt_id.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscarinscricion(txt_buscar_inscripcion.Text.Trim());
                habilitar(false);
                limpiar();

            }
            else
            {
                Utilidades.Mensaje("Ocurrieron errores al insertar Estudiante.");
            }

        }

        private void data_inscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = data_inscripciones.CurrentRow.Cells["Id"].Value.ToString();
                cmb_estudiante.Text = data_inscripciones.CurrentRow.Cells["Estudiantes_id"].Value.ToString();
                cmb_empleado.Text = data_inscripciones.CurrentRow.Cells["Empleados_id"].Value.ToString();
                cmb_matricula.Text = data_inscripciones.CurrentRow.Cells["Matricula_id"].Value.ToString();
                cmb_asignatura.Text = data_inscripciones.CurrentRow.Cells["Asignaturas_id"].Value.ToString();
                cMBCUATRIMESTRE.Text = data_inscripciones.CurrentRow.Cells["Cuatrimestre"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void txt_buscar_inscripcion_TextChanged(object sender, EventArgs e)
        {
            Buscarinscricion(txt_buscar_inscripcion.Text.Trim());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_edicion.Visible = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (panel_edicion.Visible == true)
            {
                txt_id.Text = "0";
                cMBCUATRIMESTRE.Text = "Primer Cuatrimestre";
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
                cMBCUATRIMESTRE.Text = "Primer Cuatrimestre";
                Cargarestudiante();
                Cargarempleado();
                Cargarmatricula();
                Cargarsignatura();
                // btn_nuevo.Image = Resources.flecha_hacia_abajo;

            }
        }

        void limpiar()
        {
            txt_id.Clear();
            cmb_estudiante.Text = " ";
            cmb_empleado.Text = " ";
            cmb_matricula.Text = " ";
            cmb_asignatura.Text = " ";
            txt_id.Text = "Primer Cuatrimestre";



        }
        void habilitar(bool valor)
        {
            txt_id.Enabled = false;
            cmb_estudiante.Enabled = valor;
            cmb_empleado.Enabled = valor;
            cmb_matricula.Enabled = valor;
            cmb_asignatura.Enabled = valor;
            cMBCUATRIMESTRE.Enabled = valor;

        }
        // Control_carreras los combobox
        void Cargarestudiante()
        {
            cmb_estudiante.DataSource = new Controles_Estudiante().Buscar(Variables.UsuarioId, "");
            cmb_estudiante.Refresh();

            cmb_estudiante.DisplayMember = "Nombre";
            cmb_estudiante.ValueMember = "Id";
        }
        public static bool actualizestudiante = false;

        void Cargarempleado()
        {
            cmb_empleado.DataSource = new Control_Empleados().Buscar(Variables.UsuarioId, "");
            cmb_empleado.Refresh();

            cmb_empleado.DisplayMember = "Nombre";
            cmb_empleado.ValueMember = "Id";
        }
        public static bool actualizarempleado = false;

        void Cargarmatricula()
        {
            cmb_matricula.DataSource = new Controles_Matricula().Buscar(Variables.UsuarioId, "");
            cmb_matricula.Refresh();

            cmb_matricula.DisplayMember = "Estudiante";
            cmb_matricula.ValueMember = "Id";
        }
        public static bool actualizarmatricula = false;

        void Cargarsignatura()
        {
            cmb_asignatura.DataSource = new Controlador_asignatura().Buscar(Variables.UsuarioId, "");
            cmb_asignatura.Refresh();

            cmb_asignatura.DisplayMember = "Nombre";
            cmb_asignatura.ValueMember = "Id";
        }
        public static bool actualizrasignatura = false;


        void Eliminarinscripcion(Int32 Id)
        {
            string rpt;


            Minscripciones obj = new Minscripciones()
            {
                id = Id
            };
            rpt = new Controlador_inscripciones().Eliminar(Variables.SesionId, obj);

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscarinscricion(txt_buscar_inscripcion.Text.Trim());
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_inscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Eliminarinscripcion((Int32)data_inscripciones.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitar(true);
                txt_id.Text = data_inscripciones.CurrentRow.Cells["Id"].Value.ToString();
                cmb_estudiante.Text = data_inscripciones.CurrentRow.Cells["Estudiantes_id"].Value.ToString();
                cmb_empleado.Text = data_inscripciones.CurrentRow.Cells["Empleados_id"].Value.ToString();
                cmb_matricula.Text = data_inscripciones.CurrentRow.Cells["Matricula_id"].Value.ToString();
                cmb_asignatura.Text = data_inscripciones.CurrentRow.Cells["Asignaturas_id"].Value.ToString();
                cMBCUATRIMESTRE.Text = data_inscripciones.CurrentRow.Cells["Cuatrimestre"].Value.ToString();

            }



        }
    }
}
