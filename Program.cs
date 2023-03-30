using System;
using Students;
using Readers;

namespace Students
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

namespace Readers
{ 
    public class Reader
    {
        private string Name;
        public string NumberOfCard;
        public string Faculty;
        private string Db;
        public string PhoneNumber;

        public Reader(string fullName, string numberOfCard, string faculty, string dateOfBirth, string phoneNumber)
        {
            Name = fullName;
            NumberOfCard = numberOfCard;
            Faculty = faculty;
            Db = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public void TakeBook(int count)
        {
            Console.WriteLine($"{Name} взял(а) {count} книг(и)");
        }

        public void TakeBook(params string[] bookNames) { 
            Console.WriteLine($"{Name} взял(а) книги: {string.Join(", ", bookNames)}");
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{Name} вернул(а) {count} книг(и)");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{Name} вернул(а) книги: {string.Join(", ", bookNames)}");
        }
    }
}   

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[3]
                {
                new Student("Schwarzenegger A.", "98it17", 18),
                new Student("Chan J.", "99it15", 25),
                new Student("Coleman R.", "01it11", 20)
                };

        Reader[] readers = new Reader[3]
                {
                new Reader("Freeman T.", "748042", "Журналистика", "30.08.1966.08", "1389481"),
                new Reader("Cormier Ch.", "127563", "Литература", "19.08.1967", "4534533"),
                new Reader("Dillet P.", "928475", "Искусство", "12.04.1965", "9128474")
                };

        foreach (Student student in students)
        {
            student.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Мартин Иден", "Три товарища", "Замок Броуди", "Отель", "Железный Король");
        readers[0].ReturnBook("Триумфальная арка", "Гордость и предубеждение", "Джейн Эйр");
        readers[1].ReturnBook(5);
    }
}
