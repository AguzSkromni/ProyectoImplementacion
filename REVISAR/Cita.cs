using System;

namespace Domain
{
    public class Cita
    {
        public Guid Id { get; set; }
        public virtual Paciente Paciente { get; set; }
        public short Estatus { get; set; }
        public DateTime Fecha { get; set; }
    }
}
