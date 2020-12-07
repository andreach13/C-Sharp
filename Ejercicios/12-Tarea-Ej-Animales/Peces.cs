using System;
public class Peces: Animal
{
    public string Escamas { get; set; }

    public Peces(string nombre, string especie, string familia, string habitat, string alimentacion, string reproduccion, string escamas)
    {
        Nombre = nombre;
        Especie = especie;
        Familia = familia;
        Habitat = habitat;
        Alimentacion = alimentacion;
        Reproduccion = reproduccion;
        Escamas = escamas;
    }


    public Peces(string informacion)
    {
        Informacion = informacion;
    }

    public void Datos(string informacion)
    {
    
        Console.WriteLine(informacion);
    }

    
    
}