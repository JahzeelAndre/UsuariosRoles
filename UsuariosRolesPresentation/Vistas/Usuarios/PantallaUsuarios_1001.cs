﻿using System;
using System.Configuration;
using System.Diagnostics;
using UsuariosRolesBackend.Entidades;
using UsuariosRolesBackend.Negocio;
using static System.Windows.Forms.CheckedListBox;

namespace UsuariosRolesPresentation.Vistas.Usuarios
{
    public partial class PantallaUsuarios_1001 : YibTronFronted.Controles.PantallaBase_1001
    {
        #region Variables...
        private readonly OperacionesBAL _operacionesBAL;
        private readonly ModulosBAL _modulosBAL;
        #endregion Variables

        public PantallaUsuarios_1001()
        {
            InitializeComponent();
            _operacionesBAL = new OperacionesBAL() { CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexionUsuariosRoles"].ConnectionString };
            _modulosBAL = new ModulosBAL() { CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexionUsuariosRoles"].ConnectionString };
        }
        public void IniciarComponentes()
        {

        }

        private void tabControlPrincipal_Click(object sender, EventArgs e)
        {
            switch (tabControlPrincipal.SelectedTab.Text)
            {
                case "Usuarios":
                    break;
                case "Roles":
                    break;
                case "Perfiles":
                    IniciarComponentesTabPagePerfiles();
                    break;
            }
        }

        #region Métodos...

        #region TabPage Perfiles...
        public async void IniciarComponentesTabPagePerfiles()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {

                checkedListBoxPermisos.Items.Clear();
                List<OperacionesInfo>? listaOperaciones = await _operacionesBAL.obtenerListaEntidades();
                if (listaOperaciones != null && listaOperaciones.Count > 0)
                {
                    foreach (OperacionesInfo operacionItem in listaOperaciones)
                    {
                        checkedListBoxPermisos.Items.Add(operacionItem.Nombre, false);
                    }
                }

                flowLayoutPanelModulos.Controls.Clear();

                List<ModulosInfo>? listaModulos = await _modulosBAL.obtenerListaEntidades();
                if (listaModulos != null && listaModulos.Count > 0)
                {
                    foreach (ModulosInfo moduloItem in listaModulos)
                    {
                        flowLayoutPanelModulos.Controls.Add(
                            new RadioButton() { Text = moduloItem.Nombre, Checked = false, Name = $"radioButton{moduloItem.Nombre}", AutoSize = true, Font = YibTronFronted.Utilerias.Letras.letraPrimaria(12) }
                            );
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }
        #endregion TabPage Perfiles

        public void cambiarLetraControles(Control control, int tamaño)
        {
            foreach (Control controlItem in control.Controls)
            {
                cambiarLetraControles(controlItem, tamaño);
            }
            control.Font = YibTronFronted.Utilerias.Letras.letraPrimaria(tamaño);
        }

        #endregion Métodos

        #region Eventos...

        #region TabPages Perfiles...

        private void iconButtonGuardarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RadioButton? radioButtonModulo = flowLayoutPanelModulos.Controls.OfType<RadioButton>().FirstOrDefault(radioButtonItem => radioButtonItem.Checked == true);

                if (string.IsNullOrEmpty(textBoxNombrePerfil.Text)) throw new Exception("Favor de escribir un nombre para el perfil.");
                if (checkedListBoxPermisos.CheckedIndices.Count == 0) throw new Exception("Favor de seleccionar los permisos para el perfil.");
                if (radioButtonModulo == null) throw new Exception("Favor de seleccionar el modulo en el que tendrá los permisos este perfil.");

                PerfilesInfo perfilInfo = new PerfilesInfo
                {
                    Nombre = textBoxNombrePerfil.Text
                };


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion TabPages Perfiles

        private void buttonAgregarOperacion_Click(object sender, EventArgs e)
        {
            try
            {
                _operacionesBAL.guardar(new OperacionesInfo { Id = 0, Nombre = textBoxNombreOperacion.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAgregarModulo_Click(object sender, EventArgs e)
        {
            try
            {
                _modulosBAL.guardar(new ModulosInfo { Id = 0, Nombre = textBoxNombreModulo.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PantallaUsuarios_1001_Resize(object sender, EventArgs e)
        {
            if (Height >= 500)
            {
                switch (tabControlPrincipal.SelectedTab.Text)
                {
                    case "Usuarios":
                        break;
                    case "Roles":
                        break;
                    case "Perfiles":
                        cambiarLetraControles(tabPagePerfiles, 14);
                        break;
                }
            }
            else
            {
                switch (tabControlPrincipal.SelectedTab.Text)
                {
                    case "Usuarios":
                        break;
                    case "Roles":
                        break;
                    case "Perfiles":
                        cambiarLetraControles(tabPagePerfiles, 12);

                        break;
                }
            }
        }



        #endregion Eventos

        private void checkedListBoxPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox checkBox = (CheckedListBox)sender;

            if (checkBox.SelectedItem != null)
            {
                string textCheckBoxSeleccionado = checkBox.SelectedItem.ToString()!.Trim();
                bool isControlTotalChecked = false;

                foreach (string item in checkBox.CheckedItems)
                {
                    if (item.Equals("Control total"))
                    {
                        isControlTotalChecked = true;
                    }
                }

                if (!textCheckBoxSeleccionado.Equals("Control total") && isControlTotalChecked)
                {
                    checkBox.SetItemChecked(checkBox.SelectedIndex, false);
                    MessageBox.Show("Favor de desmarcar la casilla de \"Control total\" ", "Alerta");
                }
                else
                {
                    if (textCheckBoxSeleccionado.Equals("Control total"))
                    {
                        foreach (int indexItem in checkBox.CheckedIndices)
                        {
                            if (indexItem != checkBox.SelectedIndex)
                            {
                                ObjectCollection collectionItems = checkBox.Items;
                                checkBox.SetItemChecked(indexItem, false);
                            }
                        }

                    }
                }
            }


        }
    }
}
