using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditTrainModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Train? Train0 { get; set; }

        public EditTrainModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Train0 = await context.Trains.FindAsync(id);

            if (Train0 == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Trains.Update(Train0!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
