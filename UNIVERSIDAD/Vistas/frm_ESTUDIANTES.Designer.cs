namespace UNIVERSIDAD.Vistas
{
    partial class frm_ESTUDIANTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ESTUDIANTES));
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            btn_nuevo = new Button();
            txtbuscar = new TextBox();
            panel2 = new Panel();
            data_listado = new DataGridView();
            c_eliminar = new DataGridViewImageColumn();
            c_editar = new DataGridViewImageColumn();
            pn_edition = new Panel();
            btnpdf = new Button();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            txtcarnet = new TextBox();
            txtcedula = new TextBox();
            label2 = new Label();
            txtapellido = new TextBox();
            cmbsexo = new ComboBox();
            txtnombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtid = new TextBox();
            label6 = new Label();
            Error_validar = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_listado).BeginInit();
            pn_edition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Error_validar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_nuevo);
            panel1.Controls.Add(txtbuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 87);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(759, 100);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 16;
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
            label7.Size = new Size(182, 40);
            label7.TabIndex = 15;
            label7.Text = "Estudiantes.";
            // 
            // btn_nuevo
            // 
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Image = (Image)resources.GetObject("btn_nuevo.Image");
            btn_nuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 14;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbuscar.Location = new Point(843, 36);
            txtbuscar.Margin = new Padding(4, 5, 4, 5);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(474, 31);
            txtbuscar.TabIndex = 11;
            txtbuscar.Visible = false;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(data_listado);
            panel2.Controls.Add(pn_edition);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 738);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // data_listado
            // 
            data_listado.AllowUserToAddRows = false;
            data_listado.AllowUserToOrderColumns = true;
            data_listado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_listado.Columns.AddRange(new DataGridViewColumn[] { c_eliminar, c_editar });
            data_listado.Dock = DockStyle.Fill;
            data_listado.Location = new Point(0, 0);
            data_listado.Margin = new Padding(4, 5, 4, 5);
            data_listado.Name = "data_listado";
            data_listado.RowHeadersWidth = 62;
            data_listado.RowTemplate.Height = 25;
            data_listado.ScrollBars = ScrollBars.Horizontal;
            data_listado.Size = new Size(1113, 738);
            data_listado.TabIndex = 14;
            data_listado.CellClick += data_listado_CellClick;
            data_listado.CellContentClick += data_listado_CellContentClick;
            data_listado.Click += data_listado_Click;
            // 
            // c_eliminar
            // 
            c_eliminar.HeaderText = "c_eliminar";
            c_eliminar.Image = Properties.Resources.papelera_de_reciclaje;
            c_eliminar.MinimumWidth = 8;
            c_eliminar.Name = "c_eliminar";
            c_eliminar.Width = 150;
            // 
            // c_editar
            // 
            c_editar.HeaderText = "c_editar";
            c_editar.Image = Properties.Resources.editar;
            c_editar.MinimumWidth = 8;
            c_editar.Name = "c_editar";
            c_editar.Width = 150;
            // 
            // pn_edition
            // 
            pn_edition.AutoScroll = true;
            pn_edition.AutoScrollMargin = new Size(10, 10);
            pn_edition.AutoScrollMinSize = new Size(10, 10);
            pn_edition.Controls.Add(btnpdf);
            pn_edition.Controls.Add(btn_guardar);
            pn_edition.Controls.Add(btn_cancelar);
            pn_edition.Controls.Add(label1);
            pn_edition.Controls.Add(txtcarnet);
            pn_edition.Controls.Add(txtcedula);
            pn_edition.Controls.Add(label2);
            pn_edition.Controls.Add(txtapellido);
            pn_edition.Controls.Add(cmbsexo);
            pn_edition.Controls.Add(txtnombre);
            pn_edition.Controls.Add(label3);
            pn_edition.Controls.Add(label4);
            pn_edition.Controls.Add(label5);
            pn_edition.Controls.Add(txtid);
            pn_edition.Controls.Add(label6);
            pn_edition.Dock = DockStyle.Right;
            pn_edition.Location = new Point(1113, 0);
            pn_edition.Margin = new Padding(4, 5, 4, 5);
            pn_edition.Name = "pn_edition";
            pn_edition.Size = new Size(391, 738);
            pn_edition.TabIndex = 13;
            pn_edition.Visible = false;
            // 
            // btnpdf
            // 
            btnpdf.BackColor = Color.Snow;
            btnpdf.FlatStyle = FlatStyle.Flat;
            btnpdf.ForeColor = SystemColors.Control;
            btnpdf.Image = Properties.Resources.descargar_pdf;
            btnpdf.Location = new Point(237, 598);
            btnpdf.Margin = new Padding(4, 5, 4, 5);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(83, 57);
            btnpdf.TabIndex = 9;
            btnpdf.UseVisualStyleBackColor = false;
            btnpdf.Click += btnpdf_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Image = Properties.Resources.guardar_el_archivo;
            btn_guardar.ImageAlign = ContentAlignment.MiddleRight;
            btn_guardar.Location = new Point(26, 500);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 57);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.TextAlign = ContentAlignment.MiddleLeft;
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.Location = new Point(193, 500);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(126, 320);
            txtcarnet.Margin = new Padding(4, 5, 4, 5);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(210, 31);
            txtcarnet.TabIndex = 6;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(126, 263);
            txtcedula.Margin = new Padding(4, 5, 4, 5);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(210, 31);
            txtcedula.TabIndex = 5;
            txtcedula.KeyUp += txtcedula_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(26, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(126, 153);
            txtapellido.Margin = new Padding(4, 5, 4, 5);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(210, 31);
            txtapellido.TabIndex = 3;
            // 
            // cmbsexo
            // 
            cmbsexo.FormattingEnabled = true;
            cmbsexo.Items.AddRange(new object[] { "M", "F" });
            cmbsexo.Location = new Point(126, 215);
            cmbsexo.Margin = new Padding(4, 5, 4, 5);
            cmbsexo.Name = "cmbsexo";
            cmbsexo.Size = new Size(210, 33);
            cmbsexo.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(126, 92);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(210, 31);
            txtnombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(26, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 217);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 3;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(26, 263);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 4;
            label5.Text = "Cedula:";
            // 
            // txtid
            // 
            txtid.Location = new Point(126, 35);
            txtid.Margin = new Padding(4, 5, 4, 5);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(210, 31);
            txtid.TabIndex = 1;
            txtid.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(26, 320);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 6;
            label6.Text = "Carnet:";
            // 
            // Error_validar
            // 
            Error_validar.ContainerControl = this;
            // 
            // frm_ESTUDIANTES
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 825);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frm_ESTUDIANTES";
            Text = "ESTUDIANTES";
            Load += ESTUDIANTES_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_listado).EndInit();
            pn_edition.ResumeLayout(false);
            pn_edition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Error_validar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox cmbsexo;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcarnet;
        private TextBox txtid;
        private TextBox txtcedula;
        private Panel pn_edition;
        private Button btn_nuevo;
        private DataGridView data_listado;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Label label7;
        public TextBox txtbuscar;
        private DataGridViewImageColumn c_eliminar;
        private DataGridViewImageColumn c_editar;
        private Label label8;
        private ErrorProvider Error_validar;
        private Button btnpdf;
    }
}