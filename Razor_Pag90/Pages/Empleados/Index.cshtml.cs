using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Razor_Pag90.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Nombre { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                Nombre = "Empleado 1";
            }
        }
    }
}
