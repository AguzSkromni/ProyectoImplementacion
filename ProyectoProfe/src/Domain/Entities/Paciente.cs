using System;

namespace Domain
{
    public class Paciente
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Expediente { get; set; }
        public string Foto { get; set; }
    }
}