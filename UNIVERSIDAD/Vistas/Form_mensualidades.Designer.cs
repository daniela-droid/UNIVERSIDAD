namespace UNIVERSIDAD.Vistas
{
    partial class Form_mensualidades
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
            data_mensualidad = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            panel_edit = new Panel();
            panel_edition = new Panel();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cmb_empleado = new ComboBox();
            cmb_estudents = new ComboBox();
            txt_pago = new TextBox();
            txt_fecha = new TextBox();
            txt_id = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btn_nuevo = new Button();
            txt_buscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_mensualidad).BeginInit();
            panel_edit.SuspendLayout();
            panel_edition.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(data_mensualidad);
            panel1.Controls.Add(panel_edit);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 825);
            panel1.TabIndex = 0;
            // 
            // data_mensualidad
            // 
            data_mensualidad.AllowUserToAddRows = false;
            data_mensualidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_mensualidad.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            data_mensualidad.Dock = DockStyle.Fill;
            data_mensualidad.Location = new Point(0, 87);
            data_mensualidad.Margin = new Padding(4, 5, 4, 5);
            data_mensualidad.Name = "data_mensualidad";
            data_mensualidad.RowHeadersWidth = 62;
            data_mensualidad.RowTemplate.Height = 25;
            data_mensualidad.Size = new Size(1114, 738);
            data_mensualidad.TabIndex = 2;
            data_mensualidad.CellClick += data_mensualidad_CellClick;
            data_mensualidad.CellContentClick += data_mensualidad_CellContentClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.papelera_de_reciclaje;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.editar;
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.Width = 150;
            // 
            // panel_edit
            // 
            panel_edit.Controls.Add(panel_edition);
            panel_edit.Dock = DockStyle.Right;
            panel_edit.Location = new Point(1114, 87);
            panel_edit.Margin = new Padding(4, 5, 4, 5);
            panel_edit.Name = "panel_edit";
            panel_edit.Size = new Size(390, 738);
            panel_edit.TabIndex = 1;
            // 
            // panel_edition
            // 
            panel_edition.Controls.Add(btn_cancelar);
            panel_edition.Controls.Add(btn_guardar);
            panel_edition.Controls.Add(cmb_empleado);
            panel_edition.Controls.Add(cmb_estudents);
            panel_edition.Controls.Add(txt_pago);
            panel_edition.Controls.Add(txt_fecha);
            panel_edition.Controls.Add(txt_id);
            panel_edition.Controls.Add(label7);
            panel_edition.Controls.Add(label6);
            panel_edition.Controls.Add(label5);
            panel_edition.Controls.Add(label4);
            panel_edition.Controls.Add(label3);
            panel_edition.Location = new Point(20, 10);
            panel_edition.Margin = new Padding(4, 5, 4, 5);
            panel_edition.Name = "panel_edition";
            panel_edition.Size = new Size(366, 553);
            panel_edition.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar.Location = new Point(226, 472);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(127, 57);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleLeft;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.ImageAlign = ContentAlignment.MiddleRight;
            btn_guardar.Location = new Point(60, 472);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(127, 57);
            btn_guardar.TabIndex = 11;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cmb_empleado
            // 
            cmb_empleado.FormattingEnabled = true;
            cmb_empleado.Location = new Point(179, 210);
            cmb_empleado.Margin = new Padding(4, 5, 4, 5);
            cmb_empleado.Name = "cmb_empleado";
            cmb_empleado.Size = new Size(171, 33);
            cmb_empleado.TabIndex = 10;
            // 
            // cmb_estudents
            // 
            cmb_estudents.FormattingEnabled = true;
            cmb_estudents.Location = new Point(179, 148);
            cmb_estudents.Margin = new Padding(4, 5, 4, 5);
            cmb_estudents.Name = "cmb_estudents";
            cmb_estudents.Size = new Size(171, 33);
            cmb_estudents.TabIndex = 9;
            // 
            // txt_pago
            // 
            txt_pago.Location = new Point(179, 335);
            txt_pago.Margin = new Padding(4, 5, 4, 5);
            txt_pago.Name = "txt_pago";
            txt_pago.Size = new Size(171, 31);
            txt_pago.TabIndex = 8;
            // 
            // txt_fecha
            // 
            txt_fecha.Location = new Point(179, 265);
            txt_fecha.Margin = new Padding(4, 5, 4, 5);
            txt_fecha.Name = "txt_fecha";
            txt_fecha.Size = new Size(171, 31);
            txt_fecha.TabIndex = 7;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(179, 92);
            txt_id.Margin = new Padding(4, 5, 4, 5);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(171, 31);
            txt_id.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 348);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 5;
            label7.Text = "Pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 278);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 4;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 210);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 3;
            label5.Text = "Empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 153);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 2;
            label4.Text = "Estudiante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 1;
            label3.Text = "Id:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_nuevo);
            panel2.Controls.Add(txt_buscar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
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
            btn_nuevo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_nuevo.BackColor = Color.DodgerBlue;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Image = Properties.Resources.chevron_arriba;
            btn_nuevo.ImageAlign = ContentAlignment.MiddleRight;
            btn_nuevo.Location = new Point(1357, 21);
            btn_nuevo.Margin = new Padding(4, 5, 4, 5);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(127, 57);
            btn_nuevo.TabIndex = 3;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.TextAlign = ContentAlignment.MiddleLeft;
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(835, 112);
            txt_buscar.Margin = new Padding(4, 5, 4, 5);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(474, 31);
            txt_buscar.TabIndex = 2;
            txt_buscar.Visible = false;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(774, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(61, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 0;
            label1.Text = "Mensualidades";
            label1.Click += label1_Click;
            // 
            // Form_mensualidades
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 825);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_mensualidades";
            ShowIcon = false;
            Text = "Form_mensualidades";
            Load += Form_mensualidades_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_mensualidad).EndInit();
            panel_edit.ResumeLayout(false);
            panel_edition.ResumeLayout(false);
            panel_edition.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView data_mensualidad;
        private Panel panel_edit;
        private Panel panel_edition;
        private TextBox txt_id;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private TextBox txt_buscar;
        private Label label2;
        private Label label1;
        private TextBox txt_pago;
        private TextBox txt_fecha;
        private Button btn_cancelar;
        private Button btn_guardar;
        private ComboBox cmb_empleado;
        private ComboBox cmb_estudents;
        private Button btn_nuevo;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
    }
}