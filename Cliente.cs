using System;

namespace VideoClub
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string RUT;
        private string correo;

        public Cliente(string nombre, string apellido, string RUT, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.RUT = RUT;
