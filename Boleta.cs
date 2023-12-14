using System;

namespace VideoClub{
    class Boleta{
        private string nombreTienda = "Arriendo";
        private string direccion = "Calle ....";
        private string correoTienda = "hola@mundo";
        private int numero = 99902123;
        private string website = "www.dada";
        Boleta(){

        }

        Boleta(string nombreTienda,string direccion,string correoTienda, int numero,string website){
            this.nombreTienda = nombreTienda;
            this.direccion = direccion;
            this.correoTienda = correoTienda;
            this.numero = numero;
        }




    }
}