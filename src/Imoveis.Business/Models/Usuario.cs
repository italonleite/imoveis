using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }
    }
}
