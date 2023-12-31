﻿using System;
using System.Text;
using System.Security.Cryptography;

namespace Entities
{
    public class UsuarioADO
    {
        private string _Clave;
        private bool _Habilitado;
        private string _NombreUsuario;
        private int _Id;
        private int _IdPersona;

        public UsuarioADO(string clave, bool habilitado, string nombreUsuario) 
        {
           this.Clave = clave;
           this.Habilitado = habilitado;
           this.NombreUsuario = nombreUsuario;
        }

        public UsuarioADO(int id, string nombreUsuario, bool habilitado, int idPersona)
        {
            this.Id = id;
            this.Habilitado = habilitado;
            this.NombreUsuario = nombreUsuario;
            this.IdPersona = idPersona;
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


        public string Clave
        {
            get { return _Clave; }
            set { _Clave = CalculateSHA256(value); }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int IdPersona
        {
            get { return _IdPersona; }
            set { _IdPersona = value; }
        }
    }
}
