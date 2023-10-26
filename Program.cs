using System;

class Calculator
{
    static DateTime now = DateTime.Now;
    static string[] day1 = { "    Сходить в магазин ", $"Купить: молоко, хлеб\n{DateTime.Now}", "    Сдать практическую", $"Прикрепить файлы\n{DateTime.Now} ", "  ----------", "----------" };
    static string[] day2 = { "    Доделать практическую ", $"Доделать функции 1 и 2 \n{now.AddDays(1)}", "    Посмотреть скидки в стиме ", $"Проверить список желаемого \n{now.AddDays(1)}", "  ----------", "----------" };
    static string[] day3 = { "    Посмотреть новую серию стоуна ", $"Новый мир серия 12 \n{now.AddDays(2)}", "    Дописать код ", $"Исправить ошибки \n{now.AddDays(2)}", "  ----------", "----------" };
    static string[] day4 = { "    Посмотрить новую серию стоуна ", $"Новый мир серия 13 \n{now.AddDays(3)}", "    Купить сверчков ", $"Купить 3 пачки \n{now.AddDays(3)}", "  ----------", "----------" };
    static string[] day5 = { "    Проверить промокоды ", $"Купить пиццу если промокоды есть \n{now.AddDays(4)}", "    Покормить ящериц ", $"Проверить и долить воду \n{now.AddDays(4)}", "  ----------", "----------" };
    
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска.\n");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        Console.Clear();

