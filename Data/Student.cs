namespace reg.Data
{
    public class Student
    {
        public int Id{get; set;}
        public int UserId{get; set;}
        public string Surname{get; set;}
        public string FirstName{get; set;}
        public string Age{get; set;}
        public string Class{get; set;}
        public string AdmissionNumber{get; set;}

        public Student(int id, int userId, string surname, string firstName, string age, string basic, string adminNumber)
        {
            Id = id;
            UserId = userId;
            Surname = surname;
            FirstName = firstName;
            Age = age;
            Class = basic;
            AdmissionNumber = adminNumber;
        }
    }
}