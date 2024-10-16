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
using UNIVERSIDAD.Modelos;

namespace UNIVERSIDAD.Vistas
{
    public partial class Frm_turnos : Form
    {
        public Frm_turnos()
        {
            InitializeComponent();
        }

        bool Insertar()
        {
            bool rpt = false;
            try
            {
                MTurnos turno = new MTurnos()
                {
                    Id = Convert.ToInt32(txt_id_turno.Text.Trim()),
                    Nombre = txt_nombre_turno.Text.Trim(),
                    Durabilidad = Convert.ToInt32(txt_durabilidad.Text.Trim())

                };
                string r = new Control_turno().Insertar(Variables.SesionId, turno);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception)
            {
                throw;

            }
            return rpt;
        }
        private void Frm_turnos_Load(object sender, EventArgs e)
        {
            Buscar("");
            limpiarcampos();
            habilitarcampos(false);
            panel_de_edicion.Visible = false;
        }

        bool validar()
        {
            try
            {
                Error_Turno.Clear();
                if (txt_nombre_turno.Text == string.Empty)
                {
                    Error_Turno.SetError(txt_nombre_turno, "El Nombre es requerido");
                    this.ActiveControl = txt_nombre_turno;
                    return false;

                }
                if (txt_durabilidad.Text == string.Empty)
                {
                    Error_Turno.SetError(txt_durabilidad, "Es requerido este campo");
                    this.ActiveControl = txt_durabilidad;
                    return false;
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void data_turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_turno.Text = data_turnos.CurrentRow.Cells["Id"].Value.ToString();
                txt_nombre_turno.Text = data_turnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_durabilidad.Text = data_turnos.CurrentRow.Cells["Durabilidad"].Value.ToString();

            }
            catch (Exception)
            {
                throw;
            }



        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (Insertar())
                {
                    Utilidades.Mensaje(Convert.ToInt32(txt_id_turno.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                    Buscar(txt_buscar_turno.Text.Trim());
                    habilitarcampos(false);
                    limpiarcampos();
                }
                else
                {
                    Utilidades.Mensaje("Ocurrieron errores al insertar el turno");
                }
            }
        }

        private void btn_cancelar_turno_Click(object sender, EventArgs e)
        {
            panel_de_edicion.Visible = false;
        }

        private void txt_buscar_turno_TextChanged(object sender, EventArgs e)
        {
            Buscar(txt_buscar_turno.Text.Trim());
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            limpiarcampos();
            habilitarcampos(true);
            txt_id_turno.Text = "0";
            panel_de_edicion.Visible = true;
        }

        private void data_turnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar el registro del sistema?", "Eliminar", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    ELIMINAR((Int32)data_turnos.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                txt_id_turno.Text = data_turnos.CurrentRow.Cells["Id"].Value.ToString();
                txt_nombre_turno.Text = data_turnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_durabilidad.Text = data_turnos.CurrentRow.Cells["Durabilidad"].Value.ToString();
            }

        }

        void limpiarcampos()
        {
            txt_id_turno.Text = "0";
            txt_nombre_turno.Clear();
            txt_durabilidad.Clear();

        }

        void habilitarcampos(bool valor)
        {
            txt_id_turno.Enabled = false;
            txt_nombre_turno.Enabled = valor;
            txt_durabilidad.Enabled = valor;


        }


        public void Buscar(string texto)
        {

            data_turnos.DataSource = new Control_turno().Buscar(Variables.SesionId, texto);
            data_turnos.Refresh();
            Utilidades.Personalizareldatagriedvied(data_turnos);
            //if (data_turnos.Columns.Count > 0)
            //{
            //    data_turnos.Columns[2].Visible = false; // Esto oculta la primera columna
            //}
            try
            {
                if (data_turnos.Columns.Count > 0)
                {
                    data_turnos.Columns[2].Visible = false; // Esto oculta la primera columna
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panel_de_edicion_Paint(object sender, PaintEventArgs e)
        {

        }

        void ELIMINAR(Int32 id)
        {
            string rpt;
            MTurnos obj = new MTurnos()
            {
                Id = id
            };
            rpt = new Control_turno().Eliminar(Variables.SesionId, obj);
            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar(txt_buscar_turno.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }











    }


}

