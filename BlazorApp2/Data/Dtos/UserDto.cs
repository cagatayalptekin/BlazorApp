using BlazorApp2.Data.Models;

namespace BlazorApp2.Data.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Job { get; set; }

        public int Age { get; set; }
        public int deptId { get; set; }
        public DepartmentDto dept { get; set; }


    }
}
