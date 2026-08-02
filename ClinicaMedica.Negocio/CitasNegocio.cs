using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de citas medicas
    public class CitasNegocio
    {
        private readonly ICitasRepositorio _dal;

        public CitasNegocio()
        {
            _dal = new CitasDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // Valida que la cita tenga paciente, doctor y fecha futura antes de guardar
        public async Task<string> RegistrarCitaAsync(int idPaciente, int idDoctor, DateTime fechaCita,
                                                     string estado, string tipoConsulta, decimal costo)
        {
            if (idPaciente <= 0)
                return "Debe seleccionar un paciente.";
            if (idDoctor <= 0)
                return "Debe seleccionar un doctor.";
            if (fechaCita < DateTime.Now)
                return "La fecha de la cita no puede ser en el pasado.";
            if (costo < 0)
                return "El costo no puede ser negativo.";

            await _dal.InsertarAsync(idPaciente, idDoctor, fechaCita, estado, tipoConsulta, costo);
            return "OK";
        }

        public async Task<string> ActualizarCitaAsync(int id, int idPaciente, int idDoctor, DateTime fechaCita,
                                                      string estado, string tipoConsulta, decimal costo)
        {
            if (idPaciente <= 0)
                return "Debe seleccionar un paciente.";
            if (idDoctor <= 0)
                return "Debe seleccionar un doctor.";
            if (costo < 0)
                return "El costo no puede ser negativo.";

            await _dal.ActualizarAsync(id, idPaciente, idDoctor, fechaCita, estado, tipoConsulta, costo);
            return "OK";
        }

        public async Task<string> EliminarCitaAsync(int id)
        {
            if (id <= 0)
                return "ID de cita no valido.";
            await _dal.EliminarAsync(id);
            return "OK";
        }

        // Filtro en memoria: aplica un predicado lambda sobre la tabla ya cargada
        public List<DataRow> FiltrarCitas(DataTable tabla, Func<DataRow, bool> filtro)
        {
            List<DataRow> resultado = new List<DataRow>();
            foreach (DataRow fila in tabla.Rows)
                if (filtro(fila))
                    resultado.Add(fila);
            return resultado;
        }
    }
}
