﻿using System;

namespace _9_Notas_escolares
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela(1, "Happy");

            Alumno alumno = new Alumno(5, "Pablo", "44444");
            alumno.Direccion = "SPS";
            alumno.NoCarnet = "12345";

            escuela.matricularAlumno(alumno);

            escuela.mostrarAlumnos();            
            
        }
    }
}
