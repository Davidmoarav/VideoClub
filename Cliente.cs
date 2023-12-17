using System;
using utilidades;
namespace VideoClub
{
    class Cliente : Detalles
    {
        public Cliente() : base() {
        }
        public Cliente(string nombre, string apellido, string rut, string correo) : base(nombre,apellido,rut,correo) {
        }

        public void MostrarInformacionCliente(){
            Console.WriteLine($"Informacion del Cliente:");
            Console.WriteLine($"Nombre: {Nombre}\nApellido: {Apellido}\nRut: {RUT}\nCorreo: {Correo}");
        }
    }
}

