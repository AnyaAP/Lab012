using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateTicketModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Ticket Ticket0 { get; set; } = new();
        public CreateTicketModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {

            context.Tickets.Add(Ticket0);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
