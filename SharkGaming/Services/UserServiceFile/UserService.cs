using SharkGaming.MockData;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.Users;

namespace SharkGaming.Services.UserServiceFile
{
    public class UserService
    {

        public List<User> _users { get; set; }

        private JsonService JsonService { get; set; }

        public UserService()
        {
            _users = MockUser.GetMockUser();
        }

        public UserService(JsonService jsonService)
        {
            JsonService = jsonService;

            //_users = MockUser.GetMockUser();
            _users = jsonService.GetJsonUser().ToList();
            JsonService.SaveJsonUser(_users);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            JsonService.SaveJsonUser(_users);
        }

    }
}
