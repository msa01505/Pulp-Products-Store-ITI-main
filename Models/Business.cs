using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.Models
{
    public class Business
    {
        [Key]
        public int BusinessID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(50, ErrorMessage = "Describtion can't be more than 50 characters")]
        public string Describtion { set; get; }
        [Required]
        public string PicUri { set; get; }

        public virtual ICollection<CategoryType> CategoryTypes { set; get; }

    }
}
