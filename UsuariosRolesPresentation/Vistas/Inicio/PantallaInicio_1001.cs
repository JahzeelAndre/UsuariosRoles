using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosRolesBackend.Negocio;

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
                CrearBD crearBD = new CrearBD() { CadenaConexion = "server=DESKTOP-KAM2QVH\\SQLEXPRESS;Integrated Security=true;TrustServerCertificate=true;" };
                await crearBD.generarBaseDeDatos();
                MessageBox.Show("La base de datos se ha generado correctamente.");
            }
            catch(Exception ex)
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
