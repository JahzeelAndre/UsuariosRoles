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
using UsuariosRolesBackend.Negocio;
using UsuariosRolesPresentation.Vistas.Usuarios;

namespace UsuariosRolesPresentation.Vistas.Inicio
{
    public partial class PantallaInicio_1001 : YibTronFronted.Controles.PantallaInicio_1001
    {
        public PantallaInicio_1001()
        {
            InitializeComponent();
            IniciarVariables();
            IniciarComponentes();
        }

        private async void iconButtonGenerarBD_Click(object sender, EventArgs e)
        {
            activarBotonNavegacion(sender);
            try
            {
                Cursor = Cursors.WaitCursor;
                CrearBD crearBD = new CrearBD() { CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString };
                await crearBD.generarBaseDeDatos();
                MessageBox.Show("La base de datos se ha generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, ha ocurrido el siguiente error: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void iconButtonUsuarios_Click(object sender, EventArgs e)
        {
            activarBotonNavegacion(sender);
            try
            {
                Cursor = Cursors.WaitCursor;
                PantallaUsuarios_1001 pantallaUsuarios_1001 = new PantallaUsuarios_1001();
                pantallaUsuarios_1001.Dock = DockStyle.Fill;
                splitContainerContenido.Panel2.Controls.Clear();
                splitContainerContenido.Panel2.Controls.Add(pantallaUsuarios_1001);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, ha ocurrido el siguiente error: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
