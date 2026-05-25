using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pag90.Data;
using Razor_Pag90.Models;

namespace Razor_Pag90.Pages
{
    public class ClienteModel : PageModel
    {
        private readonly Razor_Pag90Context _context;

        public ClienteModel(Razor_Pag90Context context)
        {
            _context = context;
        }

        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

        public void OnGet()
        {
            ListaClientes = _context.Cliente.ToList();
        }
    }
}