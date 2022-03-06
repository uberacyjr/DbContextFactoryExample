using System.ComponentModel.DataAnnotations;

namespace DbContextFactoryExample.Console.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
    }
}
