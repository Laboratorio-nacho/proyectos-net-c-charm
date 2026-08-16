using System.Reflection.Metadata;

namespace modelo.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int precio  { get; set; }

        public int CategoriaId { get; set; } // Required foreign key property
        public Categoria Categoria { get; set; } = null!; // Required reference navigation to principal

        public int MarcaId { get; set; } // Required foreign key property
        public Marca Marca { get; set; } = null!; // Required reference navigation to principal

    }
}
