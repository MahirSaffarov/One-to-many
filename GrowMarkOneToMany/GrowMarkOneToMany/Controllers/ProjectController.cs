using GrowMarkOneToMany.Data;
using GrowMarkOneToMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowMarkOneToMany.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _context;
        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Project project = await _context.Projects.Where(m => !m.SoftDelete).FirstOrDefaultAsync(m=>m.Id == id);

            return View(project);
        }
    }
}
