namespace UNIVERSIDAD.Vistas
{
    partial class Form_Carrera
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
            btn_nuevo = new Button();
            txt_buscar = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            data_carreras = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            pn_edicion = new Panel();
            panel_edicion = new Panel();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            cmb_facultades = new ComboBox();
            txt_precio_matricula = new TextBox();
            txt_aranceles = new TextBox();
            txt_nombre = new TextBox();
            txt_id = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_carreras).BeginInit();
            pn_edicion.SuspendLayout();
            panel_edicion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_nuevo);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 87);
            panel1.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Image = Properties.Resources.chevron_arriba;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 7;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_buscar.Location = new Point(869, 87);
            txt_buscar.Margin = new Padding(4, 5, 4, 5);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(474, 31);
            txt_buscar.TabIndex = 6;
            txt_buscar.Visible = false;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(785, 100);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 2;
            label7.Text = "Buscar:";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(61, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 40);
            label6.TabIndex = 1;
            label6.Text = "Carreras";
            // 
            // panel2
            // 
            panel2.Controls.Add(data_carreras);
            panel2.Controls.Add(pn_edicion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 805);
            panel2.TabIndex = 1;
            // 
            // data_carreras
            // 
            data_carreras.AllowUserToAddRows = false;
            data_carreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_carreras.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Edit });
            data_carreras.Dock = DockStyle.Fill;
            data_carreras.Location = new Point(0, 0);
            data_carreras.Margin = new Padding(4, 5, 4, 5);
            data_carreras.Name = "data_carreras";
            data_carreras.RowHeadersWidth = 62;
            data_carreras.RowTemplate.Height = 25;
            data_carreras.ScrollBars = ScrollBars.Horizontal;
            data_carreras.Size = new Size(1078, 805);
            data_carreras.TabIndex = 1;
            data_carreras.CellClick += data_carreras_CellClick;
            data_carreras.CellContentClick += data_carreras_CellContentClick;
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
            // pn_edicion
            // 
            pn_edicion.Controls.Add(panel_edicion);
            pn_edicion.Dock = DockStyle.Right;
            pn_edicion.Location = new Point(1078, 0);
            pn_edicion.Margin = new Padding(4, 5, 4, 5);
            pn_edicion.Name = "pn_edicion";
            pn_edicion.Size = new Size(426, 805);
            pn_edicion.TabIndex = 0;
            // 
            // panel_edicion
            // 
            panel_edicion.Controls.Add(btn_guardar);
            panel_edicion.Controls.Add(btn_cancelar);
            panel_edicion.Controls.Add(cmb_facultades);
            panel_edicion.Controls.Add(txt_precio_matricula);
            panel_edicion.Controls.Add(txt_aranceles);
            panel_edicion.Controls.Add(txt_nombre);
            panel_edicion.Controls.Add(txt_id);
            panel_edicion.Controls.Add(label5);
            panel_edicion.Controls.Add(label4);
            panel_edicion.Controls.Add(label3);
            panel_edicion.Controls.Add(label2);
            panel_edicion.Controls.Add(label1);
            panel_edicion.Location = new Point(20, 5);
            panel_edicion.Margin = new Padding(4, 5, 4, 5);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(401, 700);
            panel_edicion.TabIndex = 0;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(47, 595);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 57);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleLeft;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar.Location = new Point(244, 595);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_facultades
            // 
            cmb_facultades.FormattingEnabled = true;
            cmb_facultades.Location = new Point(160, 243);
            cmb_facultades.Margin = new Padding(4, 5, 4, 5);
            cmb_facultades.Name = "cmb_facultades";
            cmb_facultades.Size = new Size(187, 33);
            cmb_facultades.TabIndex = 9;
            // 
            // txt_precio_matricula
            // 
            txt_precio_matricula.Location = new Point(174, 372);
            txt_precio_matricula.Margin = new Padding(4, 5, 4, 5);
            txt_precio_matricula.Name = "txt_precio_matricula";
            txt_precio_matricula.Size = new Size(173, 31);
            txt_precio_matricula.TabIndex = 8;
            // 
            // txt_aranceles
            // 
            txt_aranceles.Location = new Point(160, 302);
            txt_aranceles.Margin = new Padding(4, 5, 4, 5);
            txt_aranceles.Name = "txt_aranceles";
            txt_aranceles.Size = new Size(187, 31);
            txt_aranceles.TabIndex = 7;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(160, 177);
            txt_nombre.Margin = new Padding(4, 5, 4, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(187, 31);
            txt_nombre.TabIndex = 6;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(160, 110);
            txt_id.Margin = new Padding(4, 5, 4, 5);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(187, 31);
            txt_id.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 372);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio Matricula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 302);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Aranceles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Facultades:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // Form_Carrera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1504, 892);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_Carrera";
            Text = "Form_Carrera";
            Load += Form_Carrera_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_carreras).EndInit();
            pn_edicion.ResumeLayout(false);
            panel_edicion.ResumeLayout(false);
            panel_edicion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private DataGridView data_carreras;
        private Panel pn_edicion;
        private Panel panel_edicion;
        private TextBox txt_precio_matricula;
        private TextBox txt_aranceles;
        private TextBox txt_nombre;
        private TextBox txt_id;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_nuevo;
        private TextBox txt_buscar;
        private Button btn_guardar;
        private Button btn_cancelar;
        private ComboBox cmb_facultades;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Edit;
    }
}