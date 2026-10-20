
StudentManager studentManager = new StudentManager();

bool status = true;

while (status)
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
                Student students = new Student { StudentId = id, Name = name, Age = age };
                if (studentManager.AddStudent(students))
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

                Instructor instructors = new Instructor { InstructorId = id, Name = name, Specialization = specialization };
                if (studentManager.AddInstructor(instructors))
                    Console.WriteLine("Instructor Added.");
            }
            break;
        case "3":
            {
                Console.WriteLine("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Instructor Id: ");
                int instructorId = Convert.ToInt32(Console.ReadLine());


                Instructor instructor = studentManager.FindInstructor(instructorId);
                if (instructor == null)
                {
                    System.Console.WriteLine("Invalid InstructorID");
                    break;
                }
                Course courses = new Course { CourseId = id, Title = title, Instructor = instructor };
                if (studentManager.AddCourse(courses))
                    Console.WriteLine("Course Added.");
            }
            break;
        case "4":
            {
                System.Console.WriteLine("Student Id: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Course Id: ");
                int courseId = Convert.ToInt32(Console.ReadLine());
                if (studentManager.EnrollStudentInCourse(studentId, courseId))
                {
                    System.Console.WriteLine("Enrolled successfully.");
                }
            }
            break;
        case "5":
            {
                for (int i = 0; i < studentManager.Students.Count; i++)
                {
                    System.Console.WriteLine(studentManager.Students[i].PrintDetails());
                }
            }
            break;
        case "6":
            {
                for (int i = 0; i < studentManager.Courses.Count; i++)
                {
                    System.Console.WriteLine(studentManager.Courses[i].PrintDetails());
                }
            }
            break;
        case "7":
            {
                for (int i = 0; i < studentManager.Instructors.Count; i++)
                {
                    System.Console.WriteLine(studentManager.Instructors[i].PrintDetails());
                }
            }
            break;
        case "8":
            {
                System.Console.WriteLine("1-Enter Student Id :");
                System.Console.WriteLine("2-Enter Student Name :");
                string searchType = Console.ReadLine();
                Student student = null;
                if (searchType == "1")
                {
                    System.Console.WriteLine("Enter Student Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    student = studentManager.FindStudent(id);
                }
                if (searchType == "2")
                {
                    System.Console.WriteLine("Enter Student Name: ");
                    string name = Console.ReadLine();
                    for (int i = 0; i < studentManager.Students.Count; i++)
                    {
                        if (studentManager.Students[i].Name == name)
                        {
                            student = studentManager.Students[i];
                            break;
                        }
                    }
                }

                if (student != null)
                    Console.WriteLine(student.PrintDetails());
                else
                    Console.WriteLine("Student not found.");
            }
            break;

        case "9":
            {
                System.Console.WriteLine("1-Enter Course Id :");
                System.Console.WriteLine("2-Enter Course Name :");
                string searchType = Console.ReadLine();
                Course course = null;
                if (searchType == "1")
                {
                    System.Console.WriteLine("Enter Course Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    course = studentManager.FindCourse(id);
                }
                if (searchType == "2")
                {
                    System.Console.WriteLine("Enter Course Name: ");
                    string title = Console.ReadLine();
                    for (int i = 0; i < studentManager.Courses.Count; i++)
                    {
                        if (studentManager.Courses[i].Title == title)
                        {
                            course = studentManager.Courses[i];
                            break;
                        }
                    }
                }

                if (course != null)
                    Console.WriteLine(course.PrintDetails());
                else
                    Console.WriteLine("Course not found.");
            }
            break;
        case "10":
        System.Console.WriteLine("Good Bye!");
            status = false;
            break;
    }



}