using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_3_Aayam.Models
{
    public class Bike
    {
        [Column("Id")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("BikeName")]
        [Required]
        [Display(Name = "Bike Name")]
        [StringLength(50)]
        public string BikeName { get; set; }

        [Column("Brand")]
        [Required]
        [Display(Name = "Brand")]
        [StringLength(50)]
        public string Brand { get; set; }

        [Column("Color")]
        [Required]
        [Display(Name = "Color")]
        [StringLength(50)]
        public string Color { get; set; }

        [Column("Price")]
        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Column("LaunchDate")]
        [Required]
        [Display(Name = "Launch Date")]
        public DateTime LaunchDate { get; set; }
    
}
}
