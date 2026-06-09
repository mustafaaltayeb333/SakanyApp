using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakany.Data;
using Sakany.Models;

namespace Sakany.Controllers
{
    public class ContractController : Controller
    {
        private readonly SakanyDbContext _context;
        public ContractController(SakanyDbContext context) { _context = context; }

        private string? SessionUserID => HttpContext.Session.GetString("UserID");
        private string? SessionRole => HttpContext.Session.GetString("UserRole");
        private bool IsLoggedIn => SessionUserID != null;
        private bool IsAdmin => SessionRole == "Admin";
        private bool IsOwner => SessionRole == "Owner";
        private bool IsTenant => SessionRole == "Tenant";

        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            var query = _context.Contract
                .Include(c => c.Property).Include(c => c.Owner).Include(c => c.Tenant).AsQueryable();
            if (IsOwner) query = query.Where(c => c.OwnerID == SessionUserID);
            else if (IsTenant) query = query.Where(c => c.TenantID == SessionUserID);
            return View(await query.OrderByDescending(c => c.StartDate).ToListAsync());
        }

        public async Task<IActionResult> Details(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (id == null) return NotFound();
            var contract = await _context.Contract
                .Include(c => c.Property).Include(c => c.Owner)
                .Include(c => c.Tenant).Include(c => c.Request)
                .FirstOrDefaultAsync(c => c.ID == id);
            if (contract == null) return NotFound();
            if (!IsAdmin && contract.OwnerID != SessionUserID && contract.TenantID != SessionUserID)
            { TempData["Error"] = "Access denied."; return RedirectToAction(nameof(Index)); }
            return View(contract);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) { TempData["Error"] = "Only admins can edit contracts."; return RedirectToAction(nameof(Index)); }
            var contract = await _context.Contract
                .Include(c => c.Property).Include(c => c.Tenant).Include(c => c.Owner)
                .FirstOrDefaultAsync(c => c.ID == id);
            if (contract == null) return NotFound();
            return View(contract);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ContractStatus status, DateTime? endDate)
        {
            if (!IsLoggedIn) return RedirectToAction("Login", "Account");
            if (!IsAdmin) return Forbid();
            var contract = await _context.Contract.FindAsync(id);
            if (contract == null) return NotFound();
            contract.Status = status;
            contract.EndDate = endDate;
            _context.Update(contract);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Contract updated.";
            return RedirectToAction(nameof(Index));
        }
    }
}