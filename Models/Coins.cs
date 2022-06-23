using System.ComponentModel.DataAnnotations;

namespace CriptoApi.Models
{
    public class Coins
    {
        [Key]
        public int ModenaId { get; set; }
        public string? Descripcion { get; set; }
        public double? Valor { get; set; }
        public String? ImageUrl { get; set; }
    }
}
