namespace modelo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }


        public ICollection<Producto> Posts { get; } = new List<Producto>();

    }
}
