using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos.Interface;
using CapaNegocio;

namespace CapaVisual
{
    public partial class frmPropietario : Form
    {
        // Constructor que inicializa la clase con un objeto NPropietario
        private NPropietario _propietarioNegocio;

        public frmPropietario(NPropietario propietarioNegocio)
        {
            InitializeComponent();
            _propietarioNegocio = propietarioNegocio;
        }

        // Método que se ejecuta al hacer clic en el botón GuardarPropietario
        private void GuardarPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar el propietario usando los valores de los TextBox
                _propietarioNegocio.GuardarPropietario(
                    DNITextBox.Text,
                    NombresTextBox.Text,
                    ApellidosTextBox.Text,
                    CorreoTextBox.Text,
                    TelefonoTextBox.Text,
                    DireccionTextBox.Text
                );
                // Mostrar mensaje de éxito
                MessageBox.Show("Propietario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox después de guardar exitosamente
                DNITextBox.Clear();
                NombresTextBox.Clear();
                ApellidosTextBox.Clear();
                CorreoTextBox.Clear();
                TelefonoTextBox.Clear();
                DireccionTextBox.Clear();
            }

            // Mostrar mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar propietario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPropietario_Load(object sender, EventArgs e)
        {

        }
    }
}