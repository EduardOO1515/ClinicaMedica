using System;
using System.Collections.Generic;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    public class PacientesNegocio
    {
        private PacientesDAL _dal = new PacientesDAL();

        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        public string RegistrarPaciente(string cedula, string nombre, string apellido,
                                DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cédula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacío.";

            if (fechaNac >= DateTime.Now)
                return "La fecha de nacimiento no es válida.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El teléfono debe tener formato 000-000-0000.";

            _dal.Insertar(cedula, nombre, apellido, fechaNac, telefono, tieneSeguro);
            return "OK";
        }

        public string ActualizarPaciente(int id, string cedula, string nombre, string apellido,
                                          DateTime fechaNac, string telefono, bool tieneSeguro)
        {
            if (string.IsNullOrWhiteSpace(cedula) || cedula.Length != 13)
                return "La cédula debe tener formato 000-0000000-0.";

            if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length < 2)
                return "El nombre no puede estar vacío.";

            if (string.IsNullOrWhiteSpace(apellido) || apellido.Trim().Length < 2)
                return "El apellido no puede estar vacío.";

            if (fechaNac >= DateTime.Now)
                return "La fecha de nacimiento no es válida.";

            if (string.IsNullOrWhiteSpace(telefono) || telefono.Length != 12)
                return "El teléfono debe tener formato 000-000-0000.";

            _dal.Insertar(cedula, nombre, apellido, fechaNac, telefono, tieneSeguro);
            return "OK";
        }

        public string EliminarPaciente(int id)
        {
            if (id <= 0)
                return "ID de paciente no válido.";
            _dal.Eliminar(id);
            return "OK";
        }

        //TODO Método como función — Func<DataRow, bool>
        public List<DataRow> FiltrarPacientes(DataTable tabla, Func<DataRow, bool> filtro)
        {
            List<DataRow> resultado = new List<DataRow>();
            foreach (DataRow fila in tabla.Rows)
                if (filtro(fila))
                    resultado.Add(fila);
            return resultado;
        }

        public decimal CalcularCostoCita(bool tieneSeguro)
        {
            Paciente p = new Paciente("00000000000", "Temp", "Temp",
                tieneSeguro ? "Seguro" : "NoSeguro", DateTime.Now, tieneSeguro);
            return p.CalcularCosto();
        }
    }
}