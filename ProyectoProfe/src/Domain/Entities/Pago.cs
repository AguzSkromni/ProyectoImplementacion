using System;

namespace Domain
{
    public class Pago
    {
        public Guid Id { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}