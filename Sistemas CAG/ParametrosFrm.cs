using Sistemas_CAG.Controlador;
using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Modelos.Servicios;
using Sistemas_CAG.Utils;


namespace Sistemas_CAG
{
    public partial class ParametrosFrm : Form
    {
        int pX = 0;
        int pY = 0;

        InicioAutomatico InicioAuto = new InicioAutomatico();
        ParametrosDTO ParametrosGen = new ParametrosDTO();
        NegocioRepository negocioRepository = new NegocioRepository();
        ParametrosControl parametrosControl = new ParametrosControl();
        public ParametrosFrm()
        {
            InitializeComponent();
        }
        private void ParametrosFrm_Load(object sender, EventArgs e)
        {

            cargaDatos();

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


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(●'◡'●) []~(￣▽￣)~* Invitame a un café", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (tabSistema.Focus() == true)
            {
                LimpiarSistema();

            }
            else if (tabNegPos.Focus() == true)
            {
                //LimpiarNegocio();
            }
            else if (tabParmGen.Focus() == true)
            {
                CargarParametrosGenerales();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tabSistema.Focus() == true)
            {
                GuardarSistemas();
            }
            else if (tabNegPos.Focus() == true)
            {
                //guardarNegociosPos();
            }
            else if (tabParmGen.Focus() == true)
            {
                GuardarParametrosGenerales();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tabSistema.Focus() == true)
            {
                EliminarSistemas();
            }
            else if (tabNegPos.Focus() == true)
            {
                //EliminarNegociosPos();
            }
            else if (tabParmGen.Focus() == true)
            {
                
            }
        }
        private void cargaDatos()
        {
            try
            {
                CargarTablaSistemas();

                CargarParametrosGenerales();

                dgvNegociosPos.DataSource = negocioRepository.ConsultaNegocios();

                VerificaInicioAutomatico();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        #region Parametros generales

        private void ActuScb_CheckedChanged(object sender, EventArgs e)
        {
            if (ActuScb.Checked == true)
            {

                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void deforacb_CheckedChanged(object sender, EventArgs e)
        {
            if (deforacb.Checked == true)
            {
                oracletxt.Enabled = false;
            }
            else
            {
                oracletxt.Enabled = true;
            }
        }

        private void defjavcb_CheckedChanged(object sender, EventArgs e)
        {
            if (defjavcb.Checked == true)
            {
                javatxt.Enabled = false;
            }
            else
            {
                javatxt.Enabled = true;
            }
        }

        private void defnavcb_CheckedChanged(object sender, EventArgs e)
        {
            if (defnavcb.Checked == true)
            {
                navegadortxt.Enabled = false;
            }
            else
            {
                navegadortxt.Enabled = true;
            }

        }



        private void GuardarParametrosGenerales()
        {

            try
            {
                ParametrosGen.OracleForms = oracletxt.Text;
                ParametrosGen.JavaHome = javatxt.Text;
                ParametrosGen.ServidorActualizacion = servidortxt.Text;
                ParametrosGen.NavegadorWeb = navegadortxt.Text;
                ParametrosGen.LogSistema = logtxt.Text;

                if (ActuScb.Checked == true)
                {
                    ParametrosGen.Actualiza = "S";

                }
                else
                {
                    ParametrosGen.Actualiza = "N";
                }

                if (deforacb.Checked == true)
                {
                    ParametrosGen.DefOracle = "S";

                }
                else
                {
                    ParametrosGen.DefOracle = "N";
                }

                if (defjavcb.Checked == true)
                {
                    ParametrosGen.DefJava = "S";

                }
                else
                {
                    ParametrosGen.DefJava = "N";
                }

                if (defnavcb.Checked == true)
                {
                    ParametrosGen.DefNavegador = "S";

                }
                else
                {
                    ParametrosGen.DefNavegador = "N";
                }

                if (autoInicioCb.Checked == true)
                {
                    InicioAuto.RegistrarInicioAutomatico();

                }
                else
                {
                    InicioAuto.EliminarInicioAutomatico();

                }

                if (parametrosControl.ActualizaParametros(ParametrosGen))
                {
                    MessageBox.Show("Se guardaron los parametros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los parametros genreales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void CargarParametrosGenerales()
        {
            ParametrosGen = parametrosControl.ConsultaParametros();
            codciatxt.Text = ParametrosGen.COD_CIA;
            sisttxt.Text = ParametrosGen.Sistema;
            oracletxt.Text = ParametrosGen.OracleForms;
            javatxt.Text = ParametrosGen.JavaHome;
            navegadortxt.Text = ParametrosGen.NavegadorWeb;
            servidortxt.Text = ParametrosGen.ServidorActualizacion;
            logtxt.Text = ParametrosGen.LogSistema;

            if (ParametrosGen.Actualiza == "S")
            {
                ActuScb.Checked = true;
            }
            else
            {
                ActuScb.Checked = false;
            }

            if (ParametrosGen.DefOracle == "S")
            {
                deforacb.Checked = true;
            }
            else
            {
                deforacb.Checked = false;
            }

            if (ParametrosGen.DefJava == "S")
            {
                defjavcb.Checked = true;
            }
            else
            {
                defjavcb.Checked = false;
            }

            if (ParametrosGen.DefNavegador == "S")
            {
                defnavcb.Checked = true;
            }
            else
            {
                defnavcb.Checked = false;
            }

            if (ActuScb.Checked == true)
            {

                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }




        public void VerificaInicioAutomatico()
        {
            if (InicioAuto.ExisteInicioAutomatico())
            {
                autoInicioCb.Checked = true;
            }
            else
            {
                autoInicioCb.Checked = false;
            }
        }

















        #endregion

        #region Sistemas

        private void EliminarSistemas()
        {


                bool accion = false;
                if (!string.IsNullOrEmpty(idTxt.Text))
                {
                    DialogResult resultado = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2
                        );

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            accion = parametrosControl.BorrarSistema(Convert.ToInt32(idTxt.Text));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (accion)
                {
                    MessageBox.Show("Se eliminaron los datos", "ELiminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LimpiarSistema();
                }
            
        }

        private void GuardarSistemas()
        {
            if (string.IsNullOrEmpty(nombreTxt.Text) || string.IsNullOrEmpty(tipoCbx.Text))
            {

                MessageBox.Show("Ingrese los datos requeridos *", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                SistemaDTO sistema = new SistemaDTO();

                sistema.NombreSistema = nombreTxt.Text;
                sistema.Parametro1 = param1Txt.Text;
                sistema.Parametro2 = param2Txt.Text;
                sistema.Tipo = tipoCbx.Text;
                sistema.IniciarEn = inicioEnTxt.Text;
                sistema.CarpetaSistema = carpetaTxt.Text;
                sistema.Icono = iconoTxt.Text;

                bool accion = false;
                if (string.IsNullOrEmpty(idTxt.Text))
                {
                    try
                    {
                        accion = parametrosControl.InsertaSistema(sistema);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    sistema.Id = Convert.ToInt32(idTxt.Text);
                    try
                    {

                        accion = parametrosControl.ActualizaSistema(sistema); ;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (accion)
                {
                    MessageBox.Show("Se guardaron los datos del sistema", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarSistema();
            }
        }


        private void CargarTablaSistemas()
        {
            dgvSistemas.DataSource = parametrosControl.CargaTablaSistema();
        }



        private void dgvSistemas_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvSistemas.CurrentRow != null && dgvSistemas.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvSistemas.CurrentRow;

                idTxt.Text = dgvSistemas.CurrentRow.Cells["ID"].Value.ToString();
                nombreTxt.Text = dgvSistemas.CurrentRow.Cells["NOMBRE"].Value.ToString();
                param1Txt.Text = dgvSistemas.CurrentRow.Cells["PARAMETRO1"].Value.ToString();
                param2Txt.Text = dgvSistemas.CurrentRow.Cells["PARAMETRO2"].Value.ToString();              
                inicioEnTxt.Text = dgvSistemas.CurrentRow.Cells["INICIAREN"].Value.ToString();
                carpetaTxt.Text = dgvSistemas.CurrentRow.Cells["CARPETASISTEMA"].Value.ToString();
                iconoTxt.Text = dgvSistemas.CurrentRow.Cells["ICONO"].Value.ToString();
                tipoCbx.Text = dgvSistemas.CurrentRow.Cells["TIPO"].Value.ToString();

            }
        }

        private void LimpiarSistema()
        {
            idTxt.Clear();
            nombreTxt.Clear();
            param1Txt.Clear();
            param2Txt.Clear();
            inicioEnTxt.Clear();
            carpetaTxt.Clear();
            iconoTxt.Clear();
            tipoCbx.SelectedIndex = 0;
            CargarTablaSistemas();

        }

        #endregion

    }
}
