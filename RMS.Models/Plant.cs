using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{
    public class Plant
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerDescription { get; set; }
        
    }
}
