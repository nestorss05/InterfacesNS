using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5b.Models
{
    public class ClsPersona
    {

        private int _id;
        private String _nombre;
        private String _apellidos;
        private DateTime _fechaNac;
        private String _imageUrl;
        private String _direccion;
        private int _telefono;

        public int Id { get { return _id; } }
        public String Nombre { get { return _nombre; } set { _nombre = value; } }
        public String Apellidos { get { return _apellidos; } set { _apellidos = value; } }
        public DateTime FechaNac { get { return _fechaNac; } set { _fechaNac = value; } }
        public String ImageUrl { get { return _imageUrl; } set { _imageUrl = value; } }
        public String Direccion { get { return _direccion; } set { _direccion = value; } }
        public int Telefono { get { return _telefono; } set { _telefono = value; } }

        public ClsPersona(int id, String nombre, String apellidos, DateTime fechaNac, String imageUrl, String direccion, int telefono)
        {
            _id = id;
            _nombre = nombre;
            _apellidos = apellidos;
            _fechaNac = fechaNac;
            _imageUrl = imageUrl;
            _direccion = direccion;
            _telefono = telefono;
        }

    }
}
