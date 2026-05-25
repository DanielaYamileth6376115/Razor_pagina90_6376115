using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pag90.Models;

namespace Razor_Pag90.Pages.Empleados
{
    public class AgregarEmpleadosModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }
        public void OnGet()
        {
        }
 
        public IActionResult OnPost()
        {

            return RedirectToPage("/Empleados/Index", new { Empleado.Nombre });
        }
    }
}


