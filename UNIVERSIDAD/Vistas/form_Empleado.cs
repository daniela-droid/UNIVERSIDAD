using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using UNIVERSIDAD.Controladores;
using UNIVERSIDAD.Modelos;
using System.Linq.Expressions;
using UNIVERSIDAD.Properties;

namespace UNIVERSIDAD.Vistas
{
    public partial class form_Empleado : Form
    {
        string Busqueda = "";
        public form_Empleado()
        {
            InitializeComponent();
        }

        private void form_Empleado_Load(object sender, EventArgs e)
        {
            BuscarEmpleado(txtbuscarempleado.Text);
            //Utilidades.Personalizareldatagriedvied(datalista);
            limpiar();
            habilitar(false);
            panel_editar.Visible = false;
            btn_nuevo_EMPLEADO.Image = Resources.flecha_hacia_abajo;
        }
        public void BuscarEmpleado(string Texto)
        {
            Busqueda = Texto;
            datalista.DataSource = new Control_Empleados().Buscar(Variables.SesionId, Texto);
            datalista.Refresh();
            Utilidades.Personalizareldatagriedvied(datalista);

            try
            {
                if (datalista.Columns[2].HeaderText.Equals("Autorizacion") || datalista.Columns[2].HeaderText.Equals("Error"))
                {
                    datalista.Columns["CLOpciones"].Visible = true;
                    datalista.Columns["Edit"].Visible = true;
                    datalista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    return;

                }
                if (datalista.Columns.Count > 0)
                {
                    //datalista.Columns.Count > 0 
                    datalista.Columns["CLOpciones"].Visible = true;
                    datalista.Columns["Edit"].Visible = true;
                    datalista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    datalista.Columns[2].Visible = false;
                    datalista.Columns[10].Visible = false;

                    return;


                }

                if (datalista.Rows.Count > 0)
                {
                    datalista.Columns["Nombre"].Visible = false;
                    datalista.Columns["Apellido"].Visible = false;
                    datalista.Columns["Id"].Visible = false;
                    datalista.Columns["Id_Rol"].Visible = false;
                    datalista.Columns["Login"].Visible = false;
                    datalista.Columns["Password"].Visible = false;
                    datalista.Columns["Direccion"].Visible = false;

                }
                Utilidades.Personalizareldatagriedvied(datalista);
                try
                {
                    datalista.Columns["ClOpciones"].Width = 90;
                    datalista.Columns["Edit"].Width = 90;
                }
                catch (Exception)
                {

                    throw;
                }

                foreach (DataGridViewColumn col in datalista.Columns)
                {
                    if (col.Name != "ClOpciones" && col.Name != "Edit")
                    {

                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                foreach (DataGridViewRow Row in datalista.Rows)
                {
                    Row.DividerHeight = 1;
                    Row.Height = 100;
                }

                datalista.Columns["ClOpciones"].DisplayIndex = datalista.Columns.Count - 1;
                datalista.Columns["Edit"].DisplayIndex = datalista.Columns.Count - 1;

            }
            catch (Exception)
            {

                throw;
            }
            //Utilidades.Personalizareldatagriedvied(datalista);
        }
        void ELIMINAR(Int32 id)
        {
            string rpt;
            MEmpleados obj = new MEmpleados()
            {
                Id = id
            };
            rpt = new Control_Empleados().Eliminar(Variables.UsuarioId, obj);
            if (rpt.Equals("Ok"))
            {
                MessageBox.Show("Registro Eliminado con Exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarEmpleado(txtbuscarempleado.Text);
            }
            else
            {
                MessageBox.Show(rpt, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        bool Insertar()
        {
            bool rpt = false;
            try
            {
                MEmpleados empleado = new MEmpleados()
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Nombre = txtnombre.Text.Trim(),
                    Apellido = txtapellido.Text.Trim(),
                    Sexo = cmbsexo.Text.Trim(),
                    Cedula = txtcedula.Text.Trim(),
                    INS = txtins.Text.Trim(),
                    Celular = txtcelular.Text.Trim(),
                    Direccion = txtdireccion.Text.Trim(),
                    Id_Rol = (int)cmbRol.SelectedValue,
                    Login = txt_login.Text.Trim(),
                    Password = txt_password.Text.Trim()

                };
                string r = new Control_Empleados().Insertar(Variables.SesionId, empleado);
                rpt = r.Equals("Ok") ? true : false;
            }
            catch (Exception ex)
            {
                Utilidades.Mensaje(ex.Message);
                rpt = false;
            }
            return rpt;

        }

        private void btn_guardar_empleado_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                if (Insertar())
                {
                    Utilidades.Mensaje(Convert.ToInt32(txtId.Text) == 0 ? "Registro insertado Correctamente." : "Registro Actualizado Correctamente.");
                    BuscarEmpleado(txtbuscarempleado.Text.Trim());
                    habilitar(false);
                    limpiar();
                    panel_editar.Visible = false;
                    btn_nuevo_EMPLEADO.Image = Resources.flecha_hacia_abajo;

                }
                else
                {
                    Utilidades.Mensaje("Ocurrieron errores al ejecutar el proceso", false);
                }
            }

        }

        private void btn_nuevo_EMPLEADO_Click(object sender, EventArgs e)
        {
            if (panel_editar.Visible == true)
            {
                panel_editar.Visible = false;
                limpiar();
                habilitar(false);
                btn_nuevo_EMPLEADO.Image = Resources.chevron_arriba;
            }
            else
            {
                panel_editar.Visible = true;
                limpiar();
                habilitar(true);
                txtId.Text = "0";
                this.ActiveControl = txtnombre;
                btn_nuevo_EMPLEADO.Image = Resources.flecha_hacia_abajo;
                CargarRol();
            }
        }

        private void datalista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = datalista.CurrentRow.Cells["Id"].Value.ToString();
                txtnombre.Text = datalista.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = datalista.CurrentRow.Cells["Apellido"].Value.ToString();
                cmbsexo.Text = datalista.CurrentRow.Cells["Sexo"].Value.ToString();
                txtcedula.Text = datalista.CurrentRow.Cells["Cedula"].Value.ToString();
                txtins.Text = datalista.CurrentRow.Cells["INS"].Value.ToString();
                txtcelular.Text = datalista.CurrentRow.Cells["Celular"].Value.ToString();
                txtdireccion.Text = datalista.CurrentRow.Cells["Direccion"].Value.ToString();
                //  txt_estado.Text = datalista.CurrentRow.Cells["Estado"].Value.ToString();
                cmbRol.Text = datalista.CurrentRow.Cells["ID_Rol"].Value.ToString();
                txt_login.Text = datalista.CurrentRow.Cells["Login"].Value.ToString();
                txt_password.Text = datalista.CurrentRow.Cells["Password"].Value.ToString();

                // habilitar(true);


            }
            catch (Exception)
            {
                throw;
            }




        }

        private void txtbuscarempleado_TextChanged(object sender, EventArgs e)
        {

            BuscarEmpleado(txtbuscarempleado.Text.Trim());

        }
        void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            cmbsexo.Text = " ";
            txtcedula.Clear();
            txtins.Clear();
            txtcelular.Clear();
            txtdireccion.Clear();
            // txt_estado.Clear();
            cmbRol.Text = string.Empty;
            txt_login.Clear();
            txt_password.Clear();
            // cmbestado.Text = " ";


        }
        public void EDITAR()
        {
            panel_editar.Visible = true;
            limpiar();
            habilitar(true);
            txtId.Text = "0";


            txtId.Text = datalista.CurrentRow.Cells["Id"].Value.ToString();
            txtnombre.Text = datalista.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellido.Text = datalista.CurrentRow.Cells["Apellido"].Value.ToString();
            cmbsexo.Text = datalista.CurrentRow.Cells["Sexo"].Value.ToString();
            txtcedula.Text = datalista.CurrentRow.Cells["Cedula"].Value.ToString();
            txtins.Text = datalista.CurrentRow.Cells["INS"].Value.ToString();
            txtcelular.Text = datalista.CurrentRow.Cells["Celular"].Value.ToString();
            txtdireccion.Text = datalista.CurrentRow.Cells["Direccion"].Value.ToString();
            //txt_estado.Text = datalista.CurrentRow.Cells["Estado"].Value.ToString();
            cmbRol.Text = datalista.CurrentRow.Cells["ID_Rol"].Value.ToString();
            txt_login.Text = datalista.CurrentRow.Cells["Login"].Value.ToString();
            txt_password.Text = datalista.CurrentRow.Cells["Password"].Value.ToString();
        }
        void CargarRol()
        {
            cmbRol.DataSource = new Control_Empleados().buscar_Rol(Variables.UsuarioId, "");
            cmbRol.Refresh();

            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
        }


