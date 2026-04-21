using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SalesRealApp.Data;
using SalesRealApp.Hubs;
using SalesRealApp.Models;

namespace SalesRealApp.Controllers
{
    public class SalesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<SalesHub> _hub;

        public SalesController(AppDbContext context, IHubContext<SalesHub> hub)
        {
            _context = context;
            _hub = hub;
        }

        // 📄 List
        public IActionResult Index()
        {
            var data = _context.Sales.ToList();
            return View(data);
        }

        // ➕ Add
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Sale model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();

                return Ok(); // শুধু success দাও
            }

            return BadRequest();
        }

        // ✏️ Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Sale model)
        {
            var item = await _context.Sales.FindAsync(model.Id);
            if (item != null)
            {
                item.CustomerName = model.CustomerName;
                item.Price = model.Price;
                item.SaleDate = model.SaleDate;

                await _context.SaveChangesAsync();

                // 🔥 Broadcast update
                await _hub.Clients.All.SendAsync("ItemUpdated", model);
            }

            return Ok(model);
        }

        // ❌ Delete
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Sales.FindAsync(id);
            if (item != null)
            {
                _context.Sales.Remove(item);
                await _context.SaveChangesAsync();

                // 🔥 Broadcast delete
                await _hub.Clients.All.SendAsync("ItemDeleted", id);
            }

            return Ok();
        }
    }
}
