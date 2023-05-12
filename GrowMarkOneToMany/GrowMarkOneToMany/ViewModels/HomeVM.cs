using GrowMarkOneToMany.Models;

namespace GrowMarkOneToMany.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Project> Projects{ get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<About> Abouts { get; set; }
    }
}
