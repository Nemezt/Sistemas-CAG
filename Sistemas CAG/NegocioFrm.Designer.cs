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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NegocioFrm));
            panel1 = new Panel();
            label1 = new Label();
            btn_ayuda = new Button();
            btn_salir = new Button();
            panel2 = new Panel();
            label5 = new Label();
            inventarioTxt = new TextBox();
            label4 = new Label();
            servidorTxt = new TextBox();
            label3 = new Label();
            tipoEstacionTxt = new TextBox();
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
            panel1.Size = new Size(390, 31);
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
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inventarioTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(servidorTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tipoEstacionTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(estacionTxt);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(cb_OPos);
            panel2.Controls.Add(btnAceptar);
            panel2.Location = new Point(5, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 146);
            panel2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 91);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 40;
            label5.Text = "Inventario";
            // 
            // inventarioTxt
            // 
            inventarioTxt.Enabled = false;
            inventarioTxt.Location = new Point(74, 88);
            inventarioTxt.Name = "inventarioTxt";
            inventarioTxt.ReadOnly = true;
            inventarioTxt.Size = new Size(43, 23);
            inventarioTxt.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 91);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 38;
            label4.Text = "Servidor";
            // 
            // servidorTxt
            // 
            servidorTxt.Enabled = false;
            servidorTxt.Location = new Point(217, 88);
            servidorTxt.Name = "servidorTxt";
            servidorTxt.ReadOnly = true;
            servidorTxt.Size = new Size(147, 23);
            servidorTxt.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 54);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 36;
            label3.Text = "Tipo estación";
            // 
            // tipoEstacionTxt
            // 
            tipoEstacionTxt.Location = new Point(217, 51);
            tipoEstacionTxt.Name = "tipoEstacionTxt";
            tipoEstacionTxt.Size = new Size(147, 23);
            tipoEstacionTxt.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 34;
            label2.Text = "Estación";
            // 
            // estacionTxt
            // 
            estacionTxt.Location = new Point(74, 51);
            estacionTxt.Name = "estacionTxt";
            estacionTxt.Size = new Size(43, 23);
            estacionTxt.TabIndex = 33;
            estacionTxt.KeyPress += txt_Estacion_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 16);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 32;
            label10.Text = "Negocio";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 5.25F);
            label25.Location = new Point(3, 136);
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
            cb_OPos.Location = new Point(74, 13);
            cb_OPos.Name = "cb_OPos";
            cb_OPos.Size = new Size(137, 23);
            cb_OPos.TabIndex = 30;
            cb_OPos.SelectedIndexChanged += cb_OPos_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(306, 120);
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
            ClientSize = new Size(390, 185);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(10, 94, 42);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label3;
        private TextBox tipoEstacionTxt;
        private Label label4;
        private TextBox servidorTxt;
        private Label label5;
        private TextBox inventarioTxt;
    }
}