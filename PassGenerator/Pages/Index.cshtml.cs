using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PassGenerator._3_Services.Interface;

namespace PassGenerator.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPasswordGenService _passwordGenService;

        public IndexModel(IPasswordGenService passwordGenService)
        {
            _passwordGenService = passwordGenService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetGenerateRandomPassword()
        {
            string randomPassword = _passwordGenService.GenerateRandomPassword();
            return Content(randomPassword);
        }
    }
}
