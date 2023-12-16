using System;

namespace VideoClub{
    class Inventario{
        // esta clase leera las peliculas del archivo, ademas de incluir sobrecarga de operadores + y uno booleano
        // su principal funcion sera la de verificar si existe la pelicula en el archivo
        // ademas de moficar la cantidad de peliculas.

        // atributos
        private string? titulo;
        private string? genero;
        private int cantidadEjemplares;

        private List<Pelicula> peliculas;
        // constructor
        public Inventario(){
            peliculas = new List<Pelicula>();
        }

        public Inventario(string titulo, string genero, int cantidadejemplares){
            this.titulo = titulo;
            this.genero = genero;
            this.cantidadEjemplares = cantidadejemplares;
        }

        // metodos
        public string? Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string? Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int CantidadEjemplares
        {
            get { return cantidadEjemplares; }
            set { cantidadEjemplares = value; }
        }

        public List<Inventario> LeerArchivo(string rutaArchivo){
            List<Inventario> productos = new List<Inventario>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo)){
                   
                    while (!sr.EndOfStream){
                        string[] datos = sr.ReadLine().Split(',');
                        if (datos.Length == 3)
                        {
                            /*
                            Inventario inv = new Inventario(datos[0],datos[1],Convert.ToInt32(datos[2]));
                            productos.Add(inv);
                            */
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

            return productos;
            

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


    }
}