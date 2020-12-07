using System;
public class Anfibios: Animal
{
    public bool Piel { get; set; }    
    public int Patas { get; set; }

    public Anfibios(string nombre, string especie, string familia, string habitat, string alimentacion, string reproduccion, int patas)
    {
        Nombre = nombre;
        Especie = especie;
        Familia = familia;
        Habitat = habitat;
        Alimentacion = alimentacion;
        Reproduccion = reproduccion;
        Patas = patas;
    }


    public Anfibios(string informacion, bool piel)
    {
        Informacion = informacion;
        Piel = piel;
    }

    public void Datos(string informacion)
    {
    
        Console.WriteLine(informacion);
    }

    public void Toxixidad(bool piel)
    {
        Console.WriteLine(piel);
    }

}