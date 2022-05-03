using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class InputModel
    {
        [Required(ErrorMessage="FieldRequired")]
        public string RequiredString { get; set; }
    }
}
