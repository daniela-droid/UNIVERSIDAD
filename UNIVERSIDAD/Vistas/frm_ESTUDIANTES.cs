using Azure.Core;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UNIVERSIDAD.Vistas
{
    public partial class frm_ESTUDIANTES : Form
    {
        public frm_ESTUDIANTES()
        {
            InitializeComponent();
        }

        //Formulario
        public void ESTUDIANTES_Load(object sender, EventArgs e)
        {
            Buscar(" ");
            limpiarCampos();
            habilitarcampos(false);

        }



        public void Buscar(string Texto)
        {
            data_listado.DataSource = new Controles_Estudiante().Buscar(Variables.SesionId, Texto);
            data_listado.Refresh();
            Utilidades.Personalizareldatagriedvied(data_listado);
            try
            {
                if (data_listado.Columns.Count > 0)
                {
                    data_listado.Columns[2].Visible = false; // Esto oculta la primera columna
                }
                foreach (DataGridViewColumn col in data_listado.Columns)
                {

                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }


                //foreach (DataGridViewRow Row in data_listado.Rows)
                //{
                //    //Row.DividerHeight = 1;
                //    //Row.Height = 100;
                //}

                // dataGridView1.Columns["ClO

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
                Error_validar.Clear();
                if (txtnombre.Text == string.Empty)
                {
                    Error_validar.SetError(txtnombre, "El Nombre es requerido");
                    this.ActiveControl = txtnombre;
                    return false;
                }
                if (txtapellido.Text == string.Empty)
                {
                    Error_validar.SetError(txtapellido, "El Apellido es requerido");
                    this.ActiveControl = txtapellido;
                    return false;
                }
                if (txtcedula.Text == string.Empty)
                {
                    Error_validar.SetError(txtcedula, "La Cedula es requerido");
                    this.ActiveControl = txtcedula;
                    return false;
                }
                if (txtcarnet.Text == string.Empty)
                {
                    Error_validar.SetError(txtcarnet, "El Carnet es requerido");
                    this.ActiveControl = txtcarnet;
                    return false;
                }
                if (cmbsexo.Text == string.Empty)
                {
                    Error_validar.SetError(cmbsexo, "El Sexo es requerido");
                    this.ActiveControl = cmbsexo;
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
                Mestudiante estudiante = new Mestudiante()
                {
                    id = Convert.ToInt32(txtid.Text.Trim()),
                    Nombre = txtnombre.Text.Trim(),
                    Apellido = txtapellido.Text.Trim(),
                    Sexo = cmbsexo.Text.Trim(),
                    Cedula = txtcedula.Text.Trim().ToUpper(),
                    Carnet = txtcarnet.Text.Trim()

                };
                string r = new Controles_Estudiante().Insertar(Variables.SesionId, estudiante);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception)
            {
                rpt = false;
            }

            return rpt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtbuscar.Text.Trim());
        }

        private void data_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = data_listado.CurrentRow.Cells["id"].Value.ToString();
                txtnombre.Text = data_listado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = data_listado.CurrentRow.Cells["Apellido"].Value.ToString();
                cmbsexo.Text = data_listado.CurrentRow.Cells["Sexo"].Value.ToString();
                txtcedula.Text = data_listado.CurrentRow.Cells["Cedula"].Value.ToString();
                txtcarnet.Text = data_listado.CurrentRow.Cells["Carnet"].Value.ToString();



            }
            catch (Exception)
            {
                throw;
            }


        }

        void limpiarCampos()
        {

            //  txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            cmbsexo.Text = "M";
            txtcedula.Clear();
            txtcarnet.Clear();

        }
        //boton guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (Insertar())
                {
                    Utilidades.Mensaje(Convert.ToInt32(txtid.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                    Buscar(txtbuscar.Text.Trim());
                    habilitarcampos(false);
                    limpiarCampos();


                }
                else
                {
                    Utilidades.Mensaje("Ocurrieron errores al insertar Estudiante.");
                }
            }
        }
        void habilitarcampos(bool valor)
        {
            txtid.Enabled = false;
            txtnombre.Enabled = valor;
            txtapellido.Enabled = valor;
            cmbsexo.Enabled = valor;
            txtcedula.Enabled = valor;
            txtcarnet.Enabled = valor;
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //limpiarCampos();
            //habilitarcampos(true);
            //txtid.Text = "0";
            //mostrarpaneledicion();
            if (pn_edition.Visible == true)
            {
                pn_edition.Visible = false;
                limpiarCampos();
                habilitarcampos(false);
                btn_nuevo.Image = Resources.chevron_arriba;
            }
            else
            {
                pn_edition.Visible = true;
                limpiarCampos();
                habilitarcampos(true);
                txtid.Text = "0";
                this.ActiveControl = txtnombre;
                btn_nuevo.Image = Resources.flecha_hacia_abajo;

            }

        }


        void Eliminar(Int32 Id)
        {
            string rpt;


            Mestudiante obj = new Mestudiante()
            {
                id = Id
            };
            rpt = new Controles_Estudiante().Eliminar(Variables.SesionId, obj);

            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Buscar(txtbuscar.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_listado_Click(object sender, EventArgs e)
        {

        }

        private void data_listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    Eliminar((Int32)data_listado.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                habilitarcampos(true);
                txtid.Text = data_listado.CurrentRow.Cells["Id"].Value.ToString();
                txtnombre.Text = data_listado.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = data_listado.CurrentRow.Cells["Apellido"].Value.ToString();
                cmbsexo.Text = data_listado.CurrentRow.Cells["Sexo"].Value.ToString();
                txtcedula.Text = data_listado.CurrentRow.Cells["Cedula"].Value.ToString();
                txtcarnet.Text = data_listado.CurrentRow.Cells["Carnet"].Value.ToString();

            }


        }
        void mostrarpaneledicion()
        {
            pn_edition.Visible = true;

        }
        void ocultarpaneledicion()
        {
            pn_edition.Visible = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            ocultarpaneledicion();
        }

        void abrirpdf()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("DataGridView.pdf", FileMode.Create));

            doc.Open();

            Paragraph parrafo = new Paragraph();
            parrafo.Add(new Chunk(Environment.NewLine));
            DataTable data = (DataTable)data_listado.DataSource;

            foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    parrafo.Add(item.ToString() + " ");
                }
                parrafo.Add(new Chunk(Environment.NewLine));
            }
            doc.Add(parrafo);
            doc.Close();
        }
        private void btnpdf_Click(object sender, EventArgs e)
        {
            abrirpdf();
            MessageBox.Show("El PDF ha sido creado y guardado con exito!!");

        }

        private void txtcedula_KeyUp(object sender, KeyEventArgs e)
        {
            //this.txtcedula.Text = txtcedula.Text.ToString().ToUpper();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}