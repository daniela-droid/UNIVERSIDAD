namespace UNIVERSIDAD.Vistas
{
    partial class form_Empleado
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
            panel1 = new Panel();
            label12 = new Label();
            txtbuscarempleado = new TextBox();
            label11 = new Label();
            btn_nuevo_EMPLEADO = new Button();
            panel2 = new Panel();
            datalista = new DataGridView();
            CLOpciones = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            panel_editar = new Panel();
            panel_editar_scroll = new Panel();
            btn_cancelar_empleado = new Button();
            btn_ver_pass = new Button();
            btn_guardar_empleado = new Button();
            btn_ver_rol = new Button();
            txt_password = new TextBox();
            label1 = new Label();
            txt_login = new TextBox();
            label9 = new Label();
            txtcelular = new TextBox();
            txtins = new TextBox();
            label13 = new Label();
            label6 = new Label();
            cmbRol = new ComboBox();
            txtId = new TextBox();
            label10 = new Label();
            label2 = new Label();
            label14 = new Label();
            txtnombre = new TextBox();
            label3 = new Label();
            txtdireccion = new TextBox();
            txtapellido = new TextBox();
            label4 = new Label();
            cmbsexo = new ComboBox();
            label5 = new Label();
            label7 = new Label();
            txtcedula = new TextBox();
            label8 = new Label();
            Eperror = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalista).BeginInit();
            panel_editar.SuspendLayout();
            panel_editar_scroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Eperror).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtbuscarempleado);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btn_nuevo_EMPLEADO);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 87);
            panel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(785, 41);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(81, 28);
            label12.TabIndex = 4;
            label12.Text = "Buscar:";
            label12.Visible = false;
            // 
            // txtbuscarempleado
            // 
            txtbuscarempleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbuscarempleado.Location = new Point(869, 28);
            txtbuscarempleado.Margin = new Padding(4, 5, 4, 5);
            txtbuscarempleado.Name = "txtbuscarempleado";
            txtbuscarempleado.Size = new Size(474, 31);
            txtbuscarempleado.TabIndex = 3;
            txtbuscarempleado.Visible = false;
            txtbuscarempleado.TextChanged += txtbuscarempleado_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Desktop;
            label11.Location = new Point(61, 34);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(174, 40);
            label11.TabIndex = 2;
            label11.Text = "Empleados.";
            // 
            // btn_nuevo_EMPLEADO
            // 
            btn_nuevo_EMPLEADO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo_EMPLEADO.BackColor = Color.DodgerBlue;
            btn_nuevo_EMPLEADO.FlatStyle = FlatStyle.Flat;
            btn_nuevo_EMPLEADO.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo_EMPLEADO.ForeColor = Color.White;
            btn_nuevo_EMPLEADO.Image = Properties.Resources.chevron_arriba;
            btn_nuevo_EMPLEADO.Location = new Point(1357, 21);
            btn_nuevo_EMPLEADO.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo_EMPLEADO.Name = "btn_nuevo_EMPLEADO";
            btn_nuevo_EMPLEADO.Size = new Size(127, 57);
            btn_nuevo_EMPLEADO.TabIndex = 1;
            btn_nuevo_EMPLEADO.Text = "Nuevo";
            btn_nuevo_EMPLEADO.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevo_EMPLEADO.UseVisualStyleBackColor = false;
            btn_nuevo_EMPLEADO.UseWaitCursor = true;
            btn_nuevo_EMPLEADO.Click += btn_nuevo_EMPLEADO_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(datalista);
            panel2.Controls.Add(panel_editar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 856);
            panel2.TabIndex = 1;
            // 
            // datalista
            // 
            datalista.AllowUserToAddRows = false;
            datalista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalista.Columns.AddRange(new DataGridViewColumn[] { CLOpciones, Edit });
            datalista.Dock = DockStyle.Fill;
            datalista.Location = new Point(0, 0);
            datalista.Margin = new Padding(4, 5, 4, 5);
            datalista.Name = "datalista";
            datalista.RowHeadersWidth = 62;
            datalista.RowTemplate.Height = 25;
            datalista.ScrollBars = ScrollBars.Horizontal;
            datalista.Size = new Size(1017, 856);
            datalista.TabIndex = 4;
            datalista.CellClick += datalista_CellClick;
            datalista.CellContentClick += datalista_CellContentClick;
            // 
            // CLOpciones
            // 
            CLOpciones.HeaderText = "Eliminar";
            CLOpciones.Image = Properties.Resources.papelera_de_reciclaje;
            CLOpciones.MinimumWidth = 8;
            CLOpciones.Name = "CLOpciones";
            CLOpciones.Width = 150;
            // 
            // Edit
            // 
            Edit.HeaderText = "Editar";
            Edit.Image = Properties.Resources.editar;
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Width = 150;
            // 
            // panel_editar
            // 
            panel_editar.Controls.Add(panel_editar_scroll);
            panel_editar.Controls.Add(label8);
            panel_editar.Dock = DockStyle.Right;
            panel_editar.Location = new Point(1017, 0);
            panel_editar.Margin = new Padding(4, 5, 4, 5);
            panel_editar.Name = "panel_editar";
            panel_editar.Size = new Size(487, 856);
            panel_editar.TabIndex = 1;
            // 
            // panel_editar_scroll
            // 
            panel_editar_scroll.AutoScroll = true;
            panel_editar_scroll.AutoScrollMargin = new Size(10, 10);
            panel_editar_scroll.AutoScrollMinSize = new Size(10, 10);
            panel_editar_scroll.Controls.Add(btn_cancelar_empleado);
            panel_editar_scroll.Controls.Add(btn_ver_pass);
            panel_editar_scroll.Controls.Add(btn_guardar_empleado);
            panel_editar_scroll.Controls.Add(btn_ver_rol);
            panel_editar_scroll.Controls.Add(txt_password);
            panel_editar_scroll.Controls.Add(label1);
            panel_editar_scroll.Controls.Add(txt_login);
            panel_editar_scroll.Controls.Add(label9);
            panel_editar_scroll.Controls.Add(txtcelular);
            panel_editar_scroll.Controls.Add(txtins);
            panel_editar_scroll.Controls.Add(label13);
            panel_editar_scroll.Controls.Add(label6);
            panel_editar_scroll.Controls.Add(cmbRol);
            panel_editar_scroll.Controls.Add(txtId);
            panel_editar_scroll.Controls.Add(label10);
            panel_editar_scroll.Controls.Add(label2);
            panel_editar_scroll.Controls.Add(label14);
            panel_editar_scroll.Controls.Add(txtnombre);
            panel_editar_scroll.Controls.Add(label3);
            panel_editar_scroll.Controls.Add(txtdireccion);
            panel_editar_scroll.Controls.Add(txtapellido);
            panel_editar_scroll.Controls.Add(label4);
            panel_editar_scroll.Controls.Add(cmbsexo);
            panel_editar_scroll.Controls.Add(label5);
            panel_editar_scroll.Controls.Add(label7);
            panel_editar_scroll.Controls.Add(txtcedula);
            panel_editar_scroll.Dock = DockStyle.Right;
            panel_editar_scroll.Location = new Point(0, 0);
            panel_editar_scroll.Margin = new Padding(4, 5, 4, 5);
            panel_editar_scroll.Name = "panel_editar_scroll";
            panel_editar_scroll.Size = new Size(487, 856);
            panel_editar_scroll.TabIndex = 5;
            // 
            // btn_cancelar_empleado
            // 
            btn_cancelar_empleado.Anchor = AnchorStyles.Top;
            btn_cancelar_empleado.BackColor = Color.PaleVioletRed;
            btn_cancelar_empleado.FlatStyle = FlatStyle.Flat;
            btn_cancelar_empleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_empleado.ForeColor = Color.White;
            btn_cancelar_empleado.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar_empleado.Location = new Point(305, 717);
            btn_cancelar_empleado.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar_empleado.Name = "btn_cancelar_empleado";
            btn_cancelar_empleado.Size = new Size(127, 57);
            btn_cancelar_empleado.TabIndex = 23;
            btn_cancelar_empleado.Text = "&Cancelar";
            btn_cancelar_empleado.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cancelar_empleado.UseVisualStyleBackColor = false;
            btn_cancelar_empleado.Click += btn_cancelar_empleado_Click;
            // 
            // btn_ver_pass
            // 
            btn_ver_pass.Anchor = AnchorStyles.Right;
            btn_ver_pass.BackColor = Color.DodgerBlue;
            btn_ver_pass.FlatStyle = FlatStyle.Flat;
            btn_ver_pass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ver_pass.ForeColor = Color.White;
            btn_ver_pass.Location = new Point(390, 617);
            btn_ver_pass.Margin = new Padding(4, 5, 4, 5);
            btn_ver_pass.Name = "btn_ver_pass";
            btn_ver_pass.Size = new Size(59, 48);
            btn_ver_pass.TabIndex = 25;
            btn_ver_pass.Text = "&Ver";
            btn_ver_pass.UseVisualStyleBackColor = false;
            btn_ver_pass.Click += btn_ver_pass_Click;
            // 
            // btn_guardar_empleado
            // 
            btn_guardar_empleado.Anchor = AnchorStyles.Top;
            btn_guardar_empleado.BackColor = Color.DodgerBlue;
            btn_guardar_empleado.FlatStyle = FlatStyle.Flat;
            btn_guardar_empleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar_empleado.ForeColor = Color.White;
            btn_guardar_empleado.Location = new Point(102, 717);
            btn_guardar_empleado.Margin = new Padding(4, 5, 4, 5);
            btn_guardar_empleado.Name = "btn_guardar_empleado";
            btn_guardar_empleado.Size = new Size(127, 57);
            btn_guardar_empleado.TabIndex = 22;
            btn_guardar_empleado.Text = "&Guardar";
            btn_guardar_empleado.UseVisualStyleBackColor = false;
            btn_guardar_empleado.Click += btn_guardar_empleado_Click;
            // 
            // btn_ver_rol
            // 
            btn_ver_rol.BackColor = Color.DodgerBlue;
            btn_ver_rol.FlatStyle = FlatStyle.Flat;
            btn_ver_rol.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ver_rol.ForeColor = Color.White;
            btn_ver_rol.Location = new Point(390, 493);
            btn_ver_rol.Margin = new Padding(4, 5, 4, 5);
            btn_ver_rol.Name = "btn_ver_rol";
            btn_ver_rol.Size = new Size(59, 48);
            btn_ver_rol.TabIndex = 24;
            btn_ver_rol.Text = "+";
            btn_ver_rol.UseVisualStyleBackColor = false;
            btn_ver_rol.Click += btn_ver_rol_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(204, 623);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(175, 33);
            txt_password.TabIndex = 21;
            txt_password.Text = "1234\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 19;
            label1.Text = "Id:";
            // 
            // txt_login
            // 
            txt_login.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_login.Location = new Point(204, 563);
            txt_login.Margin = new Padding(4, 5, 4, 5);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(243, 33);
            txt_login.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(100, 623);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 8;
            label9.Text = "Password:";
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtcelular.Location = new Point(204, 340);
            txtcelular.Margin = new Padding(4, 5, 4, 5);
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(243, 33);
            txtcelular.TabIndex = 16;
            // 
            // txtins
            // 
            txtins.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtins.Location = new Point(204, 288);
            txtins.Margin = new Padding(4, 5, 4, 5);
            txtins.Name = "txtins";
            txtins.Size = new Size(243, 33);
            txtins.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(97, 340);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(75, 25);
            label13.TabIndex = 24;
            label13.Text = "Celular:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(97, 563);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 5;
            label6.Text = "Login:";
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(204, 493);
            cmbRol.Margin = new Padding(4, 5, 4, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(175, 36);
            cmbRol.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(204, 22);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(243, 33);
            txtId.TabIndex = 20;
            txtId.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(97, 498);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 25);
            label10.TabIndex = 9;
            label10.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(97, 293);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(45, 25);
            label14.TabIndex = 25;
            label14.Text = "INS:";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(204, 83);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 33);
            txtnombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // txtdireccion
            // 
            txtdireccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtdireccion.Location = new Point(204, 392);
            txtdireccion.Margin = new Padding(4, 5, 4, 5);
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(243, 74);
            txtdireccion.TabIndex = 17;
            // 
            // txtapellido
            // 
            txtapellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtapellido.Location = new Point(204, 135);
            txtapellido.Margin = new Padding(4, 5, 4, 5);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(243, 33);
            txtapellido.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // cmbsexo
            // 
            cmbsexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbsexo.FormattingEnabled = true;
            cmbsexo.Items.AddRange(new object[] { "M", "F" });
            cmbsexo.Location = new Point(204, 187);
            cmbsexo.Margin = new Padding(4, 5, 4, 5);
            cmbsexo.Name = "cmbsexo";
            cmbsexo.Size = new Size(243, 36);
            cmbsexo.TabIndex = 13;
            cmbsexo.Text = "M";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(97, 243);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 4;
            label5.Text = "Cedula:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(97, 397);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 6;
            label7.Text = "Direccion:";
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(204, 238);
            txtcedula.Margin = new Padding(4, 5, 4, 5);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(243, 33);
            txtcedula.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(951, 382);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 7;
            label8.Text = "Estado:";
            // 
            // Eperror
            // 
            Eperror.ContainerControl = this;
            // 
            // form_Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 943);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "form_Empleado";
            Text = "form_Empleado";
            Load += form_Empleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datalista).EndInit();
            panel_editar.ResumeLayout(false);
            panel_editar.PerformLayout();
            panel_editar_scroll.ResumeLayout(false);
            panel_editar_scroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Eperror).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_editar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbsexo;
        private TextBox txtdireccion;
        private TextBox txtcedula;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private Label label10;
        private Label label9;
        private Button btn_nuevo_EMPLEADO;

        private Button btn_guardar_empleado;
        private Button btn_cancelar_empleado;

        private Label label11;
        private TextBox txtbuscarempleado;
        private DataGridView datalista;
        private TextBox txt_password;
        private TextBox txt_login;
        private TextBox txtId;
        private Label label1;
        private Button btn_ver_pass;
        private Label label14;
        private Label label13;
        private TextBox txtins;
        private TextBox txtcelular;
        private Button btn_ver_rol;
        private Panel panel_editar_scroll;
        public ComboBox cmbRol;
        private ErrorProvider Eperror;
        private DataGridViewImageColumn CLOpciones;
        private DataGridViewImageColumn Edit;
        private Label label12;
    }
}