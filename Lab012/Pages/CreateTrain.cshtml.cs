using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateTrainModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Train Train0 { get; set; } = new();
        public CreateTrainModel(ApplicationContext db)
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
