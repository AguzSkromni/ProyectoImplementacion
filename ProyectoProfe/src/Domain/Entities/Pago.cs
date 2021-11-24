using System;

namespace Domain
{
    public class Pago
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; } 
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public string Foto { get; set;}
    }
}