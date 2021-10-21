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
            String _connectionString = "Data Source = SKR-PC; Initial Catalog = Test; Integrated Security = True";

            //CONECCION CON BASE DE DATOS AGUS LOCAL PC
            //String _connectionString = "Data Source = SKROMNIPC; Initial Catalog = Test; Integrated Security = True";
            var _empleadosDbContext = new EmpleadosDbContext(_connectionString);

            //Creacion de variables
            int opcion;

            //INICIA OPCIONES
            do
            {
                //Inicio de programa
                Console.Write($"----------------------------------");
                Console.Write($"Programa para actualizar base de Datos desde consola");
                Console.Write($"----------------------------------");

                //Menu de opciones
                Console.Write($"1.- Listado de Empleados\n");
                Console.Write($"2.- Insertar nuevo Empleado\n");
                Console.Write($"3.- Modificar 1 empleado\n");
                Console.Write($"4.- Borrar empleado\n");
                Console.Write($"5.- Salir");

                Console.Write($"\nIngrese la opcion que requiera: \n");
                //leer consola
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    //CASO 1
                    case 1:
                        //IMPRESION POR CONSOLA LOS REGISTROS
                        Console.WriteLine("\n");
                        Console.Write($"Registros:\n");
                        var list = _empleadosDbContext.List();
                        foreach (Empleado e in list)
                        {
                            Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
                        }
                        Console.WriteLine("\n");
                        break; //FIN DE CASO 1

                    // CASO 2
                    case 2:
                        Console.WriteLine("\n");
                        Console.Write($"Ingresar Nuevo Empleado:\n");
                        Console.Write($"Nombre: \n");
                        String nombreEmpleado = Convert.ToString(Console.ReadLine());
                        Console.Write($"\nEdad: \n");
                        int edadEmpleado = Convert.ToInt32(Console.ReadLine());

                        //creacion de objeto Empleado
                        Empleado empleado = new Empleado
                        {
                            Id = Guid.NewGuid(),
                            Nombre = nombreEmpleado,
                            Edad = edadEmpleado
                        };

                        Console.Write($"\nInsertar: {empleado.Id}\n");
                        Console.Write("\n");
                        _empleadosDbContext.Create(empleado);
                        list = _empleadosDbContext.List();
                        foreach (Empleado e in list)
                        {
                            Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
                        }

                        Console.WriteLine("\n");
                        break; // FIN DE CASO 2

                    //CASO 3
                    case 3:
                        Console.WriteLine("\n");
                        Console.Write($"Ingrese ID para modificar Empleado: \n");
                        Console.Write($"ID: \n");
                        var IDUpdate = Guid.Parse(Console.ReadLine());

                        Console.Write($"Ingrese nombre a Modificar: \n");
                        String nombreUpdate = Console.ReadLine();

                        Console.Write($"Ingrese la edad a Modificar: \n");
                        int edadUpdate = Convert.ToInt32(Console.ReadLine());

                        //creacion de objeto Empleado
                        Empleado empleadoUpdate = new Empleado
                        {
                            Id = IDUpdate,
                            Nombre = nombreUpdate,
                            Edad = edadUpdate
                        };

                        Console.Write($"\nModificar: {empleadoUpdate.Id} con la edad {empleadoUpdate.Edad}\n");
                        Console.Write("\n");
                        _empleadosDbContext.Edit(empleadoUpdate);
                        list = _empleadosDbContext.List();
                        foreach (Empleado e in list)
                        {
                            Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
                        }
                        Console.WriteLine("\n");
                        break; //FIN DE CASO 3

                    //CASO 4
                    case 4:
                        Console.WriteLine("\n");
                        Console.Write($"Ingrese ID para borrar Empleado: \n");
                        Console.Write($"ID: \n");
                        var IDErase = Guid.Parse(Console.ReadLine());

                        Empleado empleadoBorrar = new Empleado
                        {
                            Id = IDErase
                        };

                        Console.Write($"\nEliminar: {empleadoBorrar.Id}\n");
                        Console.Write("\n");
                        _empleadosDbContext.Delete(empleadoBorrar.Id);
                        list = _empleadosDbContext.List();
                        foreach (Empleado e in list)
                        {
                            Console.Write($"\tId: {e.Id} \tNombre: {e.Nombre} \tEdad: {e.Edad}\n");
                        }

                        Console.WriteLine("\n");
                        break; //FIN DE CASO 4

                    //CASO 5
                    case 5:
                        Console.WriteLine("\n");
                        Console.WriteLine("Aplicacion esta por cerrar....\n");
                        Console.ReadLine();

                        
                        Console.WriteLine("\n");
                        opcion=5;
                        break; //fin de caso 5

                    default:
                        Console.Write($"Opcion Incorrecta");
                        break;
                }

            } while (opcion != 5);//TERMINA OPCIONES

        }//termina main
    }
}