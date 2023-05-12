namespace GrowMarkOneToMany.Models
{
    public class Service : BaseEntity
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
