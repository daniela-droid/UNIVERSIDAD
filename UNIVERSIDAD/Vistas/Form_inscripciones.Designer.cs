namespace UNIVERSIDAD.Vistas
{
    partial class Form_inscripciones
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
            panel1 = new Panel();
            data_inscripciones = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            panel_edicion = new Panel();
            pn_edition = new Panel();
            cMBCUATRIMESTRE = new ComboBox();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            cmb_asignatura = new ComboBox();
            cmb_matricula = new ComboBox();
            cmb_empleado = new ComboBox();
            cmb_estudiante = new ComboBox();
            txt_id = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btn_nuevo = new Button();
            txt_buscar_inscripcion = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_inscripciones).BeginInit();
            panel_edicion.SuspendLayout();
            pn_edition.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(data_inscripciones);
            panel1.Controls.Add(panel_edicion);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 888);
            panel1.TabIndex = 0;
            // 
            // data_inscripciones
            // 
            data_inscripciones.AllowUserToAddRows = false;
            data_inscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_inscripciones.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Edit });
            data_inscripciones.Dock = DockStyle.Fill;
            data_inscripciones.Location = new Point(0, 87);
            data_inscripciones.Margin = new Padding(4, 5, 4, 5);
            data_inscripciones.Name = "data_inscripciones";
            data_inscripciones.RowHeadersWidth = 62;
            data_inscripciones.RowTemplate.Height = 25;
            data_inscripciones.Size = new Size(1054, 801);
            data_inscripciones.TabIndex = 2;
            data_inscripciones.CellClick += data_inscripciones_CellClick;
            data_inscripciones.CellContentClick += data_inscripciones_CellContentClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.papelera_de_reciclaje;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 150;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.editar;
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Width = 150;
            // 
            // panel_edicion
            // 
            panel_edicion.Controls.Add(pn_edition);
            panel_edicion.Dock = DockStyle.Right;
            panel_edicion.Location = new Point(1054, 87);
            panel_edicion.Margin = new Padding(4, 5, 4, 5);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(450, 801);
            panel_edicion.TabIndex = 1;
            // 
            // pn_edition
            // 
            pn_edition.AutoScroll = true;
            pn_edition.Controls.Add(cMBCUATRIMESTRE);
            pn_edition.Controls.Add(btn_guardar);
            pn_edition.Controls.Add(btn_cancelar);
            pn_edition.Controls.Add(cmb_asignatura);
            pn_edition.Controls.Add(cmb_matricula);
            pn_edition.Controls.Add(cmb_empleado);
            pn_edition.Controls.Add(cmb_estudiante);
            pn_edition.Controls.Add(txt_id);
            pn_edition.Controls.Add(label9);
            pn_edition.Controls.Add(label7);
            pn_edition.Controls.Add(label6);
            pn_edition.Controls.Add(label5);
            pn_edition.Controls.Add(label4);
            pn_edition.Controls.Add(label2);
            pn_edition.Location = new Point(26, 10);
            pn_edition.Margin = new Padding(4, 5, 4, 5);
            pn_edition.Name = "pn_edition";
            pn_edition.Size = new Size(420, 692);
            pn_edition.TabIndex = 0;
            // 
            // cMBCUATRIMESTRE
            // 
            cMBCUATRIMESTRE.FormattingEnabled = true;
            cMBCUATRIMESTRE.Items.AddRange(new object[] { "Primer Cuatrimestre", "Segundo Cuatrimestre", "Tercero Cuatrimestre" });
            cMBCUATRIMESTRE.Location = new Point(153, 470);
            cMBCUATRIMESTRE.Margin = new Padding(4, 5, 4, 5);
            cMBCUATRIMESTRE.Name = "cMBCUATRIMESTRE";
            cMBCUATRIMESTRE.Size = new Size(195, 33);
            cMBCUATRIMESTRE.TabIndex = 19;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = SystemColors.ButtonFace;
            btn_guardar.Location = new Point(53, 613);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 57);
            btn_guardar.TabIndex = 17;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = SystemColors.ButtonFace;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar.Location = new Point(223, 613);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 18;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_asignatura
            // 
            cmb_asignatura.FormattingEnabled = true;
            cmb_asignatura.Location = new Point(153, 395);
            cmb_asignatura.Margin = new Padding(4, 5, 4, 5);
            cmb_asignatura.Name = "cmb_asignatura";
            cmb_asignatura.Size = new Size(195, 33);
            cmb_asignatura.TabIndex = 14;
            // 
            // cmb_matricula
            // 
            cmb_matricula.FormattingEnabled = true;
            cmb_matricula.Location = new Point(153, 328);
            cmb_matricula.Margin = new Padding(4, 5, 4, 5);
            cmb_matricula.Name = "cmb_matricula";
            cmb_matricula.Size = new Size(195, 33);
            cmb_matricula.TabIndex = 13;
            // 
            // cmb_empleado
            // 
            cmb_empleado.FormattingEnabled = true;
            cmb_empleado.Location = new Point(153, 242);
            cmb_empleado.Margin = new Padding(4, 5, 4, 5);
            cmb_empleado.Name = "cmb_empleado";
            cmb_empleado.Size = new Size(195, 33);
            cmb_empleado.TabIndex = 12;
            // 
            // cmb_estudiante
            // 
            cmb_estudiante.FormattingEnabled = true;
            cmb_estudiante.Location = new Point(153, 180);
            cmb_estudiante.Margin = new Padding(4, 5, 4, 5);
            cmb_estudiante.Name = "cmb_estudiante";
            cmb_estudiante.Size = new Size(195, 33);
            cmb_estudiante.TabIndex = 11;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(153, 110);
            txt_id.Margin = new Padding(4, 5, 4, 5);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(195, 31);
            txt_id.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 475);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(116, 25);
            label9.TabIndex = 7;
            label9.Text = "Cuatrimestre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 408);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 5;
            label7.Text = "Asignatura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 342);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 4;
            label6.Text = "Matricula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 255);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 3;
            label5.Text = "Empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 185);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 2;
            label4.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 1;
            label2.Text = "Id:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_nuevo);
            panel2.Controls.Add(txt_buscar_inscripcion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 87);
            panel2.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.ForeColor = SystemColors.ButtonFace;
            btn_nuevo.Image = Properties.Resources.chevron_arriba;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 16;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txt_buscar_inscripcion
            // 
            txt_buscar_inscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_buscar_inscripcion.Location = new Point(843, 87);
            txt_buscar_inscripcion.Margin = new Padding(4, 5, 4, 5);
            txt_buscar_inscripcion.Name = "txt_buscar_inscripcion";
            txt_buscar_inscripcion.Size = new Size(474, 31);
            txt_buscar_inscripcion.TabIndex = 9;
            txt_buscar_inscripcion.Visible = false;
            txt_buscar_inscripcion.TextChanged += txt_buscar_inscripcion_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(759, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 1;
            label3.Text = "Buscar:";
            label3.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(61, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 0;
            label1.Text = "Inscripciones";
            // 
            // Form_inscripciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 888);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_inscripciones";
            Text = "Form_inscripciones";
            Load += Form_inscripciones_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_inscripciones).EndInit();
            panel_edicion.ResumeLayout(false);
            pn_edition.ResumeLayout(false);
            pn_edition.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_edicion;
        private Panel pn_edition;
        private Panel panel2;
        private DataGridView data_inscripciones;
        private ComboBox comboBox5;
        private ComboBox cmb_asignatura;
        private ComboBox cmb_matricula;
        private ComboBox cmb_empleado;
        private ComboBox cmb_estudiante;
        private TextBox textBox3;
        private TextBox txt_id;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btn_nuevo;
        private TextBox txt_buscar_inscripcion;
        private Label label3;
        private Label label1;
        private Button btn_guardar;
        private Button btn_cancelar;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Edit;
        private ComboBox cMBCUATRIMESTRE;
    }
}