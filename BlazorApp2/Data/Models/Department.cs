namespace BlazorApp2.Data.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Manager { get; set; }

        public string Location { get; set; }
        public double Budget { get; set; }
        public User user { get; set; }
    }
}
