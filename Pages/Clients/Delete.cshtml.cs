using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_.NetCore8.Data;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Pages.Clients
{
	[BindProperties]

	public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public Client Client { get; set; }

		public DeleteModel(ApplicationDbContext context)
		{
			_context = context;
		}
        public void OnGet(int id)
        {
            Client = _context.Clients.Find(id);
            //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
            //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
        }
        public async Task<IActionResult> OnPost()
		{

			var clientFromDb = _context.Clients.Find(Client.Id);

			if (clientFromDb != null)
			{   
				_context.Clients.Remove(clientFromDb);
				await _context.SaveChangesAsync();
				TempData["success"] = "Client deleted successfully";
				return RedirectToPage("Index");
			
			}
			return Page();
		}
	}
}
