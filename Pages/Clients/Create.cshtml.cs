using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_RazorPages_.NetCore8.Data;
using WebApp_RazorPages_.NetCore8.Models;

namespace WebApp_RazorPages_.NetCore8.Pages.Clients
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public Client clients { get; set; }

		//public CreateModel(ApplicationDbContext context)
		//{
		//	_context = context;
		//}
		
		//public async Task<IActionResult> OnPost()
		//{
		//	 //   await _context.Clients.AddAsync(clients);

		//		//await _context.Clients.SaveChangesAsync();
		//		////TempData["success"] = "Category created successfully";
		//		//return RedirectToPage("Index");
			
		//	//return Page();
		//}
	}
}
