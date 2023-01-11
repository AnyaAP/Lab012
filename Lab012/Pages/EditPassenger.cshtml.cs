using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditPassengerModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Passenger? Passenger0 { get; set; }

        public EditPassengerModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Passenger0 = await context.Passengers.FindAsync(id);

            if (Passenger0 == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Passengers.Update(Passenger0!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
