using System;

namespace pryZarateSP1._2.Models
{
    public class Medico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int EspecialidadId { get; set; }

        // Parameterless constructor required for object initializers
        public Medico() { }

        // Existing constructor (kept for compatibility)
        public Medico(string nombre,
            string apellido,
            int especialidad,
            int matricula)
        {
            Nombre = nombre;
            Apellido = apellido;
            EspecialidadId = especialidad;
            Matricula = matricula;
        }

        // Convenience constructor commonly used in repository code
        public Medico(int matricula, string nombre, int especialidadId)
        {
            Matricula = matricula;
            Nombre = nombre;
            EspecialidadId = especialidadId;
        }

        public override string ToString()
        {
            return $"{Matricula} - {Nombre} {Apellido} (EspecialidadId: {EspecialidadId})";
        }
    }
}
