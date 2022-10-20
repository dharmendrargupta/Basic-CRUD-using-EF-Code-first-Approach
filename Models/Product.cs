using System.ComponentModel.DataAnnotations;

namespace 
    .Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public float CategoriId { get; set; }

        public string? CategoriName  { get; set; }
       


    }
}
