using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }
        public Usuario()
        {

        }

        public Usuario(string usuario, string contraseña)
        {
            CodigoUsuario = usuario;
            Contraseña = contraseña;
        }
    }
}
