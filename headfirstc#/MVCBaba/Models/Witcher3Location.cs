using System.ComponentModel.DataAnnotations;

namespace MVCBaba.Models
{
    
        public enum Location
        {
            [Display(Name = "White Orchard")]
            White_Orchard,
            Velen,
            Novigrad,
            Skellige,
            Oxenfurt,
            [Display(Name = "Kaer Morhen")]
            Kaer_Morhen,



        }
    
    
}
