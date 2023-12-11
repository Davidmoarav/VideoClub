using System;
using VideoClub;

public class Program{
    static void Main(string[] args){
        Cliente cliente1 = new Cliente("jorge","perez","213131","holamundo@dad.cl");
        

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("===== Menú =====");
            Console.WriteLine("1. Boleta");
            Console.WriteLine("2. Peliculas");
            Console.WriteLine("3. Agregar Película");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has elegido la opción 1.");
                    // poner el código de la boleta
                    cliente1.MostrarInformacionCliente();
                    break;
                case "2":
                    Console.WriteLine("Has elegido la opción 2.");
                    break;
                case "3":
                    Console.WriteLine("Has elegido Agregar Película");
                    Console.WriteLine("Ingrese Titulo de la Película:");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Ingrese Género de la Película:");
                    string genero = Console.ReadLine();
                    
                    Console.WriteLine("Ingrese Cantidad de Ejemplares:");
                    int cantidadEjemplares = Convert.ToInt32(Console.ReadLine());
                    
                    Pelicula peli = new Pelicula(titulo, genero, cantidadEjemplares);
                    break;
                case "4":
                    Console.WriteLine("Has elegido salir. ¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción del menú.");
                    break;
            }
        }

    }
}
