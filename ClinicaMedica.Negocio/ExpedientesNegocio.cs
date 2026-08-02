using System;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    // Logica de negocio para el modulo de Expedientes.
    public class ExpedientesNegocio
    {
        private ExpedientesDAL _dal = new ExpedientesDAL();

        // Retorna todos los expedientes sin filtro.
        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        // Valida los datos y registra un nuevo expediente.
        // La fecha de registro se establece automaticamente con la fecha actual.
        // Retorna "OK" si fue exitoso o un mensaje de error si falla la validacion.
        public string RegistrarExpediente(int idCita, string diagnostico, string tratamiento)
        {
            if (idCita <= 0)
                return "Debe seleccionar una cita.";

            if (string.IsNullOrWhiteSpace(diagnostico))
                return "El diagnostico es obligatorio.";

            _dal.Insertar(idCita, diagnostico, tratamiento, DateTime.Now);
            return "OK";
        }
    }
}
