using System;


namespace utilidades{


    abstract class Caracteristicas{
    // metodos para la clase pelicula
    public abstract void MostrarDetalles();
    }


    class Detalles{
        private string? nombre;
        private string? apellido;
        private string? rut;
        private string? correo;

        public Detalles(){
    
        }

        public string? Nombre{
            get{return nombre;}
            set{this.nombre = value;}
        } 

        public string? Apellido{
            get{return apellido;}
            set{this.apellido = value;}
        }

        public string? RUT{
            get{return rut;}
            set{this.rut = value;}
        }

        public string? Correo{
            get{return correo;}
            set{this.correo = value;}
        }
    }

}
