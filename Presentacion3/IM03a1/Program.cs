using System;

namespace IM03a1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONECCION CON BASE DE DATOS DEL PROFESOR
            //String _connectionString = "Data Source=im03.database.windows.net ;Initial Catalog=db ;User ID= AdminDB ; Password = P@$$w0rd;";

            //String _connectionString = "Data Source=unitec-db.database.windows.net ;Initial Catalog=im ; User ID= AdminDB ; Password = P@$$w0rd;";

            //CONECCION CON BASE DE DATOS AGUS LOCAL LAPTOP
            //String _connectionString = "Data Source = SKR-PC; Initial Catalog = Test; Integrated Security = True";

            //CONECCION CON BASE DE DATOS AGUS LOCAL PC
            String _connectionString = "Data Source = SKROMNIPC; Initial Catalog = Test; Integrated Security = True";
            var _empleadosDbContext = new EmpleadosDbContext(_connectionString);

            //IMPRESION POR CONSOLA LOS REGISTROS
            Console.Write($"Registros:\n");
            var list = _empleadosDbContext.List();
            foreach (Empleado e in list)
            {
                Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
            }


            Empleado empleado = new Empleado
            {
                Id = Guid.NewGuid(),
                Nombre = "Prueba Base",
                Edad = 30
            };


            Empleado empleadoBorrar = new Empleado
            {
                Id = Guid.Parse("2132fbd7-5975-4b17-bbfd-7ef97fa9ea01")
            };

            /*
                        Console.Write($"\nInsertar: {empleado.Id}\n");
                        _empleadosDbContext.Create(empleado);
                        list = _empleadosDbContext.List();
                        foreach (Empleado e in list)
                        {
                            Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
                        }
            */

            /*
            empleado.Edad = 25;
            Console.Write($"\nModificar: {empleado.Id} con la edad {empleado.Edad}\n");
            _empleadosDbContext.Edit(empleado);
            list = _empleadosDbContext.List();
            foreach (Empleado e in list)
            {
                Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
            }
            */


            Console.Write($"\nEliminar: {empleadoBorrar.Id}\n");
            _empleadosDbContext.Delete(empleadoBorrar.Id);
            list = _empleadosDbContext.List();
            foreach (Empleado e in list)
            {
                Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
            }

        }
    }
}