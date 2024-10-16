namespace UNIVERSIDAD.Vistas
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btn_acceder = new Button();
            label2 = new Label();
            tex_id = new TextBox();
            tex_nombre = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 430);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Left;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(281, 430);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(btn_acceder);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tex_id);
            panel2.Controls.Add(tex_nombre);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(290, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 430);
            panel2.TabIndex = 0;
            // 
            // btn_acceder
            // 
            btn_acceder.BackColor = Color.FromArgb(192, 192, 255);
            btn_acceder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acceder.Location = new Point(193, 345);
            btn_acceder.Margin = new Padding(4, 5, 4, 5);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(137, 58);
            btn_acceder.TabIndex = 3;
            btn_acceder.Text = "Acceder";
            btn_acceder.UseVisualStyleBackColor = false;
            btn_acceder.Click += btn_acceder_Click;
            btn_acceder.Enter += btn_acceder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 192);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 29);
            label2.TabIndex = 3;
            label2.Text = "Id:";
            // 
            // tex_id
            // 
            tex_id.Location = new Point(101, 188);
            tex_id.Margin = new Padding(4, 5, 4, 5);
            tex_id.Name = "tex_id";
            tex_id.Size = new Size(227, 31);
            tex_id.TabIndex = 2;
            tex_id.UseSystemPasswordChar = true;
            // 
            // tex_nombre
            // 
            tex_nombre.Location = new Point(137, 105);
            tex_nombre.Margin = new Padding(4, 5, 4, 5);
            tex_nombre.Name = "tex_nombre";
            tex_nombre.Size = new Size(191, 31);
            tex_nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 430);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_login";
            ShowIcon = false;
            Text = "Universidad";
            Load += Form_login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private TextBox tex_id;
        private Label label1;
        private Button btn_acceder;
        public TextBox tex_nombre;
    }
}