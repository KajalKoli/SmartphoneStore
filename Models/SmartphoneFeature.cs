using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartphoneShop.Models
{
    public class SmartphoneFeature
    {
        [Key]
        [Required]
        public Int16 MobileId { get; set; }
        [Required(ErrorMessage = "Brand Name Required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model Name Required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Rating Required ")]
        public double Rating { get; set; }
        [Required(ErrorMessage = "Price Required")]
        public double Price { get; set; }
        [Display(Name = "Screen Size")]
        [Required(ErrorMessage = "Screen Size Required")]
        public double ScreenSize { get; set; }
        [Required(ErrorMessage = "RAM Required")]
        public int RAM { get; set; }
        [Display(Name = "Internal Storage")]
        [Required(ErrorMessage = "Internal Storage Required")]
        public int InternalStorage { get; set; }
        [Display(Name = "Front Camera")]
        [Required(ErrorMessage = "Front Camera Required")]
        public int FrontCamera { get; set; }
        [Display(Name = "Rear Camera")]
        [Required(ErrorMessage = "Rear Camera Required")]
        public int RearCamera { get; set; }
        [Required(ErrorMessage = "OS Required")]
        public string OS { get; set; }
        [Required(ErrorMessage = "Sim Required")]
        public string Sim { get; set; }
        [Required(ErrorMessage = "Sensor Required")]
        public string Sensor { get; set; }
        [Display(Name = "Battery Capacity")]
        [Required(ErrorMessage = "Battery Capacity Required")]
        public int BatteryCapacity { get; set; }
        [Required(ErrorMessage = "Color Required")]
        public string Color { get; set; }
        [StringLength(2048)]
        public string Image { get; set; }

    }
}