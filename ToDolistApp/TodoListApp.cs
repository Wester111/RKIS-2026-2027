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
            //Лекция 3
            string[] todos = new string[2];
            int todoCount = 0;
            while (true)
            {
                Console.Write("\n Введите команду: ");
                string input = Console.ReadLine()?.Trim() ?? ""; //"?.Trim() ?? "";"-очистка от нуля, лишних пробелов и замена null на пустую строку
                if (string.IsNullOrEmpty(input))
                    continue;

                switch (input.ToLower())
                {
                    case "exit":
                        Console.WriteLine("ВСЁ!");
                        return; // Выход из метода Main
                    case "help":
                        Console.WriteLine(@"Доступные команды:
help    - список команд
profile - данные пользователя
add ... - добавить задачу
view    - показать задачи
exit    - выход");
                        break;
                    case "profile":
                        Console.WriteLine($"{firstName} {lastName}, {birthYear}");
                        break;
                    case var cmd when cmd.StartsWith("add "):
                        string taskText = input.Substring(4).Trim('"');
                        if (todoCount >= todos.Length)
                        {
                            string[] newTodos = new string[todos.Length * 2];
                            for (int i = 0; i < todos.Length; i++) 
                                newTodos[i] = todos[i];
                            todos = newTodos;
                            Console.WriteLine($"[Система]: Массив увеличен до {todos.Length} элементов.");
                        }
                        todos[todoCount++] = taskText;
                        Console.WriteLine("Задача  добавлена");
                        break;
                    case "view":
                        bool hasTasks = 0;
                        for (int i = 0; i < todoCount; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todos[i]}");
                            hasTasks = 1;
                        }
                        if (!hasTasks)
                            Console.WriteLine("Задач нет, время отдыха");
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                        break;
                }



            }

        }
    }
}
//Lesson 3:add command