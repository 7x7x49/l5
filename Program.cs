using System;
using ReaderNS;

namespace Student
{
    public class Student 
    { 
        public string Name;
        public string Group;
        private int Age;

        public Student(string name, string group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Группа: {Group}, Возраст: {Age}");
        }
    }
}

namespace ReaderNS
{ 
    public class Reader
    {
        private string FullName;
        public string CardNumber;
        public string Faculty;
        private string DateOfBirth;
        public string PhoneNumber;

        public Reader(string fullName, string cardNumber, string faculty, string dateOfBirth, string phoneNumber)
        { 
            FullName = fullName;
            CardNumber = cardNumber;
            Faculty = faculty;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public void TakeBook(int count)
        {
            Console.WriteLine($"{FullName} взял(а) {count} книг(и)");
        }

        public void TakeBook(params string[] bookNames) { 
            Console.WriteLine($"{FullName} взял(а) книги: {string.Join(", ", bookNames)}");
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{FullName} вернул(а) {count} книг(и)");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{FullName} вернул(а) книги: {string.Join(", ", bookNames)}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student.Student[] students = new Student.Student[3]
                {
                new Student.Student("Schwarzenegger A.", "98it17", 18),
                new Student.Student("Chan J.", "99it15", 25),
                new Student.Student("Coleman R.", "01it11", 20)
                };

        Reader[] readers = new Reader[3]
                {
                new Reader("Freeman T.", "748042", "Журналистика", "30.08.1966.08", "1389481"),
                new Reader("Cormier Ch.", "127563", "Литература", "19.08.1967", "4534533"),
                new Reader("Dillet P.", "928475", "Искусство", "12.04.1965", "9128474")
                };

        foreach (var student in students)
        {
            student.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Мартин Иден", "Три товарища", "Замок Броуди", "Отель", "Железный Король");
        readers[0].ReturnBook("Триумфальная арка", "Гордость и предубеждение", "Джейн Эйр");
        readers[1].ReturnBook(5);
    }
}
