using System.ComponentModel.DataAnnotations;

namespace hackathon.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        [Required]
        public int FirmaId { get; set; }
        [Required]
        public int UrunId { get; set; }
        public string MusteriAd { get; set; }  
        public DateTime SiparisT { get; set; }

    }
}
