using System;

namespace VideoClub
{
    public class VideoClub
    {
        private List<Pelicula> inventario;

        public VideoClub()
        {
            inventario = new List<Pelicula>();
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            inventario.Add(pelicula);
        }

        public void ModificarPelicula(Pelicula pelicula)
        {
            int index = inventario.FindIndex(p => p.Titulo == pelicula.Titulo);
            if (index != -1)
            {
                inventario[index] = pelicula;
            }
        }

        public void EliminarPelicula(Pelicula pelicula)
        {
            int index = inventario.FindIndex(p => p.Titulo == pelicula.Titulo);
            if (index != -1)
            {
                inventario.RemoveAt(index);
            }
        }

        public List<Pelicula> ObtenerInventario()
        {
            return inventario;
        }

        public void GenerarBoleta(Arriendo arriendo)
        {
            // Imprime los datos del arriendo
            Console.WriteLine("===== Boleta de arriendo =====");
            Console.WriteLine("Película: {0}", arriendo.Pelicula.Titulo);
            Console.WriteLine("Cliente: {0} {1}", arriendo.Cliente.Nombre, arriendo.Cliente.Apellido);
            Console.WriteLine("Fecha de arriendo: {0}", arriendo.FechaArriendo);
            Console.WriteLine("Fecha de devolución: {0}", arriendo.FechaDevolucion);

            // Calcula el precio del arriendo
            int precio = arriendo.Pelicula.CantidadVecesArrendada * 2000;

            // Imprime el precio del arriendo
            Console.WriteLine("Precio: {0}", precio);
        }
    }
}
