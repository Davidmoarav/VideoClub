using System;

namespace VideoClub
{
    public class Pelicula : Caracteristicas
    {
        private string titulo;
        private string genero;
        private int cantidadEjemplares;
        private int cantidadVecesArrendada;

        public Pelicula(string titulo, string genero, int cantidadEjemplares) : base()
        {
            this.titulo = titulo;
            this.genero = genero;
            this.cantidadEjemplares = cantidadEjemplares;
            this.cantidadVecesArrendada = 0;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int CantidadEjemplares
        {
            get { return cantidadEjemplares; }
            set { cantidadEjemplares = value; }
        }

        public int CantidadVecesArrendada
        {
            get { return cantidadVecesArrendada; }
            set { cantidadVecesArrendada = value; }
        }

        public override void MostrarDetalles(){
            Console.WriteLine();
        }
    }
}
