using System;

namespace inventario_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p = new Producto();
            p.Codigo = 1;
            p.Descripcion = "iPhone X";
            p.Precio = 10000;
            p.Fecha = DateTime.Now;

            Producto prod = new Producto();
            prod.Codigo = 2;
            prod.Descripcion = "Samsung Galaxy S21";
            

            Console.WriteLine("Producto 1: " + p.Descripcion );
            Console.WriteLine("Producto 2: " + prod.Descripcion );
        }
    }
}
