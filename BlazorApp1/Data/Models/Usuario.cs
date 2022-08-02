using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data.Models
{
    public class Usuario : IdentityUser
    {
        [PersonalData, StringLength(255)]
        public string Nombre { get; set; }
        [PersonalData, StringLength(255)]
        public string Apellido { get; set; }
    }
}
