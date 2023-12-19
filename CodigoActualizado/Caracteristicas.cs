using System;

namespace utilidades{


    abstract class Caracteristicas{
    // metodos para la clase pelicula
    public abstract string MostrarDetalles();
    public abstract void MostrarDetallesVoid();

    }
    class Detalles{
        private string? nombre;
        private string? apellido;
        private string? rut;
        private string? correo;
        private string? formadePago;
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

        public string? FormadePago{
            get{return formadePago;}
            set{this.formadePago = value;}
        }
    }

}
