using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Pulp.Models;

namespace Pulp.ViewModels
{
    public class ConfirmOrder
    {

        public Buyer buyer { set; get; }
        [Required]
        public PaymentMethodEnum paymentMethod { set; get; }
        public decimal? total { set; get; }
    }
}
