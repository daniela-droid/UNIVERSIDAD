namespace UNIVERSIDAD.Vistas
{
    partial class FORM_Asignatura
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
            txt_buscar = new TextBox();
            label5 = new Label();
            btn_nuevo = new Button();
            label4 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            data_asignatura = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            panel_edition = new Panel();
            btn_cancelar = new Button();
            btn_guardado = new Button();
            txtnombre = new TextBox();
            txtdescripcion = new TextBox();
            txtid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pan_edicion = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_asignatura).BeginInit();
            panel_edition.SuspendLayout();
            pan_edicion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_nuevo);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 87);
            panel1.TabIndex = 0;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_buscar.Location = new Point(863, 87);
            txt_buscar.Margin = new Padding(4, 5, 4, 5);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(474, 31);
            txt_buscar.TabIndex = 6;
            txt_buscar.Visible = false;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(61, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(169, 42);
            label5.TabIndex = 4;
            label5.Text = "Asignaturas";
            // 
            // btn_nuevo
            // 
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.ForeColor = SystemColors.ButtonHighlight;
            btn_nuevo.Image = Properties.Resources.chevron_arriba;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 6;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(779, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 3;
            label4.Text = "Buscar:";
            label4.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 856);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 448);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1095, 408);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(data_asignatura);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 353);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // data_asignatura
            // 
            data_asignatura.AllowUserToAddRows = false;
            data_asignatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_asignatura.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Edit });
            data_asignatura.Dock = DockStyle.Top;
            data_asignatura.Location = new Point(0, 0);
            data_asignatura.Margin = new Padding(4, 5, 4, 5);
            data_asignatura.Name = "data_asignatura";
            data_asignatura.RowHeadersWidth = 62;
            data_asignatura.RowTemplate.Height = 25;
            data_asignatura.ScrollBars = ScrollBars.None;
            data_asignatura.Size = new Size(1095, 353);
            data_asignatura.TabIndex = 1;
            data_asignatura.CellClick += data_asignatura_CellClick;
            data_asignatura.CellContentClick += data_asignatura_CellContentClick;
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
            // panel_edition
            // 
            panel_edition.Controls.Add(btn_cancelar);
            panel_edition.Controls.Add(btn_guardado);
            panel_edition.Controls.Add(txtnombre);
            panel_edition.Controls.Add(txtdescripcion);
            panel_edition.Controls.Add(txtid);
            panel_edition.Controls.Add(label3);
            panel_edition.Controls.Add(label2);
            panel_edition.Controls.Add(label1);
            panel_edition.Location = new Point(23, 23);
            panel_edition.Margin = new Padding(4, 5, 4, 5);
            panel_edition.Name = "panel_edition";
            panel_edition.Size = new Size(386, 753);
            panel_edition.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar.Location = new Point(183, 553);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardado
            // 
            btn_guardado.BackColor = Color.DodgerBlue;
            btn_guardado.FlatStyle = FlatStyle.Flat;
            btn_guardado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardado.ForeColor = SystemColors.ButtonHighlight;
            btn_guardado.Location = new Point(30, 553);
            btn_guardado.Margin = new Padding(4, 5, 4, 5);
            btn_guardado.Name = "btn_guardado";
            btn_guardado.Size = new Size(127, 57);
            btn_guardado.TabIndex = 7;
            btn_guardado.Text = "Guardar";
            btn_guardado.UseVisualStyleBackColor = false;
            btn_guardado.Click += btn_guardado_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(134, 143);
            txtnombre.Margin = new Padding(4, 5, 4, 5);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(174, 31);
            txtnombre.TabIndex = 5;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(134, 205);
            txtdescripcion.Margin = new Padding(4, 5, 4, 5);
            txtdescripcion.Multiline = true;
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(174, 154);
            txtdescripcion.TabIndex = 4;
            // 
            // txtid
            // 
            txtid.Location = new Point(134, 90);
            txtid.Margin = new Padding(4, 5, 4, 5);
            txtid.Name = "txtid";
            txtid.Size = new Size(174, 31);
            txtid.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // pan_edicion
            // 
            pan_edicion.Controls.Add(panel_edition);
            pan_edicion.Dock = DockStyle.Right;
            pan_edicion.Enabled = false;
            pan_edicion.Location = new Point(1095, 87);
            pan_edicion.Margin = new Padding(4, 5, 4, 5);
            pan_edicion.Name = "pan_edicion";
            pan_edicion.Size = new Size(409, 856);
            pan_edicion.TabIndex = 3;
            // 
            // FORM_Asignatura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 943);
            Controls.Add(panel2);
            Controls.Add(pan_edicion);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FORM_Asignatura";
            Text = "FORM_Asignatura";
            Load += FORM_Asignatura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_asignatura).EndInit();
            panel_edition.ResumeLayout(false);
            panel_edition.PerformLayout();
            pan_edicion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView data_asignatura;
        private Panel panel_edition;
        private TextBox txt_buscar;
        private Label label5;
        private Button btn_nuevo;
        private Label label4;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Edit;
        private Button btn_cancelar;
        private Button btn_guardado;
        private TextBox txtnombre;
        private TextBox txtdescripcion;
        private TextBox txtid;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pan_edicion;
        private Panel panel3;
        private Panel panel5;
    }
}