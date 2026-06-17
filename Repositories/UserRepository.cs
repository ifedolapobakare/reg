using reg.Data;

namespace reg.Repositories
{
    public class UserRepository
    {
        public static List<User> users = new List<User>();

        public void Add(User user)
        {
            users.Add(user);
        }

        public bool IsEmailExist(string email)
        {
            foreach(User item in users)
            {
                if(item.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUser(int id)
        {
            foreach(User item in users)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public List<User> GetAll()
        {
            return users;
        }
        
    }
}