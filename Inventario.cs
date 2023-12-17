using System;
using utilidades;

namespace VideoClub{
    class Inventario{
        // esta clase leera las peliculas del archivo, ademas de incluir sobrecarga de operadores + y uno booleano
        // su principal funcion sera la de verificar si existe la pelicula en el archivo
        // ademas de moficar la cantidad de peliculas.

        private List<Pelicula>? peliculas;
        // constructor
        public Inventario(){
            peliculas = new List<Pelicula>();
        }
        
        // metodos
        public void LeerArchivo(string rutaArchivo){

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo)){
                   
                    while (!sr.EndOfStream){
                        string[] datos = sr.ReadLine().Split(',');
                        if (datos.Length == 3)
                        {
                            
                            Pelicula pelicula = new Pelicula(datos[0], datos[1], Convert.ToInt32(datos[2]));
                            peliculas.Add(pelicula);
                        }
                    }
                }
            }
            catch (FileNotFoundException) {
                Console.WriteLine("El archivo no se encontró");
            } catch (IOException) {
                Console.WriteLine("Error al leer el archivo");
            } finally {
                // Cerrar el archivo en cualquier caso
            }
        }

        public void MostrarInventario()
        {
            if (peliculas.Count == 0)
            {
                Console.WriteLine("No hay peliculas en el inventario.");
            }
            else
            {
                foreach (Pelicula pelicula in peliculas)
                {
                    pelicula.MostrarDetalles();
                }
            }
        }

        // solo se puede pedir una pelicula
        public bool ActualizarInventario(Pelicula pelicula)
        {
            // Busca la película por su título
            Pelicula peli = null;
            foreach (Pelicula p in peliculas)
            {
                if (p.Titulo == pelicula.Titulo)
                {
                    peli = p;
                    break;
                }
            }       
            // Si la película existe y hay ejemplares disponibles, disminuye la cantidad en 1
            if (peli != null && peli.CantidadEjemplares > 0)
            {
                peli.CantidadEjemplares--;
                Console.WriteLine("Película agregada al pedido. Cantidad de ejemplares actualizada.");
                return true;
            }
            else
            {
                Console.WriteLine("No se encontró la película o no hay ejemplares disponibles.");
                return false;
            }
        }

    }
}