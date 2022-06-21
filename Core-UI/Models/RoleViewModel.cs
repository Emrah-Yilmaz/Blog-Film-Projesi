using System.ComponentModel.DataAnnotations;

namespace Core_UI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Rol adı boş geçilemez")]
        public string Name { get; set; }
    }
}
