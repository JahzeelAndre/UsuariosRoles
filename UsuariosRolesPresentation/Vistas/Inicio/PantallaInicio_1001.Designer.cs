namespace UsuariosRolesPresentation.Vistas.Inicio
{
    partial class PantallaInicio_1001
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
            iconButtonGenerarBD = new FontAwesome.Sharp.IconButton();
            iconButtonUsuarios = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)splitContainerContenido).BeginInit();
            splitContainerContenido.Panel1.SuspendLayout();
            splitContainerContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBarraNavegacionEncabezado).BeginInit();
            splitContainerBarraNavegacionEncabezado.Panel1.SuspendLayout();
            splitContainerBarraNavegacionEncabezado.Panel2.SuspendLayout();
            splitContainerBarraNavegacionEncabezado.SuspendLayout();
            panelBarraNavegacionBotones.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainerContenido
            // 
            // 
            // splitContainerBarraNavegacionEncabezado
            // 
            // 
            // iconButtonBurguer
            // 
            iconButtonBurguer.FlatAppearance.BorderSize = 0;
            // 
            // iconButtonDatosEmpresa
            // 
            iconButtonDatosEmpresa.FlatAppearance.BorderSize = 0;
            // 
            // panelBarraNavegacionBotones
            // 
            panelBarraNavegacionBotones.Controls.Add(iconButtonUsuarios);
            panelBarraNavegacionBotones.Controls.Add(iconButtonGenerarBD);
            // 
            // iconButtonGenerarBD
            // 
            iconButtonGenerarBD.Dock = DockStyle.Top;
            iconButtonGenerarBD.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonGenerarBD.IconColor = Color.Black;
            iconButtonGenerarBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGenerarBD.Location = new Point(0, 0);
            iconButtonGenerarBD.Name = "iconButtonGenerarBD";
            iconButtonGenerarBD.Size = new Size(163, 23);
            iconButtonGenerarBD.TabIndex = 0;
            iconButtonGenerarBD.Text = "Generar BD";
            iconButtonGenerarBD.UseVisualStyleBackColor = true;
            iconButtonGenerarBD.Click += iconButtonGenerarBD_Click;
            // 
            // iconButtonUsuarios
            // 
            iconButtonUsuarios.Dock = DockStyle.Top;
            iconButtonUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonUsuarios.IconColor = Color.Black;
            iconButtonUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUsuarios.Location = new Point(0, 23);
            iconButtonUsuarios.Name = "iconButtonUsuarios";
            iconButtonUsuarios.Size = new Size(163, 23);
            iconButtonUsuarios.TabIndex = 1;
            iconButtonUsuarios.Text = "Usuarios";
            iconButtonUsuarios.UseVisualStyleBackColor = true;
            iconButtonUsuarios.Click += iconButtonUsuarios_Click;
            // 
            // PantallaInicio_1001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "PantallaInicio_1001";
            splitContainerContenido.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerContenido).EndInit();
            splitContainerContenido.ResumeLayout(false);
            splitContainerBarraNavegacionEncabezado.Panel1.ResumeLayout(false);
            splitContainerBarraNavegacionEncabezado.Panel1.PerformLayout();
            splitContainerBarraNavegacionEncabezado.Panel2.ResumeLayout(false);
            splitContainerBarraNavegacionEncabezado.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerBarraNavegacionEncabezado).EndInit();
            splitContainerBarraNavegacionEncabezado.ResumeLayout(false);
            panelBarraNavegacionBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonGenerarBD;
        private FontAwesome.Sharp.IconButton iconButtonUsuarios;
    }
}