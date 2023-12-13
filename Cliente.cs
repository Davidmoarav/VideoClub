using System;

namespace VideoClub
{
    public class Cliente
    {
        private string? nombre;
        private string? apellido;
        private string? rut;
        private string? correo;

        public Cliente(){
        }
        public Cliente(string nombre, string apellido, string rut, string correo){
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.correo = correo;
        }

        

        public string Nombre{
            get{return nombre;}
            set{this.nombre = value;}
        } 

        public string Apellido{
            get{return apellido;}
            set{this.apellido = value;}
        }

        public string RUT{
            get{return rut;}
            set{this.rut = value;}
        }

        public string Correo{
            get{return correo;}
            set{this.correo = value;}
        }

        public void MostrarInformacionCliente(){
            System.Console.WriteLine($"Informacion del Cliente:");
            System.Console.WriteLine($"Nombre: {Nombre}\nApellido: {Apellido}\nRut: {RUT}\nCorreo: {Correo}");
        }
    }
}

