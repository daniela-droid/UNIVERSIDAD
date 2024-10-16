namespace UNIVERSIDAD.Vistas
{
    partial class Frm_turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_turnos));
            panel1 = new Panel();
            data_turnos = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            panel_de_edicion = new Panel();
            btn_cancelar_turno = new Button();
            button_insertar = new Button();
            txt_id_turno = new TextBox();
            txt_nombre_turno = new TextBox();
            txt_durabilidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            button_nuevo = new Button();
            txt_buscar_turno = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Error_Turno = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_turnos).BeginInit();
            panel_de_edicion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Error_Turno).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(data_turnos);
            panel1.Controls.Add(panel_de_edicion);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 825);
            panel1.TabIndex = 0;
            // 
            // data_turnos
            // 
            data_turnos.AllowUserToAddRows = false;
            data_turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_turnos.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            data_turnos.Dock = DockStyle.Fill;
            data_turnos.Location = new Point(0, 87);
            data_turnos.Margin = new Padding(4, 5, 4, 5);
            data_turnos.Name = "data_turnos";
            data_turnos.RowHeadersWidth = 62;
            data_turnos.RowTemplate.Height = 25;
            data_turnos.Size = new Size(1093, 738);
            data_turnos.TabIndex = 2;
            data_turnos.CellClick += data_turnos_CellClick;
            data_turnos.CellContentClick += data_turnos_CellContentClick;
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
            // panel_de_edicion
            // 
            panel_de_edicion.Controls.Add(btn_cancelar_turno);
            panel_de_edicion.Controls.Add(button_insertar);
            panel_de_edicion.Controls.Add(txt_id_turno);
            panel_de_edicion.Controls.Add(txt_nombre_turno);
            panel_de_edicion.Controls.Add(txt_durabilidad);
            panel_de_edicion.Controls.Add(label3);
            panel_de_edicion.Controls.Add(label4);
            panel_de_edicion.Controls.Add(label5);
            panel_de_edicion.Dock = DockStyle.Right;
            panel_de_edicion.Location = new Point(1093, 87);
            panel_de_edicion.Margin = new Padding(4, 5, 4, 5);
            panel_de_edicion.Name = "panel_de_edicion";
            panel_de_edicion.Size = new Size(411, 738);
            panel_de_edicion.TabIndex = 1;
            panel_de_edicion.Paint += panel_de_edicion_Paint;
            // 
            // btn_cancelar_turno
            // 
            btn_cancelar_turno.BackColor = Color.PaleVioletRed;
            btn_cancelar_turno.FlatStyle = FlatStyle.Flat;
            btn_cancelar_turno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar_turno.ForeColor = Color.White;
            btn_cancelar_turno.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar_turno.ImageAlign = ContentAlignment.MiddleRight;
            btn_cancelar_turno.Location = new Point(243, 560);
            btn_cancelar_turno.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar_turno.Name = "btn_cancelar_turno";
            btn_cancelar_turno.Size = new Size(127, 57);
            btn_cancelar_turno.TabIndex = 5;
            btn_cancelar_turno.Text = "Cancelar";
            btn_cancelar_turno.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cancelar_turno.UseVisualStyleBackColor = false;
            btn_cancelar_turno.Click += btn_cancelar_turno_Click;
            // 
            // button_insertar
            // 
            button_insertar.BackColor = Color.DodgerBlue;
            button_insertar.FlatStyle = FlatStyle.Flat;
            button_insertar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_insertar.ForeColor = Color.White;
            button_insertar.Location = new Point(40, 560);
            button_insertar.Margin = new Padding(4, 5, 4, 5);
            button_insertar.Name = "button_insertar";
            button_insertar.Size = new Size(127, 57);
            button_insertar.TabIndex = 4;
            button_insertar.Text = "Guardar\r\n";
            button_insertar.UseVisualStyleBackColor = false;
            button_insertar.Click += button_insertar_Click;
            // 
            // txt_id_turno
            // 
            txt_id_turno.Location = new Point(150, 58);
            txt_id_turno.Margin = new Padding(4, 5, 4, 5);
            txt_id_turno.Name = "txt_id_turno";
            txt_id_turno.Size = new Size(218, 31);
            txt_id_turno.TabIndex = 1;
            // 
            // txt_nombre_turno
            // 
            txt_nombre_turno.Location = new Point(150, 130);
            txt_nombre_turno.Margin = new Padding(4, 5, 4, 5);
            txt_nombre_turno.Name = "txt_nombre_turno";
            txt_nombre_turno.Size = new Size(218, 31);
            txt_nombre_turno.TabIndex = 2;
            // 
            // txt_durabilidad
            // 
            txt_durabilidad.Location = new Point(150, 193);
            txt_durabilidad.Margin = new Padding(4, 5, 4, 5);
            txt_durabilidad.Name = "txt_durabilidad";
            txt_durabilidad.Size = new Size(218, 31);
            txt_durabilidad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(40, 130);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Nombre:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 207);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 4;
            label5.Text = "Durabilidad:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_nuevo);
            panel2.Controls.Add(txt_buscar_turno);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1504, 87);
            panel2.TabIndex = 0;
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
            button_nuevo.TabIndex = 3;
            button_nuevo.Text = "Nuevo\r\n";
            button_nuevo.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_nuevo.UseVisualStyleBackColor = false;
            button_nuevo.Click += button_nuevo_Click;
            // 
            // txt_buscar_turno
            // 
            txt_buscar_turno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_buscar_turno.Location = new Point(843, 87);
            txt_buscar_turno.Margin = new Padding(4, 5, 4, 5);
            txt_buscar_turno.Name = "txt_buscar_turno";
            txt_buscar_turno.Size = new Size(474, 31);
            txt_buscar_turno.TabIndex = 2;
            txt_buscar_turno.Visible = false;
            txt_buscar_turno.TextChanged += txt_buscar_turno_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(759, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(61, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 0;
            label1.Text = "Turnos\r\n\r\n";
            // 
            // Error_Turno
            // 
            Error_Turno.ContainerControl = this;
            // 
            // Frm_turnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 825);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_turnos";
            Text = "Frm_turnos";
            Load += Frm_turnos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_turnos).EndInit();
            panel_de_edicion.ResumeLayout(false);
            panel_de_edicion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Error_Turno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView data_turnos;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
        private Panel panel_de_edicion;
        private Panel panel2;
        private TextBox txt_nombre_turno;
        private TextBox txt_durabilidad;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_id_turno;
        private TextBox txt_buscar_turno;
        private Label label2;
        private Label label1;
        private Button btn_cancelar_turno;
        private Button button_insertar;
        private Button button_nuevo;
        private ErrorProvider Error_Turno;
    }
}