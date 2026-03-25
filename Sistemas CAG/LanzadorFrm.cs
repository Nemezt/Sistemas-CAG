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

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - this.Width, workingArea.Bottom - this.Height);


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

        /// <summary>
        /// Evento para mover el formulario al arrastrar con el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento para mostrar icono en area de notificaciones de windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanzadorFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {          
                this.ntf_Lanzador.Visible = true;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ntf_Lanzador.Visible = true;
                this.ShowInTaskbar = true;
            }
        }

        /// <summary>
        /// Evento para mostrar u ocultar la ventana al hacer doble clic en el icono del area de notificaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;

            }


        }

        /// <summary>
        /// Manejo del color del fomulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ck_tema_CheckedChanged(object sender, EventArgs e)
        {
            if ( true)
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

        
        private void btn_config_Click(object sender, EventArgs e)
        {
            ParametrosFrm parametrosFrm = new ParametrosFrm();
            if (parametrosFrm.ShowDialog() == DialogResult.OK)
            {
                CrearBotonesDinamicos();

            }
            else
            {
                return;
            }
            
            
        }

        
       
        /// <summary>
        /// Creaión de botones dinamicos
        /// </summary>
        private void CrearBotonesDinamicos()
        {

            fLPDesktop.Controls.Clear();
            fLPWeb.Controls.Clear();
            fLPServer.Controls.Clear();
            try
            {
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
                    etiqueta.Width = 70;
                    etiqueta.AutoSize = false;
                    etiqueta.Font = new Font("Microsoft Sans Serif", 6.5F);

                    Panel contenedor = new Panel();
                    contenedor.Width = etiqueta.Width;
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
                    else if (btn.Tipo == "web" || btn.Tipo == "Javaws")
                    {
                        fLPWeb.Controls.Add(contenedor);
                    }
                    else if (btn.Tipo == "servidor")
                    {
                        fLPServer.Controls.Add(contenedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            

        }

        private async void BotonDinamico_Click(object sender, EventArgs e)
        {
            SistemaButton btn = sender as SistemaButton;
            SistemaDTO sistemaDto = btn.ToDTO();
            NegocioDTO negocioResult = new NegocioDTO();
            progressBarLoader.Visible = true;
            tabControl1.Enabled = false;



            try
            {
                if (btn.NombreSistema == "V-Kiosco" || btn.NombreSistema == "V-Facturacion" || btn.NombreSistema == "V-Preventa")
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

                await lanzar.lanzarAplicacion(sistemaDto, negocioResult);
            }
            finally
            {
                progressBarLoader.Visible = false;
                tabControl1.Enabled = true;

            }

        }
















    }
}
