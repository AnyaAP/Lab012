using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreatePassengerModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Passenger Passenger0 { get; set; } = new();
        public CreatePassengerModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {

            context.Passengers.Add(Passenger0);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
