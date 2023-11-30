using Practica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void CreateStudentFile(string fileName, string groupName, int numberOfStudents)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {

                for (int i = 1; i <= numberOfStudents; i++)
                {
                    string studentName = $"Student{i}";
                    writer.WriteLine($"{studentName}; {groupName}");
                }
            }
        }
        static void Main(string[] args)
        {
            // ЗАДАЧА 1.
            Console.WriteLine("Задачa 1. Студенты и мероприятия");
            Students students = new Students();

            CreateStudentFile("Group1.txt", "Group1", 15);
            CreateStudentFile("Group2.txt", "Group2", 20);
            CreateStudentFile("Group3.txt", "Group3", 10);
            students.ReadStudentsFromFile("Group1.txt");
            students.ReadStudentsFromFile("Group2.txt");
            students.ReadStudentsFromFile("Group3.txt");

            Event event1 = new Event("Театр", new DateTime(2023, 12, 11), 5);
            Event event2 = new Event("Концерт", new DateTime(2023, 12, 15), 8);

            students.AssignStudentsToEvent(event1);
            students.AssignStudentsToEvent(event2);
            students.SaveEventToFile("Event1.txt", event1);
            students.SaveEventToFile("Event2.txt", event2);

            //ЗАДАЧА 2.
            Console.WriteLine("Задача 2. Интересующие события");
            Console.WriteLine("Варианты: Кино, Музыка, Спорт");
            Person person1 = new Person("Рустам", "Кино");
            Person person2 = new Person("Данис", "Музыка");
            Person person3 = new Person("Самат", "Спорт");
            string ev = Console.ReadLine();
            foreach (Person person in new[] { person1, person2, person3 })
            {
                string reaction = person.GetReactionToEvent(ev);
                Console.WriteLine(person.Name + ": " + reaction);
            }
        }
    }
}