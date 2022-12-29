
using Assignment4;
using Assignment4.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

Console.WriteLine("###########################   Welcome Attendence System  ***************************");

TrainingDbContext context = new TrainingDbContext();


#region Take input to enter 
Console.WriteLine("Welcome to Our userName");
string userName = Console.ReadLine();
Console.WriteLine("Welcome to password");
int password = int.Parse(Console.ReadLine());


#endregion


User c1 = context.Users.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
if (c1?.UserName != null && c1.UserType == 0)
{
    Console.WriteLine(c1.UserName + " Type : " + c1.UserType);
    Console.WriteLine("Enter 1 to Add Teacher");
    Console.WriteLine("Enter 2 to Add Student");
    Console.WriteLine("Enter 3 to Add Course");


    int m = int.Parse(Console.ReadLine());
    if (m == 1)
    {
        Console.WriteLine("If assign course with Teacher then 1 or give 2 seeing course then assign and give 3 to see teacher then assign a course");
        int value = int.Parse(Console.ReadLine());
        #region student insert with seeing course
        if (value == 2)
        {
            Console.WriteLine("Name : ");
            string Name = Console.ReadLine();

            Console.WriteLine("UserName : ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Password : ");
            int Password = int.Parse(Console.ReadLine());

            User user = new User { Name = Name, UserName = UserName, Password = Password, UserType = (UserStatus)m };
            context.Add(user);
            context.SaveChanges();
            List<Course> d1 = context.Courses.ToList();

            #region display Course which are assign 
            Console.WriteLine("Course List");
            int i;

            for (i = 0; i < d1.Count; i++)
            {
                if (d1[i].TeacherId == null)
                {
                    Console.WriteLine($"No : {i + 1} {d1[i].CourseName}");
                }

            }
            #endregion

            #region Update Teacher ID with the requirement of Teacher
            string courseTitle = Console.ReadLine();
            Course b1 = context.Courses.Where(x => x.CourseName == courseTitle).FirstOrDefault();

            if (b1?.CourseName != null)
            {
                b1.TeacherId = user.Id;
                context.SaveChanges();

            }
        }
        #endregion
        #endregion

        #region new insert with course
        if (value == 1)
        {
            Console.WriteLine("Name :");
            string Name = Console.ReadLine();

            Console.WriteLine("UserName :");
            string UserName = Console.ReadLine();

            Console.WriteLine("Password :");
            int Password = int.Parse(Console.ReadLine());


            User StudentWithCourse = new User { Name = Name, UserName = UserName, Password = Password, UserType = (UserStatus)m };
            StudentWithCourse.Courses = new List<Course>();

            Console.WriteLine("How many course are taken : ");

            Console.WriteLine("CourseName :");
            string CourseName = Console.ReadLine();

            Console.WriteLine("Fees :");
            int Fees = int.Parse(Console.ReadLine());

            StudentWithCourse.Courses.Add(new Course { CourseName = CourseName, Fees = Fees });


            context.Users.Add(StudentWithCourse);
            context.SaveChanges();
        }
        if (value == 3)
        {
            List<User> Users1 = context.Users.Where(x => x.UserType == UserStatus.Teacher).ToList();

            foreach (var it in Users1)
            {
                Console.WriteLine(it.UserName + " " + it.UserType);

            }

            List<Course> d1 = context.Courses.ToList();

          // display Course which are assign 
            Console.WriteLine("Course List which are not assign : ");
            int i;

            for (i = 0; i < d1.Count; i++)
            {
                if (d1[i].TeacherId == null)
                {
                    Console.WriteLine($"No : {i + 1} {d1[i].CourseName}");
                }

            }

            String SubjectName = Console.ReadLine();
            String name = Console.ReadLine();
            Course find4 = context.Courses.Where(x => x.CourseName == SubjectName)
                .Include(x => x.Teacher)
                .FirstOrDefault();

            List<User> find3 = context.Users.Where(x => x.UserType == UserStatus.Teacher).ToList();
            int j;
            for (j = 0; j < find3.Count; j++)
            {
                if (find3[j].UserName == name)
                {
                    find4.TeacherId = find3[j].Id;
                    context.SaveChanges();
                    break;
                }

            }

        }

        #endregion


    }
    else if (m == 2)
    {
        Console.WriteLine("Student ");

        Console.WriteLine("Name :");
        string Name = Console.ReadLine();

        Console.WriteLine("UserName :");
        string UserName = Console.ReadLine();

        Console.WriteLine("Password :");
        int Password = int.Parse(Console.ReadLine());


        User StudentWithCourse = new User { Name = Name, UserName = UserName, Password = Password, UserType = (UserStatus)m };
        context.Users.Add(StudentWithCourse);
        context.SaveChanges();
       

        List<Course> d1 = context.Courses.ToList();

      // display Course which are assign 
        Console.WriteLine("Course List");
        int i;

        for (i = 0; i < d1.Count; i++)
        {
            {
                Console.WriteLine($"No : {i + 1} {d1[i].CourseName}");
            }

        }


        //assign

        Console.WriteLine("-------------------  if you entry a course then 1-------  ");
        //all student
        List<User> Users1 = context.Users.Where(x => x.UserType == UserStatus.Student).ToList();

        foreach (var it in Users1)
        {
            Console.WriteLine(it.UserName + " " + it.UserType);

        }


        int give = int.Parse(Console.ReadLine());
        if(give==1)
        {


            Console.WriteLine("give Course Name");
        String Coursename = Console.ReadLine();

            Console.WriteLine("give student UserName");
            String studentName = Console.ReadLine();


        Course course12 = context.Courses.Where(x => x.CourseName == Coursename)
            .Include(x => x.CourseStudents)
            .FirstOrDefault();

        if (course12.CourseStudents == null)
            course12.CourseStudents = new List<StudentCourseAssignment>();

        User s1 = context.Users.Where(x => x.UserName == studentName).FirstOrDefault(); ;
        course12.CourseStudents.Add(new StudentCourseAssignment { Student = s1 });
        context.SaveChanges();

        }
        else
        {
            Console.WriteLine("Thanks ");
        }


    }
    #region Admin Added New Course
    else if (m == 3)
    {
        Console.WriteLine("CourseName : ");
        string CourseName = Console.ReadLine();

        Console.WriteLine("Fees : ");
        int Fees = int.Parse(Console.ReadLine());

        Course course = new Course { CourseName = CourseName, Fees = Fees };
        context.Add(course);
        context.SaveChanges();

        List<Course> d1 = context.Courses.ToList();
        Console.WriteLine("Course List");
        int i;
        for (i = 0; i < d1.Count; i++)
        {
            Console.WriteLine($"No : {i + 1} {d1[i].CourseName}");

        }
    }
    #endregion
    else
    {

        Console.WriteLine("Give correct number");



    }
}


else if (c1?.UserName != null && c1.UserType == (UserStatus)1)
{
    Console.WriteLine("###################################### Teacher Panel ");
    Console.WriteLine("Enter 1 to See Course");
    User user = context.Users.Where(x => x.UserName == c1.UserName).FirstOrDefault();
    List<Course> d1 = context.Courses.ToList();
    int m = int.Parse(Console.ReadLine());
    if (m == 1)
    {
        #region display Course which are assign 
        int i;

        for (i = 0; i < d1.Count; i++)
        {
            if (d1[i].TeacherId == user.Id)
            {
                Console.WriteLine($"No : {i + 1} {d1[i].CourseName}");
            }

        }
        #endregion
    }
    else
    {
        Console.WriteLine("Give Correct Input");
    }
}

else
{
    Console.WriteLine("Give Correct Username Or Password");

}

#region
//Admin save
/*User user = new User { Name = "Avishek das", UserName = "Avishek", Password = 12345, UserType = (UserStatus)0 };
context.Add(user);
context.SaveChanges();*/
#endregion