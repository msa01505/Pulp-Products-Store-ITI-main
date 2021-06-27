using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Pulp.Models;

namespace Pulp.Areas.Identity.Data
{
    public class PulpProjectUser : IdentityUser
    {
        //public string Username { get; set; }

        public DateTime BirthDate { get; set; }
        public string PictureUri { get; set; }


        public Address Address { set; get; }
    }
}
