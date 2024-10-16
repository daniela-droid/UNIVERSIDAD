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
using UNIVERSIDAD.Properties;

namespace UNIVERSIDAD.Vistas
{
    public partial class Frm_Facultades : Form
    {
        public Frm_Facultades()
        {
            InitializeComponent();
        }

        public void Frm_Facultades_Load(object sender, EventArgs e)
        {
            Buscar(tex_buscar.Text);
            Limpiarcampos();
            Habilitarcampos(false);
            ocultarpanel();
        }


        public void Buscar(string Texto)
        {
            data_facultades.DataSource = new Facultades_controlador().Buscar(Variables.SesionId, Texto);
            data_facultades.Refresh();
            Utilidades.Personalizareldatagriedvied(data_facultades);

            try
            {
                if (data_facultades.Columns.Count > 0)
                {
                    data_facultades.Columns[2].Visible = false;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        bool validar()
        {
            try
            {
                Error_facultades.Clear();
                if (tex_Nombre.Text == string.Empty)
                {
                    Error_facultades.SetError(tex_Nombre, "El Nombre es requerido");
                    this.ActiveControl = tex_Nombre;
                    return false;
                }
                if (tex_descripcion.Text == string.Empty)
                {
                    Error_facultades.SetError(tex_descripcion, "La Descripcion es requerida");
                    this.ActiveControl = tex_descripcion;
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        bool Insertar()
        {

            bool rpt = false;
            try
            {
                MFacultades facultades = new MFacultades()
                {
                    Id = Convert.ToInt32(tex_id.Text.Trim()),
                    Nombre = tex_Nombre.Text.Trim(),
                    Descripcion = tex_descripcion.Text.Trim()
                };
                string r = new Facultades_controlador().Insertar(Variables.SesionId, facultades);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception)
            {
                rpt = false;

            }
            return rpt;

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            if (Insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(tex_id.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                Buscar(tex_buscar.Text.Trim());
                Habilitarcampos(false);
                Limpiarcampos();

            }
            else
            {
                Utilidades.Mensaje("Ocurrieron errores al insertar Facultad.");
            }



        }

        void Limpiarcampos()
        {
            tex_id.Text = "0";
            tex_Nombre.Clear();
            tex_descripcion.Clear();
        }

        void Habilitarcampos(bool valor)
        {
            tex_id.Enabled = false;
            tex_Nombre.Enabled = valor;
            tex_descripcion.Enabled = valor;

        }

        private void data_facultades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tex_id.Text = data_facultades.CurrentRow.Cells["Id"].Value.ToString();
                tex_Nombre.Text = data_facultades.CurrentRow.Cells["Nombre"].Value.ToString();
                tex_descripcion.Text = data_facultades.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                throw;
            }

        }

        private void tex_buscar_TextChanged(object sender, EventArgs e)
        {
            Buscar("");

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            ocultarpanel();
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            //Limpiarcampos();
            //Habilitarcampos(true);
            //mostrarpanel();
            //tex_id.Text = "0";
            if (panel_edicion.Visible == true)
            {
                panel_edicion.Visible = false;
                Limpiarcampos();
                Habilitarcampos(false);
                button_nuevo.Image = Resources.chevron_arriba;
            }
            else
            {
                panel_edicion.Visible = true;
                Limpiarcampos();
                Habilitarcampos(true);
                tex_id.Text = "0";
                this.ActiveControl = tex_Nombre;
                button_nuevo.Image = Resources.flecha_hacia_abajo;

            }

        }

        void ocultarpanel()
        {
            panel_edicion.Visible = false;

        }
        void mostrarpanel()
        {
            panel_edicion.Visible = true;
        }


        void eliminar(Int32 id)
        {
            string rpt;
            MFacultades obj = new MFacultades() { Id = id };
            rpt = new Facultades_controlador().ELIMINAR(Variables.SesionId, obj);
            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar(tex_buscar.Text);

            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_facultades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                Buscar("");
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    eliminar((Int32)data_facultades.CurrentRow.Cells["Id"].Value);

                }

            }
            if (e.ColumnIndex == 1)
            {
                tex_id.Text = data_facultades.CurrentRow.Cells["Id"].Value.ToString();
                tex_Nombre.Text = data_facultades.CurrentRow.Cells["Nombre"].Value.ToString();
                tex_descripcion.Text = data_facultades.CurrentRow.Cells["Descripcion"].Value.ToString();
                Habilitarcampos(true);
            }




        }

        private void data_facultades_SelectionChanged(object sender, EventArgs e)
        {

            cargarcarreras();

        }
        void cargarcarreras()
        {

            foreach (DataGridViewColumn col in dtcarreras.Columns)
            {

                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

            Utilidades.Personalizareldatagriedvied(dtcarreras);
            int Facultadid = (int)data_facultades.CurrentRow.Cells["Id"].Value;
            dtcarreras.DataSource = new Control_carreras().Buscarpor_facultad(Variables.SesionId, Facultadid);
            dtcarreras.Refresh();
            Utilidades.Personalizareldatagriedvied(dtcarreras);
            dtcarreras.Columns[0].Visible = false;
            dtcarreras.Columns[1].Visible = false;

        }

    }
}
