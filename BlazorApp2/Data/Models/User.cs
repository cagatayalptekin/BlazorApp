using BlazorApp2;

namespace BlazorApp2.Data.Models

    
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public int Age { get; set; }
        public int deptId { get; set; }
        public Department dept { get; set; }
    }
}