using Sistemas_CAG.Modelos.Entidad;
using Sistemas_CAG.Modelos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_CAG
{
    public partial class ParametrosFrm : Form
    {
        int pX = 0;
        int pY = 0;

        SistemaParam ParametrosSis = new SistemaParam();
        ParametroGen ParametrosGen = new ParametroGen();
        NegocioDTO NegocioPos = new NegocioDTO();
        NegocioRepository negocioRepository = new NegocioRepository();
        public ParametrosFrm()
        {
            InitializeComponent();
        }
        private void ParametrosFrm_Load(object sender, EventArgs e)
        {
            dgvSistemas.DataSource = ParametrosSis.consultaSistemas();
            dgvNegociosPos.DataSource = negocioRepository.consultaNegocios();
            cargaParmetrosGen();

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

        }

        private void cargaParmetrosGen()
        {
            try
            {
                ParametrosGen = ParametrosGen.consultaParametros();
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
            catch (Exception ex)
            {

            }



        }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tabSistema.Focus() == true)
            {
                //guardarSistemas();
            }
            else if (tabNegPos.Focus() == true)
            {
                //guardarNegociosPos();
            }
            else if (tabParmGen.Focus() == true)
            {
                guardarParametrosGen();
            }
        }

        private void guardarParametrosGen()
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


                if (ParametrosGen.actualizaParametros(ParametrosGen))
                {
                    MessageBox.Show("Se guardaron los parametros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaParmetrosGen();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los parametros genreales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
