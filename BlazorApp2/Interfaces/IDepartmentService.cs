using BlazorApp2.Data.Dtos;

namespace BlazorApp2.Interfaces
{
    public interface IDepartmentService
    {
        public List<DepartmentDto> GetAllDepartments();
        public DepartmentDto GetDepartment(int id);
        public bool InsertDepartment(DepartmentDto departmentdto);
        public bool UpdateDepartment(DepartmentDto departmentdto);
        public bool DeleteDepartment(int Id);
    }
}
