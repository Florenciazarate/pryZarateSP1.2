using System.Collections.Generic;
using System.Linq;
using pryZarateSP1._2.Models;

namespace pryZarateSP1._2.Data
{
    public static class Repository
    {
        private static readonly List<Especialidad> especialidades = new List<Especialidad>
        {
            new Especialidad { Id = 1, Nombre = "Cardiología" },
            new Especialidad { Id = 2, Nombre = "Pediatría" }
        };

        private static readonly List<Medico> medicos = new List<Medico>
        {
            new Medico { Matricula = 1001, Nombre = "Ana", Apellido = "Pérez", EspecialidadId = 1 },
            new Medico { Matricula = 1002, Nombre = "Luis", Apellido = "Gómez", EspecialidadId = 2 }
        };

        public static IEnumerable<Especialidad> GetEspecialidades()
        {
            return especialidades.ToList();
        }

        public static IEnumerable<Medico> GetMedicos()
        {
            return medicos.ToList();
        }

        public static IEnumerable<Medico> GetMedicosByEspecialidadId(int especialidadId)
        {
            return medicos.Where(m => m.EspecialidadId == especialidadId).ToList();
        }

        public static bool AddEspecialidad(Especialidad e, out string errorMessage)
        {
            errorMessage = null;
            if (e == null)
            {
                errorMessage = "Especialidad inválida.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(e.Nombre))
            {
                errorMessage = "El nombre de la especialidad no puede estar vacío.";
                return false;
            }

            if (especialidades.Any(x => x.Id == e.Id))
            {
                errorMessage = $"Ya existe una especialidad con Id {e.Id}.";
                return false;
            }

            especialidades.Add(new Especialidad { Id = e.Id, Nombre = e.Nombre.Trim() });
            return true;
        }

        public static bool AddMedico(Medico m, out string errorMessage)
        {
            errorMessage = null;
            if (m == null)
            {
                errorMessage = "Médico inválido.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.Nombre))
            {
                errorMessage = "El nombre del médico no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.Apellido))
            {
                errorMessage = "El apellido del médico no puede estar vacío.";
                return false;
            }

            if (!especialidades.Any(e => e.Id == m.EspecialidadId))
            {
                errorMessage = "La especialidad indicada no existe.";
                return false;
            }

            if (medicos.Any(x => x.Matricula == m.Matricula))
            {
                errorMessage = $"Ya existe un médico con matrícula {m.Matricula}.";
                return false;
            }

            medicos.Add(new Medico { Matricula = m.Matricula, Nombre = m.Nombre.Trim(), Apellido = m.Apellido.Trim(), EspecialidadId = m.EspecialidadId });
            return true;
        }

        // Actualiza el nombre, apellido y la especialidad de un médico identificado por su matrícula.
        public static bool UpdateMedico(int matricula, string nombre, string apellido, int especialidadId, out string errorMessage)
        {
            errorMessage = null;
            var medico = medicos.FirstOrDefault(m => m.Matricula == matricula);
            if (medico == null)
            {
                errorMessage = $"No se encontró un médico con matrícula {matricula}.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                errorMessage = "El nombre del médico no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                errorMessage = "El apellido del médico no puede estar vacío.";
                return false;
            }

            if (!especialidades.Any(e => e.Id == especialidadId))
            {
                errorMessage = "La especialidad indicada no existe.";
                return false;
            }

            medico.Nombre = nombre.Trim();
            medico.Apellido = apellido.Trim();
            medico.EspecialidadId = especialidadId;
            return true;
        }

        // Elimina un médico por matrícula
        public static bool RemoveMedico(int matricula, out string errorMessage)
        {
            errorMessage = null;
            var medico = medicos.FirstOrDefault(m => m.Matricula == matricula);
            if (medico == null)
            {
                errorMessage = $"No se encontró un médico con matrícula {matricula}.";
                return false;
            }

            medicos.Remove(medico);
            return true;
        }
    }
}