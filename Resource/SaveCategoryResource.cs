using System.ComponentModel.DataAnnotations;

namespace src.Resource
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}