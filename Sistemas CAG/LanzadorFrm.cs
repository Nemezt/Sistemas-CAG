
using Sistemas_CAG.Entidad;
using Sistemas_CAG.Logica;

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
        SistemaParam sistema = new SistemaParam();
        LanzadorControl lanzar = new LanzadorControl();
        NegocioPos negocio = new NegocioPos();

        private void LanzadorFrm_Load(object sender, EventArgs e)
        {
            rbt_srm.Checked = true;
            rbt_opos.Checked = true;
            cb_OPos.Enabled = false;

            int deskHeight = Screen.PrimaryScreen.Bounds.Height;

            int deskWidth = Screen.PrimaryScreen.Bounds.Width;

            this.Location = new Point(deskWidth - this.Width, deskHeight - this.Height);

            lblNotificacion.Text = "v" + sistema.Version;

            //Carga de los negocios Openpos
            cb_OPos.DataSource = negocio.consultaNegocios();
            cb_OPos.DisplayMember = "Negocio";
            cb_OPos.ValueMember = "Negocio";
            cb_OPos.SelectedIndex = -1;



            //Carga de los servidores 
            cb_ServAdmin.DataSource = sistema.consultaTipoSistemas("servidor");
            cb_ServAdmin.DisplayMember = "Nombre";
            cb_ServAdmin.ValueMember = "Nombre";
            cb_ServAdmin.SelectedIndex = -1;

            //Carga de los Sistemas Web 
            cb_SistWeb.DataSource = sistema.consultaTipoSistemas("web");
            cb_SistWeb.DisplayMember = "Nombre";
            cb_SistWeb.ValueMember = "Nombre";
            cb_SistWeb.SelectedIndex = -1;
        }
        private void btn_srm_Click(object sender, EventArgs e)
        {
            if (rbt_marcar.Checked == true)
            {
                sistema.NombreSistema = "SRMMarcar";
            }
            else if (rbt_sinc.Checked == true)
            {
                sistema.NombreSistema = "SRMSincronizar";
            }
            else
            {
                sistema.NombreSistema = "SRM";
            }

            lanzar.lanzarAplicacion(sistema);

        }

        private void btn_agricli_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Agri_cli";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_AgrScr_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Agri_scre6i";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_agros_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Agros";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_desazu_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Desazu";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Password";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_notif_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Notificaciones";
            lanzar.lanzarAplicacion(sistema);
        }


        private void btn_sitra_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Sitra";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_entrega_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "EntregaDesktop";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_siceca_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Siceca";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_oside_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Side6i";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_opos_Click(object sender, EventArgs e)
        {
            if (rbt_preventa.Checked == true)
            {
                MessageBox.Show("Debe verificar el directorio establecido del parametro " +
                    "DIR_CAJ indicado en el pos.ini", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!(cb_OPos.Text == ""))
                {
                    sistema.NombreSistema = "preventa";
                    sistema.Negocio = cb_OPos.Text;
                    sistema.Estacion = txt_Estacion.Text;
                }
                else
                {
                    sistema.NombreSistema = null;
                    sistema.Negocio = null;
                    sistema.Estacion = null;
                }
            }
            else if (rbt_facturacion.Checked == true)
            {
                MessageBox.Show("Debe verificar el directorio establecido del parametro " +
                    "DIR_CAJ indicado en el pos.ini", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!(cb_OPos.Text == ""))
                {
                    sistema.NombreSistema = "facturacion";
                    sistema.Negocio = cb_OPos.Text;
                    sistema.Estacion = txt_Estacion.Text;
                }
                else
                {
                    sistema.NombreSistema = null;
                    sistema.Negocio = null;
                    sistema.Estacion = null;
                }
            }
            else if (rbt_kiosco.Checked == true)
            {
                if (!(cb_OPos.Text == ""))
                {
                    sistema.NombreSistema = "kiosco";
                    sistema.Negocio = cb_OPos.Text;
                }
                else
                {
                    sistema.NombreSistema = null;
                    sistema.Negocio = null;
                }

            }
            else
            {
                sistema.NombreSistema = "openpos60";
                sistema.Parametro2 = null;
            }

            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_indicad_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Indicadores";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_otouch_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "OpenTouch";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_parqueo_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Parqueo";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_recibidor_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Recibidor";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_seem_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Seem";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_sicofe_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Sicofe";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_sica_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "Sica";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_sirpe_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "SirpeDesktop";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_eco_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "E-co";
            lanzar.lanzarAplicacion(sistema);
        }
        private void btn_saac_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "SAAC";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_mcr_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "MCR";
            lanzar.lanzarAplicacion(sistema);
        }

        private void btn_admsis_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "adminsis";
            lanzar.lanzarAplicacion(sistema);
        }


        private void rbt_opos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_opos.Checked == true)
            {
                cb_OPos.Enabled = false;
                cb_OPos.SelectedIndex = -1;
                txt_Estacion.Enabled = false;
                txt_Estacion.Clear();

            }
            else
            {
                cb_OPos.Enabled = true;
                txt_Estacion.Enabled = true;

            }
        }

        private void rbt_kiosco_CheckedChanged(object sender, EventArgs e)
        {
            // if (rbt_kiosco.Checked == true)
            //  {
            //      cb_OPos.Enabled = true;

            // }
            // else
            //  {
            //      cb_OPos.Enabled = false;
            //       cb_OPos.SelectedIndex = -1;
            //  }
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
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;
                groupbox4.ForeColor = Color.White;
                groupBox5.ForeColor = Color.White;
                groupBox6.ForeColor = Color.White;
                groupBox7.ForeColor = Color.White;
                tabPage1.ForeColor = Color.White;
                tabPage1.BackColor = Color.FromArgb(27, 27, 27);
                tabPage2.ForeColor = Color.White;
                tabPage2.BackColor = Color.FromArgb(27, 27, 27);
                tabPage3.ForeColor = Color.White;
                tabPage3.BackColor = Color.FromArgb(27, 27, 27);
                tabPage4.ForeColor = Color.White;
                tabPage4.BackColor = Color.FromArgb(27, 27, 27);
                tabControl1.BackColor = Color.FromArgb(27, 27, 27);
            }
            else
            {
                //Modo oscuro
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox1.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox2.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox3.ForeColor = Color.FromArgb(10, 94, 42);
                groupbox4.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox5.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox6.ForeColor = Color.FromArgb(10, 94, 42);
                groupBox7.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage1.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage1.BackColor = Color.White;
                tabPage2.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage2.BackColor = Color.White;
                tabPage3.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage3.BackColor = Color.White;
                tabPage4.ForeColor = Color.FromArgb(10, 94, 42);
                tabPage4.BackColor = Color.White;
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

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            ParametrosFrm frm = new ParametrosFrm();
            frm.ShowDialog();
        }

        public void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


        }

        public void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void saacDesa_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "saac_desa";
            lanzar.lanzarAplicacion(sistema);
        }

        private void mcrDesa_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "mcr_desa";
            lanzar.lanzarAplicacion(sistema);
        }

        private void saacPre_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "saac_pre";
            lanzar.lanzarAplicacion(sistema);
        }

        private void mcrPre_Click(object sender, EventArgs e)
        {
            sistema.NombreSistema = "mcr_pre";
            lanzar.lanzarAplicacion(sistema);
        }

        private void servDesa_Click(object sender, EventArgs e)
        {
            if (!(cb_ServAdmin.Text == ""))
            {
                sistema.NombreSistema = cb_ServAdmin.Text;
                lanzar.lanzarAplicacion(sistema);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un servidor de sistemas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txt_Estacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 2)
                    e.Handled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sisWeb_Click(object sender, EventArgs e)
        {
            if (!(cb_SistWeb.Text == ""))
            {
                sistema.NombreSistema = cb_SistWeb.Text;
                lanzar.lanzarAplicacion(sistema);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un sistema web", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
