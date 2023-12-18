using System;
using System.Net.NetworkInformation;
using utilidades;


namespace VideoClub
{
    class Pelicula : Caracteristicas
    {
        private string? titulo;
        private string? genero;
        private int cantidadEjemplares;
        public Pelicula() : base(){
            
        }
        public Pelicula(string titulo, string genero, int cantidadEjemplares) : base()
        {
            this.titulo = titulo;
            this.genero = genero;
            this.cantidadEjemplares = cantidadEjemplares;
            
        }

        public Pelicula(string titulo) : base ()
        {
            this.Titulo = titulo;
        }

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

        public override void MostrarDetalles(){
            //Console.WriteLine("Detalles de la Pelicula");
            Console.WriteLine($"Titulo: {Titulo} Genero:{Genero} Cantidad de ejemplares: {CantidadEjemplares}");
        }
    }
}
