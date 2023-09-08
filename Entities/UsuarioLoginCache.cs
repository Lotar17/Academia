using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class UsuarioLoginCache
    {
        public static int _IdUsuario { get; set; }
        public static string _Nombre { get; set; }   
        public static string _Apellido { get; set; }
        public static string _Email { get; set;}
        public static int _TipoUsuario { get; set; }

    }
}
