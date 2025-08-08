namespace Sistemas_CAG
{
    partial class NegocioFrm
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
            label1 = new Label();
            btn_ayuda = new Button();
            btn_salir = new Button();
            panel2 = new Panel();
            label2 = new Label();
            estacionTxt = new TextBox();
            label10 = new Label();
            label25 = new Label();
            cb_OPos = new ComboBox();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 94, 42);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_ayuda);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 31);
            panel1.TabIndex = 7;
            panel1.MouseMove += panel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(300, 24);
            label1.TabIndex = 7;
            label1.Text = "Parámetros Negocio Comercial";
            label1.MouseMove += panel_MouseMove;
            // 
            // btn_ayuda
            // 
            btn_ayuda.FlatAppearance.BorderSize = 0;
            btn_ayuda.FlatStyle = FlatStyle.Flat;
            btn_ayuda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_ayuda.ForeColor = Color.Transparent;
            btn_ayuda.Location = new Point(311, 2);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(35, 29);
            btn_ayuda.TabIndex = 2;
            btn_ayuda.Text = "?";
            btn_ayuda.UseVisualStyleBackColor = true;
            btn_ayuda.Click += btn_ayuda_Click;
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btn_salir.ForeColor = Color.Transparent;
            btn_salir.Location = new Point(354, 2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(35, 29);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(estacionTxt);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(cb_OPos);
            panel2.Controls.Add(btnAceptar);
            panel2.Location = new Point(5, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 137);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 34;
            label2.Text = "Estación";
            // 
            // estacionTxt
            // 
            estacionTxt.Location = new Point(62, 47);
            estacionTxt.Name = "estacionTxt";
            estacionTxt.Size = new Size(35, 23);
            estacionTxt.TabIndex = 33;
            estacionTxt.KeyPress += txt_Estacion_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 16);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 32;
            label10.Text = "Negocio";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 5.25F);
            label25.Location = new Point(8, 83);
            label25.Name = "label25";
            label25.Size = new Size(93, 7);
            label25.TabIndex = 31;
            label25.Text = "*DIR_CAJ=C:\\Openpos\\pos";
            // 
            // cb_OPos
            // 
            cb_OPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_OPos.FormattingEnabled = true;
            cb_OPos.Items.AddRange(new object[] { "(No hay negocios)" });
            cb_OPos.Location = new Point(60, 13);
            cb_OPos.Name = "cb_OPos";
            cb_OPos.Size = new Size(138, 23);
            cb_OPos.TabIndex = 30;
            cb_OPos.SelectedIndexChanged += cb_OPos_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(303, 111);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // NegocioFrm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(395, 181);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(10, 94, 42);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NegocioFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NegocioFrm";
            Load += NegocioFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_ayuda;
        private Button btn_salir;
        private Panel panel2;
        private Button btnAceptar;
        private Label label25;
        private ComboBox cb_OPos;
        private Label label10;
        private Label label2;
        private TextBox estacionTxt;
    }
}