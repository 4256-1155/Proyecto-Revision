﻿using GestionCasos.Administrador;
using GestionCasos.Configuracion;
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

namespace GestionCasos
{
    public partial class Principal : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Principal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        Registrar llamarRegistrar = new Registrar();
        AsignarCaso llamarAsignarCaso = new AsignarCaso();
        private void Principal_Load(object sender, EventArgs e)
        {
            SetPanelDefault();
            SetThemeColor();
        }

        private void SetThemeColor()
        {
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                this.BackColor = Color.FromArgb(41, 79, 116);
                this.DesktopPanel.BackColor = Color.FromArgb(41, 79, 116);
                this.DesktopPanel.ForeColor = Color.White;

                this.pnLateralIzquierda.BackColor = Color.FromArgb(41, 79, 116);
                this.pnLateralIzquierda.ForeColor = Color.White;
            }
            else
            {

            }
        }

        private void SetPanelDefault()
        {
            Color color;
            fDashBoard dashBoard = new fDashBoard();
            dashBoard.TopLevel = false;
            dashBoard.FormBorderStyle = FormBorderStyle.None;
            dashBoard.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(dashBoard);
            if (ConfigurationManager.AppSettings["DarkMode"] == "false")
            {
                color = Color.FromArgb(66, 100, 128);
            }
            else
            {
                color = Color.FromArgb(9, 12, 16);
            }
            currentButton = this.btnDashBoard;
            currentButton.BackColor = color;
            dashBoard.Show();
        }


        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fContador(), sender);
        }
 
        private void btnAsignarCasos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AsignarCaso(), sender);
        }

        private void btnDashBoard_MouseEnter(object sender, EventArgs e)
        {
            btnDashBoard.BackColor = Color.FromArgb(9, 12, 16);
        }


        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color;
                    if (ConfigurationManager.AppSettings["DarkMode"] == "false")
                    {
                        color = Color.FromArgb(66, 100, 128);

                    }
                    else
                    {
                        color = Color.FromArgb(9, 12, 16);
                    }
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnLateralIzquierda.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color;
                    if (ConfigurationManager.AppSettings["DarkMode"] == "false")
                    {
                        color = Color.FromArgb(41, 79, 116);

                    }
                    else
                    {
                        color = Color.FromArgb(33, 38, 45);
                    }
                    previousBtn.BackColor = color;
                }
            }
        }


        //Pintar formulario hijo
        //Formulario en uso
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDashBoard(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fConfiguraciones(),sender);
        }

        private void btnJuntas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fInstituciones(), sender);
        }
    }

}
