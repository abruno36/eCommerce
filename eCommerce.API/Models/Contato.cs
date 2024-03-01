using System;
using System.Collections.Generic;

namespace eCommerce.API.Models
{
    public class Contato
    {
        public int Id { get; set; } = 0;
        public int UsuarioId { get; set; } = 0;
        public string Telefone { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public Usuario Usuario { get; set; } = new Usuario();
    }
}
