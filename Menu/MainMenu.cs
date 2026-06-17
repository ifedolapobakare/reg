using reg.Services;
using reg.Dto;

namespace reg.Menu
{
    public class MainMenu
    {
        StudentService studentService = new StudentService();

        public void Start()
        {
            bool flag = true;

            while(flag)
            {
                Console.WriteLine("1. Register\n2. Login\n3. Logout");
                int opt = int.Parse(Console.ReadLine());

                if(opt == 1)
                {
                    Register();
                }
            }
        }

        public void Register()
        {
            Console.WriteLine("What is your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("What is your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your age");
            string age = Console.ReadLine();
            Console.WriteLine("What is your class");
            string basic = Console.ReadLine();
            Console.WriteLine("What is your email");
            string email = Console.ReadLine();
            Console.WriteLine("What is your password");
            string password = Console.ReadLine();

            RegisterStudentRequest request = new RegisterStudentRequest()
            {
                Surname = surname,
                FirstName = firstname,
                Age = age,
                Class = basic,
                Email = email,
                Password = password,
            };
            studentService.RegisterStudent(request);
        }
    }
}