namespace UNIVERSIDAD.Vistas
{
    partial class Frm_Facultades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Facultades));
            panel1 = new Panel();
            button_nuevo = new Button();
            tex_buscar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            panel4 = new Panel();
            dtcarreras = new DataGridView();
            panel5 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            data_facultades = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            panel_edicion = new Panel();
            button_guardar = new Button();
            button_cancelar = new Button();
            tex_Nombre = new TextBox();
            tex_descripcion = new TextBox();
            tex_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Error_facultades = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtcarreras).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_facultades).BeginInit();
            panel_edicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Error_facultades).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button_nuevo);
            panel1.Controls.Add(tex_buscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 87);
            panel1.TabIndex = 0;
            // 
            // button_nuevo
            // 
            button_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_nuevo.BackColor = Color.DodgerBlue;
            button_nuevo.FlatStyle = FlatStyle.Flat;
            button_nuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_nuevo.ForeColor = Color.White;
            button_nuevo.Image = (Image)resources.GetObject("button_nuevo.Image");
            button_nuevo.Location = new Point(1357, 21);
            button_nuevo.Margin = new Padding(4, 5, 4, 5);
            button_nuevo.Name = "button_nuevo";
            button_nuevo.Size = new Size(127, 57);
            button_nuevo.TabIndex = 7;
            button_nuevo.Text = "Nuevo";
            button_nuevo.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_nuevo.UseVisualStyleBackColor = false;
            button_nuevo.Click += button_nuevo_Click;
            // 
            // tex_buscar
            // 
            tex_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tex_buscar.Location = new Point(843, 87);
            tex_buscar.Margin = new Padding(4, 5, 4, 5);
            tex_buscar.Name = "tex_buscar";
            tex_buscar.Size = new Size(474, 31);
            tex_buscar.TabIndex = 6;
            tex_buscar.Visible = false;
            tex_buscar.TextChanged += tex_buscar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(61, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(323, 40);
            label5.TabIndex = 2;
            label5.Text = "Area de Conocimiento";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(759, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 1;
            label4.Text = "Buscar:";
            label4.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel_edicion);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 738);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 350);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1107, 388);
            panel7.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtcarreras);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1107, 388);
            panel4.TabIndex = 3;
            // 
            // dtcarreras
            // 
            dtcarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtcarreras.Dock = DockStyle.Fill;
            dtcarreras.Location = new Point(0, 0);
            dtcarreras.Margin = new Padding(4, 5, 4, 5);
            dtcarreras.Name = "dtcarreras";
            dtcarreras.RowHeadersWidth = 62;
            dtcarreras.RowTemplate.Height = 25;
            dtcarreras.Size = new Size(1107, 388);
            dtcarreras.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 275);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1107, 75);
            panel5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(57, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 40);
            label6.TabIndex = 0;
            label6.Text = "Carreras";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1107, 275);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(data_facultades);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1107, 275);
            panel6.TabIndex = 2;
            // 
            // data_facultades
            // 
            data_facultades.AllowUserToAddRows = false;
            data_facultades.AllowUserToOrderColumns = true;
            data_facultades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_facultades.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            data_facultades.Dock = DockStyle.Fill;
            data_facultades.Location = new Point(0, 0);
            data_facultades.Margin = new Padding(4, 5, 4, 5);
            data_facultades.Name = "data_facultades";
            data_facultades.RowHeadersWidth = 62;
            data_facultades.RowTemplate.Height = 25;
            data_facultades.Size = new Size(1107, 275);
            data_facultades.TabIndex = 1;
            data_facultades.CellClick += data_facultades_CellClick;
            data_facultades.CellContentClick += data_facultades_CellContentClick;
            data_facultades.SelectionChanged += data_facultades_SelectionChanged;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Column1";
            Eliminar.Image = Properties.Resources.papelera_de_reciclaje;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Column1";
            Editar.Image = Properties.Resources.editar1;
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.Width = 150;
            // 
            // panel_edicion
            // 
            panel_edicion.Controls.Add(button_guardar);
            panel_edicion.Controls.Add(button_cancelar);
            panel_edicion.Controls.Add(tex_Nombre);
            panel_edicion.Controls.Add(tex_descripcion);
            panel_edicion.Controls.Add(tex_id);
            panel_edicion.Controls.Add(label3);
            panel_edicion.Controls.Add(label2);
            panel_edicion.Controls.Add(label1);
            panel_edicion.Dock = DockStyle.Right;
            panel_edicion.Location = new Point(1107, 0);
            panel_edicion.Margin = new Padding(4, 5, 4, 5);
            panel_edicion.Name = "panel_edicion";
            panel_edicion.Size = new Size(397, 738);
            panel_edicion.TabIndex = 0;
            // 
            // button_guardar
            // 
            button_guardar.BackColor = Color.DodgerBlue;
            button_guardar.FlatStyle = FlatStyle.Flat;
            button_guardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_guardar.ForeColor = Color.White;
            button_guardar.Location = new Point(60, 578);
            button_guardar.Margin = new Padding(4, 5, 4, 5);
            button_guardar.Name = "button_guardar";
            button_guardar.Size = new Size(127, 57);
            button_guardar.TabIndex = 4;
            button_guardar.Text = "Guardar";
            button_guardar.UseVisualStyleBackColor = false;
            button_guardar.Click += button_guardar_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.PaleVioletRed;
            button_cancelar.FlatStyle = FlatStyle.Flat;
            button_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_cancelar.ForeColor = Color.White;
            button_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            button_cancelar.Location = new Point(224, 578);
            button_cancelar.Margin = new Padding(4, 5, 4, 5);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(127, 57);
            button_cancelar.TabIndex = 5;
            button_cancelar.Text = "Cancelar";
            button_cancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // tex_Nombre
            // 
            tex_Nombre.Location = new Point(143, 130);
            tex_Nombre.Margin = new Padding(4, 5, 4, 5);
            tex_Nombre.Name = "tex_Nombre";
            tex_Nombre.Size = new Size(223, 31);
            tex_Nombre.TabIndex = 2;
            // 
            // tex_descripcion
            // 
            tex_descripcion.Location = new Point(143, 197);
            tex_descripcion.Margin = new Padding(4, 5, 4, 5);
            tex_descripcion.Multiline = true;
            tex_descripcion.Name = "tex_descripcion";
            tex_descripcion.Size = new Size(223, 104);
            tex_descripcion.TabIndex = 3;
            // 
            // tex_id
            // 
            tex_id.Location = new Point(143, 57);
            tex_id.Margin = new Padding(4, 5, 4, 5);
            tex_id.Name = "tex_id";
            tex_id.Size = new Size(223, 31);
            tex_id.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // Error_facultades
            // 
            Error_facultades.ContainerControl = this;
            // 
            // Frm_Facultades
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 825);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_Facultades";
            Text = "Frm_Facultades";
            Load += Frm_Facultades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtcarreras).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_facultades).EndInit();
            panel_edicion.ResumeLayout(false);
            panel_edicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Error_facultades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel_edicion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tex_buscar;
        public DataGridView data_facultades;
        public TextBox tex_id;
        public TextBox tex_Nombre;
        public TextBox tex_descripcion;
        public Button button_nuevo;
        public Button button_guardar;
        public Button button_cancelar;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
        private ErrorProvider Error_facultades;
        private Panel panel4;
        private DataGridView dtcarreras;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private Panel panel6;
        private Panel panel7;
    }
}