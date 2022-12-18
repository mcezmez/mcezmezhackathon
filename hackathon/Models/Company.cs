using System.ComponentModel.DataAnnotations;

namespace hackathon.Models
{
    public class Company
    {
        
        
        
        public int Id { get; set; }
        [Required]
        public string FirmaAd { get; set; }
        [Required]
        public bool Onay { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd}" ,ApplyFormatInEditMode = true)]
        public DateTime sbaslagic { get; set; }

        public DateTime sbitis { get; set; }

    }
}
