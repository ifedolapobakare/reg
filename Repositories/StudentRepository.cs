using reg.Data;
namespace reg.Repositories
{
    public class StudentRepository
    {
        public static List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        
        public bool IsStudentExist(string admissionNumber)
        {
            foreach(Student item in students)
            {
                if(item.AdmissionNumber == admissionNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public Student GetStudent(string surname)
        {
            foreach(Student item in students)
            {
                if(item.Surname == surname)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Student> GetAll()
        {
            return students;
        }
    }
}