using System;

namespace VideoClub
{
    class VIDEOCLUB
    {
        private List<Pelicula> pedido;
        private List<Inventario> inventario;
        public VIDEOCLUB()
        {
            inventario = new List<Inventario>();
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
    }
}
