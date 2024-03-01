using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace eCommerce.API.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string NomeMae { get; set; } = string.Empty;
        public string SituacaoCadastro { get; set; } = string.Empty;
        public DateTimeOffset DataCadastro { get; set; }

        [Write(false)]
        public Contato Contato { get; set; } = new Contato();

        [Write(false)]
        public ICollection<EnderecoEntrega> EnderecosEntrega { get; set; } = new List<EnderecoEntrega>();

        [Write(false)]
        public ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
    }
}
