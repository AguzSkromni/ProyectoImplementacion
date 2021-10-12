using System;

public class Alumno{

    //ATRIBUTOS
    private static int contadorAlumno;
    public int idAlumno;
    public string nombre { get; set; }
    public int cuenta { get; set; }
    public double promedio { get; set; }

    //CONSTRUCTORES
    public Alumno(string nombre, int cuenta, double promedio){
        this.idAlumno = ++contadorAlumno;
        this.nombre = nombre;
        this.cuenta = cuenta;
        this.promedio = promedio;
    }
}