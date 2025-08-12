using Sistemas_CAG.Controlador;
using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Modelos.Entidad.Convertidores;
using System.Data;
using System.Reflection;

namespace Sistemas_CAG
{
    public partial class LanzadorFrm : Form
    {
        int pX = 0;
        int pY = 0;
        public LanzadorFrm()
        {
            InitializeComponent();

        }
        ParametrosControl parametrosControl =new ParametrosControl();

        LanzadorControl lanzar = new LanzadorControl();

        private void LanzadorFrm_Load(object sender, EventArgs e)
        {

            int deskHeight = Screen.PrimaryScreen.Bounds.Height;

            int deskWidth = Screen.PrimaryScreen.Bounds.Width;

            this.Location = new Point(deskWidth - this.Width, deskHeight - this.Height);

            lblNotificacion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version; 

            CrearBotonesDinamicos();
            
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                pX = e.X;
                pY = e.Y;
            }
            else
            {
                Left = Left + (e.X - pX);
                Top = Top + (e.Y - pY);
            }
        }


        private void LanzadorFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Si está minimizándose se muestra la notificación
                this.ntf_Lanzador.Visible = true;
                this.ShowInTaskbar = false;
            }
            else
            {
                // Si no se está minimizando se esconde a notificación
                this.ntf_Lanzador.Visible = true;
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Al hacer doble clic en el icono de la bandeja se muestra la ventana normalmente
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;

            }


        }

        //Cambio de tema de color
        private void ck_tema_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_tema.Checked == true)
            {
                //Modo blanco
                this.BackColor = Color.FromArgb(27, 27, 27);
                this.ForeColor = Color.White;
                tabPage1.ForeColor = Color.White;
                tabPage1.BackColor = Color.FromArgb(27, 27, 27);
                tabPage2.ForeColor = Color.White;
                tabPage2.BackColor = Color.FromArgb(27, 27, 27);
                tabPage3.ForeColor = Color.White;
                tabPage3.BackColor = Color.FromArgb(27, 27, 27);
                tabControl1.BackColor = Color.FromArgb(27, 27, 27);
            }
            else
            {
                //Modo oscuro
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage1.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage1.BackColor = Color.White;
                tabPage2.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage2.BackColor = Color.White;
                tabPage3.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage3.BackColor = Color.White;
                tabControl1.BackColor = Color.White;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void lblNotificacion_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_config_Click(object sender, EventArgs e)
        {
            ParametrosFrm frm = new ParametrosFrm();
            frm.ShowDialog();
        }

        
       

        private void CrearBotonesDinamicos()
        {

            fLPDesktop.Controls.Clear();

            DataTable registros = parametrosControl.CargaTablaSistema();

            foreach (DataRow row in registros.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string nombre = row["Nombre"].ToString();
                string imagenNombre = row["Icono"].ToString();
                string rutaImagen = Path.Combine(Application.StartupPath, "Resources", "Iconos", imagenNombre);

                //Botones dinamicos
                SistemaButton btn = new SistemaButton();
                btn.Id = id;
                btn.NombreSistema = nombre;
                btn.Tipo = row["Tipo"].ToString();
                btn.IniciarEn = row["IniciarEn"].ToString();
                btn.CarpetaSistema = row["CarpetaSistema"].ToString();
                btn.Parametro1 = row["Parametro1"].ToString();
                btn.Parametro2 = row["Parametro2"].ToString();
                btn.Name = "btn_" + id;
                btn.Tag = id;
                btn.ToolTipText = nombre;
                btn.Size = new Size(65, 65);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(166, 211, 12);
                btn.Cursor = Cursors.Hand;
                btn.UseVisualStyleBackColor = false;


                if (File.Exists(rutaImagen))
                    btn.BackgroundImage = Image.FromFile(rutaImagen);
                else
                {
                    string rutaDefault = Path.Combine(Application.StartupPath, "Resources", "Iconos", "default.png");
                    if (File.Exists(rutaDefault))
                        btn.BackgroundImage = Image.FromFile(rutaDefault);
                }

                //Etiquetas dinamicas
                Label etiqueta = new Label();
                etiqueta.Text = nombre;
                etiqueta.TextAlign = ContentAlignment.MiddleCenter;
                etiqueta.Dock = DockStyle.Bottom;
                etiqueta.Height = 20;
                etiqueta.AutoSize = false;
                etiqueta.Font = new Font("Microsoft Sans Serif", 7F);

                Panel contenedor = new Panel();
                contenedor.Width = btn.Width;
                contenedor.Height = btn.Height + etiqueta.Height + 5;
                contenedor.Margin = new Padding(5);
                contenedor.Controls.Add(btn);
                contenedor.Controls.Add(etiqueta);

                btn.Dock = DockStyle.Top;


                btn.Click += BotonDinamico_Click;
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(btn, btn.ToolTipText);


                if (btn.Tipo == "oracle" || btn.Tipo == "exe" || btn.Tipo == "java")
                {
                    fLPDesktop.Controls.Add(contenedor);
                }
                else if (btn.Tipo == "web" || btn.Tipo == "javaws")
                {
                    fLPWeb.Controls.Add(contenedor);
                }
                else if (btn.Tipo == "servidor")
                {
                    fLPServer.Controls.Add(contenedor);
                }
            }

        }

        private void BotonDinamico_Click(object sender, EventArgs e)
        {
            SistemaButton btn = sender as SistemaButton;
            SistemaDTO sistemaDto = btn.ToDTO();
            NegocioDTO negocioResult = new NegocioDTO();

            if(btn.NombreSistema == "kiosco" || btn.NombreSistema == "facturacion" || btn.NombreSistema == "preventa")
            {
                NegocioFrm negocioFrm = new NegocioFrm();
                if (negocioFrm.ShowDialog() == DialogResult.OK)
                {

                    negocioResult = negocioFrm.negocioResult;


                }
                else
                {
                    return;
                }
            }


            lanzar.lanzarAplicacion(sistemaDto, negocioResult);
            
        }
















    }
}
