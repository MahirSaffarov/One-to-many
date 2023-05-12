using GrowMarkOneToMany.Data;
using GrowMarkOneToMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowMarkOneToMany.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
           Team team = await _context.Teams.Where(m=>!m.SoftDelete).FirstOrDefaultAsync(m=>m.Id == id);
            return View(team);
        }
    }
}
