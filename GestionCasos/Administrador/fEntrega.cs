﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using GestionCasos.Reportes;
using Negocios;
using Utilidades;

namespace GestionCasos.Administrador
{
    public partial class fEntrega : Form
    {
        private string isDark = ConfigurationManager.AppSettings["DarkMode"];
        ContadorNegocio personaNegocio = new ContadorNegocio();
        RecepcionNegocio recepcion = new RecepcionNegocio();
        EntregaNegocio entregaNegocio = new EntregaNegocio();
        EstadoNegocio estadoNegocio = new EstadoNegocio();
        RevisionNegocio revisionNegocio = new RevisionNegocio();
        showMessageDialog Message = new showMessageDialog();
        private t_EntregaCasos entregaCasos = null;
        

        public fEntrega(t_EntregaCasos id)
        {
            InitializeComponent();
            entregaCasos = id;
        }

        private void CargarDatos()
        {

            try
            {
                
                if (entregaCasos != null)
                {
                    btnGuardar.Visible = false;
                    btnPdf.Visible = true;
                    lblFecha.Visible = true;

                    txtCedula.Text = entregaCasos.Cedula;
                    txtNombre.Text = entregaCasos.t_Persona.Nombre;
                    txtApellido1.Text = entregaCasos.t_Persona.Apellido1;
                    txtApellido2.Text = entregaCasos.t_Persona.Apellido2;
                    cbTipo.SelectedIndex = (int)entregaCasos.t_Persona.TipoId;
                    cbEntrega.Text = entregaCasos.t_Recepcion.Nombre;
                    txtConsecutivo.Text = entregaCasos.t_Revision.Consecutivo;
                    lblFecha.Text = "Entregado "+entregaCasos.FechaEntrega.ToLongDateString();
                    if (entregaCasos.Pago == 0)
                    {
                        cbCheque.Checked = true;
                        cbTranferencia.Checked = false;
                    }
                    else
                    {
                        cbCheque.Checked = false;
                        cbTranferencia.Checked = true;
                    }
                }
                else
                {
                    btnGuardar.Visible = true;
                    btnPdf.Visible = false;

                    txtConsecutivo.Text = DatosTemp.t_Revision.Consecutivo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public void CargarCombos()
        {
            cbTipo.SelectedIndex = 0;
            var data = recepcion.obtenerTodo(new t_Recepcion());
            //Recepcion
            cbEntrega.DataSource = data.Where(x => x.id >= 3).ToList();
            cbEntrega.ValueMember = "id";
            cbEntrega.DisplayMember = "Nombre";
        }


        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            try
            {

                t_Persona persona = new t_Persona();
                persona.Cedula = txtCedula.Text;

                if (txtCedula.Text.Length > 6)
                {

                    persona = personaNegocio.obtenerPorId(persona);
                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre;
                        txtApellido1.Text = persona.Apellido1;
                        txtApellido2.Text = persona.Apellido2;
                    }
                }

                if (txtCedula.Text.Length > 8 || txtCedula.Text != "")
                {

                    persona = personaNegocio.obtenerPorId(persona);
                    if (persona != null)
                    {
                        txtNombre.Text = persona.Nombre;
                        txtApellido1.Text = persona.Apellido1;
                        txtApellido2.Text = persona.Apellido2;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                txtCedula.Mask = "0-0000-0000";
            }
            else
            {
                txtCedula.Mask = "000000000000";
            }
        }



        private void fEntrega_Load(object sender, EventArgs e)
        {
            lblFecha.Visible = false;
            CargarCombos();
            CargarDatos();
        }



        private void cbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheque.Checked == true)
            {
                cbTranferencia.Checked = false;
            }
        }



        private void cbTranferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTranferencia.Checked == true)
            {
                cbCheque.Checked = false;
            }
        }



        private void btn_Click(object sender, EventArgs e)
        {
            fReporteEntrega entrega = new fReporteEntrega(txtConsecutivo.Text);
            entrega.ShowDialog();
        }


        private void labelColorChange()
        {

            if (isDark == "false")
            {
                label3.ForeColor = Colors.Black;
                label4.ForeColor = Colors.Black;
                label6.ForeColor = Colors.Black;
                label7.ForeColor = Colors.Black;
            }
            else
            {
                label3.ForeColor = Colors.White;
                label4.ForeColor = Colors.White;
                label6.ForeColor = Colors.White;
                label7.ForeColor = Colors.White;
            }

            if (txtCedula.Text.Length < 8)
            {
                label7.ForeColor = Colors.RedFont;
            }
            if (txtNombre.Text == string.Empty)
            {
                label6.ForeColor = Colors.RedFont;
            }
            if (txtApellido1.Text == string.Empty)
            {
                label3.ForeColor = Colors.RedFont;
            }
            if (txtApellido2.Text == string.Empty)
            {
                label4.ForeColor = Colors.RedFont;
            }

        }


        private bool ValidarCampos()
        {
            labelColorChange();

            if (txtCedula.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de cedula no puede ser vacio");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de Nombre no puede ser vacio");
                return false;
            }
            else if (txtApellido1.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de primer apellido no puede ser vacio");
                return false;
            }
            else if (txtApellido2.Text == string.Empty)
            {
                Message.Danger(new Alertas.Alerta(), "El campo de segundo apellido no puede ser vacio");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                t_EntregaCasos entregaCasos = new t_EntregaCasos();
                if (ValidarCampos() == true)
                {
                    entregaCasos.Cedula = txtCedula.Text;
                    entregaCasos.Recepcion = (int)cbEntrega.SelectedValue;

                    if (cbCheque.Checked == true)
                    {
                        //Por cheque
                        entregaCasos.Pago = 0;
                    }
                    else
                    {
                        //Por Transferencia
                        entregaCasos.Pago = 1;
                    }
                    
                    Estado state = new Estado();
                    state.id = 4;

                    t_Revision revision = revisionNegocio.obtenerPorConsecutivo(txtConsecutivo.Text).SingleOrDefault();
                    //Cambio el estado en entregado
                    Estado estado = estadoNegocio.obtenerPorId(state);
                    revision.Estado = estado.id;
                    revision.Estado1 = estado;

                    entregaCasos.Id_Caso = revision.Id_Caso;
                    entregaCasos.FechaEntrega = DateTime.Now;

                    if (entregaNegocio.guardar(entregaCasos) == true && revisionNegocio.modificar(revision)==true)
                    {
                        Message.Success(new Alertas.Alerta(), "La informacion fue guardada");
                        btnPdf.Visible = true;
                    }
                    else
                    {
                        Message.Danger(new Alertas.Alerta(), "No se pudo guaardar la informacion");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
