namespace UNIVERSIDAD.Vistas
{
    partial class Fr_matricula
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
            data_matricula = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            panel_edicion = new Panel();
            pn_edicion = new Panel();
            txt_año = new TextBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cmb_turno = new ComboBox();
            cmb_estudents = new ComboBox();
            cmb_carrera = new ComboBox();
            txt_semestre = new TextBox();
            txt_id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_nuevo = new Button();
            txt_buscar = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_matricula).BeginInit();
            panel_edicion.SuspendLayout();
            pn_edicion.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(data_matricula);
            panel1.Controls.Add(panel_edicion);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 825);
            panel1.TabIndex = 0;
            // 
            // data_matricula
            // 
            data_matricula.AllowUserToAddRows = false;
            data_matricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_matricula.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Edit });
            data_matricula.Dock = DockStyle.Fill;
            data_matricula.Location = new Point(0, 87);
            data_matricula.Margin = new Padding(4, 5, 4, 5);
            data_matricula.Name = "data_matricula";
            data_matricula.RowHeadersWidth = 62;
            data_matricula.RowTemplate.Height = 25;
            data_matricula.Size = new Size(1115, 738);
            data_matricula.TabIndex = 2;
            data_matricula.CellClick += data_matricula_CellClick;
            data_matricula.CellContentClick += data_matricula_CellContentClick;
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
            panel_edicion.Controls.Add(pn_edicion);
            panel_edicion.Dock = DockStyle.Right;
            panel_edicion.Location = new Point(1115, 87);
            panel_edicion.Margin = new Padding(4, 5, 4, 5);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(389, 738);
            panel_edicion.TabIndex = 1;
            // 
            // pn_edicion
            // 
            pn_edicion.Controls.Add(txt_año);
            pn_edicion.Controls.Add(btn_cancelar);
            pn_edicion.Controls.Add(btn_guardar);
            pn_edicion.Controls.Add(cmb_turno);
            pn_edicion.Controls.Add(cmb_estudents);
            pn_edicion.Controls.Add(cmb_carrera);
            pn_edicion.Controls.Add(txt_semestre);
            pn_edicion.Controls.Add(txt_id);
            pn_edicion.Controls.Add(label6);
            pn_edicion.Controls.Add(label5);
            pn_edicion.Controls.Add(label4);
            pn_edicion.Controls.Add(label3);
            pn_edicion.Controls.Add(label2);
            pn_edicion.Controls.Add(label1);
            pn_edicion.Location = new Point(27, 10);
            pn_edicion.Margin = new Padding(4, 5, 4, 5);
            pn_edicion.Name = "pn_edicion";
            pn_edicion.Size = new Size(361, 698);
            pn_edicion.TabIndex = 0;
            // 
            // txt_año
            // 
            txt_año.Location = new Point(134, 320);
            txt_año.Margin = new Padding(4, 5, 4, 5);
            txt_año.Name = "txt_año";
            txt_año.Size = new Size(168, 31);
            txt_año.TabIndex = 14;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = SystemColors.Control;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar.Location = new Point(194, 547);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 13;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = SystemColors.Control;
            btn_guardar.Location = new Point(16, 547);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 57);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cmb_turno
            // 
            cmb_turno.FormattingEnabled = true;
            cmb_turno.Location = new Point(131, 265);
            cmb_turno.Margin = new Padding(4, 5, 4, 5);
            cmb_turno.Name = "cmb_turno";
            cmb_turno.Size = new Size(171, 33);
            cmb_turno.TabIndex = 10;
            // 
            // cmb_estudents
            // 
            cmb_estudents.FormattingEnabled = true;
            cmb_estudents.Location = new Point(131, 212);
            cmb_estudents.Margin = new Padding(4, 5, 4, 5);
            cmb_estudents.Name = "cmb_estudents";
            cmb_estudents.Size = new Size(171, 33);
            cmb_estudents.TabIndex = 9;
            // 
            // cmb_carrera
            // 
            cmb_carrera.FormattingEnabled = true;
            cmb_carrera.Location = new Point(131, 163);
            cmb_carrera.Margin = new Padding(4, 5, 4, 5);
            cmb_carrera.Name = "cmb_carrera";
            cmb_carrera.Size = new Size(171, 33);
            cmb_carrera.TabIndex = 8;
            // 
            // txt_semestre
            // 
            txt_semestre.Location = new Point(131, 380);
            txt_semestre.Margin = new Padding(4, 5, 4, 5);
            txt_semestre.Name = "txt_semestre";
            txt_semestre.Size = new Size(168, 31);
            txt_semestre.TabIndex = 7;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(134, 100);
            txt_id.Margin = new Padding(4, 5, 4, 5);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(171, 31);
            txt_id.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 393);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 5;
            label6.Text = "Semestre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 333);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 278);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Turno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Carrera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_nuevo);
            panel2.Controls.Add(txt_buscar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 87);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.ForeColor = SystemColors.Control;
            btn_nuevo.Image = Properties.Resources.chevron_arriba;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 9;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_buscar.Location = new Point(843, 32);
            txt_buscar.Margin = new Padding(4, 5, 4, 5);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(474, 31);
            txt_buscar.TabIndex = 8;
            txt_buscar.Visible = false;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(759, 45);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 2;
            label8.Text = "Buscar:";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(61, 34);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(161, 40);
            label7.TabIndex = 1;
            label7.Text = "Matriculas";
            // 
            // Fr_matricula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 825);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Fr_matricula";
            Text = "Fr_matricula";
            Load += Fr_matricula_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_matricula).EndInit();
            panel_edicion.ResumeLayout(false);
            pn_edicion.ResumeLayout(false);
            pn_edicion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_edicion;
        private Panel pn_edicion;
        private Button btn_cancelar;
        private Button btn_guardar;
        private ComboBox comboBox4;
        private ComboBox cmb_turno;
        private ComboBox cmb_estudents;
        private ComboBox cmb_carrera;
        private TextBox txt_semestre;
        private TextBox txt_id;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btn_nuevo;
        private TextBox txt_buscar;
        private Label label8;
        private Label label7;
        private DataGridView data_matricula;
        private TextBox txt_año;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Edit;
    }
}