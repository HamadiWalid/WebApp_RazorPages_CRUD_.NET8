using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_.NetCore8.Data;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Pages.Clients
{
	[BindProperties]

	public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public Client Client { get; set; }

		public CreateModel(ApplicationDbContext context)
		{
			_context = context;
		}
		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPost()
		{
            if (Client.Name == "okk")
            {
                ModelState.AddModelError("Clients.Name", "The name cannot be okk.");
            }//Custum validation
            if (ModelState.IsValid)//Server side
			{
				await _context.Clients.AddAsync(Client);
				await _context.SaveChangesAsync();
				TempData["success"] = "Client created successfully";
				return RedirectToPage("Index");
			}
			return Page();
		}
	}
}
