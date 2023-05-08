﻿using System.Windows.Forms;

namespace UWallet.Interfaces.Admin
{
    partial class frmNuevaCiudad
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.imgClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmar = new Guna.UI2.WinForms.Guna2Button();
            this.cbPaises = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNombreNuevo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dcForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.resizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panelLogo.Controls.Add(this.lblEmpresa);
            this.panelLogo.Controls.Add(this.imgLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 400);
            this.panelLogo.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpresa.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblEmpresa.Location = new System.Drawing.Point(0, 240);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(200, 60);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "U Wallet";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgLogo.Image = global::UWallet.Properties.Resources.logo1;
            this.imgLogo.Location = new System.Drawing.Point(0, 100);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(2, 34, 2, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 137);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.imgClose);
            this.panelBarra.Controls.Add(this.imgMaximize);
            this.panelBarra.Controls.Add(this.imgMinimize);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(200, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(400, 30);
            this.panelBarra.TabIndex = 9;
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.HoverState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgClose.ImageRotate = 0F;
            this.imgClose.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Location = new System.Drawing.Point(370, 0);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgClose.Name = "imgClose";
            this.imgClose.PressedState.Image = global::UWallet.Properties.Resources.macos_close;
            this.imgClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgClose.Size = new System.Drawing.Size(30, 30);
            this.imgClose.TabIndex = 16;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgMaximize
            // 
            this.imgMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMaximize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMaximize.HoverState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Image = global::UWallet.Properties.Resources.macos_fullscreen;
            this.imgMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMaximize.ImageRotate = 0F;
            this.imgMaximize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Location = new System.Drawing.Point(340, 0);
            this.imgMaximize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMaximize.Name = "imgMaximize";
            this.imgMaximize.PressedState.Image = global::UWallet.Properties.Resources.macos_fullscreen_gris;
            this.imgMaximize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMaximize.Size = new System.Drawing.Size(30, 30);
            this.imgMaximize.TabIndex = 15;
            this.imgMaximize.Click += new System.EventHandler(this.imgMaximize_Click);
            // 
            // imgMinimize
            // 
            this.imgMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMinimize.HoverState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Image = global::UWallet.Properties.Resources.macos_minimize;
            this.imgMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgMinimize.ImageRotate = 0F;
            this.imgMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Location = new System.Drawing.Point(310, 0);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.PressedState.Image = global::UWallet.Properties.Resources.macos_minimize_gris;
            this.imgMinimize.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.imgMinimize.Size = new System.Drawing.Size(30, 30);
            this.imgMinimize.TabIndex = 14;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnConfirmar);
            this.panelContenido.Controls.Add(this.cbPaises);
            this.panelContenido.Controls.Add(this.txtNombreNuevo);
            this.panelContenido.Controls.Add(this.lblTitulo);
            this.panelContenido.Controls.Add(this.lblPais);
            this.panelContenido.Controls.Add(this.lblNombre);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 30);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(400, 370);
            this.panelContenido.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelar.Image = global::UWallet.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelar.Location = new System.Drawing.Point(50, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.btnCancelar.Size = new System.Drawing.Size(140, 45);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.BorderRadius = 5;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Image = global::UWallet.Properties.Resources.accept;
            this.btnConfirmar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirmar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfirmar.Location = new System.Drawing.Point(210, 296);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Size = new System.Drawing.Size(140, 45);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbPaises
            // 
            this.cbPaises.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPaises.BackColor = System.Drawing.Color.Transparent;
            this.cbPaises.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.cbPaises.BorderRadius = 15;
            this.cbPaises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPaises.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.cbPaises.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cbPaises.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.cbPaises.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbPaises.ForeColor = System.Drawing.Color.White;
            this.cbPaises.IntegralHeight = false;
            this.cbPaises.ItemHeight = 30;
            this.cbPaises.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.cbPaises.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.cbPaises.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbPaises.Location = new System.Drawing.Point(50, 202);
            this.cbPaises.Margin = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(300, 36);
            this.cbPaises.TabIndex = 29;
            this.cbPaises.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreNuevo.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtNombreNuevo.BorderRadius = 15;
            this.txtNombreNuevo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreNuevo.DefaultText = "";
            this.txtNombreNuevo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreNuevo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreNuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.txtNombreNuevo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtNombreNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.ForeColor = System.Drawing.Color.White;
            this.txtNombreNuevo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.txtNombreNuevo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtNombreNuevo.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtNombreNuevo.Location = new System.Drawing.Point(50, 121);
            this.txtNombreNuevo.Margin = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.txtNombreNuevo.MinimumSize = new System.Drawing.Size(300, 35);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.PasswordChar = '\0';
            this.txtNombreNuevo.PlaceholderText = "";
            this.txtNombreNuevo.SelectedText = "";
            this.txtNombreNuevo.Size = new System.Drawing.Size(300, 35);
            this.txtNombreNuevo.TabIndex = 28;
            this.txtNombreNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreNuevo.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AGREGAR NUEVA CIUDAD";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPais.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblPais.ForeColor = System.Drawing.Color.White;
            this.lblPais.Location = new System.Drawing.Point(0, 171);
            this.lblPais.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(400, 26);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País:";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(0, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(400, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la Ciudad:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dcForm
            // 
            this.dcForm.DockIndicatorTransparencyValue = 0.6D;
            this.dcForm.TargetControl = this.panelBarra;
            this.dcForm.UseTransparentDrag = true;
            // 
            // resizeForm
            // 
            this.resizeForm.TargetForm = this;
            // 
            // frmNuevaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmNuevaCiudad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelLogo;
        private Label lblTitulo;
        private Panel panelBarra;
        private Panel panelContenido;
        private Label lblPais;
        private Label lblNombre;
        private Guna.UI2.WinForms.Guna2ImageButton imgClose;
        private Guna.UI2.WinForms.Guna2ImageButton imgMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton imgMinimize;
        private Label lblEmpresa;
        private PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreNuevo;
        private Guna.UI2.WinForms.Guna2ComboBox cbPaises;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnConfirmar;
        private Guna.UI2.WinForms.Guna2DragControl dcForm;
        private Guna.UI2.WinForms.Guna2ResizeForm resizeForm;
    }
}