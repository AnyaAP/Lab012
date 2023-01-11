using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab012.Models;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Train Train0 { get; set; } = new();
        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {

            context.Trains.Add(Train0);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
