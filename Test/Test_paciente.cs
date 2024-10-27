using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;

class Test_paciente
{
    //static void Main(string[] args)
    public void test_paciente()
    {
        // Crear una instancia de la clase Conexion
        Conexion conexion = new Conexion();

        // Crear una instancia de Paciente, pasando la conexión
        Paciente pacienteNuevo = new Paciente(conexion);

        // Insertar un nuevo paciente
        pacienteNuevo.InsertarPaciente("Juan Pérez", 25061243, DateTime.Now, 48, "Masculino", "2235903633",
          "Calle Falsa 123", "ori@live.com.ar", "Soltero", "ds", "d");

        Console.WriteLine("Operación completada.");
    }
}
