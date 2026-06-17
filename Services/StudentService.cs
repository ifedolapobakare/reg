using reg.Repositories;
using reg.Dto;
using reg.Data;

namespace reg.Services
{
    public class StudentService
    {
        UserRepository userRepository = new UserRepository();
        StudentRepository studentRepository = new StudentRepository();

        public int? RegisterStudent(RegisterStudentRequest request)
        {
            bool exists = userRepository.IsEmailExist(request.Email);
            if(exists == true)
            {
                return null;
            }

            User user = new User(UserRepository.users.Count + 1, request.Email, request.Password);

            userRepository.Add(user);
            int userCount = StudentRepository.students.Count + 1;

            Student student = new Student(userCount, user.Id, request.Surname, request.FirstName, request.Age, request.Class, $"000{userCount}");
            studentRepository.AddStudent(student);

            return student.Id;
        }
    }
}