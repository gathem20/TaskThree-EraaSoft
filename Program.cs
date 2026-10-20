




using System.Data.Common;

Instructor instructor = new Instructor();
instructor.InstructorId = 50;
instructor.Name = "ahmed";
instructor.Specialization = "C#";
System.Console.WriteLine(instructor.PrintDetails());
Instructor instructor1 = new Instructor();
instructor1.InstructorId = 51;
instructor1.Name = "khalid";
instructor1.Specialization = "C++";
System.Console.WriteLine(instructor1.PrintDetails());
Instructor instructor2 = new Instructor();
instructor2.InstructorId = 52;
instructor2.Name = "mohamed";
instructor2.Specialization = "C";
System.Console.WriteLine(instructor2.PrintDetails());


Course course = new Course();

course.CourseId = 215;
course.Title = "C#";
course.Instructor = instructor;
System.Console.WriteLine(course.PrintDetails());
Course course1 = new Course();
course1.CourseId = 216;
course1.Title = "C++";
course1.Instructor = instructor1;
System.Console.WriteLine(course1.PrintDetails());
Course course2 = new Course();
course2.CourseId = 217;
course2.Title = "C";
course2.Instructor = instructor2;


System.Console.WriteLine(course2.PrintDetails());


Student student = new Student();
student.Name = "Hassan";
student.Age = 18;
student.StudentId = 87;
student.Enroll(course);


System.Console.WriteLine(student.PrintDetails());
Student student1 = new Student();
student1.Name = "Hassan";
student1.Age = 19;
student1.StudentId = 83;
student1.Enroll(course);
student1.Enroll(course2);


System.Console.WriteLine(student1.PrintDetails());
Student student2 = new Student();
student2.Name = "Hassan";
student2.Age = 15;
student2.StudentId = 89;
student2.Enroll(course);
student2.Enroll(course1);


System.Console.WriteLine(student2.PrintDetails());




StudentManager studentManager = new StudentManager();



while (true)
{
    System.Console.WriteLine("1. Add Student");
    System.Console.WriteLine("2. Add Instructor");
    System.Console.WriteLine("3. Add Course");
    System.Console.WriteLine("4. Enroll Student in Course");
    System.Console.WriteLine("5. Show All Students");
    System.Console.WriteLine("6. Show All Courses");
    System.Console.WriteLine("7. Show All Instructors");
    System.Console.WriteLine("8. Find the student by id or name");
    System.Console.WriteLine("9. Fine the course by id or name");
    System.Console.WriteLine("10. Exit");

    string Choice = Console.ReadLine();
    switch (Choice)
    {
        case "1":
            {
                System.Console.WriteLine("ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Student students = new Student();
                if (studentManager.AddStudent(student))
                    Console.WriteLine("Student added.");
            }
            break;

        case "2":
            {
                Console.WriteLine("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Specialization: ");
                string specialization = Console.ReadLine();

                Instructor instructors = new Instructor();
                if (studentManager.AddInstructor(instructor))
                    Console.WriteLine("Instructor added.");
            }
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        case "9":
            break;
        case "10":

            break;
    }



}