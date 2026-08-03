using System;
using System.Data;
using System.Threading.Tasks;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para la gestion de expedientes medicos
    public class ExpedientesNegocio
    {
        private readonly IExpedientesRepositorio _dal;

        public ExpedientesNegocio()
        {
            _dal = new ExpedientesDAL();
        }

        public async Task<DataTable> ObtenerTodosAsync()
        {
            return await _dal.ObtenerTodosAsync();
        }

        // FechaRegistro siempre se establece como la fecha y hora actuales al guardar
        public async Task<string> RegistrarExpedienteAsync(int idCita, string diagnostico, string tratamiento)
        {
            if (idCita <= 0)
                return "Debe seleccionar una cita.";

            if (string.IsNullOrWhiteSpace(diagnostico))
                return "El diagnostico es obligatorio.";

            await _dal.InsertarAsync(idCita, diagnostico, tratamiento, DateTime.Now);
            return "OK";
        }

        public async Task<string> ActualizarExpedienteAsync(int id, string diagnostico, string tratamiento)
        {
            if (id <= 0)
                return "ID de expediente no valido.";

            if (string.IsNullOrWhiteSpace(diagnostico))
                return "El diagnostico es obligatorio.";

            await _dal.ActualizarAsync(id, diagnostico, tratamiento);
            return "OK";
        }
    }
}
