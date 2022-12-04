using System;
using System.ComponentModel.DataAnnotations;

namespace ChatEcosystem.Models
{
    public class Message
    {
        public Message()
        {
            CreatedOn = DateTime.UtcNow;
        }

        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }

        public string RecieverId { get; set; }

        public AppUser Reciever { get; set; }

        public string UserId { get; set; }
        public virtual AppUser Sender { get; set; }
    }
}
