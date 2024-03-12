using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_.NetCore8.Data;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Pages.Clients
{
	[BindProperties]

	public class EditModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public Client Client { get; set; }

		public EditModel(ApplicationDbContext context)
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
            if (Client.Name == "okk")
            {
                ModelState.AddModelError("Clients.Name", "The name cannot be okk.");
            }//Custum validation
            if (ModelState.IsValid)//Server side
			{
			    _context.Clients.Update(Client);
				await _context.SaveChangesAsync();
				TempData["success"] = "Client updated successfully";

				return RedirectToPage("Index");
			}
			return Page();
		}
	}
}
