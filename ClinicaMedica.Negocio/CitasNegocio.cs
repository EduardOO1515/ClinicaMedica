using System;
using System.Collections.Generic;
using System.Data;
using ClinicaMedica.Datos;

namespace ClinicaMedica.Negocio
{
    public class CitasNegocio
    {
        private CitasDAL _dal = new CitasDAL();

        public DataTable ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        public string RegistrarCita(int idPaciente, int idDoctor, DateTime fechaCita,
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

            _dal.Insertar(idPaciente, idDoctor, fechaCita, estado, tipoConsulta, costo);
            return "OK";
        }

        public string ActualizarCita(int id, int idPaciente, int idDoctor, DateTime fechaCita,
                                      string estado, string tipoConsulta, decimal costo)
        {
            if (idPaciente <= 0)
                return "Debe seleccionar un paciente.";
            if (idDoctor <= 0)
                return "Debe seleccionar un doctor.";
            if (costo < 0)
                return "El costo no puede ser negativo.";

            _dal.Actualizar(id, idPaciente, idDoctor, fechaCita, estado, tipoConsulta, costo);
            return "OK";
        }

        public string EliminarCita(int id)
        {
            if (id <= 0)
                return "ID de cita no válido.";
            _dal.Eliminar(id);
            return "OK";
        }

        //TODO Método como función — filtrar citas usando Func
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