using System.Collections.Generic;
namespace eCommerce.API.Models
{
    public class Departamento
    {
        public int Id { get; set; } = 0;        
        public string Nome { get; set; } = string.Empty;
        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
