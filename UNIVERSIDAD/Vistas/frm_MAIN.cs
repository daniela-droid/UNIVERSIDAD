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
    public partial class Frm_MAIN : Form
    {
        string FOMRACTIVE = " ";
        frm_ESTUDIANTES Estudiantes;
        form_Empleado Empleados;
        Frm_Facultades Facultades;
        Frm_turnos Turnos;
        Form_Carrera Carrera;
        FORM_Asignatura Asignatura;
        Form_inscripciones Inscripciones;
        Fr_matricula Matricula;
        Form_mensualidades mensualidades;
        Form_pagos pagos;
        FrmInicio Home;
        public Frm_MAIN()
        {
            InitializeComponent();
            Estudiantes = new frm_ESTUDIANTES();
            Empleados = new form_Empleado();
            Facultades = new Frm_Facultades();
            Turnos = new Frm_turnos();
            Carrera = new Form_Carrera();
            Asignatura = new FORM_Asignatura();
            Inscripciones = new Form_inscripciones();
            Matricula = new Fr_matricula();
            mensualidades = new Form_mensualidades();
            pagos = new Form_pagos();
            Home = new FrmInicio();
            //Cargaradminstrador();
        }

        private void Frm_MAIN_Load(object sender, EventArgs e)
        {
            this.LblRol.Text = Variables.Rol;
            abrirInicio(Home);
            FOMRACTIVE = "HOME";
        }

        private void pn_arriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_navegador_Paint(object sender, PaintEventArgs e)
        {
          
            mensaje.Visible = false;

        }

        private void pn_conatiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_buscadormadre_TextChanged(object sender, EventArgs e)
        {
            if (FOMRACTIVE == "Estudiantes") Estudiantes.Buscar(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Empleados") Empleados.BuscarEmpleado(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Turnos") Turnos.Buscar(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Carrera") Carrera.Buscarcarrera(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Facultades") Facultades.Buscar(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Asignatura") Asignatura.Buscar(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Matricula") Matricula.Buscarmatricula(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "Inscripciones") Inscripciones.Buscarinscricion(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "mensualidades") mensualidades.buscarmensualidad(txt_buscadormadre.Text.Trim());
            if (FOMRACTIVE == "pagos") pagos.buscar(txt_buscadormadre.Text.Trim());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            abrirInicio(Home);
            FOMRACTIVE = "HOME";

        }
        void abrirlosfrm(frm_ESTUDIANTES frm)
        {
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == frm.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
        }

        void abrirempelado(form_Empleado form)
        {
            if (form != null)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == form.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }

        }

        void abrirInicio(FrmInicio form)
        {
            if (form != null)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == form.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }

        }
        void abrirfacultades(Frm_Facultades fac)
        {
            if (fac != null)
            {
                fac.TopLevel = false;
                fac.FormBorderStyle = FormBorderStyle.None;
                fac.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == fac.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fac);
                fac.BringToFront();
                fac.Show();

            }

        }

        void abrirturno(Frm_turnos fturno)
        {
            if (fturno != null)
            {
                fturno.TopLevel = false;
                fturno.FormBorderStyle = FormBorderStyle.None;
                fturno.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == fturno.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fturno);
                fturno.BringToFront();
                fturno.Show();

            }

        }
        void abrircarreras(Form_Carrera fcarrera)
        {
            if (fcarrera != null)
            {
                fcarrera.TopLevel = false;
                fcarrera.FormBorderStyle = FormBorderStyle.None;
                fcarrera.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {
                        if (existingForm.GetType() == fcarrera.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fcarrera);
                fcarrera.BringToFront();
                fcarrera.Show();

            }

        }
        void abrirasignatura(FORM_Asignatura fasig)
        {
            if (fasig != null)
            {
                fasig.TopLevel = false;
                fasig.FormBorderStyle = FormBorderStyle.None;
                fasig.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {

                        if (existingForm.GetType() == fasig.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fasig);
                fasig.BringToFront();
                fasig.Show();

            }

        }

        void abriramatricula(Fr_matricula fr)
        {
            if (fr != null)
            {
                fr.TopLevel = false;
                fr.FormBorderStyle = FormBorderStyle.None;
                fr.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {
                        //Form existingForm = (Form)control;

                        if (existingForm.GetType() == fr.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fr);
                fr.BringToFront();
                fr.Show();

            }

        }

        void abrirainscripcion(Form_inscripciones fi)
        {
            if (fi != null)
            {
                fi.TopLevel = false;
                fi.FormBorderStyle = FormBorderStyle.None;
                fi.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {
                        //Form existingForm = (Form)control;

                        if (existingForm.GetType() == fi.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fi);
                fi.BringToFront();
                fi.Show();

            }

        }
        void abrirmensualidades(Form_mensualidades fmens)
        {
            if (fmens != null)
            {
                fmens.TopLevel = false;
                fmens.FormBorderStyle = FormBorderStyle.None;
                fmens.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {
                        //Form existingForm = (Form)control;

                        if (existingForm.GetType() == fmens.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fmens);
                fmens.BringToFront();
                fmens.Show();

            }

        }
        void abrirpagos(Form_pagos fpagos)
        {
            if (fpagos != null)
            {
                fpagos.TopLevel = false;
                fpagos.FormBorderStyle = FormBorderStyle.None;
                fpagos.Dock = DockStyle.Fill;

                foreach (Control control in pn_conatiner.Controls)
                {
                    if (control is Form existingForm)
                    {
                        //Form existingForm = (Form)control;

                        if (existingForm.GetType() == fpagos.GetType())
                        {
                            existingForm.BringToFront();
                            return; //el formulario ya existe en el panel
                        }
                    }
                }
                pn_conatiner.Controls.Add(fpagos);
                fpagos.BringToFront();
                fpagos.Show();

            }

        }

        private void btn_estudiantes_Click(object sender, EventArgs e)
        {

            abrirlosfrm(Estudiantes);
            FOMRACTIVE = "Estudiantes";

        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {

            abrirempelado(Empleados);
            FOMRACTIVE = "Empleados";

        }

        private void btn_rol_Click(object sender, EventArgs e)
        {
            //fm = new frm_Rol();
            //abrirRol(fm);
        }

        void mostrarpanel()
        {
            pn_navegador.Visible = true;
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {

            if (pn_navegador.Visible == false)
            {
                mostrarpanel();
            }
            else
            {
                pn_navegador.Visible = false;

            }

        }

        private void btn_facultades_Click(object sender, EventArgs e)
        {

            abrirfacultades(Facultades);
            FOMRACTIVE = "Facultades";
        }

        private void btnturno_Click(object sender, EventArgs e)
        {

            abrirturno(Turnos);
            FOMRACTIVE = "Turnos";
        }

        private void btn_salr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mensaje_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Frm_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //frm_ESTUDIANTES frm;=


        void mostrarusuario()
        {




        }


        private void textx_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_abrir_carrera_Click(object sender, EventArgs e)
        {

            abrircarreras(Carrera);
            FOMRACTIVE = "Carrera";

        }

        private void btn_asignatura_Click(object sender, EventArgs e)
        {

            abrirasignatura(Asignatura);
            FOMRACTIVE = "Asignatura";
        }

        private void btn_inscripcion_Click(object sender, EventArgs e)
        {

            abrirainscripcion(Inscripciones);
            FOMRACTIVE = "Inscripciones";
        }

        private void btn_matricula_Click(object sender, EventArgs e)
        {

            abriramatricula(Matricula);
            FOMRACTIVE = "Matricula";
        }
        //llamamos el nombre del administrador
        //void Cargaradminstrador()
        //{
        //    texempleado.DataContext = new Control_Empleados().Buscar(Variables.UsuarioId, "");
        //    texempleado.Refresh();
        //    MEmpleados nombrea = new MEmpleados();
        //    texempleado.AccessibleName = "Nombre";
        //    // nombrea.Nombre = texempleado;
        //    // texempleado.ValueMember = "Id";
        //}
        public static bool actualizrestudiante = false;
        private void btn_estudiantes_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void btn_mensualides_Click(object sender, EventArgs e)
        {
            abrirmensualidades(mensualidades);
            FOMRACTIVE = "mensualidades";
        }

        private void btn_Pagos_Click(object sender, EventArgs e)
        {
            abrirpagos(pagos);
            FOMRACTIVE = "pagos";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


