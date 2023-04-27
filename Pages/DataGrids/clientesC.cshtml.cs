using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace login4.Pages.DataGrids
{
    [Authorize]
    public class clientesCModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
