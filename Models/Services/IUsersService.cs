namespace ese01.Models.Services
{
    public interface IUsersService
    {
        IEnumerable<UserModel> GetAll();
        UserModel? FindById(int id);
        UserModel Add(UserModel user);
        int DeleteById(int id);
    }
}