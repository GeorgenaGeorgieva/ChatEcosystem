using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace ChatEcosystem.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }

        public bool IsOnline { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
