using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Accounts
{
    public class AccountExists
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}