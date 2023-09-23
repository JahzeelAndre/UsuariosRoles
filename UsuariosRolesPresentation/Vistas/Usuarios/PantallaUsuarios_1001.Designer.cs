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
            tableLayoutPanelPrincipal = new TableLayoutPanel();
            splitContainerPrincipal = new SplitContainer();
            textBoxNombrePerfil = new TextBox();
            label1 = new Label();
            checkedListBoxPermisos = new CheckedListBox();
            label2 = new Label();
            panelModulos = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            label3 = new Label();
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
            tableLayoutPanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).BeginInit();
            splitContainerPrincipal.Panel1.SuspendLayout();
            splitContainerPrincipal.Panel2.SuspendLayout();
            splitContainerPrincipal.SuspendLayout();
            panelModulos.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            tabPagePerfiles.Controls.Add(tableLayoutPanelPrincipal);
            tabPagePerfiles.Location = new Point(4, 24);
            tabPagePerfiles.Name = "tabPagePerfiles";
            tabPagePerfiles.Padding = new Padding(3);
            tabPagePerfiles.Size = new Size(704, 430);
            tabPagePerfiles.TabIndex = 2;
            tabPagePerfiles.Text = "Perfiles";
            tabPagePerfiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.ColumnCount = 1;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelPrincipal.Controls.Add(splitContainerPrincipal, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelModulos, 0, 1);
            tableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new Point(3, 3);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.RowCount = 2;
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelPrincipal.Size = new Size(698, 424);
            tableLayoutPanelPrincipal.TabIndex = 1;
            // 
            // splitContainerPrincipal
            // 
            splitContainerPrincipal.Dock = DockStyle.Fill;
            splitContainerPrincipal.Location = new Point(3, 3);
            splitContainerPrincipal.Name = "splitContainerPrincipal";
            // 
            // splitContainerPrincipal.Panel1
            // 
            splitContainerPrincipal.Panel1.Controls.Add(textBoxNombrePerfil);
            splitContainerPrincipal.Panel1.Controls.Add(label1);
            // 
            // splitContainerPrincipal.Panel2
            // 
            splitContainerPrincipal.Panel2.Controls.Add(checkedListBoxPermisos);
            splitContainerPrincipal.Panel2.Controls.Add(label2);
            splitContainerPrincipal.Size = new Size(692, 206);
            splitContainerPrincipal.SplitterDistance = 230;
            splitContainerPrincipal.TabIndex = 0;
            // 
            // textBoxNombrePerfil
            // 
            textBoxNombrePerfil.Dock = DockStyle.Top;
            textBoxNombrePerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombrePerfil.Location = new Point(0, 21);
            textBoxNombrePerfil.Name = "textBoxNombrePerfil";
            textBoxNombrePerfil.Size = new Size(230, 27);
            textBoxNombrePerfil.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre perfil:";
            // 
            // checkedListBoxPermisos
            // 
            checkedListBoxPermisos.Dock = DockStyle.Fill;
            checkedListBoxPermisos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxPermisos.FormattingEnabled = true;
            checkedListBoxPermisos.HorizontalScrollbar = true;
            checkedListBoxPermisos.Location = new Point(0, 21);
            checkedListBoxPermisos.MultiColumn = true;
            checkedListBoxPermisos.Name = "checkedListBoxPermisos";
            checkedListBoxPermisos.Size = new Size(458, 185);
            checkedListBoxPermisos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Permisos:";
            // 
            // panelModulos
            // 
            panelModulos.Controls.Add(flowLayoutPanel1);
            panelModulos.Controls.Add(label3);
            panelModulos.Dock = DockStyle.Fill;
            panelModulos.Location = new Point(3, 215);
            panelModulos.Name = "panelModulos";
            panelModulos.Size = new Size(692, 206);
            panelModulos.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(radioButton1);
            flowLayoutPanel1.Controls.Add(radioButton2);
            flowLayoutPanel1.Controls.Add(radioButton3);
            flowLayoutPanel1.Controls.Add(radioButton4);
            flowLayoutPanel1.Controls.Add(radioButton5);
            flowLayoutPanel1.Controls.Add(radioButton6);
            flowLayoutPanel1.Controls.Add(radioButton7);
            flowLayoutPanel1.Controls.Add(radioButton8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(692, 185);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(203, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(303, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(403, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(503, 3);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(3, 28);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(103, 28);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 7;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "Módulos:";
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
            tabControlPrincipal.ResumeLayout(false);
            tabPagePerfiles.ResumeLayout(false);
            tableLayoutPanelPrincipal.ResumeLayout(false);
            splitContainerPrincipal.Panel1.ResumeLayout(false);
            splitContainerPrincipal.Panel1.PerformLayout();
            splitContainerPrincipal.Panel2.ResumeLayout(false);
            splitContainerPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPrincipal).EndInit();
            splitContainerPrincipal.ResumeLayout(false);
            panelModulos.ResumeLayout(false);
            panelModulos.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanelPrincipal;
        private SplitContainer splitContainerPrincipal;
        private TextBox textBoxNombrePerfil;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxPermisos;
        private Panel panelModulos;
        private Label label3;
        private TabPage tabPagePermisos;
        private TabPage tabPageModulos;
        private Panel panel1;
        private TextBox textBoxNombreOperacion;
        private Label label4;
        private Button buttonAgregarOperacion;
        private Button buttonAgregarModulo;
        private TextBox textBoxNombreModulo;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
    }
}
