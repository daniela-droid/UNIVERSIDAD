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
using UNIVERSIDAD.Properties;

namespace UNIVERSIDAD.Vistas
{
    public partial class Form_pagos : Form
    {
        public Form_pagos()
        {
            InitializeComponent();
        }
        public void buscar(string texto)
        {
            data_pagos.DataSource = new Control_pagos().Buscar(Variables.SesionId, texto);
            data_pagos.Refresh();
            Utilidades.Personalizareldatagriedvied(data_pagos);
            try
            {
                if (data_pagos.Columns.Count > 0)
                {
                    data_pagos.Columns[2].Visible = false;
                }
                foreach (DataGridViewColumn col in data_pagos.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        void eliminarpagos(Int32 Id)
        {
            string rpt;
            Mpagos pagos = new Mpagos()
            {
                id = Id
            };
            rpt = new Control_pagos().Eliminar(Variables.SesionId, pagos);
            if (rpt.Equals("OK"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar("");
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        bool insertar()
        {
            bool rpt = false;
            try
            {
                Mpagos pago = new Mpagos()
                {
                    id = Convert.ToInt32(tex_id.Text.Trim()),
                    origen = tex_origen.Text.Trim(),
                    concepto = tex_concepto.Text.Trim(),
                    monto = Convert.ToInt32(texmonto.Text.Trim()),
                    moneda = tex_Moneda.Text.Trim(),
                    tipocambio = Convert.ToDecimal(tex_cambio.Text.Trim())

                };
                string r = new Control_pagos().Insertar(Variables.SesionId, pago);
                rpt = r.Equals("OK") ? true : false;
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                rpt = true;
            }
            return rpt;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {



        }

        private void data_pagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                tex_id.Text = data_pagos.CurrentRow.Cells["id_Pagos"].Value.ToString();
                tex_origen.Text = data_pagos.CurrentRow.Cells["Origen"].Value.ToString();
                tex_concepto.Text = data_pagos.CurrentRow.Cells["Concepto"].Value.ToString();
                texmonto.Text = data_pagos.CurrentRow.Cells["Monto"].Value.ToString();
                tex_Moneda.Text = data_pagos.CurrentRow.Cells["Moneda"].Value.ToString();
                tex_cambio.Text = data_pagos.CurrentRow.Cells["Tipo_de_cambio"].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        void editar()
        {

            pane_editionar.Visible = true;
            limpiar();
            habilitarcampos(true);
            tex_id.Text = "0";
            
            tex_id.Text = data_pagos.CurrentRow.Cells["id_Pagos"].Value.ToString();
            tex_origen.Text = data_pagos.CurrentRow.Cells["Origen"].Value.ToString();
            tex_concepto.Text = data_pagos.CurrentRow.Cells["Concepto"].Value.ToString();
            texmonto.Text = data_pagos.CurrentRow.Cells["Monto"].Value.ToString();
            tex_Moneda.Text = data_pagos.CurrentRow.Cells["Moneda"].Value.ToString();
            tex_cambio.Text = data_pagos.CurrentRow.Cells["Tipo_de_cambio"].Value.ToString();
        }
        private void button_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void tx_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_pagos_Load(object sender, EventArgs e)
        {
            buscar(tex_busqueda.Text);
            pane_editionar.Visible = false;
        }
        void limpiar()
        {
            tex_id.Text = "0";
            tex_concepto.Clear();
            tex_fecha.Clear();
            tex_Moneda.Clear();
            texmonto.Clear();
            tex_origen.Clear();
            tex_cambio.Clear();
        }
        void habilitarcampos(bool valor)
        {
            tex_id.Enabled = false;
            tex_concepto.Enabled = valor;
            tex_fecha.Enabled = false;
            tex_Moneda.Enabled = valor;
            tex_origen.Enabled = valor;
            tex_cambio.Enabled = valor;

        }
        private void button_new_Click(object sender, EventArgs e)
        {
            if (pane_editionar.Visible == true)
            {
                pane_editionar.Visible = false;
                limpiar();
                habilitarcampos(false);
                button_new.Image = Resources.chevron_arriba;
            }
            else
            {
                pane_editionar.Visible = true;
                limpiar();
                habilitarcampos(true);
                button_new.Image = Resources.flecha_hacia_abajo;
            }

        }

        private void button_saved_Click(object sender, EventArgs e)
        {
            if (insertar())
            {
                Utilidades.Mensaje(Convert.ToInt32(tex_id.Text) == 0 ? "Registro insertado correctamente." : "Registro actualizado correctamente.");
                buscar(tex_busqueda.Text);
                habilitarcampos(false);
                limpiar();
            }
            else
            {
                Utilidades.Mensaje("Ha ocurrido un error al insertar");
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            pane_editionar.Visible = false;
        }

        private void data_pagos_Click(object sender, EventArgs e)
        {

        }

        private void data_pagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar el regsitro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    eliminarpagos((Int32)data_pagos.CurrentRow.Cells["id_Pagos"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                editar();
                tex_id.Text = data_pagos.CurrentRow.Cells["id_Pagos"].Value.ToString();
                tex_origen.Text = data_pagos.CurrentRow.Cells["Origen"].Value.ToString();
                tex_concepto.Text = data_pagos.CurrentRow.Cells["Concepto"].Value.ToString();
                texmonto.Text = data_pagos.CurrentRow.Cells["Monto"].Value.ToString();
                tex_Moneda.Text = data_pagos.CurrentRow.Cells["Moneda"].Value.ToString();
                tex_cambio.Text = data_pagos.CurrentRow.Cells["Tipo_de_cambio"].Value.ToString();
                
            }
        }

        private void tex_busqueda_TextChanged(object sender, EventArgs e)
        {
            buscar("");
        }
    }
}
