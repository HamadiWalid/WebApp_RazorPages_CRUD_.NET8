using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_.NetCore8.Data;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Client> Clients {  get; set; }  
        public IndexModel(ApplicationDbContext context)
        {
            _context=context;   
        }
        public void OnGet()
        {
            Clients = _context.Clients; 
        }
    }
}
