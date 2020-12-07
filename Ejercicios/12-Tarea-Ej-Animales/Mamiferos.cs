using System;
public class Mamiferos: Animal
{
    public string Tipo { get; set; }
    public int Patas { get; set; }

    public Mamiferos(string nombre, string especie, string familia, string habitat, string alimentacion, string tipo, string reproduccion, int patas)
    {
        Nombre = nombre;
        Especie = especie;
        Familia = familia;
        Habitat = habitat;
        Alimentacion = alimentacion;
        Tipo = tipo;
        Reproduccion = reproduccion;
        Patas = patas;
        
    }

    public Mamiferos(string informacion, string sonido)
    {
        Informacion = informacion;
        Sonido = sonido;
    }
    public void Datos(string informacion)
    {
    
        Console.WriteLine(informacion);
    }

    public void Sonidos(string sonido)
    {
        Console.WriteLine(sonido);
    }
   
}