        Vibor();

    }

    static void Exit()                                                                        // БЛОК ВЫХОДА
    {
        Console.WriteLine("Завершение работы нажмите Escape.");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            else
            {
                Console.Clear();
                Vibor();
            }
        }
    }

    static void Vibor()                                                                        // МЕНЮ
    {
        Console.WriteLine($"Перемещайте дату при помощи стрелок < >\nДата: {DateTime.Now}");


        int post = 1;
        ConsoleKeyInfo info;

        do
        {
            info = Console.ReadKey();

            if (info.Key == ConsoleKey.LeftArrow && post != 1)
            {
                Console.Clear();
                post--;
                Console.WriteLine("Перемещайте дату при помощи стрелок < >");
                Console.WriteLine($"Дата: {now.AddDays(post-1)}");
            }
            else if (info.Key == ConsoleKey.RightArrow && post != 5)
            {
                Console.Clear();
                post++;
                Console.WriteLine("Перемещайте дату при помощи стрелок < >");
                Console.WriteLine($"Дата: {now.AddDays(post-1)}");
            }
        }
        while (info.Key != ConsoleKey.Enter);

        if (post == 1)
        {
            //добавить дату и её вывод
            Console.Clear();
            Day(1);
        }

        if (post == 2)
        {
            Console.Clear();
            Day(2);
        }

        if (post == 3)
        {
            Console.Clear();
            Day(3);
        }

        if (post == 4)
        {
            Console.Clear();
            Day(4);
        }

        if (post == 5)
        {
            Console.Clear();
            Day(5);
        }
        Console.SetCursorPosition(0, 5);
    }

    static void Day(int a)                                                                            // ВЫБОР ТОГО ЧТО БУДЕТ СДЕЛАНО
    {
        Console.WriteLine($" Заметки на {now.AddDays(a - 1)}");
        Console.WriteLine("  Заметки ");
        Console.WriteLine("  Выход в меню ");
        Console.WriteLine("  Выход ");

        int d = a;                                                                                     // ПЕРЕХОД ДНЯ

        int post = 1;
        ConsoleKeyInfo info;

        do
        {
            Console.SetCursorPosition(0, post);
            Console.WriteLine("->");

            info = Console.ReadKey();

            Console.SetCursorPosition(0, post);
            Console.WriteLine("  ");

            if (info.Key == ConsoleKey.UpArrow && post != 1)
            {
                post--;
            }
            else if (info.Key == ConsoleKey.DownArrow && post != 3)
            {
                post++;
            }
        }
        while (info.Key != ConsoleKey.Enter);

        if (post == 1)
        {
            Console.Clear();
            Zametki(d);
        }

        if (post == 2)
        {
            Console.Clear();
            Vibor();
        }

        if (post == 3)
        {
            Console.Clear();
            Exit();
        }

        Console.SetCursorPosition(0, 3);
    }

    static void Zametki(int d)                                                  //  меню заметок
    {
        // ДЛЯ ВЫВОДА ТОГО ЧТО УЖЕ ЕСТЬ
        
        if (d == 1)
        {
            Console.WriteLine($"{ now.AddDays(d - 1)}");
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day1[0]);
            Console.WriteLine(day1[2]);
            Console.WriteLine(day1[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад ");
        }
        if (d == 2)
        {
            Console.WriteLine($"{now.AddDays(d - 1)}");
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day2[0]);
            Console.WriteLine(day2[2]);
            Console.WriteLine(day2[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d == 3)
        {
            Console.WriteLine($"{now.AddDays(d - 1)}");
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day3[0]);
            Console.WriteLine(day3[2]);
            Console.WriteLine(day3[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d == 4)
        {
            Console.WriteLine($"{now.AddDays(d - 1)}");
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day4[0]);
            Console.WriteLine(day4[2]);
            Console.WriteLine(day4[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d == 5)
        {
            Console.WriteLine($"{now.AddDays(d - 1)}");
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day5[0]);
            Console.WriteLine(day5[2]);
            Console.WriteLine(day5[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }

        int post = 1;
        ConsoleKeyInfo info;

        do
        {                                                                         //ПЕРЕМЕЩЕНИЕ ПУНКТОВ
            Console.SetCursorPosition(0, post);
            Console.WriteLine("->");

            info = Console.ReadKey();

            Console.SetCursorPosition(0, post);
            Console.WriteLine("  ");

            if (info.Key == ConsoleKey.UpArrow && post != 2)
            {
                post--;
            }
            else if (info.Key == ConsoleKey.DownArrow && post != 6)
            {
                post++;
            }
        }
        while (info.Key != ConsoleKey.Enter);

        if (post == 2)                                                              //НАЧАЛО ПЕРВОЙ ЗАМЕТКИ
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Enter");
            if (d == 1)
            {
                Console.WriteLine(day1[0]);
                Console.WriteLine(day1[1]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 2)
            {
                Console.WriteLine(day2[0]);
                Console.WriteLine(day2[1]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 3)
            {
                Console.WriteLine(day3[0]);
                Console.WriteLine(day3[1]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 4)
            {
                Console.WriteLine(day4[0]);
                Console.WriteLine(day4[1]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 5)
            {
                Console.WriteLine(day5[0]);
                Console.WriteLine(day5[1]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
        }

        if (post == 3)                                                             //НАЧАЛО ВТОРОЙ ЗАМЕТКИ
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Enter");
            if (d == 1)
            {
                Console.WriteLine(day1[2]);
                Console.WriteLine(day1[3]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 2)
            {
                Console.WriteLine(day2[2]);
                Console.WriteLine(day2[3]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 3)
            {
                Console.WriteLine(day3[2]);
                Console.WriteLine(day3[3]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 4)
            {
                Console.WriteLine(day4[2]);
                Console.WriteLine(day4[3]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 5)
            {
                Console.WriteLine(day5[2]);
                Console.WriteLine(day5[3]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
        }

        if (post == 4)                                                                            //НАЧАЛО 3 ЗАМЕТКИ
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Enter");
            if (d == 1)
            {
                Console.WriteLine(day1[4]);
                Console.WriteLine(day1[5]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 2)
            {
                Console.WriteLine(day2[4]);
                Console.WriteLine(day2[5]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 3)
            {
                Console.WriteLine(day3[4]);
                Console.WriteLine(day3[5]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 4)
            {
                Console.WriteLine(day4[4]);
                Console.WriteLine(day4[5]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 5)
            {
                Console.WriteLine(day5[4]);
                Console.WriteLine(day5[5]);
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
        }                                                                              //КОНЕЦ ВЫВОДА ТРЕТЬЕЙ ЗАМЕТКИ

        if (post == 5)
        {                                                                              //НАЧАЛО ДОБАВЛЕНИЯ ЗАМЕТКИ
            Console.Clear();
            Console.WriteLine("Введите заметку (для корректного использования поставьте 2 пробела перед вводом заметки):");
            if (d == 1)
            {
                day1[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day1[5] = Console.ReadLine()+$"\n{ DateTime.Now}";
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 2)
            {
                day2[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day2[5] = Console.ReadLine()+$"\n{now.AddDays(d - 1)}";
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 3)
            {
                day3[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day3[5] = Console.ReadLine() + $"\n{now.AddDays(d - 1)}";
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 4)
            {
                day4[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day4[5] = Console.ReadLine() + $"\n{now.AddDays(d - 1)}";
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
            if (d == 5)
            {
                day5[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day5[5] = Console.ReadLine() + $"\n{now.AddDays(d - 1)}";
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
        }                                                                             //КОНЕЦ ВВОДА ЗАМЕТКИ

        if (post == 6)
        {
            Console.Clear();
            Vibor();
        }
    }
}