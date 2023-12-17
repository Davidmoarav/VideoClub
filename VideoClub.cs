using System;

namespace VideoClub
{
    class VIDEOCLUB
    {
        private List<Pelicula> pedido;
        public VIDEOCLUB()
        {
            pedido = new List<Pelicula>();
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            pedido.Add(pelicula);
        }
        public void MostrarPeliculas()
        {
            foreach (Pelicula pelicula in pedido)
            {
                pelicula.MostrarDetalles();
            }
        }

         // Sobrecarga del operador -
        public static VIDEOCLUB operator -(VIDEOCLUB videoclub, Pelicula pelicula)
        {
        
        // Busca la película por su título
            Pelicula peli = null;
            foreach (Pelicula p in videoclub.pedido)
            {
                if (p.Titulo == pelicula.Titulo)
                {
                    peli = p;
                    break;
                }
            }

        // Si la película existe, la elimina
            if (peli != null)
            {
                videoclub.pedido.Remove(peli);
                Console.WriteLine("Película eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró la película.");
            }

            return videoclub;
        }

    }
}
