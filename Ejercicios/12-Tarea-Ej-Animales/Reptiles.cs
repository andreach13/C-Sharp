using System;
public class Reptiles: Animal
{
    public string Longitud { get; set; }
    public Reptiles(string nombre, string especie, string familia, string habitat, string alimentacion, string reproduccion, string longitud)
    {
        Nombre = nombre;
        Especie = especie;
        Familia = familia;
        Habitat = habitat;
        Alimentacion = alimentacion;
        Reproduccion = reproduccion;
        Longitud = longitud;
        
    }

    public Reptiles(string informacion)
    {
        Console.WriteLine(informacion);
    }

    public void Datos(string informacion)
    {
    
        Console.WriteLine(informacion);
    }
}