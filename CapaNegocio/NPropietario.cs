using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos.Interface;


namespace CapaNegocio
{
    public class NPropietario
    {
        // Constructor que inicializa la clase con un objeto Propietario
        public readonly Propietario _propietario;

        public NPropietario(Propietario propietarioRepositorio)
        {
            _propietario = propietarioRepositorio;
        }

        // Método para guardar un nuevo propietario
        public void GuardarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            // Verificar que todos los campos no estén vacíos o en blanco
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(apellidos) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                // Lanzar una excepción si algún campo está vacío o en blanco
                throw new ArgumentException("Todos los campos deben ser completados.");
            }

            // Llamar al método InsertarPropietario para guardar el propietario en la base de datos
            _propietario.InsertarPropietario(dni, nombres, apellidos, correo, telefono, direccion);
        }
    }
}
