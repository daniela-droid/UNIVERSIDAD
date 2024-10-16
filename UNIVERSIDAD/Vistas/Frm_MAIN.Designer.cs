namespace UNIVERSIDAD.Vistas
{
    partial class Frm_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MAIN));
            pn_arriba = new Panel();
            txt_buscadormadre = new TextBox();
            LblRol = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_salr = new Button();
            btn_Menu = new Button();
            pn_conatiner = new Panel();
            pn_navegador = new Panel();
            btn_inicio = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_estudiantes = new Button();
            btn_empleado = new Button();
            btn_facultades = new Button();
            btnturno = new Button();
            btn_abrir_carrera = new Button();
            btn_asignatura = new Button();
            btn_inscripcion = new Button();
            btn_matricula = new Button();
            btn_mensualides = new Button();
            btn_Pagos = new Button();
            mensaje = new NotifyIcon(components);
            pn_arriba.SuspendLayout();
            pn_conatiner.SuspendLayout();
            pn_navegador.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_arriba
            // 
            pn_arriba.BackColor = Color.White;
            pn_arriba.Controls.Add(txt_buscadormadre);
            pn_arriba.Controls.Add(LblRol);
            pn_arriba.Controls.Add(label4);
            pn_arriba.Controls.Add(label3);
            pn_arriba.Controls.Add(btn_salr);
            pn_arriba.Controls.Add(btn_Menu);
            pn_arriba.Dock = DockStyle.Top;
            pn_arriba.Location = new Point(0, 0);
            pn_arriba.Margin = new Padding(4, 5, 4, 5);
            pn_arriba.Name = "pn_arriba";
            pn_arriba.Size = new Size(1546, 85);
            pn_arriba.TabIndex = 0;
            pn_arriba.Paint += pn_arriba_Paint;
            // 
            // txt_buscadormadre
            // 
            txt_buscadormadre.BackColor = SystemColors.InactiveBorder;
            txt_buscadormadre.BorderStyle = BorderStyle.None;
            txt_buscadormadre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_buscadormadre.ForeColor = Color.Gray;
            txt_buscadormadre.Location = new Point(313, 34);
            txt_buscadormadre.Margin = new Padding(4, 5, 4, 5);
            txt_buscadormadre.Name = "txt_buscadormadre";
            txt_buscadormadre.Size = new Size(814, 32);
            txt_buscadormadre.TabIndex = 0;
            txt_buscadormadre.TextChanged += txt_buscadormadre_TextChanged;
            // 
            // LblRol
            // 
            LblRol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LblRol.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblRol.Location = new Point(1404, 50);
            LblRol.Margin = new Padding(4, 0, 4, 0);
            LblRol.Name = "LblRol";
            LblRol.Size = new Size(138, 29);
            LblRol.TabIndex = 8;
            LblRol.Text = "Admin";
            LblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Image = Properties.Resources.lupa;
            label4.Location = new Point(260, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 38);
            label4.TabIndex = 7;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Image = Properties.Resources.usuario;
            label3.Location = new Point(1427, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 51);
            label3.TabIndex = 6;
            // 
            // btn_salr
            // 
            btn_salr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salr.BackColor = Color.FromArgb(55, 76, 112);
            btn_salr.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salr.ForeColor = Color.White;
            btn_salr.Image = Properties.Resources.puerta_de_salida;
            btn_salr.Location = new Point(1614, 53);
            btn_salr.Margin = new Padding(4, 5, 4, 5);
            btn_salr.Name = "btn_salr";
            btn_salr.Size = new Size(57, 52);
            btn_salr.TabIndex = 5;
            btn_salr.UseVisualStyleBackColor = false;
            btn_salr.Visible = false;
            btn_salr.Click += btn_salr_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.BackColor = Color.White;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.ForeColor = SystemColors.ButtonFace;
            btn_Menu.Image = (Image)resources.GetObject("btn_Menu.Image");
            btn_Menu.Location = new Point(0, 0);
            btn_Menu.Margin = new Padding(4, 5, 4, 5);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(252, 86);
            btn_Menu.TabIndex = 3;
            btn_Menu.TextAlign = ContentAlignment.MiddleRight;
            btn_Menu.UseVisualStyleBackColor = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // pn_conatiner
            // 
            pn_conatiner.AutoScroll = true;
            pn_conatiner.AutoScrollMargin = new Size(6, 6);
            pn_conatiner.AutoScrollMinSize = new Size(6, 6);
            pn_conatiner.BackColor = Color.FromArgb(238, 242, 245);
            pn_conatiner.Controls.Add(pn_navegador);
            pn_conatiner.Dock = DockStyle.Fill;
            pn_conatiner.ForeColor = Color.White;
            pn_conatiner.Location = new Point(0, 85);
            pn_conatiner.Margin = new Padding(4, 5, 4, 5);
            pn_conatiner.Name = "pn_conatiner";
            pn_conatiner.Size = new Size(1546, 965);
            pn_conatiner.TabIndex = 1;
            pn_conatiner.Paint += pn_conatiner_Paint;
            // 
            // pn_navegador
            // 
            pn_navegador.AutoScroll = true;
            pn_navegador.BackColor = SystemColors.MenuText;
            pn_navegador.BorderStyle = BorderStyle.FixedSingle;
            pn_navegador.Controls.Add(btn_inicio);
            pn_navegador.Controls.Add(flowLayoutPanel1);
            pn_navegador.Dock = DockStyle.Left;
            pn_navegador.Location = new Point(0, 0);
            pn_navegador.Margin = new Padding(4, 5, 4, 5);
            pn_navegador.Name = "pn_navegador";
            pn_navegador.Size = new Size(252, 965);
            pn_navegador.TabIndex = 0;
            pn_navegador.Visible = false;
            pn_navegador.Paint += pn_navegador_Paint;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = SystemColors.Desktop;
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inicio.ForeColor = Color.White;
            btn_inicio.Image = (Image)resources.GetObject("btn_inicio.Image");
            btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inicio.Location = new Point(6, 5);
            btn_inicio.Margin = new Padding(0);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(245, 70);
            btn_inicio.TabIndex = 1;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_estudiantes);
            flowLayoutPanel1.Controls.Add(btn_empleado);
            flowLayoutPanel1.Controls.Add(btn_facultades);
            flowLayoutPanel1.Controls.Add(btnturno);
            flowLayoutPanel1.Controls.Add(btn_abrir_carrera);
            flowLayoutPanel1.Controls.Add(btn_asignatura);
            flowLayoutPanel1.Controls.Add(btn_inscripcion);
            flowLayoutPanel1.Controls.Add(btn_matricula);
            flowLayoutPanel1.Controls.Add(btn_mensualides);
            flowLayoutPanel1.Controls.Add(btn_Pagos);
            flowLayoutPanel1.Location = new Point(2, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 793);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // btn_estudiantes
            // 
            btn_estudiantes.BackColor = SystemColors.Desktop;
            btn_estudiantes.FlatAppearance.BorderSize = 0;
            btn_estudiantes.FlatStyle = FlatStyle.Flat;
            btn_estudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_estudiantes.ForeColor = Color.White;
            btn_estudiantes.Image = (Image)resources.GetObject("btn_estudiantes.Image");
            btn_estudiantes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_estudiantes.Location = new Point(4, 5);
            btn_estudiantes.Margin = new Padding(4, 5, 4, 5);
            btn_estudiantes.Name = "btn_estudiantes";
            btn_estudiantes.Size = new Size(245, 69);
            btn_estudiantes.TabIndex = 1;
            btn_estudiantes.Text = "Estudiantes";
            btn_estudiantes.UseVisualStyleBackColor = false;
            btn_estudiantes.Click += btn_estudiantes_Click;
            btn_estudiantes.MouseCaptureChanged += btn_estudiantes_MouseCaptureChanged;
            // 
            // btn_empleado
            // 
            btn_empleado.BackColor = SystemColors.Desktop;
            btn_empleado.FlatAppearance.BorderSize = 0;
            btn_empleado.FlatStyle = FlatStyle.Flat;
            btn_empleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_empleado.ForeColor = Color.White;
            btn_empleado.Image = (Image)resources.GetObject("btn_empleado.Image");
            btn_empleado.ImageAlign = ContentAlignment.MiddleLeft;
            btn_empleado.Location = new Point(4, 84);
            btn_empleado.Margin = new Padding(4, 5, 4, 5);
            btn_empleado.Name = "btn_empleado";
            btn_empleado.Size = new Size(253, 69);
            btn_empleado.TabIndex = 2;
            btn_empleado.Text = "Empleado";
            btn_empleado.UseVisualStyleBackColor = false;
            btn_empleado.Click += btn_empleado_Click;
            // 
            // btn_facultades
            // 
            btn_facultades.BackColor = SystemColors.Desktop;
            btn_facultades.FlatAppearance.BorderSize = 0;
            btn_facultades.FlatStyle = FlatStyle.Flat;
            btn_facultades.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_facultades.ForeColor = Color.White;
            btn_facultades.Image = (Image)resources.GetObject("btn_facultades.Image");
            btn_facultades.ImageAlign = ContentAlignment.MiddleLeft;
            btn_facultades.Location = new Point(4, 163);
            btn_facultades.Margin = new Padding(4, 5, 4, 5);
            btn_facultades.Name = "btn_facultades";
            btn_facultades.Size = new Size(253, 85);
            btn_facultades.TabIndex = 3;
            btn_facultades.Text = "Area de\r\nConocimiento";
            btn_facultades.UseVisualStyleBackColor = false;
            btn_facultades.Click += btn_facultades_Click;
            // 
            // btnturno
            // 
            btnturno.FlatAppearance.BorderSize = 0;
            btnturno.FlatStyle = FlatStyle.Flat;
            btnturno.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnturno.ForeColor = Color.White;
            btnturno.Image = (Image)resources.GetObject("btnturno.Image");
            btnturno.ImageAlign = ContentAlignment.MiddleLeft;
            btnturno.Location = new Point(4, 258);
            btnturno.Margin = new Padding(4, 5, 4, 5);
            btnturno.Name = "btnturno";
            btnturno.Size = new Size(253, 69);
            btnturno.TabIndex = 4;
            btnturno.Text = "Turno";
            btnturno.UseVisualStyleBackColor = false;
            btnturno.Click += btnturno_Click;
            // 
            // btn_abrir_carrera
            // 
            btn_abrir_carrera.BackColor = SystemColors.Desktop;
            btn_abrir_carrera.FlatAppearance.BorderSize = 0;
            btn_abrir_carrera.FlatStyle = FlatStyle.Flat;
            btn_abrir_carrera.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_abrir_carrera.ForeColor = Color.White;
            btn_abrir_carrera.Image = (Image)resources.GetObject("btn_abrir_carrera.Image");
            btn_abrir_carrera.ImageAlign = ContentAlignment.MiddleLeft;
            btn_abrir_carrera.Location = new Point(4, 337);
            btn_abrir_carrera.Margin = new Padding(4, 5, 4, 5);
            btn_abrir_carrera.Name = "btn_abrir_carrera";
            btn_abrir_carrera.Size = new Size(253, 69);
            btn_abrir_carrera.TabIndex = 5;
            btn_abrir_carrera.Text = "Carreras";
            btn_abrir_carrera.UseVisualStyleBackColor = false;
            btn_abrir_carrera.Click += btn_abrir_carrera_Click;
            // 
            // btn_asignatura
            // 
            btn_asignatura.BackColor = SystemColors.Desktop;
            btn_asignatura.FlatAppearance.BorderSize = 0;
            btn_asignatura.FlatStyle = FlatStyle.Flat;
            btn_asignatura.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_asignatura.ForeColor = Color.White;
            btn_asignatura.Image = (Image)resources.GetObject("btn_asignatura.Image");
            btn_asignatura.ImageAlign = ContentAlignment.MiddleLeft;
            btn_asignatura.Location = new Point(4, 416);
            btn_asignatura.Margin = new Padding(4, 5, 4, 5);
            btn_asignatura.Name = "btn_asignatura";
            btn_asignatura.Size = new Size(253, 69);
            btn_asignatura.TabIndex = 6;
            btn_asignatura.Text = "Asignaturas";
            btn_asignatura.UseVisualStyleBackColor = false;
            btn_asignatura.Click += btn_asignatura_Click;
            // 
            // btn_inscripcion
            // 
            btn_inscripcion.BackColor = SystemColors.Desktop;
            btn_inscripcion.FlatAppearance.BorderSize = 0;
            btn_inscripcion.FlatStyle = FlatStyle.Flat;
            btn_inscripcion.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inscripcion.ForeColor = Color.White;
            btn_inscripcion.Image = (Image)resources.GetObject("btn_inscripcion.Image");
            btn_inscripcion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inscripcion.Location = new Point(4, 495);
            btn_inscripcion.Margin = new Padding(4, 5, 4, 5);
            btn_inscripcion.Name = "btn_inscripcion";
            btn_inscripcion.Size = new Size(253, 69);
            btn_inscripcion.TabIndex = 3;
            btn_inscripcion.Text = "Inscripciones";
            btn_inscripcion.UseVisualStyleBackColor = false;
            btn_inscripcion.Click += btn_inscripcion_Click;
            // 
            // btn_matricula
            // 
            btn_matricula.BackColor = SystemColors.Desktop;
            btn_matricula.FlatAppearance.BorderSize = 0;
            btn_matricula.FlatStyle = FlatStyle.Flat;
            btn_matricula.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_matricula.ForeColor = Color.White;
            btn_matricula.Image = (Image)resources.GetObject("btn_matricula.Image");
            btn_matricula.ImageAlign = ContentAlignment.MiddleLeft;
            btn_matricula.Location = new Point(4, 574);
            btn_matricula.Margin = new Padding(4, 5, 4, 5);
            btn_matricula.Name = "btn_matricula";
            btn_matricula.Size = new Size(253, 69);
            btn_matricula.TabIndex = 7;
            btn_matricula.Text = "Matriculas";
            btn_matricula.UseVisualStyleBackColor = false;
            btn_matricula.Click += btn_matricula_Click;
            // 
            // btn_mensualides
            // 
            btn_mensualides.BackColor = SystemColors.Desktop;
            btn_mensualides.FlatAppearance.BorderSize = 0;
            btn_mensualides.FlatStyle = FlatStyle.Flat;
            btn_mensualides.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mensualides.ForeColor = Color.White;
            btn_mensualides.Image = (Image)resources.GetObject("btn_mensualides.Image");
            btn_mensualides.ImageAlign = ContentAlignment.MiddleLeft;
            btn_mensualides.Location = new Point(4, 653);
            btn_mensualides.Margin = new Padding(4, 5, 4, 5);
            btn_mensualides.Name = "btn_mensualides";
            btn_mensualides.Size = new Size(253, 69);
            btn_mensualides.TabIndex = 17;
            btn_mensualides.Text = "Mensualidad";
            btn_mensualides.UseVisualStyleBackColor = false;
            btn_mensualides.Click += btn_mensualides_Click;
            // 
            // btn_Pagos
            // 
            btn_Pagos.BackColor = SystemColors.Desktop;
            btn_Pagos.FlatAppearance.BorderSize = 0;
            btn_Pagos.FlatStyle = FlatStyle.Flat;
            btn_Pagos.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Pagos.ForeColor = Color.White;
            btn_Pagos.Image = (Image)resources.GetObject("btn_Pagos.Image");
            btn_Pagos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Pagos.Location = new Point(4, 732);
            btn_Pagos.Margin = new Padding(4, 5, 4, 5);
            btn_Pagos.Name = "btn_Pagos";
            btn_Pagos.Size = new Size(253, 69);
            btn_Pagos.TabIndex = 18;
            btn_Pagos.Text = "Pagos";
            btn_Pagos.UseVisualStyleBackColor = false;
            btn_Pagos.Click += btn_Pagos_Click;
            // 
            // mensaje
            // 
            mensaje.BalloonTipText = "Desplegar Menu\r\n";
            mensaje.Text = "Pulse para ver el menu";
            mensaje.Visible = true;
            mensaje.MouseDoubleClick += mensaje_MouseDoubleClick;
            // 
            // Frm_MAIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(15, 15);
            AutoScrollMinSize = new Size(15, 15);
            ClientSize = new Size(1546, 1050);
            Controls.Add(pn_conatiner);
            Controls.Add(pn_arriba);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_MAIN";
            ShowIcon = false;
            Text = "Universidad";
            TransparencyKey = Color.FromArgb(128, 255, 255);
            WindowState = FormWindowState.Maximized;
            FormClosing += Frm_MAIN_FormClosing;
            Load += Frm_MAIN_Load;
            pn_arriba.ResumeLayout(false);
            pn_arriba.PerformLayout();
            pn_conatiner.ResumeLayout(false);
            pn_navegador.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_arriba;
        private TextBox txt_buscadormadre;
        private Panel pn_conatiner;
        private Button btn_Menu;
        private Button btn_inicio;
        private Button btn_empleado;
        private Button btn_estudiantes;
        public Panel pn_navegador;
        private Button btn_facultades;
        private Button btnturno;
        private Button btn_salr;
        public NotifyIcon mensaje;
        private Label label3;
        private Label label4;
        private Label JLB_USUARIO;
        private Label LblRol;
        private Button btn_abrir_carrera;
        private Button btn_inscripcion;
        private Button btn_asignatura;
        private Button btn_matricula;
        private Button btn_Pagos;
        private Button btn_mensualides;
        private TextBox texempleado;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}