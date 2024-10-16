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
using UNIVERSIDAD.Properties;

namespace UNIVERSIDAD.Vistas
{
    public partial class Form_mensualidades : Form
    {
        public Form_mensualidades()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void buscarmensualidad(string Texto)
        {

            data_mensualidad.DataSource = new Control_Mensualidades().Buscar(Variables.SesionId, Texto);
            data_mensualidad.Refresh();
            Utilidades.Personalizareldatagriedvied(data_mensualidad);
            try
            {
                if (data_mensualidad.Columns.Count > 0)
                {
                    data_mensualidad.Columns[2].Visible = false;
                }
                foreach (DataGridViewColumn col in data_mensualidad.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                throw;
            }



        }
        bool insertar()
        {
            bool rpt = false;
            try
            {
                Mmensualidades mensualidad = new Mmensualidades()
                {
                    id = Convert.ToInt32(txt_id.Text.Trim()),
                    idEmpleado = (int)cmb_empleado.SelectedValue,
                    idEstudiante = (int)cmb_estudents.SelectedValue,
                    tipoPago = txt_pago.Text.Trim()
                };
                string r = new Control_Mensualidades().Insertar(Variables.SesionId, mensualidad);
                rpt = r.Equals("Ok") ? true : false;

            }
            catch (Exception ex)
            {

                Utilidades.Mensaje(ex.Message);
                rpt = false;

            }

            return rpt;
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (panel_edit.Visible == true)
            {
                panel_edit.Visible = false;
                limpiar();
                habilitarcampos(false);
                btn_nuevo.Image = Resources.chevron_arriba;
            }
            else
            {
                panel_edit.Visible = true;
                limpiar();
                habilitarcampos(true);
                txt_id.Text = "0";
                txt_id.Enabled = false;
                // this.ActiveControl = txtnombre;
                btn_nuevo.Image = Resources.flecha_hacia_abajo;
                Cargarestudiante();
                Cargarempleado();
            }

        }
        void habilitarcampos(bool valor)
        {
            txt_id.Enabled = false;
            cmb_estudents.Text = " ";
            cmb_empleado.Text = " ";
            txt_fecha.Enabled = false;
            txt_pago.Enabled = valor;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(txt_id.Text) == 0 ? "Registro insertado correctamente." : "Registro actualizado correctamente.");
                
                buscarmensualidad(txt_buscar.Text.Trim());
                limpiar();
            }
            else
            {
                Utilidades.Mensaje("Error al insertar registro");
            }

        }
        void limpiar()
        {
            txt_id.Text = "0";
            cmb_estudents.Text = " ";
            cmb_estudents.Text = " ";
            txt_fecha.Clear();
            txt_pago.Clear();
        }

        private void data_mensualidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = data_mensualidad.CurrentRow.Cells["id"].Value.ToString();
                cmb_estudents.Text = data_mensualidad.CurrentRow.Cells["Estudiantes_id"].Value.ToString();
                cmb_empleado.Text = data_mensualidad.CurrentRow.Cells["Empleado_id"].Value.ToString();
                txt_fecha.Text = data_mensualidad.CurrentRow.Cells["Fecha"].Value.ToString();
                txt_pago.Text = data_mensualidad.CurrentRow.Cells["Tipo_pago"].Value.ToString();


            }
            catch (Exception)
            {
                throw;
            }



        }
        void Cargarestudiante()
        {
            cmb_estudents.DataSource = new Controles_Estudiante().Buscar(Variables.UsuarioId, "");
            cmb_estudents.Refresh();

            cmb_estudents.DisplayMember = "Nombre";
            cmb_estudents.ValueMember = "Id";
        }
        public static bool actualizrestudiante = false;
        void Cargarempleado()
        {
            cmb_empleado.DataSource = new Control_Empleados().Buscar(Variables.UsuarioId, "");
            cmb_empleado.Refresh();

            cmb_empleado.DisplayMember = "Nombre";
            cmb_empleado.ValueMember = "Id";
        }
        public static bool actualizrempleado = false;

        void eliminar(Int32 Id)
        {
            string rpt;
            Mmensualidades mens = new Mmensualidades() { id = Id };

            rpt = new Control_Mensualidades().Eliminar(Variables.SesionId, mens);
            if (rpt.Equals("OK"))
            {
                Utilidades.Mensaje("Registro eliminado con exito");
                buscarmensualidad(txt_buscar.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            buscarmensualidad(txt_buscar.Text.Trim());
        }

        private void Form_mensualidades_Load(object sender, EventArgs e)
        {
            panel_edit.Visible = false;
            buscarmensualidad(txt_buscar.Text.Trim());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void data_mensualidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Deseas eliminar el reggistro del sistema?", "Eliminar", MessageBoxButtons.YesNo,

                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    eliminar((Int32)data_mensualidad.CurrentRow.Cells["id"].Value);
                }

                if (e.ColumnIndex == 1)
                {
                    habilitarcampos(true);
                    txt_id.Text = data_mensualidad.CurrentRow.Cells["id"].Value.ToString();
                    cmb_estudents.Text = data_mensualidad.CurrentRow.Cells["Estudiantes_id"].Value.ToString();
                    cmb_empleado.Text = data_mensualidad.CurrentRow.Cells["Empleado_id"].Value.ToString();
                    txt_fecha.Text = data_mensualidad.CurrentRow.Cells["Fecha"].Value.ToString();
                    txt_pago.Text = data_mensualidad.CurrentRow.Cells["Tipo_pago"].Value.ToString();


                }
            }




        }
    }
}







