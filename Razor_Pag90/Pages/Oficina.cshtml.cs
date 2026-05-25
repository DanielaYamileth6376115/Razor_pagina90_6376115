using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pag90.Data;
using Razor_Pag90.Models;

namespace Razor_Pag90.Pages
{
    public class OficinaModel : PageModel
    {
        private readonly Razor_Pag90Context _context;

        public OficinaModel(Razor_Pag90Context context)
        {
            _context = context;
        }

        public List<Oficina> ListaOficinas { get; set; } = new List<Oficina>();

        public void OnGet()
        {
   
            ListaOficinas = _context.Oficina.ToList();
        }
    }
}