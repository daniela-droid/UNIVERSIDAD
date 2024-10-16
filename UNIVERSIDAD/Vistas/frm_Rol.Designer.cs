namespace UNIVERSIDAD.Vistas
{
    partial class frm_Rol
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
            label4 = new Label();
            panel2 = new Panel();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            txt_salario = new TextBox();
            txt_nombre = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 30);
            label4.TabIndex = 8;
            label4.Text = "Agregar Rol.";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 283);
            panel2.TabIndex = 1;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.DodgerBlue;
            btn_guardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(96, 195);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(89, 34);
            btn_guardar.TabIndex = 7;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.PaleVioletRed;
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Image = Properties.Resources.flecha_hacia_abajo;
            btn_cancelar.Location = new Point(241, 195);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(89, 34);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 128);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario:";
            // 
            // txt_salario
            // 
            txt_salario.Location = new Point(194, 128);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(179, 23);
            txt_salario.TabIndex = 6;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(194, 78);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(179, 23);
            txt_nombre.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_guardar);
            panel1.Controls.Add(txt_salario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 283);
            panel1.TabIndex = 9;
            // 
            // frm_Rol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(424, 283);
            Controls.Add(panel2);
            Name = "frm_Rol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Rol";
            Load += frm_Rol_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox txt_nombre;
        private TextBox txt_salario;
        private Label label3;
        private Label label2;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Label label4;
        private Panel panel1;
    }
}