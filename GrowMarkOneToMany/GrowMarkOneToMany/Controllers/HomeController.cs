using GrowMarkOneToMany.Data;
using GrowMarkOneToMany.Models;
using GrowMarkOneToMany.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GrowMarkOneToMany.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Project> projects = await _context.Projects.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Team> teams = await _context.Teams.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<About> abouts = await _context.Abouts.Include(m => m.Service).Where(m => !m.SoftDelete).ToListAsync();

            HomeVM homeVM = new HomeVM() 
            { 
                Projects = projects,
                Teams = teams,
                Abouts = abouts
            };
            return View(homeVM);
        }

    }
}