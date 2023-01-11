using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab012.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab012.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Train> Trains { get; private set; } = new();
        public List<Passenger> Passengers { get; private set; } = new();
        public List<Ticket> Tickets { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Trains = context.Trains.AsNoTracking().ToList();
            Passengers = context.Passengers.AsNoTracking().ToList();
            Tickets = context.Tickets.AsNoTracking().ToList();
        }
        public async Task<IActionResult> OnPostDeleteTrainAsync(int id)
        {
            var train = await context.Trains.FindAsync(id);

            if (train != null)
            {
                context.Trains.Remove(train);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostDeletePassengerAsync(int id)
        {
            var passenger = await context.Passengers.FindAsync(id);

            if (passenger != null)
            {
                context.Passengers.Remove(passenger);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostDeleteTicketAsync(int id)
        {
            var ticket = await context.Tickets.FindAsync(id);

            if (ticket != null)
            {
                context.Tickets.Remove(ticket);
                await context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}