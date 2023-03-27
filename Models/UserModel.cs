
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BasketballScores.Models
{
    public class UserModel : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        
        public string username { get; set; }

        public string password { get; set; }   

        public bool admin { get; set; }
    }
}
