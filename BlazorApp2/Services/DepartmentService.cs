using System.Net.NetworkInformation;

using BlazorApp2.Services;
using BlazorApp2.Data.Dtos;
using BlazorApp2.Data;
using BlazorApp2.Data.Models;

using BlazorApp2.Pages;
using Microsoft.EntityFrameworkCore;
using System.Data;
using BlazorApp2.Interfaces;

namespace BlazorApp2.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly AppDbContext _context;
        public DepartmentService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public List<DepartmentDto> GetAllDepartments()
        {
            var departments = from data in _context.Departments
                              select new DepartmentDto
                              {
                                  Id = data.Id,
                                  Name = data.Name,
                                  Manager = data.Manager,
                                  Budget = data.Budget,
                                  Location = data.Location,


                              };


            return departments.ToList();
        }

        public DepartmentDto? GetDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            DepartmentDto deptdto = new DepartmentDto();
            if(department != null)
            {
                deptdto.Id = department.Id;
                deptdto.Budget = department.Budget;
                deptdto.Location = department.Location;
                deptdto.Manager = department.Manager;
                deptdto.Name = department.Name;
                return deptdto;


            }
            else
            {
                return null;
            }


        }
        public bool InsertDepartment(DepartmentDto departmentdto)
        {
            Department dept = new Department()
            {
                Budget = departmentdto.Budget,
                Location = departmentdto.Location,
                Manager = departmentdto.Manager,
                Name = departmentdto.Name,


            };
            _context.Departments.Add(dept);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateDepartment(DepartmentDto departmentdto)
        {
            Department dept = new Department()
            {
                Id = departmentdto.Id,
                Budget = departmentdto.Budget,
                Location = departmentdto.Location,
                Manager = departmentdto.Manager,
                Name = departmentdto.Name,
                user = new User()
            };


            _context.ChangeTracker.Clear();
            _context.Entry(dept).State = EntityState.Modified;
           
            _context.SaveChanges();
            return true;
        }

        public bool DeleteDepartment(int Id)
        {
            var department = _context.Departments.Find(Id);
            _context.Departments.Remove(department);
            _context.SaveChanges();
            return true;
        }




    }
}
