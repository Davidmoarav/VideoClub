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

        public void AgregarPelicula(Pelicula peli1,Pelicula peli2){
            if (peli1.Titulo == peli2.Titulo){
                Console.WriteLine("Ingrese peliculas distintas");
            }
            else{
                pedido.Add(peli1);
                pedido.Add(peli2);
            }
            
        }

        public void MostrarPeliculas1(StreamWriter sw){
            foreach (Pelicula pelicula in pedido)
            {
                sw.WriteLine(pelicula.MostrarDetalles());
            }
        }

        public void MostrarPeliculas()
        {
            foreach (Pelicula pelicula in pedido)
            {
                pelicula.MostrarDetallesVoid();
            }
        }


         // Sobrecarga del operador -
        public static VIDEOCLUB operator -(VIDEOCLUB videoclub, Pelicula pelicula)
        {
        
        // Busca la película por su título
            Pelicula peli = null!;
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

        public string PrecioTotal(){
            int valorPelicula = 5000;
            double iva = 0.19;
            int total = 0;

            foreach (Pelicula pelicula in pedido)
            {
                total += pelicula.CantidadEjemplares * valorPelicula;
            }

            double totalIVA = total * iva;


            //Console.WriteLine("Total" + total);
            //Console.WriteLine("El valor del IVA es: " + totalIVA);
            return "Total: " + total + "\nIVA: " + totalIVA;
        }

    }
}
