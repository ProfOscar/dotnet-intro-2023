namespace ese01.Models.Services
{
    public class UsersService : IUsersService
    {
        private List<UserModel> users = new List<UserModel>
            {
                new UserModel(1, "Paolino","Paperino", new DateTime(1934,5,29), "San Francisco"),
                new UserModel(2, "Giuseppe","Garibaldi", new DateTime(1790,10,5), "Nizza"),
                new (3, "Mario", "Garibaldi", new DateTime(1801, 8, 3), "Genova"),
                new (4, "Roberto", "Baggio", new DateTime(1963, 3, 2), "Cremona")
            };

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel? FindById(int id)
        {
            return users.SingleOrDefault(u => u.Id == id);
        }

        public UserModel Add(UserModel user)
        {
            user.Id = users.Max(u => u.Id) + 1;

            users.Add(user);
            return user;
        }

        public int DeleteById(int id)
        {
            return users.RemoveAll(u => u.Id == id);
        }

    }
}