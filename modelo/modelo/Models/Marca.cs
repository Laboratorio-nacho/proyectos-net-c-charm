using Microsoft.Extensions.Hosting;

namespace modelo.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public String Nombre { get; set; }


        public ICollection<Producto> Posts { get; } = new List<Producto>();
    }
}
