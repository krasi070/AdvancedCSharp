using System;
using System.Collections.Generic;
using System.Linq;

class FindStudents
{
    static void Main()
    {
        var listOfStudents = new List<Student>() { new Student(
        "Asen",
        "Mihailov",
        23,
        732114,
        "02 97549100",
        "a.mihaiko@abv.bg",
        new List<int> { 3, 4, 4, 5, 6, 2, 4, 5},
        2,
        "Gaton"),
        new Student(
            "Timothy",
            "Stark",
            19,
            632715,
            "0896123654",
            "starksftw@gamil.com",
            new List<int> {6, 6, 6, 6, 5, 4, 5, 6},
            1,
            "Lispor"),
        new Student(
            "Dobromira",
            "Bojanova",
            28,
            123015,
            "0897642135",
            "ebojina@fakeemail.com",
            new List<int> { 3, 5, 2, 2, 4},
            1,
            "Nerbeam"),
        new Student(
            "Galina",
            "Hiranova",
            18,
            678315,
            "0297509999",
            "harryp12@gmail.com",
            new List<int> { 2, 3, 3, 3, 5, 4, 4, 3, 4},
            2,
            "Nerbeam"),
        new Student(
            "Jana",
            "Kirimova",
            19,
            909013,
            "0896144488",
            "mirojan96@abd.bg",
            new List<int> { 3, 4, 5, 5, 5, 5, 5, 5, 5},
            1,
            "Nerbeam"),
        new Student(
            "Filio",
            "Michev",
            26,
            121314,
            "0897144123",
            "saverick@abv.bg",
            new List<int> { 6, 6, 6, 6, 5, 4, 6},
            1,
            "Gaton"),
        new Student(
            "Radoslava",
            "Kojuharova",
            31,
            765015,
            "0297096744",
            "shipjerry@something.com",
            new List<int> { 4, 4, 4, 5, 5, 5, 3, 5},
            2,
            "Gaton"),
        new Student(
            "Valentina",
            "Slepcheva",
            23,
            087615,
            "+359297554400",
            "plshelpsanchez@abv.bg",
            new List<int> { 3, 4, 4, 4, 5, 6, 6},
            1,
            "Lispor")};
        Console.WriteLine("1.Students By Group\n2.Students By First And Last Name\n3.Students By Age\n4.Sort Students (extensions)");
        Console.WriteLine("5.Sort Students (query)\n6.Filter Students By Email Domain\n7.Filter Students By Phone\n8.Excellent Students\n9.Weak Students");
        Console.Write("10.Students Enrolled In 2014\n11.Students By Groups\nEnter number: ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                OrderStudentsByGroup(listOfStudents);
                break;
            case "2":
                OrderStudentsByFirstAndLastName(listOfStudents);
                break;
            case "3":
                OrderByAge(listOfStudents);
                break;
            case "4":
                OrderByNameExtensions(listOfStudents);
                break;
            case "5":
                OrderByNameQuery(listOfStudents);
                break;
            case "6":
                PrintABVStudents(listOfStudents);
                break;
            case "7":
                PrintSofiaPhoneStudents(listOfStudents);
                break;
            case "8":
                PrintExcellentStudents(listOfStudents);
                break;
            case "9":
                PrintWeakStudents(listOfStudents);
                break;
            case "10":
                PrintStudentsFrom2014(listOfStudents);
                break;
            case "11":
                PrintGroups(listOfStudents);
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }

    }
    static void OrderStudentsByGroup(List<Student> students)
    {
        var orderByGroup = from student in students
                           where student.GroupNumber == 2
                           orderby student.FirstName
                           select student;
        foreach (var student in orderByGroup)
        {
            Console.WriteLine(student);
        }
    }
    static void OrderStudentsByFirstAndLastName(List<Student> students)
    {
        var orderByName = from student in students
                          where string.Compare(student.FirstName, student.LastName) < 0
                          select student;
        foreach (var student in orderByName)
        {
            Console.WriteLine(student);
        }
    }
    static void OrderByAge(List<Student> students)
    {
        var orderByAge = from student in students
                         where student.Age >= 18 && student.Age <= 24
                         select new { student.FirstName, student.LastName, student.Age };
        foreach (var student in orderByAge)
        {
            Console.WriteLine(student);
        }
    }
    static void OrderByNameExtensions(List<Student> students)
    {
        var orderByName = students
            .OrderByDescending(student => student.FirstName)
            .ThenByDescending(student => student.LastName)
            .Select(student => student)
            .ToList();
        orderByName
            .ForEach(student => Console.WriteLine(student));
    }
    static void OrderByNameQuery(List<Student> students)
    {
        var orderByName = from student in students
                          orderby student.FirstName descending,
                          student.LastName descending
                          select student;
        foreach (var student in orderByName)
        {
            Console.WriteLine(student);
        }

    }
    static void PrintABVStudents(List<Student> students)
    {
        var abvStudents = students
            .Where(student => student.Email.Contains("abv.bg"))
            .Select(student => student)
            .ToList();
        abvStudents
            .ForEach(student => Console.WriteLine("{0} {1} {2}",
                student.FirstName, student.LastName, student.Email));
    }
    static void PrintSofiaPhoneStudents(List<Student> students)
    {
        var sofiaPhoneStudents = students
            .Where(student => student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2"))
            .Select(student => student)
            .ToList();
        sofiaPhoneStudents
            .ForEach(student => Console.WriteLine("{0} {1} {2}",
                student.FirstName, student.LastName, student.Phone));
    }
    static void PrintExcellentStudents(List<Student> students)
    {
        var excellentStudents = students
            .Where(student => student.Marks.Contains(6))
            .Select(student => new
            {
                FullName = string.Join(" ", student.FirstName, student.LastName),
                Marks = string.Join(", ", student.Marks)
            })
            .ToList();

        excellentStudents
            .ForEach(student => Console.WriteLine(student));
    }
    static void PrintWeakStudents(List<Student> students)
    {
        var weakStudents = students
            .Where(student => student.Marks.Count(badMark => badMark == 2) == 2)
            .Select(student => new
            {
                FullName = string.Join(" ", student.FirstName, student.LastName),
                Marks = string.Join(", ", student.Marks)
            })
            .ToList();

        weakStudents
            .ForEach(student => Console.WriteLine(student));
    }
    static void PrintStudentsFrom2014(List<Student> students)
    {
        var studentsFrom2014 = students
            .Where(student => student.FacultyNumber % 100 == 14)
            .Select(student => student);

        foreach (var student in studentsFrom2014)
        {
            Console.WriteLine(student);
        }

    }
    static void PrintGroups(List<Student> students)
    {
        var groups = students
            .GroupBy(student => student.GroupName)
            .Select(student => student);

        foreach (var group in groups)
        {
            Console.WriteLine("{0}\nMembers: {1}", group.Key, string.Join(", ", group));
        }
    }
}
