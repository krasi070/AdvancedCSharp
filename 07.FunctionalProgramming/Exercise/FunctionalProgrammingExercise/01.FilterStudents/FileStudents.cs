namespace LinqExercise
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FileStudents
    {
        public static void Main()
        {
            const string FilePath = @"../../Students-data.txt";

            List<Student> students = new List<Student>();
            string data = "";
            using (var studentData = new StreamReader(FilePath))
            {
                studentData.ReadLine();
                data = studentData.ReadToEnd();
            }

            string[] tokens = data.Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i += 12)
            {
                int id = int.Parse(tokens[0 + i]);
                string firstName = tokens[1 + i];
                string lastName = tokens[2 + i];
                string email = tokens[3 + i];
                string gender = tokens[4 + i];
                string studentType = tokens[5 + i];
                int examResult = int.Parse(tokens[6 + i]);
                int homeworksSent = int.Parse(tokens[7 + i]);
                int homeworksEvaluated = int.Parse(tokens[8 + i]);
                double teamworkScore = double.Parse(tokens[9 + i]);
                int attendancesCount = int.Parse(tokens[10 + i]);
                double bonus = double.Parse(tokens[11 + i]);

                students.Add(new Student(
                    id,
                    firstName,
                    lastName,
                    email,
                    gender,
                    studentType,
                    examResult,
                    homeworksSent,
                    homeworksEvaluated,
                    teamworkScore,
                    attendancesCount,
                    bonus));
            }
            Console.WriteLine("1.Male Students\n2.First Letter A Students\n3.Good Result Students\n4.Good Online Students");
            Console.WriteLine("5.No Homework Students\n6.Online Students' Emails\n7.Low Attendance Students");
            Console.WriteLine("8.Big Bonus Students\n9.Average Exam Results\n10.Number of Best Teamwork Scores");
            Console.WriteLine("11.Group Students Alphabetically\n12.Online and Onsite Students' Results");
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    PrintMaleStudents(students);
                    break;
                case "2":
                    PrintFirstLetterAStudents(students);
                    break;
                case "3":
                    PrintGoodResultStudents(students);
                    break;
                case "4":
                    PrintGoodOnlineStudents(students);
                    break;
                case "5":
                    PrintNoHomeworkStudents(students);
                    break;
                case "6":
                    PrintOnlineStudentsEmails(students);
                    break;
                case "7":
                    PrintLowAttendanceStudents(students);
                    break;
                case "8":
                    PrintBonusStudents(students);
                    break;
                case "9":
                    PrintAverageExamResults(students);
                    break;
                case "10":
                    PrintNumberOfBestTeamworkScores(students);
                    break;
                case "11":
                    PrintAlphabeticalGroup(students);
                    break;
                case "12":
                    PrintOnlineAndOnsiteStudents(students);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
        static void PrintMaleStudents(List<Student> students)
        {
            var maleStudents = students
                .Where(student => student.Gender == "Male")
                .Select(student => student)
                .ToList();
            maleStudents
            .ForEach(student => Console.WriteLine("{0} {1} - {2}",
            student.FirstName, student.LastName, student.Gender));
        }
        static void PrintFirstLetterAStudents(List<Student> students)
        {
            var firstLetterAStudents = students
                .Where(student => student.FirstName[0] == 'A')
                .Select(student => student)
                .ToList();
            firstLetterAStudents
                .ForEach(student => Console.WriteLine("{0} {1}",
                    student.FirstName, student.LastName));
        }
        static void PrintGoodResultStudents(List<Student> students)
        {
            var goodResultStudents = students
                .Where(student => student.ExamResult >= 350)
                .Select(student => student)
                .ToList();
            goodResultStudents
                .ForEach(student => Console.WriteLine("{0} {1} ({2}) - {3}",
                    student.FirstName, student.LastName, student.StudentType, student.ExamResult));
        }
        static void PrintGoodOnlineStudents(List<Student> students)
        {
            var goodOnlineStudents = students
                .Where(student => student.ExamResult >= 300 && student.StudentType == "Online")
                .OrderByDescending(student => student.ExamResult)
                .Select(student => student)
                .ToList();
            goodOnlineStudents
                .ForEach(student => Console.WriteLine("{0} {1} ({2}) - {3}",
                    student.FirstName, student.LastName, student.StudentType, student.ExamResult));
        }
        static void PrintNoHomeworkStudents(List<Student> students)
        {
            var noHomeworkStudents = students
                .Where(student => student.HomeworksSent == 0)
                .OrderBy(student => student.FirstName)
                .ThenBy(student => student.LastName)
                .Select(student => student)
                .ToList();
            noHomeworkStudents
                .ForEach(student => Console.WriteLine("{0} {1} ({2} homeworks sent)",
                    student.FirstName, student.LastName, student.HomeworksSent));
        }
        static void PrintOnlineStudentsEmails(List<Student> students)
        {
            var onlineStudentEmails = students
                .Where(student => student.StudentType == "Online")
                .Select(student => student.Email)
                .ToList();
            onlineStudentEmails
                .ForEach(email => Console.WriteLine(email));
        }
        static void PrintLowAttendanceStudents(List<Student> students)
        {
            var littleAttendencesStudents = students
                .Where(student => student.StudentType == "Onsite" && student.AttendancesCount < 5)
                .Select(student => student)
                .ToList();
            littleAttendencesStudents
                .ForEach(student => Console.WriteLine("Result: {0}, attendences: {1}",
            student.ExamResult, student.AttendancesCount));
        }
        static void PrintBonusStudents(List<Student> students)
        {
            var bonusStudents = students
                .Where(student => student.Bonus >= 4)
                .Select(student => student)
                .ToList();
            Console.WriteLine(bonusStudents.Count);
        }
        static void PrintAverageExamResults(List<Student> students)
        {
            Console.WriteLine("Online average: {0}\nOnsite average: {1}",
                students.Where(student => student.StudentType == "Online").Average(student => student.ExamResult),
            students.Where(student => student.StudentType == "Onsite").Average(student => student.ExamResult));
        }
        static void PrintNumberOfBestTeamworkScores(List<Student> students)
        {
            var maxTeamworkScore = students
                .Select(student => student.TeamworkScore);
            var maxTeamworkPointsStudents = students
                .Where(student => student.TeamworkScore == maxTeamworkScore.Max())
                .Select(student => student)
                .ToList();
            Console.WriteLine(maxTeamworkPointsStudents.Count);
        }
        static void PrintAlphabeticalGroup(List<Student> students)
        {
            var alphabeticalOrder = students
                .GroupBy(student => student.FirstName[0])
                .OrderBy(group => group.Key)
                .Select(student => student);
            foreach (var group in alphabeticalOrder)
            {
                Console.WriteLine(group.Key + ":");
                foreach (var student in group)
                {
                    Console.WriteLine(" " + student);
                }
            }
        }
        static void PrintOnlineAndOnsiteStudents(List<Student> students)
        {
            var onlineAndOnsiteStudents = students
                .OrderByDescending(student => student.ExamResult)
                .GroupBy(student => student.StudentType)
                .Select(student => student);
            foreach (var group in onlineAndOnsiteStudents)
            {
                Console.WriteLine("{0}:", group.Key.ToUpper());
                foreach (var student in group)
                {
                    Console.WriteLine(" {0} {1} - {2}", student.FirstName, student.LastName, student.ExamResult);
                }
            }
        }
    }
}
