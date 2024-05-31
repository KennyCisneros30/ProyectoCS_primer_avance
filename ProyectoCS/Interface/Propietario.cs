using ProyectoCS.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.Interface
{
    public class Propietario
    {
        private readonly ConeccionSQL _conexionSQL;

        // Constructor que inicializa la clase Propietario con un objeto ConeccionSQL
        public Propietario(ConeccionSQL conexionSQL)
        {
            _conexionSQL = conexionSQL;
        }
        // Método para insertar un nuevo registro de Propietario en la base de datos
        public void InsertarPropietario(string dni, string nombres, string apellidos, string correo, string telefono, string direccion)
        {
            // Abrir una conexión a la base de datos
            using (SqlConnection connection = _conexionSQL.AbrirConexion())
            {
                // Crear un nuevo SqlCommand para el procedimiento almacenado "InsertarPropietario"
                using (SqlCommand command = new SqlCommand("InsertarPropietario", connection))
                {
                    // Especificar que el comando es un procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros al comando, que se pasarán al procedimiento almacenado
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Direccion", direccion);

                    // Ejecutar el comando para insertar los datos en la base de datos
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
