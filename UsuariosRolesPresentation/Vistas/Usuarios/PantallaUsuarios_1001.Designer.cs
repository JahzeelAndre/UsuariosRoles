namespace UsuariosRolesPresentation.Vistas.Usuarios
{
    partial class PantallaUsuarios_1001
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlPrincipal = new TabControl();
            tabPageUsuarios = new TabPage();
            tabPageRoles = new TabPage();
            tabPagePerfiles = new TabPage();
            tableLayoutPanelPerfiles = new TableLayoutPanel();
            panelDatos = new Panel();
            tableLayoutPanelSaveButton = new TableLayoutPanel();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            textBoxNombrePerfil = new TextBox();
            labelNombrePerfil = new Label();
            panelPermisos = new Panel();
            checkedListBoxPermisos = new CheckedListBox();
            labelPermisos = new Label();
            panel2 = new Panel();
            flowLayoutPanelModulos = new FlowLayoutPanel();
            labelModulos = new Label();
            tabPagePermisos = new TabPage();
            panel1 = new Panel();
            buttonAgregarOperacion = new Button();
            textBoxNombreOperacion = new TextBox();
            label4 = new Label();
            tabPageModulos = new TabPage();
            buttonAgregarModulo = new Button();
            textBoxNombreModulo = new TextBox();
            label5 = new Label();
            tabControlPrincipal.SuspendLayout();
            tabPagePerfiles.SuspendLayout();
            tableLayoutPanelPerfiles.SuspendLayout();
            panelDatos.SuspendLayout();
            tableLayoutPanelSaveButton.SuspendLayout();
            panelPermisos.SuspendLayout();
            panel2.SuspendLayout();
            tabPagePermisos.SuspendLayout();
            panel1.SuspendLayout();
            tabPageModulos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Controls.Add(tabPageUsuarios);
            tabControlPrincipal.Controls.Add(tabPageRoles);
            tabControlPrincipal.Controls.Add(tabPagePerfiles);
            tabControlPrincipal.Controls.Add(tabPagePermisos);
            tabControlPrincipal.Controls.Add(tabPageModulos);
            tabControlPrincipal.Dock = DockStyle.Fill;
            tabControlPrincipal.Location = new Point(0, 0);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(712, 458);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.Click += tabControlPrincipal_Click;
            // 
            // tabPageUsuarios
            // 
            tabPageUsuarios.Location = new Point(4, 24);
            tabPageUsuarios.Name = "tabPageUsuarios";
            tabPageUsuarios.Padding = new Padding(3);
            tabPageUsuarios.Size = new Size(704, 430);
            tabPageUsuarios.TabIndex = 0;
            tabPageUsuarios.Text = "Usuarios";
            tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabPageRoles
            // 
            tabPageRoles.Location = new Point(4, 24);
            tabPageRoles.Name = "tabPageRoles";
            tabPageRoles.Padding = new Padding(3);
            tabPageRoles.Size = new Size(704, 430);
            tabPageRoles.TabIndex = 1;
            tabPageRoles.Text = "Roles";
            tabPageRoles.UseVisualStyleBackColor = true;
            // 
            // tabPagePerfiles
            // 
            tabPagePerfiles.Controls.Add(tableLayoutPanelPerfiles);
            tabPagePerfiles.Location = new Point(4, 24);
            tabPagePerfiles.Name = "tabPagePerfiles";
            tabPagePerfiles.Padding = new Padding(3);
            tabPagePerfiles.Size = new Size(704, 430);
            tabPagePerfiles.TabIndex = 2;
            tabPagePerfiles.Text = "Perfiles";
            tabPagePerfiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPerfiles
            // 
            tableLayoutPanelPerfiles.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanelPerfiles.ColumnCount = 3;
            tableLayoutPanelPerfiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelPerfiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelPerfiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelPerfiles.Controls.Add(panelDatos, 0, 0);
            tableLayoutPanelPerfiles.Controls.Add(panelPermisos, 1, 0);
            tableLayoutPanelPerfiles.Controls.Add(panel2, 2, 0);
            tableLayoutPanelPerfiles.Dock = DockStyle.Fill;
            tableLayoutPanelPerfiles.Location = new Point(3, 3);
            tableLayoutPanelPerfiles.Name = "tableLayoutPanelPerfiles";
            tableLayoutPanelPerfiles.RowCount = 1;
            tableLayoutPanelPerfiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPerfiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelPerfiles.Size = new Size(698, 424);
            tableLayoutPanelPerfiles.TabIndex = 1;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(tableLayoutPanelSaveButton);
            panelDatos.Controls.Add(textBoxNombrePerfil);
            panelDatos.Controls.Add(labelNombrePerfil);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(4, 4);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(225, 416);
            panelDatos.TabIndex = 4;
            // 
            // tableLayoutPanelSaveButton
            // 
            tableLayoutPanelSaveButton.AutoSize = true;
            tableLayoutPanelSaveButton.ColumnCount = 1;
            tableLayoutPanelSaveButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSaveButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelSaveButton.Controls.Add(iconButtonGuardar, 0, 0);
            tableLayoutPanelSaveButton.Dock = DockStyle.Fill;
            tableLayoutPanelSaveButton.Location = new Point(0, 49);
            tableLayoutPanelSaveButton.Name = "tableLayoutPanelSaveButton";
            tableLayoutPanelSaveButton.RowCount = 1;
            tableLayoutPanelSaveButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSaveButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelSaveButton.Size = new Size(225, 367);
            tableLayoutPanelSaveButton.TabIndex = 8;
            // 
            // iconButtonGuardar
            // 
            iconButtonGuardar.Anchor = AnchorStyles.Top;
            iconButtonGuardar.AutoSize = true;
            iconButtonGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconButtonGuardar.IconColor = Color.Blue;
            iconButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardar.IconSize = 30;
            iconButtonGuardar.Location = new Point(68, 8);
            iconButtonGuardar.Margin = new Padding(3, 8, 3, 3);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(89, 36);
            iconButtonGuardar.TabIndex = 7;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButtonGuardar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombrePerfil
            // 
            textBoxNombrePerfil.Dock = DockStyle.Top;
            textBoxNombrePerfil.Location = new Point(0, 26);
            textBoxNombrePerfil.Name = "textBoxNombrePerfil";
            textBoxNombrePerfil.Size = new Size(225, 23);
            textBoxNombrePerfil.TabIndex = 7;
            // 
            // labelNombrePerfil
            // 
            labelNombrePerfil.AutoSize = true;
            labelNombrePerfil.Dock = DockStyle.Top;
            labelNombrePerfil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombrePerfil.Location = new Point(0, 0);
            labelNombrePerfil.Name = "labelNombrePerfil";
            labelNombrePerfil.Padding = new Padding(0, 0, 0, 5);
            labelNombrePerfil.Size = new Size(111, 26);
            labelNombrePerfil.TabIndex = 1;
            labelNombrePerfil.Text = "Nombre perfil:";
            // 
            // panelPermisos
            // 
            panelPermisos.Controls.Add(checkedListBoxPermisos);
            panelPermisos.Controls.Add(labelPermisos);
            panelPermisos.Dock = DockStyle.Fill;
            panelPermisos.Location = new Point(236, 4);
            panelPermisos.Name = "panelPermisos";
            panelPermisos.Size = new Size(225, 416);
            panelPermisos.TabIndex = 2;
            // 
            // checkedListBoxPermisos
            // 
            checkedListBoxPermisos.BorderStyle = BorderStyle.None;
            checkedListBoxPermisos.CheckOnClick = true;
            checkedListBoxPermisos.Dock = DockStyle.Fill;
            checkedListBoxPermisos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxPermisos.FormattingEnabled = true;
            checkedListBoxPermisos.Location = new Point(0, 26);
            checkedListBoxPermisos.MultiColumn = true;
            checkedListBoxPermisos.Name = "checkedListBoxPermisos";
            checkedListBoxPermisos.Size = new Size(225, 390);
            checkedListBoxPermisos.TabIndex = 3;
            // 
            // labelPermisos
            // 
            labelPermisos.AutoSize = true;
            labelPermisos.Dock = DockStyle.Top;
            labelPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPermisos.Location = new Point(0, 0);
            labelPermisos.Name = "labelPermisos";
            labelPermisos.Padding = new Padding(0, 0, 0, 5);
            labelPermisos.Size = new Size(76, 26);
            labelPermisos.TabIndex = 2;
            labelPermisos.Text = "Permisos:";
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanelModulos);
            panel2.Controls.Add(labelModulos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(468, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 416);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanelModulos
            // 
            flowLayoutPanelModulos.Dock = DockStyle.Fill;
            flowLayoutPanelModulos.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelModulos.Location = new Point(0, 26);
            flowLayoutPanelModulos.Name = "flowLayoutPanelModulos";
            flowLayoutPanelModulos.Size = new Size(226, 390);
            flowLayoutPanelModulos.TabIndex = 4;
            // 
            // labelModulos
            // 
            labelModulos.AutoSize = true;
            labelModulos.Dock = DockStyle.Top;
            labelModulos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelModulos.Location = new Point(0, 0);
            labelModulos.Name = "labelModulos";
            labelModulos.Padding = new Padding(0, 0, 0, 5);
            labelModulos.Size = new Size(74, 26);
            labelModulos.TabIndex = 3;
            labelModulos.Text = "Módulos:";
            // 
            // tabPagePermisos
            // 
            tabPagePermisos.Controls.Add(panel1);
            tabPagePermisos.Location = new Point(4, 24);
            tabPagePermisos.Name = "tabPagePermisos";
            tabPagePermisos.Padding = new Padding(3);
            tabPagePermisos.Size = new Size(704, 430);
            tabPagePermisos.TabIndex = 3;
            tabPagePermisos.Text = "Permisos";
            tabPagePermisos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAgregarOperacion);
            panel1.Controls.Add(textBoxNombreOperacion);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 424);
            panel1.TabIndex = 0;
            // 
            // buttonAgregarOperacion
            // 
            buttonAgregarOperacion.AutoSize = true;
            buttonAgregarOperacion.Location = new Point(278, 99);
            buttonAgregarOperacion.Name = "buttonAgregarOperacion";
            buttonAgregarOperacion.Size = new Size(75, 25);
            buttonAgregarOperacion.TabIndex = 4;
            buttonAgregarOperacion.Text = "Agregar";
            buttonAgregarOperacion.UseVisualStyleBackColor = true;
            buttonAgregarOperacion.Click += buttonAgregarOperacion_Click;
            // 
            // textBoxNombreOperacion
            // 
            textBoxNombreOperacion.Dock = DockStyle.Top;
            textBoxNombreOperacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreOperacion.Location = new Point(0, 21);
            textBoxNombreOperacion.Name = "textBoxNombreOperacion";
            textBoxNombreOperacion.Size = new Size(698, 27);
            textBoxNombreOperacion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 2;
            label4.Text = "Nombre operación:";
            // 
            // tabPageModulos
            // 
            tabPageModulos.Controls.Add(buttonAgregarModulo);
            tabPageModulos.Controls.Add(textBoxNombreModulo);
            tabPageModulos.Controls.Add(label5);
            tabPageModulos.Location = new Point(4, 24);
            tabPageModulos.Name = "tabPageModulos";
            tabPageModulos.Padding = new Padding(3);
            tabPageModulos.Size = new Size(704, 430);
            tabPageModulos.TabIndex = 4;
            tabPageModulos.Text = "Módulos";
            tabPageModulos.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarModulo
            // 
            buttonAgregarModulo.AutoSize = true;
            buttonAgregarModulo.Location = new Point(278, 251);
            buttonAgregarModulo.Name = "buttonAgregarModulo";
            buttonAgregarModulo.Size = new Size(75, 25);
            buttonAgregarModulo.TabIndex = 7;
            buttonAgregarModulo.Text = "Agregar";
            buttonAgregarModulo.UseVisualStyleBackColor = true;
            buttonAgregarModulo.Click += buttonAgregarModulo_Click;
            // 
            // textBoxNombreModulo
            // 
            textBoxNombreModulo.Dock = DockStyle.Top;
            textBoxNombreModulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreModulo.Location = new Point(3, 24);
            textBoxNombreModulo.Name = "textBoxNombreModulo";
            textBoxNombreModulo.Size = new Size(698, 27);
            textBoxNombreModulo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 5;
            label5.Text = "Nombre módulo";
            // 
            // PantallaUsuarios_1001
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlPrincipal);
            Name = "PantallaUsuarios_1001";
            Resize += PantallaUsuarios_1001_Resize;
            tabControlPrincipal.ResumeLayout(false);
            tabPagePerfiles.ResumeLayout(false);
            tableLayoutPanelPerfiles.ResumeLayout(false);
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            tableLayoutPanelSaveButton.ResumeLayout(false);
            tableLayoutPanelSaveButton.PerformLayout();
            panelPermisos.ResumeLayout(false);
            panelPermisos.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPagePermisos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageModulos.ResumeLayout(false);
            tabPageModulos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabPageUsuarios;
        private TabPage tabPageRoles;
        private TabPage tabPagePerfiles;
        private TableLayoutPanel tableLayoutPanelPerfiles;
        private TabPage tabPagePermisos;
        private TabPage tabPageModulos;
        private Panel panel1;
        private TextBox textBoxNombreOperacion;
        private Label label4;
        private Button buttonAgregarOperacion;
        private Button buttonAgregarModulo;
        private TextBox textBoxNombreModulo;
        private Label label5;
        private Panel panelPermisos;
        private CheckedListBox checkedListBoxPermisos;
        private Label labelPermisos;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanelModulos;
        private Label labelModulos;
        private Panel panelDatos;
        private Label labelNombrePerfil;
        private TextBox textBoxNombrePerfil;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private TableLayoutPanel tableLayoutPanelSaveButton;
    }
}
