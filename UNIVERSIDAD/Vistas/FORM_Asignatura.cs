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
    public partial class FORM_Asignatura : Form
    {
        public FORM_Asignatura()
        {
            InitializeComponent();
        }


        public void Buscar(string Texto)
        {
            data_asignatura.DataSource = new Controlador_asignatura().Buscar(Variables.SesionId, Texto);
            data_asignatura.Refresh();
            Utilidades.Personalizareldatagriedvied(data_asignatura);
            try
            {
                if (data_asignatura.Columns.Count > 0)
                {
                    data_asignatura.Columns[2].Visible = false; // Esto oculta la primera columna
                }



            }
            catch (Exception)
            {

                throw;
            }

        }
        private void FORM_Asignatura_Load(object sender, EventArgs e)
        {
            Buscar(" ");
            limpiarCampos();
            habilitarcampos(false);
            pan_edicion.Visible = false;

        }
        void limpiarCampos()
        {

            //  txtid.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();

        }
        void habilitarcampos(bool valor)
        {
            txtid.Enabled = false;
            txtnombre.Enabled = valor;
            txtdescripcion.Enabled = valor;
        }
        private void btn_guardado_Click(object sender, EventArgs e)
        {

            if (Insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(txtid.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscar(txt_buscar.Text.Trim());
                habilitarcampos(false);
                limpiarCampos();

            }
            else
            {
                Utilidades.Mensaje("Ocurrieron errores al insertar .");
            }

        }
        bool Insertar()
        {
            bool rpt = false;

            try
            {
                MAsignatura asignatura = new MAsignatura()
                {
                    id = Convert.ToInt32(txtid.Text.Trim()),
                    nombre = txtnombre.Text.Trim(),
                    descripcion = txtdescripcion.Text.Trim()
                };
                string r = new Controlador_asignatura().Insertar(Variables.SesionId, asignatura);
                rpt = r.Equals("Ok") ? true : false;

                Utilidades.Mensaje(r, true);
            }
            catch (Exception e)
            {
                string er = e.Message;
                rpt = false;
            }

            return rpt;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txtid.Text = "0";
            pan_edicion.Visible = true;
            habilitarcampos(true);
            limpiarCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pan_edicion.Visible = false;
        }

        private void data_asignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = data_asignatura.CurrentRow.Cells["id"].Value.ToString();
                txtnombre.Text = data_asignatura.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdescripcion.Text = data_asignatura.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }
        void Eliminarasignatura(Int32 Id)
        {
            string rpt;
            MAsignatura obj = new MAsignatura()
            {
                id = Id
            };
            rpt = new Controlador_asignatura().ELIMINAR(Variables.SesionId, obj);

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar(txt_buscar.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void data_asignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Eliminarasignatura((Int32)data_asignatura.CurrentRow.Cells["id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                txtid.Text = data_asignatura.CurrentRow.Cells["id"].Value.ToString();
                txtnombre.Text = data_asignatura.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdescripcion.Text = data_asignatura.CurrentRow.Cells["Descripcion"].Value.ToString();


            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txt_buscar.Text.Trim());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
