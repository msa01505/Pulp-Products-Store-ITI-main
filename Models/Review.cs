using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { set; get; }
        [Range(1, 5)]
        [Required]
        public int Rating { get; set; }

        [MaxLength(500)]
        [Required]
        public string Comment { set; get; }

        public virtual Buyer Buyer { get; set; }
        [Required]

        public int BuyerID { set; get; }





    }
}
