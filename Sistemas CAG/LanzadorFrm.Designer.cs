namespace Sistemas_CAG
{
    partial class LanzadorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanzadorFrm));
            label25 = new Label();
            cb_OPos = new ComboBox();
            ck_tema = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            btn_conf = new Button();
            btn_minimizar = new Button();
            btn_salir = new Button();
            panel2 = new Panel();
            lblNotificacion = new Label();
            errorProvider1 = new ErrorProvider(components);
            ntf_Lanzador = new NotifyIcon(components);
            CM_notificacion = new ContextMenuStrip(components);
            salirToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            fLPDesktop = new FlowLayoutPanel();
            fLPWeb = new FlowLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            fLPServer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            CM_notificacion.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 5.25F);
            label25.Location = new Point(134, 42);
            label25.Name = "label25";
            label25.Size = new Size(93, 7);
            label25.TabIndex = 29;
            label25.Text = "*DIR_CAJ=C:\\Openpos\\pos";
            // 
            // cb_OPos
            // 
            cb_OPos.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_OPos.FormattingEnabled = true;
            cb_OPos.Items.AddRange(new object[] { "(No hay negocios)" });
            cb_OPos.Location = new Point(233, 34);
            cb_OPos.Name = "cb_OPos";
            cb_OPos.Size = new Size(138, 23);
            cb_OPos.TabIndex = 5;
            // 
            // ck_tema
            // 
            ck_tema.AutoSize = true;
            ck_tema.Location = new Point(325, 6);
            ck_tema.Name = "ck_tema";
            ck_tema.Size = new Size(50, 19);
            ck_tema.TabIndex = 31;
            ck_tema.Text = "Dark";
            ck_tema.UseVisualStyleBackColor = true;
            ck_tema.CheckedChanged += ck_tema_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 94, 42);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_conf);
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 31);
            panel1.TabIndex = 5;
            panel1.MouseMove += panel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 5);
            label1.Name = "label1";
            label1.Size = new Size(215, 24);
            label1.TabIndex = 7;
            label1.Text = "Lanzador de Sistemas";
            label1.MouseMove += panel_MouseMove;
            // 
            // btn_conf
            // 
            btn_conf.FlatAppearance.BorderSize = 0;
            btn_conf.FlatStyle = FlatStyle.Flat;
            btn_conf.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_conf.ForeColor = Color.Transparent;
            btn_conf.Location = new Point(270, 1);
            btn_conf.Name = "btn_conf";
            btn_conf.Size = new Size(35, 29);
            btn_conf.TabIndex = 2;
            btn_conf.Text = "⚙️";
            btn_conf.UseVisualStyleBackColor = true;
            btn_conf.Click += btn_config_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.FlatAppearance.BorderSize = 0;
            btn_minimizar.FlatStyle = FlatStyle.Flat;
            btn_minimizar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btn_minimizar.ForeColor = Color.Transparent;
            btn_minimizar.Location = new Point(307, 1);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(35, 29);
            btn_minimizar.TabIndex = 1;
            btn_minimizar.Text = "_";
            btn_minimizar.UseVisualStyleBackColor = true;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btn_salir.ForeColor = Color.Transparent;
            btn_salir.Location = new Point(344, 1);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(35, 29);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(ck_tema);
            panel2.Controls.Add(lblNotificacion);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 27);
            panel2.TabIndex = 6;
            // 
            // lblNotificacion
            // 
            lblNotificacion.AutoSize = true;
            lblNotificacion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblNotificacion.ForeColor = Color.FromArgb(166, 211, 12);
            lblNotificacion.Location = new Point(3, 8);
            lblNotificacion.Name = "lblNotificacion";
            lblNotificacion.Size = new Size(21, 13);
            lblNotificacion.TabIndex = 8;
            lblNotificacion.Text = "v0";
            lblNotificacion.Click += lblNotificacion_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ntf_Lanzador
            // 
            ntf_Lanzador.BalloonTipText = "Lanzador";
            ntf_Lanzador.BalloonTipTitle = "Ejecutandose en segundo plano...";
            ntf_Lanzador.ContextMenuStrip = CM_notificacion;
            ntf_Lanzador.Icon = (Icon)resources.GetObject("ntf_Lanzador.Icon");
            ntf_Lanzador.Text = "Lanzador de Sistemas";
            ntf_Lanzador.Visible = true;
            ntf_Lanzador.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // CM_notificacion
            // 
            CM_notificacion.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, mostrarToolStripMenuItem });
            CM_notificacion.Name = "contextMenuStrip1";
            CM_notificacion.Size = new Size(116, 48);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(115, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(115, 22);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // fLPDesktop
            // 
            fLPDesktop.AutoScroll = true;
            fLPDesktop.Location = new Point(6, 6);
            fLPDesktop.Name = "fLPDesktop";
            fLPDesktop.Size = new Size(345, 360);
            fLPDesktop.TabIndex = 33;
            // 
            // fLPWeb
            // 
            fLPWeb.AutoScroll = true;
            fLPWeb.Location = new Point(6, 6);
            fLPWeb.Name = "fLPWeb";
            fLPWeb.Size = new Size(345, 360);
            fLPWeb.TabIndex = 34;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(9, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(365, 403);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(fLPDesktop);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(357, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Desktop";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(fLPWeb);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(361, 375);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Web";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(fLPServer);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(361, 375);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Servidores";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // fLPServer
            // 
            fLPServer.AutoScroll = true;
            fLPServer.Location = new Point(6, 7);
            fLPServer.Name = "fLPServer";
            fLPServer.Size = new Size(345, 360);
            fLPServer.TabIndex = 35;
            // 
            // LanzadorFrm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 495);
            ControlBox = false;
            Controls.Add(label25);
            Controls.Add(tabControl1);
            Controls.Add(cb_OPos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(10, 94, 42);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LanzadorFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lanzador de sistemas";
            Load += LanzadorFrm_Load;
            Resize += LanzadorFrm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            CM_notificacion.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cb_OPos;
        private Panel panel1;
        private Button btn_conf;
        private Button btn_minimizar;
        private Button btn_salir;
        private Panel panel2;
        private Label label1;
        private Label label25;
        private NotifyIcon ntf_Lanzador;
        private ErrorProvider errorProvider1;
        public Label lblNotificacion;
        private CheckBox ck_tema;
        private ContextMenuStrip CM_notificacion;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private FlowLayoutPanel fLPDesktop;
        private FlowLayoutPanel fLPWeb;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private FlowLayoutPanel fLPServer;
    }
}