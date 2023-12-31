using System;
using System.Security.Cryptography.X509Certificates;
using utilidades;


namespace VideoClub{
    class Boleta : Caracteristicas {
        private string nombreTienda = "Arriendo";
        private string direccion = "Calle ....";
        private string correoTienda = "hola@mundo";
        private int numero = 99902123;
        private string website = "www.dada";

        private VIDEOCLUB videos;
        public Boleta(){
            videos = new VIDEOCLUB();
        }

        public Boleta(string nombreTienda,string direccion,string correoTienda, int numero,string website) : base(){
            this.nombreTienda = nombreTienda;
            this.direccion = direccion;
            this.correoTienda = correoTienda;
            this.numero = numero;

            videos = new VIDEOCLUB();
        }

        public override string MostrarDetalles()
        {
            //Console.WriteLine($"{nombreTienda}\n{direccion}\n{correoTienda}\n{numero}\n{website}\n");
            
            videos.MostrarPeliculas();
            return $"{nombreTienda}\n{direccion}\n{correoTienda}\n{numero}\n{website}\n";
        }

        public override void MostrarDetallesVoid()
        {
            //throw new NotImplementedException();

        }


    }
}