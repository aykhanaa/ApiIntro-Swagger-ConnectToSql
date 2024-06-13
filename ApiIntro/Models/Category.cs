using System.ComponentModel.DataAnnotations;

namespace ApiIntro.Models
{
    public class Category :BaseEntity
    {
        [StringLength(10)]
         public string Name { get; set; }
    }


}
