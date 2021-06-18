using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace GestionCasos
{
    public partial class AsignarCaso : Form
    {
        public AsignarCaso()
        {
            InitializeComponent();
        }

        private void AsignarCaso_Load(object sender, EventArgs e)
        {
            SetThemeColor();
        }
        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {

                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(9, 12, 16);
                this.panel2.ForeColor = Color.White;
                this.panel2.BackColor = Color.FromArgb(41, 79, 116);
                lbConsecutivo.ForeColor = Color.FromArgb(9, 12, 16);
                lbAsignado.ForeColor = Color.FromArgb(9, 12, 16);
                lbCircuiton.ForeColor = Color.FromArgb(9, 12, 16);
                lbCodigo.ForeColor = Color.FromArgb(9, 12, 16);
                lbFecha.ForeColor = Color.FromArgb(9, 12, 16);
                lbJunta.ForeColor = Color.FromArgb(9, 12, 16);
                lbMedioReceptivo.ForeColor = Color.FromArgb(9, 12, 16);
               

            }
            else
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso asignado con exito","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbJunta_Click(object sender, EventArgs e)
        {

        }

        private void lbCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lbAsignado_Click(object sender, EventArgs e)
        {

        }

        private void lbConsecutivo_Click(object sender, EventArgs e)
        {

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void lbMedioReceptivo_Click(object sender, EventArgs e)
        {

        }

        private void lbCircuiton_Click(object sender, EventArgs e)
        {

        }
    }
}
