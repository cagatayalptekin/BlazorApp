using System.Net.NetworkInformation;

using BlazorApp2.Services;
using BlazorApp2.Data.Dtos;
using BlazorApp2.Data;
using BlazorApp2.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using BlazorApp2.Interfaces;

namespace BlazorApp2.Services
{
    public class UserService:IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public List<UserDto> GetAllUsers()
        {
            var users = from data in _context.Users
                        select new UserDto
                        {
                            Id = data.Id,
                            Name = data.Name,
                            Age = data.Age,
                            deptId = data.deptId,
                            Job = data.Job,

                        };


            return users.ToList();



        }
        public UserDto? GetUser(int id)
        {
            var user = _context.Users.Find(id);
            UserDto userdto=new UserDto();
            if (user!=null)
            {

                userdto.Age = user.Age;
                userdto.Name = user.Name;
                 userdto.Job = user.Job;
                userdto.deptId = user.deptId;
                userdto.Id = user.Id;
                return userdto;


            }
            else
            {
                return null;
            }
           
            

            
        }
        public bool InsertUser(UserDto userdto)
        {
            User user = new User()
            {

                Age = userdto.Age,
                deptId = userdto.deptId,
                Job = userdto.Job,
                Name = userdto.Name
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateUser(UserDto userdto)
        {
            User user = new User()
            {
                Id = userdto.Id,
                Age = userdto.Age,
                deptId = userdto.deptId,
                Job = userdto.Job,
                Name = userdto.Name,
                dept = new Department()
            };
            _context.ChangeTracker.Clear();

            _context.Entry(user).State = EntityState.Modified;

            // _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUser(int Id)
        {
            var user = _context.Users.Find(Id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }




    }
}
