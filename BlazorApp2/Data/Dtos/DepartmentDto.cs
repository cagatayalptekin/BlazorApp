using BlazorApp2.Data.Models;
namespace BlazorApp2.Data.Dtos
{
    public class DepartmentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Manager { get; set; }

        public string Location { get; set; }
        public double Budget { get; set; }
        public UserDto user { get; set; }
    }
}
