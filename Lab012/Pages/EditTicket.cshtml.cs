using Lab012.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab012.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditTicketModel : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Ticket? Ticket0 { get; set; }

        public EditTicketModel(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Ticket0 = await context.Tickets.FindAsync(id);

            if (Ticket0 == null) return NotFound();

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Tickets.Update(Ticket0!);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
