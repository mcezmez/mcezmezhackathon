using System.ComponentModel.DataAnnotations;

namespace hackathon.Models
{
    public class Products
    {
        
        public int Id { get; set; }
        [Required]
        public int FirmaId { get; set; }
        [Required]
        public string UrunAd { get; set; }
        
        public int stok { get; set; }
        public double fiyat { get; set; }


      
    }
}
