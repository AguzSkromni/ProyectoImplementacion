using System;

public class Alumnos
{
    //ATRIBUTOS
    private static int contadorAlumno;
    public int idAlumno;
    public string nombre;
    public int cuenta;
    public float promedio;

    //CONSTRUCTOR
    public Alumnos(string nombre, int cuenta, float promedio){
        this.idAlumno = ++contadorAlumno;
        this.nombre = nombre;
        this.cuenta = cuenta;
        this.promedio = promedio;
    }
}
