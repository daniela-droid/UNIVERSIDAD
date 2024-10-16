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
using UNIVERSIDAD.Properties;

namespace UNIVERSIDAD.Vistas
{
    public partial class Form_Carrera : Form
    {
        public Form_Carrera()
        {
            InitializeComponent();

        }

        private void data_carreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id.Text = data_carreras.CurrentRow.Cells["Id"].Value.ToString();
                txt_nombre.Text = data_carreras.CurrentRow.Cells["Nombre"].Value.ToString();
                cmb_facultades.Text = data_carreras.CurrentRow.Cells["Id_Facultad"].Value.ToString();
                txt_aranceles.Text = data_carreras.CurrentRow.Cells["Aranceles"].Value.ToString();
                txt_precio_matricula.Text = data_carreras.CurrentRow.Cells["Precio_Matricula"].Value.ToString();

            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                throw;
            }
        }

        private void Form_Carrera_Load(object sender, EventArgs e)
        {
            Buscarcarrera(" ");
            limpiar();
            habilitar(false);
            pn_edicion.Visible = false;
        }
        bool Insertar()
        {
            bool rpt = false;
            try
            {
                MCarreras carreras = new MCarreras()
                {
                    Id = Convert.ToInt32(txt_id.Text),
                    Nombre = txt_nombre.Text.Trim(),
                    Id_Facultates = (int)cmb_facultades.SelectedValue,
                    Aranceles = Convert.ToInt32(txt_aranceles.Text),
                    Precio_Matricula = Convert.ToInt32(txt_precio_matricula.Text)

                };
                string r = new Control_carreras().Insertar(Variables.SesionId, carreras);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                rpt = false;
            }
            return rpt;

        }
        public void Buscarcarrera(string Texto)
        {
            data_carreras.DataSource = new Control_carreras().Buscar(Variables.SesionId, Texto);
            data_carreras.Refresh();
            Utilidades.Personalizareldatagriedvied(data_carreras);

            try
            {
                if (data_carreras.Columns.Count > 0)
                {
                    data_carreras.Columns[2].Visible = false; // Esto oculta la primera columna
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
            if (pn_edicion.Visible == true)
            {
                pn_edicion.Visible = false;
                limpiar();
                habilitar(false);
                btn_nuevo.Image = Resources.chevron_arriba;
            }
            else
            {
                pn_edicion.Visible = true;
                limpiar();
                habilitar(true);
                txt_id.Text = "0";
                this.ActiveControl = txt_nombre;
                btn_nuevo.Image = Resources.flecha_hacia_abajo;
                Cargarfacultades();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(txt_id.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscarcarrera(txt_buscar.Text.Trim());
                habilitar(false);
                limpiar();
                pn_edicion.Visible = false;
                btn_nuevo.Image = Resources.flecha_hacia_abajo;

            }
            else
            {
                Utilidades.Mensaje("Ocurrieron errores al ejecutar el proceso", false);
            }

        }
        void Cargarfacultades()
        {
            cmb_facultades.DataSource = new Facultades_controlador().Buscar(Variables.UsuarioId, "");
            cmb_facultades.Refresh();

            cmb_facultades.DisplayMember = "Nombre";
            cmb_facultades.ValueMember = "Id";
        }
        public static bool actualizarfacultades = false;
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            pn_edicion.Visible = false;
            limpiar();
            habilitar(false);
            txt_id.Text = "0";
            btn_cancelar.Image = Resources.chevron_arriba;
            btn_nuevo.Image = Resources.chevron_arriba;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            Buscarcarrera(txt_buscar.Text.Trim());
        }

        void limpiar()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            cmb_facultades.Text = " ";
            txt_aranceles.Clear();
            txt_precio_matricula.Clear();



        }
        void habilitar(bool valor)
        {
            txt_id.Enabled = false;
            txt_nombre.Enabled = valor;
            cmb_facultades.Enabled = valor;
            txt_aranceles.Enabled = valor;
            txt_precio_matricula.Enabled = valor;

        }
        public void EDITAR()
        {
            pn_edicion.Visible = true;
            limpiar();
            habilitar(true);
            txt_id.Text = "0";

            txt_id.Text = data_carreras.CurrentRow.Cells["Id"].Value.ToString();
            txt_nombre.Text = data_carreras.CurrentRow.Cells["Nombre"].Value.ToString();
            cmb_facultades.Text = data_carreras.CurrentRow.Cells["Id_Facultad"].Value.ToString();
            txt_aranceles.Text = data_carreras.CurrentRow.Cells["Aranceles"].Value.ToString();
            txt_precio_matricula.Text = data_carreras.CurrentRow.Cells["Precio_Matricula"].Value.ToString();

        }
        public void Eliminarcarrera(Int32 Id)
        {
            string rpt;


            MCarreras obj = new MCarreras()
            {
                Id = Id
            };
            rpt = new Control_carreras().Eliminar(Variables.SesionId, obj);

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscarcarrera(txt_buscar.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void data_carreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Eliminarcarrera((Int32)data_carreras.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitar(true);
                EDITAR();
                txt_id.Text = data_carreras.CurrentRow.Cells["Id"].Value.ToString();
                txt_nombre.Text = data_carreras.CurrentRow.Cells["Nombre"].Value.ToString();
                cmb_facultades.Text = data_carreras.CurrentRow.Cells["Id_Facultad"].Value.ToString();
                txt_aranceles.Text = data_carreras.CurrentRow.Cells["Aranceles"].Value.ToString();
                txt_precio_matricula.Text = data_carreras.CurrentRow.Cells["Precio_Matricula"].Value.ToString();

            }
        }
    }
}
