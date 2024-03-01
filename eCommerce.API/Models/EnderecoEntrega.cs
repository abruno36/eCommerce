using System;
using System.Collections.Generic;

namespace eCommerce.API.Models
{
    public class EnderecoEntrega
    {
        public int Id { get; set; } = 0;
        public int UsuarioId { get; set; } = 0;
        public string NomeEndereco { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;

        public Usuario Usuario { get; set; } = new Usuario();
    }
}
