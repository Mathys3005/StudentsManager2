using Microsoft.AspNetCore.Identity;

namespace StudentsCoursCesi.Models.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
