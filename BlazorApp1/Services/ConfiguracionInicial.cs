using BlazorApp1.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Services
{
    public class ConfiguracionInicial : IConfiguracionInicial
    {
        private readonly UserManager<Usuario> _userManager;

        public ConfiguracionInicial(UserManager<Usuario> userManager) 
        {
            _userManager = userManager;
        }

        public void Init()
        {
            
        }
    }
}
