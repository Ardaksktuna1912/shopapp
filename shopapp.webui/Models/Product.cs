using System;
using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(60,MinimumLength =10,ErrorMessage ="10 ile 60 karakter arası")]
        public  string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage ="Fiyat girmelisiniz")]
        [Range(1,10000)]
        
        public  double Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }

        [Required]
        public int? CategoryID { get; set; }

       
    }
}
