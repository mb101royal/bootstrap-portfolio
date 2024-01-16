using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootstrap_portfolio.Core.Models
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
        public string UsernameOrEmail { get; set; }
    }
}
