namespace GrowMarkOneToMany.Models
{
    public class About :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Service> Service { get; set; }
    }
}
