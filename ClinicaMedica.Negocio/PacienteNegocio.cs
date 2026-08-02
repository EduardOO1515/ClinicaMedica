using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de pacientes
    public class PacientesNegocio
    {
        private readonly IPacientesRepositorio _dal;

        public PacientesNegocio()
        {
            _dal = new PacientesDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // Valida el formato de los campos antes de insertar el paciente
        public async Task<string> RegistrarPacienteAsync(string cedula, string nombre, string apellido,
                                                         DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cedula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacio.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacio.";

            if (fechaNac >= DateTime.Now)
                return "La fecha de nacimiento no es valida.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El telefono debe tener formato 000-000-0000.";

            await _dal.InsertarAsync(cedula, nombre, apellido, fechaNac, telefono, tieneSeguro);
            return "OK";
        }

        public async Task<string> ActualizarPacienteAsync(int id, string cedula, string nombre, string apellido,
                                                          DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cedula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacio.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacio.";

            if (fechaNac >= DateTime.Now)
                return "La fecha de nacimiento no es valida.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El telefono debe tener formato 000-000-0000.";

            await _dal.InsertarAsync(cedula, nombre, apellido, fechaNac, telefono, tieneSeguro);
            return "OK";
        }

        public async Task<string> EliminarPacienteAsync(int id)
        {
            if (id <= 0)
                return "ID de paciente no valido.";
            await _dal.EliminarAsync(id);
            return "OK";
        }

        // Filtro en memoria: no requiere acceso a base de datos
        public List<DataRow> FiltrarPacientes(DataTable tabla, Func<DataRow, bool> filtro)
        {
            List<DataRow> resultado = new List<DataRow>();
            foreach (DataRow fila in tabla.Rows)
                if (filtro(fila))
                    resultado.Add(fila);
            return resultado;
        }

        // Metodo utilitario para previsualizar el costo de una cita antes de guardarla
        public decimal CalcularCostoCita(bool tieneSeguro)
        {
            Paciente p = new Paciente("00000000000", "Temp", "Temp",
                tieneSeguro ? "Seguro" : "NoSeguro", DateTime.Now, tieneSeguro);
            return p.CalcularCosto();
        }
    }
}
