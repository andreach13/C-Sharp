using System;
public class Aves: Animal
{
    public string Plumaje { get; set; }
    public bool Vuelo { get; set; }


    public Aves(string nombre, string especie, string familia, string habitat, string alimentacion, string reproduccion, string plumaje)
    {
        Nombre = nombre;
        Especie = especie;
        Familia = familia;
        Habitat = habitat;
        Alimentacion = alimentacion;
        Plumaje = plumaje;
        Reproduccion = reproduccion;
        
    }

    public Aves(string informacion, bool vuelo)
    {
        Informacion = informacion;
        Vuelo = vuelo;
    }

    public void Datos(string informacion)
    {
    
        Console.WriteLine(informacion);
    }

    public void Volar(bool vuelo)
    {
        Console.WriteLine(vuelo);
    }
}