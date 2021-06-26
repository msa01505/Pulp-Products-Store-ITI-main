using System.ComponentModel.DataAnnotations;

namespace Pulp.Models
{

    public class Admin : BaseUser
    {
        [Required]
        public Roles Role { set; get; }
    }
}
