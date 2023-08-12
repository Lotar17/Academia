﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Dominio
{
    public class Controller
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public bool LoginUsuario(string nombre_usuario, string clave)
        {
            return usuarioDAO.Login(nombre_usuario, clave);
        }

        public bool verificarUsuario(int idPersona)
        {
            return usuarioDAO.verificarUser(idPersona);
        }
    }
}