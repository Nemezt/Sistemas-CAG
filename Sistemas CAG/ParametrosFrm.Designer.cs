namespace Sistemas_CAG
{
    partial class ParametrosFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btn_ayuda = new Button();
            btn_minimizar = new Button();
            btn_salir = new Button();
            dgvSistemas = new DataGridView();
            panelMenu = new Panel();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            dgvNegociosPos = new DataGridView();
            tabControl1 = new TabControl();
            tabParmGen = new TabPage();
            defnavcb = new CheckBox();
            defjavcb = new CheckBox();
            deforacb = new CheckBox();
            groupBox1 = new GroupBox();
            servidortxt = new TextBox();
            logtxt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            ActuScb = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            codciatxt = new TextBox();
            sisttxt = new TextBox();
            javatxt = new TextBox();
            navegadortxt = new TextBox();
            oracletxt = new TextBox();
            tabSistema = new TabPage();
            label15 = new Label();
            carpetaTxt = new TextBox();
            label14 = new Label();
            inicioEnTxt = new TextBox();
            label13 = new Label();
            tipoTxt = new TextBox();
            label12 = new Label();
            param2Txt = new TextBox();
            label11 = new Label();
            param1Txt = new TextBox();
            label10 = new Label();
            nombreTxt = new TextBox();
            label9 = new Label();
            idTxt = new TextBox();
            tabNegPos = new TabPage();
            label16 = new Label();
            textBox1 = new TextBox();
            label17 = new Label();
            textBox2 = new TextBox();
            label18 = new Label();
            iconoTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSistemas).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNegociosPos).BeginInit();
            tabControl1.SuspendLayout();
            tabParmGen.SuspendLayout();
            groupBox1.SuspendLayout();
            tabSistema.SuspendLayout();
            tabNegPos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 94, 42);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_ayuda);
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 31);
            panel1.TabIndex = 6;
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
            label1.Size = new Size(326, 24);
            label1.TabIndex = 7;
            label1.Text = "Parámetros Lanzador de Sistemas";
            label1.MouseMove += panel_MouseMove;
            // 
            // btn_ayuda
            // 
            btn_ayuda.FlatAppearance.BorderSize = 0;
            btn_ayuda.FlatStyle = FlatStyle.Flat;
            btn_ayuda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_ayuda.ForeColor = Color.Transparent;
            btn_ayuda.Location = new Point(521, 1);
            btn_ayuda.Name = "btn_ayuda";
            btn_ayuda.Size = new Size(35, 29);
            btn_ayuda.TabIndex = 2;
            btn_ayuda.Text = "?";
            btn_ayuda.UseVisualStyleBackColor = true;
            btn_ayuda.Click += btn_ayuda_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.FlatAppearance.BorderSize = 0;
            btn_minimizar.FlatStyle = FlatStyle.Flat;
            btn_minimizar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btn_minimizar.ForeColor = Color.Transparent;
            btn_minimizar.Location = new Point(558, 1);
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
            btn_salir.Location = new Point(595, 1);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(35, 29);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgvSistemas
            // 
            dgvSistemas.AllowUserToAddRows = false;
            dgvSistemas.AllowUserToDeleteRows = false;
            dgvSistemas.AllowUserToOrderColumns = true;
            dgvSistemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSistemas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSistemas.BackgroundColor = Color.White;
            dgvSistemas.BorderStyle = BorderStyle.Fixed3D;
            dgvSistemas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 94, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 94, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSistemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSistemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSistemas.EnableHeadersVisualStyles = false;
            dgvSistemas.GridColor = Color.FromArgb(10, 94, 42);
            dgvSistemas.Location = new Point(6, 140);
            dgvSistemas.Name = "dgvSistemas";
            dgvSistemas.ReadOnly = true;
            dgvSistemas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(166, 211, 12);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSistemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSistemas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(166, 211, 12);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvSistemas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSistemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSistemas.Size = new Size(603, 194);
            dgvSistemas.TabIndex = 0;
            dgvSistemas.MouseClick += dgvSistemas_MouseClick;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnEliminar);
            panelMenu.Controls.Add(btnGuardar);
            panelMenu.Controls.Add(btnNuevo);
            panelMenu.Location = new Point(3, 32);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(625, 34);
            panelMenu.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = Properties.Resources.eliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(71, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(30, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = Properties.Resources.salvar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(37, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(30, 30);
            btnGuardar.TabIndex = 1;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.BackgroundImage = Properties.Resources.nueva;
            btnNuevo.BackgroundImageLayout = ImageLayout.Zoom;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(30, 30);
            btnNuevo.TabIndex = 0;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvNegociosPos
            // 
            dgvNegociosPos.AllowUserToAddRows = false;
            dgvNegociosPos.AllowUserToDeleteRows = false;
            dgvNegociosPos.AllowUserToOrderColumns = true;
            dgvNegociosPos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvNegociosPos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNegociosPos.BackgroundColor = Color.White;
            dgvNegociosPos.BorderStyle = BorderStyle.Fixed3D;
            dgvNegociosPos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 94, 42);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 94, 42);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvNegociosPos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvNegociosPos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNegociosPos.EnableHeadersVisualStyles = false;
            dgvNegociosPos.GridColor = Color.FromArgb(10, 94, 42);
            dgvNegociosPos.Location = new Point(6, 6);
            dgvNegociosPos.Name = "dgvNegociosPos";
            dgvNegociosPos.ReadOnly = true;
            dgvNegociosPos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(166, 211, 12);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvNegociosPos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNegociosPos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(166, 211, 12);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvNegociosPos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvNegociosPos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNegociosPos.Size = new Size(603, 331);
            dgvNegociosPos.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabParmGen);
            tabControl1.Controls.Add(tabSistema);
            tabControl1.Controls.Add(tabNegPos);
            tabControl1.Location = new Point(5, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(623, 368);
            tabControl1.TabIndex = 9;
            // 
            // tabParmGen
            // 
            tabParmGen.Controls.Add(defnavcb);
            tabParmGen.Controls.Add(defjavcb);
            tabParmGen.Controls.Add(deforacb);
            tabParmGen.Controls.Add(groupBox1);
            tabParmGen.Controls.Add(ActuScb);
            tabParmGen.Controls.Add(label6);
            tabParmGen.Controls.Add(label5);
            tabParmGen.Controls.Add(label4);
            tabParmGen.Controls.Add(label3);
            tabParmGen.Controls.Add(label2);
            tabParmGen.Controls.Add(codciatxt);
            tabParmGen.Controls.Add(sisttxt);
            tabParmGen.Controls.Add(javatxt);
            tabParmGen.Controls.Add(navegadortxt);
            tabParmGen.Controls.Add(oracletxt);
            tabParmGen.Location = new Point(4, 24);
            tabParmGen.Name = "tabParmGen";
            tabParmGen.Size = new Size(615, 340);
            tabParmGen.TabIndex = 2;
            tabParmGen.Text = "Parametros Generales";
            tabParmGen.UseVisualStyleBackColor = true;
            // 
            // defnavcb
            // 
            defnavcb.AutoSize = true;
            defnavcb.Location = new Point(429, 173);
            defnavcb.Name = "defnavcb";
            defnavcb.Size = new Size(167, 19);
            defnavcb.TabIndex = 19;
            defnavcb.Text = "Usar directorio por defecto";
            defnavcb.UseVisualStyleBackColor = true;
            defnavcb.CheckedChanged += defnavcb_CheckedChanged;
            // 
            // defjavcb
            // 
            defjavcb.AutoSize = true;
            defjavcb.Location = new Point(429, 126);
            defjavcb.Name = "defjavcb";
            defjavcb.Size = new Size(167, 19);
            defjavcb.TabIndex = 18;
            defjavcb.Text = "Usar directorio por defecto";
            defjavcb.UseVisualStyleBackColor = true;
            defjavcb.CheckedChanged += defjavcb_CheckedChanged;
            // 
            // deforacb
            // 
            deforacb.AutoSize = true;
            deforacb.Location = new Point(429, 80);
            deforacb.Name = "deforacb";
            deforacb.Size = new Size(167, 19);
            deforacb.TabIndex = 17;
            deforacb.Text = "Usar directorio por defecto";
            deforacb.UseVisualStyleBackColor = true;
            deforacb.CheckedChanged += deforacb_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(servidortxt);
            groupBox1.Controls.Add(logtxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.ForeColor = Color.FromArgb(10, 94, 42);
            groupBox1.Location = new Point(3, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 115);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizaciones";
            // 
            // servidortxt
            // 
            servidortxt.Enabled = false;
            servidortxt.Location = new Point(7, 39);
            servidortxt.Name = "servidortxt";
            servidortxt.Size = new Size(594, 23);
            servidortxt.TabIndex = 1;
            // 
            // logtxt
            // 
            logtxt.Enabled = false;
            logtxt.Location = new Point(7, 83);
            logtxt.Name = "logtxt";
            logtxt.Size = new Size(594, 23);
            logtxt.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 21);
            label8.Name = "label8";
            label8.Size = new Size(151, 15);
            label8.TabIndex = 13;
            label8.Text = "Servidor de Actualizaciones";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 65);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 12;
            label7.Text = "Log de Actualizaciones";
            // 
            // ActuScb
            // 
            ActuScb.AutoSize = true;
            ActuScb.Location = new Point(0, 198);
            ActuScb.Name = "ActuScb";
            ActuScb.Size = new Size(127, 19);
            ActuScb.TabIndex = 15;
            ActuScb.Text = "Actualizar Sistemas";
            ActuScb.UseVisualStyleBackColor = true;
            ActuScb.CheckedChanged += ActuScb_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 151);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "Ruta Navegador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 104);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 10;
            label5.Text = "Ruta Java";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Ruta Oracle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 13);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 8;
            label3.Text = "Sistema";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Compañia";
            // 
            // codciatxt
            // 
            codciatxt.Enabled = false;
            codciatxt.Location = new Point(3, 31);
            codciatxt.Name = "codciatxt";
            codciatxt.Size = new Size(141, 23);
            codciatxt.TabIndex = 6;
            // 
            // sisttxt
            // 
            sisttxt.Enabled = false;
            sisttxt.Location = new Point(173, 31);
            sisttxt.Name = "sisttxt";
            sisttxt.Size = new Size(241, 23);
            sisttxt.TabIndex = 5;
            // 
            // javatxt
            // 
            javatxt.Location = new Point(3, 122);
            javatxt.Name = "javatxt";
            javatxt.Size = new Size(411, 23);
            javatxt.TabIndex = 4;
            // 
            // navegadortxt
            // 
            navegadortxt.Location = new Point(3, 169);
            navegadortxt.Name = "navegadortxt";
            navegadortxt.Size = new Size(411, 23);
            navegadortxt.TabIndex = 3;
            // 
            // oracletxt
            // 
            oracletxt.Location = new Point(3, 78);
            oracletxt.Name = "oracletxt";
            oracletxt.Size = new Size(411, 23);
            oracletxt.TabIndex = 0;
            // 
            // tabSistema
            // 
            tabSistema.Controls.Add(label18);
            tabSistema.Controls.Add(iconoTxt);
            tabSistema.Controls.Add(label15);
            tabSistema.Controls.Add(carpetaTxt);
            tabSistema.Controls.Add(label14);
            tabSistema.Controls.Add(inicioEnTxt);
            tabSistema.Controls.Add(label13);
            tabSistema.Controls.Add(tipoTxt);
            tabSistema.Controls.Add(label12);
            tabSistema.Controls.Add(param2Txt);
            tabSistema.Controls.Add(label11);
            tabSistema.Controls.Add(param1Txt);
            tabSistema.Controls.Add(label10);
            tabSistema.Controls.Add(nombreTxt);
            tabSistema.Controls.Add(label9);
            tabSistema.Controls.Add(idTxt);
            tabSistema.Controls.Add(dgvSistemas);
            tabSistema.Location = new Point(4, 24);
            tabSistema.Name = "tabSistema";
            tabSistema.Padding = new Padding(3);
            tabSistema.Size = new Size(615, 340);
            tabSistema.TabIndex = 0;
            tabSistema.Text = "Sistemas";
            tabSistema.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(367, 49);
            label15.Name = "label15";
            label15.Size = new Size(107, 15);
            label15.TabIndex = 21;
            label15.Text = "Carpeta de sistema";
            // 
            // carpetaTxt
            // 
            carpetaTxt.Location = new Point(367, 67);
            carpetaTxt.Name = "carpetaTxt";
            carpetaTxt.Size = new Size(242, 23);
            carpetaTxt.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(122, 49);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 19;
            label14.Text = "Iniciar en...";
            // 
            // inicioEnTxt
            // 
            inicioEnTxt.Location = new Point(122, 67);
            inicioEnTxt.Name = "inicioEnTxt";
            inicioEnTxt.Size = new Size(239, 23);
            inicioEnTxt.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 49);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 17;
            label13.Text = "Tipo *";
            // 
            // tipoTxt
            // 
            tipoTxt.Location = new Point(6, 67);
            tipoTxt.Name = "tipoTxt";
            tipoTxt.Size = new Size(110, 23);
            tipoTxt.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(413, 3);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 15;
            label12.Text = "Parámetro 2";
            // 
            // param2Txt
            // 
            param2Txt.Location = new Point(413, 21);
            param2Txt.Name = "param2Txt";
            param2Txt.Size = new Size(196, 23);
            param2Txt.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(201, 3);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 13;
            label11.Text = "Parámetro 1";
            // 
            // param1Txt
            // 
            param1Txt.Location = new Point(201, 21);
            param1Txt.Name = "param1Txt";
            param1Txt.Size = new Size(206, 23);
            param1Txt.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 3);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 11;
            label10.Text = "Nombre *";
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(54, 21);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(141, 23);
            nombreTxt.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 9;
            label9.Text = "ID";
            // 
            // idTxt
            // 
            idTxt.Enabled = false;
            idTxt.Location = new Point(6, 21);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(42, 23);
            idTxt.TabIndex = 8;
            // 
            // tabNegPos
            // 
            tabNegPos.Controls.Add(dgvNegociosPos);
            tabNegPos.Controls.Add(label16);
            tabNegPos.Controls.Add(textBox1);
            tabNegPos.Controls.Add(label17);
            tabNegPos.Controls.Add(textBox2);
            tabNegPos.Location = new Point(4, 24);
            tabNegPos.Name = "tabNegPos";
            tabNegPos.Padding = new Padding(3);
            tabNegPos.Size = new Size(615, 340);
            tabNegPos.TabIndex = 1;
            tabNegPos.Text = "Negocios OpenPos";
            tabNegPos.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(53, 3);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 15;
            label16.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 3);
            label17.Name = "label17";
            label17.Size = new Size(18, 15);
            label17.TabIndex = 13;
            label17.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(42, 23);
            textBox2.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 93);
            label18.Name = "label18";
            label18.Size = new Size(100, 15);
            label18.TabIndex = 23;
            label18.Text = "Nombre de Icono";
            // 
            // iconoTxt
            // 
            iconoTxt.Location = new Point(6, 111);
            iconoTxt.Name = "iconoTxt";
            iconoTxt.Size = new Size(139, 23);
            iconoTxt.TabIndex = 22;
            // 
            // ParametrosFrm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(631, 450);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(10, 94, 42);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametrosFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parámetros Lanzador";
            Load += ParametrosFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSistemas).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNegociosPos).EndInit();
            tabControl1.ResumeLayout(false);
            tabParmGen.ResumeLayout(false);
            tabParmGen.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabSistema.ResumeLayout(false);
            tabSistema.PerformLayout();
            tabNegPos.ResumeLayout(false);
            tabNegPos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_ayuda;
        private Button btn_minimizar;
        private Button btn_salir;
        private Panel panel2;
        private DataGridView dgvSistemas;
        private Panel panelMenu;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dgvNegociosPos;
        private TabControl tabControl1;
        private TabPage tabSistema;
        private TabPage tabNegPos;
        private TabPage tabParmGen;
        private TextBox codciatxt;
        private TextBox sisttxt;
        private TextBox javatxt;
        private TextBox navegadortxt;
        private TextBox logtxt;
        private TextBox servidortxt;
        private TextBox oracletxt;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox ActuScb;
        private CheckBox defnavcb;
        private CheckBox defjavcb;
        private CheckBox deforacb;
        private Label label15;
        private TextBox carpetaTxt;
        private Label label14;
        private TextBox inicioEnTxt;
        private Label label13;
        private TextBox tipoTxt;
        private Label label12;
        private TextBox param2Txt;
        private Label label11;
        private TextBox param1Txt;
        private Label label10;
        private TextBox nombreTxt;
        private Label label9;
        private TextBox idTxt;
        private Label label16;
        private TextBox textBox1;
        private Label label17;
        private TextBox textBox2;
        private Label label18;
        private TextBox iconoTxt;
    }
}