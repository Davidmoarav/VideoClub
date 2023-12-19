using System;
using utilidades;
namespace VideoClub
{
    class Cliente : Detalles
    {
        public Cliente() : base() {
        }

        public string MostrarInformacionCliente(){
            return $"Informacion del Cliente \nNombre: {Nombre} \nApellido: {Apellido} \nRut: {RUT} \nCorreo: {Correo} \nForma de pago: {FormadePago} ";
        }
    }
}

