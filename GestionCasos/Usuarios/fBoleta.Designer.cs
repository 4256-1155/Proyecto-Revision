
namespace GestionCasos.Usuarios
{
    partial class fBoleta
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
            this.components = new System.ComponentModel.Container();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConsecutivo = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbMotivo1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo4 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo5 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo6 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo7 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMotivo8 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnBoleta = new Guna.UI.WinForms.GunaButton();
            this.btnObservacion = new Guna.UI.WinForms.GunaButton();
            this.gunaLinePanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.gunaLinePanel1.Controls.Add(this.btnObservacion);
            this.gunaLinePanel1.Controls.Add(this.btnBoleta);
            this.gunaLinePanel1.Controls.Add(this.guna2GroupBox2);
            this.gunaLinePanel1.Controls.Add(this.guna2GroupBox1);
            this.gunaLinePanel1.Controls.Add(this.lblConsecutivo);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 2;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.gunaLinePanel1.LineLeft = 2;
            this.gunaLinePanel1.LineRight = 2;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 2;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(800, 600);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLinePanel1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(81)))), ((int)(((byte)(73)))));
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(753, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consecutivo: ";
            // 
            // lblConsecutivo
            // 
            this.lblConsecutivo.AutoSize = true;
            this.lblConsecutivo.BackColor = System.Drawing.Color.Transparent;
            this.lblConsecutivo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsecutivo.ForeColor = System.Drawing.Color.White;
            this.lblConsecutivo.Location = new System.Drawing.Point(126, 10);
            this.lblConsecutivo.Name = "lblConsecutivo";
            this.lblConsecutivo.Size = new System.Drawing.Size(32, 21);
            this.lblConsecutivo.TabIndex = 2;
            this.lblConsecutivo.Text = "R-1";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.guna2GroupBox1.Controls.Add(this.txtOtros);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo8);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo7);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo6);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo5);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo4);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo3);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo2);
            this.guna2GroupBox1.Controls.Add(this.cbMotivo1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 48);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(776, 258);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Motivos";
            // 
            // cbMotivo1
            // 
            this.cbMotivo1.AutoSize = true;
            this.cbMotivo1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo1.CheckedState.BorderRadius = 2;
            this.cbMotivo1.CheckedState.BorderThickness = 0;
            this.cbMotivo1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo1.ForeColor = System.Drawing.Color.White;
            this.cbMotivo1.Location = new System.Drawing.Point(40, 60);
            this.cbMotivo1.Name = "cbMotivo1";
            this.cbMotivo1.Size = new System.Drawing.Size(185, 21);
            this.cbMotivo1.TabIndex = 0;
            this.cbMotivo1.Text = "FALTA DE FIRMA DE CIERRE";
            this.cbMotivo1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo1.UncheckedState.BorderRadius = 2;
            this.cbMotivo1.UncheckedState.BorderThickness = 0;
            this.cbMotivo1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo1.UseVisualStyleBackColor = true;
            // 
            // cbMotivo2
            // 
            this.cbMotivo2.AutoSize = true;
            this.cbMotivo2.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo2.CheckedState.BorderRadius = 2;
            this.cbMotivo2.CheckedState.BorderThickness = 0;
            this.cbMotivo2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo2.ForeColor = System.Drawing.Color.White;
            this.cbMotivo2.Location = new System.Drawing.Point(40, 100);
            this.cbMotivo2.Name = "cbMotivo2";
            this.cbMotivo2.Size = new System.Drawing.Size(186, 21);
            this.cbMotivo2.TabIndex = 1;
            this.cbMotivo2.Text = "FALTA HOJA DE ASISTENSIA";
            this.cbMotivo2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo2.UncheckedState.BorderRadius = 2;
            this.cbMotivo2.UncheckedState.BorderThickness = 0;
            this.cbMotivo2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo2.UseVisualStyleBackColor = false;
            // 
            // cbMotivo3
            // 
            this.cbMotivo3.AutoSize = true;
            this.cbMotivo3.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo3.CheckedState.BorderRadius = 2;
            this.cbMotivo3.CheckedState.BorderThickness = 0;
            this.cbMotivo3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo3.ForeColor = System.Drawing.Color.White;
            this.cbMotivo3.Location = new System.Drawing.Point(40, 140);
            this.cbMotivo3.Name = "cbMotivo3";
            this.cbMotivo3.Size = new System.Drawing.Size(250, 21);
            this.cbMotivo3.TabIndex = 2;
            this.cbMotivo3.Text = "FALTA # SESIÓN ORDIN/EXTRA ORDIN";
            this.cbMotivo3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo3.UncheckedState.BorderRadius = 2;
            this.cbMotivo3.UncheckedState.BorderThickness = 0;
            this.cbMotivo3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo3.UseVisualStyleBackColor = false;
            // 
            // cbMotivo4
            // 
            this.cbMotivo4.AutoSize = true;
            this.cbMotivo4.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo4.CheckedState.BorderRadius = 2;
            this.cbMotivo4.CheckedState.BorderThickness = 0;
            this.cbMotivo4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo4.ForeColor = System.Drawing.Color.White;
            this.cbMotivo4.Location = new System.Drawing.Point(40, 180);
            this.cbMotivo4.Name = "cbMotivo4";
            this.cbMotivo4.Size = new System.Drawing.Size(132, 21);
            this.cbMotivo4.TabIndex = 3;
            this.cbMotivo4.Text = "MALO # FACTURA";
            this.cbMotivo4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo4.UncheckedState.BorderRadius = 2;
            this.cbMotivo4.UncheckedState.BorderThickness = 0;
            this.cbMotivo4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo4.UseVisualStyleBackColor = false;
            // 
            // cbMotivo5
            // 
            this.cbMotivo5.AutoSize = true;
            this.cbMotivo5.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo5.CheckedState.BorderRadius = 2;
            this.cbMotivo5.CheckedState.BorderThickness = 0;
            this.cbMotivo5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo5.ForeColor = System.Drawing.Color.White;
            this.cbMotivo5.Location = new System.Drawing.Point(40, 220);
            this.cbMotivo5.Name = "cbMotivo5";
            this.cbMotivo5.Size = new System.Drawing.Size(234, 21);
            this.cbMotivo5.TabIndex = 4;
            this.cbMotivo5.Text = "FALTA INFORMACION EN ARTICULO";
            this.cbMotivo5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo5.UncheckedState.BorderRadius = 2;
            this.cbMotivo5.UncheckedState.BorderThickness = 0;
            this.cbMotivo5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo5.UseVisualStyleBackColor = false;
            // 
            // cbMotivo6
            // 
            this.cbMotivo6.AutoSize = true;
            this.cbMotivo6.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo6.CheckedState.BorderRadius = 2;
            this.cbMotivo6.CheckedState.BorderThickness = 0;
            this.cbMotivo6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo6.ForeColor = System.Drawing.Color.White;
            this.cbMotivo6.Location = new System.Drawing.Point(388, 60);
            this.cbMotivo6.Name = "cbMotivo6";
            this.cbMotivo6.Size = new System.Drawing.Size(193, 21);
            this.cbMotivo6.TabIndex = 5;
            this.cbMotivo6.Text = "NO INDICA EL MONTO FACT";
            this.cbMotivo6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo6.UncheckedState.BorderRadius = 2;
            this.cbMotivo6.UncheckedState.BorderThickness = 0;
            this.cbMotivo6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo6.UseVisualStyleBackColor = false;
            // 
            // cbMotivo7
            // 
            this.cbMotivo7.AutoSize = true;
            this.cbMotivo7.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo7.CheckedState.BorderRadius = 2;
            this.cbMotivo7.CheckedState.BorderThickness = 0;
            this.cbMotivo7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo7.ForeColor = System.Drawing.Color.White;
            this.cbMotivo7.Location = new System.Drawing.Point(388, 100);
            this.cbMotivo7.Name = "cbMotivo7";
            this.cbMotivo7.Size = new System.Drawing.Size(126, 21);
            this.cbMotivo7.TabIndex = 6;
            this.cbMotivo7.Text = "MALO # CÉDULA";
            this.cbMotivo7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo7.UncheckedState.BorderRadius = 2;
            this.cbMotivo7.UncheckedState.BorderThickness = 0;
            this.cbMotivo7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo7.UseVisualStyleBackColor = false;
            // 
            // cbMotivo8
            // 
            this.cbMotivo8.AutoSize = true;
            this.cbMotivo8.BackColor = System.Drawing.Color.Transparent;
            this.cbMotivo8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo8.CheckedState.BorderRadius = 2;
            this.cbMotivo8.CheckedState.BorderThickness = 0;
            this.cbMotivo8.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMotivo8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotivo8.ForeColor = System.Drawing.Color.White;
            this.cbMotivo8.Location = new System.Drawing.Point(608, 60);
            this.cbMotivo8.Name = "cbMotivo8";
            this.cbMotivo8.Size = new System.Drawing.Size(68, 21);
            this.cbMotivo8.TabIndex = 7;
            this.cbMotivo8.Text = "OTROS";
            this.cbMotivo8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo8.UncheckedState.BorderRadius = 2;
            this.cbMotivo8.UncheckedState.BorderThickness = 0;
            this.cbMotivo8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbMotivo8.UseVisualStyleBackColor = false;
            this.cbMotivo8.CheckedChanged += new System.EventHandler(this.cbMotivo8_CheckedChanged);
            // 
            // txtOtros
            // 
            this.txtOtros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtros.Location = new System.Drawing.Point(388, 140);
            this.txtOtros.Multiline = true;
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOtros.Size = new System.Drawing.Size(385, 115);
            this.txtOtros.TabIndex = 8;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.guna2GroupBox2.Controls.Add(this.txtObservacion);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 331);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(776, 200);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Observacion";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(3, 42);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(770, 155);
            this.txtObservacion.TabIndex = 0;
            // 
            // btnBoleta
            // 
            this.btnBoleta.AnimationHoverSpeed = 0.07F;
            this.btnBoleta.AnimationSpeed = 0.03F;
            this.btnBoleta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(187)))), ((int)(((byte)(102)))));
            this.btnBoleta.BorderColor = System.Drawing.Color.Black;
            this.btnBoleta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBoleta.FocusedColor = System.Drawing.Color.Empty;
            this.btnBoleta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleta.ForeColor = System.Drawing.Color.White;
            this.btnBoleta.Image = global::GestionCasos.Properties.Resources.pdf_40px;
            this.btnBoleta.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBoleta.Location = new System.Drawing.Point(608, 546);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBoleta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoleta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBoleta.OnHoverImage = null;
            this.btnBoleta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoleta.Size = new System.Drawing.Size(177, 42);
            this.btnBoleta.TabIndex = 6;
            this.btnBoleta.Text = "Generar Boleta";
            // 
            // btnObservacion
            // 
            this.btnObservacion.AnimationHoverSpeed = 0.07F;
            this.btnObservacion.AnimationSpeed = 0.03F;
            this.btnObservacion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(79)))), ((int)(((byte)(116)))));
            this.btnObservacion.BorderColor = System.Drawing.Color.Black;
            this.btnObservacion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnObservacion.FocusedColor = System.Drawing.Color.Empty;
            this.btnObservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObservacion.ForeColor = System.Drawing.Color.White;
            this.btnObservacion.Image = global::GestionCasos.Properties.Resources.add_40px;
            this.btnObservacion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnObservacion.Location = new System.Drawing.Point(354, 546);
            this.btnObservacion.Name = "btnObservacion";
            this.btnObservacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnObservacion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnObservacion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnObservacion.OnHoverImage = null;
            this.btnObservacion.OnPressedColor = System.Drawing.Color.Black;
            this.btnObservacion.Size = new System.Drawing.Size(223, 42);
            this.btnObservacion.TabIndex = 7;
            this.btnObservacion.Text = "Agregar Observacion";
            this.btnObservacion.Click += new System.EventHandler(this.btnObservacion_Click);
            // 
            // fBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBoleta";
            this.Load += new System.EventHandler(this.fBoleta_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label lblConsecutivo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox txtOtros;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo8;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo7;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo6;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo5;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo4;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo3;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo2;
        private Guna.UI2.WinForms.Guna2CheckBox cbMotivo1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.TextBox txtObservacion;
        private Guna.UI.WinForms.GunaButton btnObservacion;
        private Guna.UI.WinForms.GunaButton btnBoleta;
    }
}