        public static bool actualizarRor = false;
        bool validar()
        {
            //con esto damos un pequeño mensaje de error si los campos estan vacios
            try
            {
                Eperror.Clear();
                if (txtnombre.Text == string.Empty)
                {
                    Eperror.SetError(txtnombre, "El Nombre es requerido");
                    this.ActiveControl = txtnombre;
                    return false;
                }
                if (txtapellido.Text == string.Empty)
                {
                    Eperror.SetError(txtapellido, "El Apellido es requerido");
                    this.ActiveControl = txtapellido;
                    return false;
                }
                if (txtcedula.Text == string.Empty)
                {
                    Eperror.SetError(txtcedula, "La Cedula es requerido");
                    this.ActiveControl = txtcedula;
                    return false;
                }
                if (txtdireccion.Text == string.Empty)
                {
                    Eperror.SetError(txtdireccion, "La Direccion es requerido");
                    this.ActiveControl = txtdireccion;
                    return false;
                }

                if (txtcelular.Text == string.Empty)
                {
                    Eperror.SetError(txtcelular, "El Celular es requerido");
                    this.ActiveControl = txtcelular;
                    return false;
                }
                if (cmbRol.Text == string.Empty)
                {
                    Eperror.SetError(cmbRol, "El Rol es requerido");
                    this.ActiveControl = cmbRol;
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        void habilitar(bool valor)
        {

            txtnombre.Enabled = valor;
            txtapellido.Enabled = valor;
            cmbsexo.Enabled = valor;
            txtcedula.Enabled = valor;
            txtins.Enabled = valor;
            txtcelular.Enabled = valor;

            txtdireccion.Enabled = valor;
            //txt_estado.Enabled = valor;
            cmbRol.Enabled = valor;
            txt_login.Enabled = valor;
            txt_password.Enabled = valor;


        }

        private void btn_cancelar_empleado_Click(object sender, EventArgs e)
        {
            panel_editar.Visible = false;
            limpiar();
            habilitar(false);
            txtId.Text = "0";
            btn_cancelar_empleado.Image = Resources.chevron_arriba;
        }

        private void datalista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult result;
                result = MessageBox.Show("Desea eliminar Registro del Sistema?", "Eliminar", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    ELIMINAR((Int32)datalista.CurrentRow.Cells["Id"].Value);
                }
            }
            if (e.ColumnIndex == 1)
            {
                EDITAR();
                habilitar(true);
                txtId.Text = datalista.CurrentRow.Cells["Id"].Value.ToString();
                txtnombre.Text = datalista.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = datalista.CurrentRow.Cells["Apellido"].Value.ToString();
                cmbsexo.Text = datalista.CurrentRow.Cells["Sexo"].Value.ToString();
                txtcedula.Text = datalista.CurrentRow.Cells["Cedula"].Value.ToString();
                txtins.Text = datalista.CurrentRow.Cells["INS"].Value.ToString();
                txtcelular.Text = datalista.CurrentRow.Cells["Celular"].Value.ToString();
                txtdireccion.Text = datalista.CurrentRow.Cells["Direccion"].Value.ToString();
                //txt_estado.Text = datalista.CurrentRow.Cells["Estado"].Value.ToString();
                cmbRol.Text = datalista.CurrentRow.Cells["ID_Rol"].Value.ToString();
                txt_login.Text = datalista.CurrentRow.Cells["Login"].Value.ToString();
                txt_password.Text = datalista.CurrentRow.Cells["Password"].Value.ToString();

            }
        }

        private void btn_ver_pass_Click(object sender, EventArgs e)
        {
            //para visualizar la contraseña
            txt_password.PasswordChar = (txt_password.PasswordChar == '*' ? '\0' : '*');
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void txtins_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_ver_rol_Click(object sender, EventArgs e)
        {
            frm_Rol frm = new frm_Rol();
            frm.ShowDialog();
            if (actualizarRor)
            {
                CargarRol();
            }
            else
            {
                Utilidades.Mensaje("No se inserto ningun rol.");
            }
        }

        //private void label6_Click(object sender, EventArgs e)
        //{
        //}

        //private void txt_login_TextChanged(object sender, EventArgs e)
        //{
        //}

        //private void txt_password_TextChanged(object sender, EventArgs e)
        //{


        //}









    }
}
