namespace UNIVERSIDAD.Vistas
{
    partial class Form_pagos
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
            data_pagos = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            pane_editionar = new Panel();
            pn_edition = new Panel();
            texmonto = new TextBox();
            label9 = new Label();
            button_cancel = new Button();
            button_saved = new Button();
            tex_Moneda = new TextBox();
            tex_id = new TextBox();
            tex_origen = new TextBox();
            tex_concepto = new TextBox();
            tex_cambio = new TextBox();
            tex_fecha = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button_new = new Button();
            tex_busqueda = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_pagos).BeginInit();
            pane_editionar.SuspendLayout();
            pn_edition.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(data_pagos);
            panel1.Controls.Add(pane_editionar);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 825);
            panel1.TabIndex = 0;
            // 
            // data_pagos
            // 
            data_pagos.AllowUserToAddRows = false;
            data_pagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_pagos.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar });
            data_pagos.Dock = DockStyle.Fill;
            data_pagos.Location = new Point(0, 87);
            data_pagos.Margin = new Padding(4, 5, 4, 5);
            data_pagos.Name = "data_pagos";
            data_pagos.ReadOnly = true;
            data_pagos.RowHeadersWidth = 62;
            data_pagos.RowTemplate.Height = 25;
            data_pagos.ScrollBars = ScrollBars.Horizontal;
            data_pagos.Size = new Size(1091, 738);
            data_pagos.TabIndex = 2;
            data_pagos.CellClick += data_pagos_CellClick;
            data_pagos.Click += data_pagos_Click;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.papelera_de_reciclaje;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.editar;
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 150;
            // 
            // pane_editionar
            // 
            pane_editionar.Controls.Add(pn_edition);
            pane_editionar.Dock = DockStyle.Right;
            pane_editionar.Location = new Point(1091, 87);
            pane_editionar.Margin = new Padding(4, 5, 4, 5);
            pane_editionar.Name = "pane_editionar";
            pane_editionar.Size = new Size(413, 738);
            pane_editionar.TabIndex = 1;
            // 
            // pn_edition
            // 
            pn_edition.AutoScroll = true;
            pn_edition.Controls.Add(texmonto);
            pn_edition.Controls.Add(label9);
            pn_edition.Controls.Add(button_cancel);
            pn_edition.Controls.Add(button_saved);
            pn_edition.Controls.Add(tex_Moneda);
            pn_edition.Controls.Add(tex_id);
            pn_edition.Controls.Add(tex_origen);
            pn_edition.Controls.Add(tex_concepto);
            pn_edition.Controls.Add(tex_cambio);
            pn_edition.Controls.Add(tex_fecha);
            pn_edition.Controls.Add(label8);
            pn_edition.Controls.Add(label7);
            pn_edition.Controls.Add(label6);
            pn_edition.Controls.Add(label5);
            pn_edition.Controls.Add(label4);
            pn_edition.Controls.Add(label3);
            pn_edition.Location = new Point(23, 10);
            pn_edition.Margin = new Padding(4, 5, 4, 5);
            pn_edition.Name = "pn_edition";
            pn_edition.Size = new Size(373, 662);
            pn_edition.TabIndex = 0;
            // 
            // texmonto
            // 
            texmonto.Location = new Point(146, 275);
            texmonto.Margin = new Padding(4, 5, 4, 5);
            texmonto.Name = "texmonto";
            texmonto.Size = new Size(174, 31);
            texmonto.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 275);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 14;
            label9.Text = "Monto:";
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.PaleVioletRed;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_cancel.ForeColor = SystemColors.Control;
            button_cancel.Image = Properties.Resources.flecha_hacia_abajo;
            button_cancel.ImageAlign = ContentAlignment.MiddleRight;
            button_cancel.Location = new Point(234, 550);
            button_cancel.Margin = new Padding(4, 5, 4, 5);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(127, 57);
            button_cancel.TabIndex = 13;
            button_cancel.Text = "Cancelar";
            button_cancel.TextAlign = ContentAlignment.MiddleLeft;
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_saved
            // 
            button_saved.BackColor = Color.DodgerBlue;
            button_saved.FlatStyle = FlatStyle.Flat;
            button_saved.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_saved.ForeColor = SystemColors.ButtonFace;
            button_saved.Location = new Point(49, 550);
            button_saved.Margin = new Padding(4, 5, 4, 5);
            button_saved.Name = "button_saved";
            button_saved.Size = new Size(127, 57);
            button_saved.TabIndex = 12;
            button_saved.Text = "Guardar";
            button_saved.UseVisualStyleBackColor = false;
            button_saved.Click += button_saved_Click;
            // 
            // tex_Moneda
            // 
            tex_Moneda.Location = new Point(146, 387);
            tex_Moneda.Margin = new Padding(4, 5, 4, 5);
            tex_Moneda.Name = "tex_Moneda";
            tex_Moneda.Size = new Size(174, 31);
            tex_Moneda.TabIndex = 11;
            // 
            // tex_id
            // 
            tex_id.Location = new Point(146, 88);
            tex_id.Margin = new Padding(4, 5, 4, 5);
            tex_id.Name = "tex_id";
            tex_id.Size = new Size(174, 31);
            tex_id.TabIndex = 10;
            // 
            // tex_origen
            // 
            tex_origen.Location = new Point(146, 157);
            tex_origen.Margin = new Padding(4, 5, 4, 5);
            tex_origen.Name = "tex_origen";
            tex_origen.Size = new Size(174, 31);
            tex_origen.TabIndex = 9;
            // 
            // tex_concepto
            // 
            tex_concepto.Location = new Point(146, 217);
            tex_concepto.Margin = new Padding(4, 5, 4, 5);
            tex_concepto.Name = "tex_concepto";
            tex_concepto.Size = new Size(174, 31);
            tex_concepto.TabIndex = 8;
            // 
            // tex_cambio
            // 
            tex_cambio.Location = new Point(146, 443);
            tex_cambio.Margin = new Padding(4, 5, 4, 5);
            tex_cambio.Name = "tex_cambio";
            tex_cambio.Size = new Size(174, 31);
            tex_cambio.TabIndex = 7;
            // 
            // tex_fecha
            // 
            tex_fecha.Location = new Point(146, 330);
            tex_fecha.Margin = new Padding(4, 5, 4, 5);
            tex_fecha.Name = "tex_fecha";
            tex_fecha.Size = new Size(174, 31);
            tex_fecha.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 443);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 5;
            label8.Text = "Cambio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 392);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 4;
            label7.Text = "Moneda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 335);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 3;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 217);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 2;
            label5.Text = "Concepto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 1;
            label4.Text = "Origen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 25);
            label3.TabIndex = 0;
            label3.Text = "Id:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_new);
            panel2.Controls.Add(tex_busqueda);
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
            // button_new
            // 
            button_new.BackColor = Color.DodgerBlue;
            button_new.FlatStyle = FlatStyle.Flat;
            button_new.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_new.ForeColor = Color.AliceBlue;
            button_new.Image = Properties.Resources.chevron_arriba;
            button_new.ImageAlign = ContentAlignment.MiddleRight;
            button_new.Location = new Point(1357, 21);
            button_new.Margin = new Padding(4, 5, 4, 5);
            button_new.Name = "button_new";
            button_new.Size = new Size(127, 57);
            button_new.TabIndex = 3;
            button_new.Text = "Nuevo";
            button_new.TextAlign = ContentAlignment.MiddleLeft;
            button_new.UseVisualStyleBackColor = false;
            button_new.Click += button_new_Click;
            // 
            // tex_busqueda
            // 
            tex_busqueda.Location = new Point(863, 87);
            tex_busqueda.Margin = new Padding(4, 5, 4, 5);
            tex_busqueda.Name = "tex_busqueda";
            tex_busqueda.Size = new Size(474, 31);
            tex_busqueda.TabIndex = 2;
            tex_busqueda.Visible = false;
            tex_busqueda.TextChanged += tex_busqueda_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(779, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
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
            label1.Size = new Size(99, 40);
            label1.TabIndex = 0;
            label1.Text = "Pagos";
            // 
            // Form_pagos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(10, 10);
            AutoScrollMinSize = new Size(10, 10);
            ClientSize = new Size(1504, 825);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_pagos";
            Text = "Form_pagos";
            Load += Form_pagos_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_pagos).EndInit();
            pane_editionar.ResumeLayout(false);
            pn_edition.ResumeLayout(false);
            pn_edition.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel pane_editionar;
        private Panel pn_edition;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private TextBox tx_buscar;
        private DataGridView data_pagos;
        private Button button_cancel;
        private Button button_saved;
        private TextBox tex_Moneda;
        private TextBox tex_id;
        private TextBox tex_origen;
        private TextBox tex_concepto;
        private TextBox tex_cambio;
        private TextBox tex_fecha;
        private Button button_new;
        private TextBox tex_busqueda;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn Editar;
        private TextBox texmonto;
    }
}