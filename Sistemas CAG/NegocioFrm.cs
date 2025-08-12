using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Modelos.Servicios;


namespace Sistemas_CAG
{
    public partial class NegocioFrm : Form
    {
        int pX = 0;
        int pY = 0;

        NegocioRepository negocioRepository = new NegocioRepository();

        public NegocioDTO negocioResult { get; private set; }

        public NegocioFrm()
        {
            InitializeComponent();

        }

        private void NegocioFrm_Load(object sender, EventArgs e)
        {
            try
            {
                cb_OPos.DataSource = negocioRepository.ConsultaNegocios();
                cb_OPos.DisplayMember = "Negocio";
                cb_OPos.ValueMember = "Negocio";
                cb_OPos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void txt_Estacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if ((sender as TextBox).Text.Count(Char.IsDigit) >= 2)
                    e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            negocioResult = new NegocioDTO();
            negocioResult.Negocio = cb_OPos.Text;
            negocioResult = CargaNegocioPos(negocioResult);

            negocioResult.Estacion = estacionTxt.Text;
            negocioResult.TipoEstacion = tipoEstacionTxt.Text;

            if (cb_OPos.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un negocio comercial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private NegocioDTO CargaNegocioPos(NegocioDTO nNegocio)
        {
            try
            {
                nNegocio = negocioRepository.ConsultaNegocio(nNegocio);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nNegocio;

        }

        private void cb_OPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioDTO negocioDTO = new NegocioDTO();
            negocioDTO.Negocio = cb_OPos.Text;
            negocioDTO = CargaNegocioPos(negocioDTO);
            estacionTxt.Text = negocioDTO.Estacion;
            tipoEstacionTxt.Text = negocioDTO.TipoEstacion;
            inventarioTxt.Text = negocioDTO.Inventario;
            servidorTxt.Text = negocioDTO.Servidor;
            
        }

    }
}
