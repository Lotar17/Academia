using System;
using System.Text;
using System.Security.Cryptography;

namespace Entities
{
    public class Usuario
    {
        private string _Apellido;
        private string _Clave;
        private string _Email;
        private bool _Habilitado;
        private string _Nombre;
        private string _NombreUsuario;

        public Usuario(string apellido, string clave, string email, bool habilitado, string nombre, string nombreUsuario) 
        {
           this.Apellido = apellido;
           this.Clave = clave;
           this.Email = email;
           this.Habilitado = habilitado;
           this.Nombre = nombre;
           this.NombreUsuario = nombreUsuario;
        }

        static string CalculateSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir el input en bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Calcular el hash SHA-256
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convertir el hash en una representación de cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = CalculateSHA256(value); }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
    }
}
