using System;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнил Вахрамеев");
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите год рождения: ");
            string yearInput = Console.ReadLine();

            int birthYear = Convert.ToInt32(yearInput);
            int currentYear = 2026;
            int age = currentYear - birthYear;

            Console.WriteLine($"Добавлен пользователь {firstName} {lastName}, возраст {age}");
        }
    }
}
