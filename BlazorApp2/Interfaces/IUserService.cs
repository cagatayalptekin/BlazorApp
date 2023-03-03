using BlazorApp2.Data.Dtos;

namespace BlazorApp2.Interfaces
{
    public interface IUserService
    {
        public List<UserDto> GetAllUsers();
        public UserDto GetUser(int id);
        public bool InsertUser(UserDto userdto);
        public bool UpdateUser(UserDto userdto);
        public bool DeleteUser(int Id);
    }
}
