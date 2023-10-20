using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Calculator
{
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
        Console.WriteLine("Перемещайте дату при помощи стрелок < >\nДата:1");
        

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
                Console.WriteLine("Дата:" +  post);
            }
            else if (info.Key == ConsoleKey.RightArrow && post != 5)
            {
                Console.Clear();
                post++;
                Console.WriteLine("Перемещайте дату при помощи стрелок < >");
                Console.WriteLine("Дата:" + post);
            }
        }
        while (info.Key != ConsoleKey.Enter);

        if (post == 1)
        {
            //добавить дату и её вывод
            Console.Clear();
            Day(1);
            Console.WriteLine("  ");
        }

        if (post == 2)
        {
            Console.Clear();
            Day(2);
            Console.WriteLine(" 2 ");
        }

        if (post == 3)
        {
            Console.Clear();
            Day(3);
            Console.WriteLine(" 3 ");
        }

        if (post == 4)
        {
            Console.Clear();
            Day(4);
            Console.WriteLine(" 4 ");
        }

        if (post == 5)
        {
            Console.Clear();
            Day(5);
            Console.WriteLine(" 5 ");
        }

        Console.SetCursorPosition(0, 5);
    }

    static void Day(int a)                                                                            // ВЫБОР ТОГО ЧТО БУДЕТ СДЕЛАНО
    {
        Console.WriteLine(" заметки на опред день ");
        Console.WriteLine("  Заметки ");
        Console.WriteLine("  3 ");
        Console.WriteLine("  4 ");
        Console.WriteLine("  Выход в меню ");
        Console.WriteLine("  Выход ");

        int d = a;                                                                                     // ПЕРЕХОД ДНЯ

        //тут дата
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
            else if (info.Key == ConsoleKey.DownArrow && post != 5)
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
            Console.WriteLine(" 2 ");
        }

        if (post == 3)
        {
            Console.Clear();
            Console.WriteLine(" 3 ");
        }

        if (post == 4)
        {
            Console.Clear();
            Vibor();
        }

        if (post == 5)
        {
            Console.Clear();
            Exit();
        }

        Console.SetCursorPosition(0, 5);
    }

    static void Zametki(int d)                                                  //  меню заметок
    {
        string[] day1 = {"    Сходить в магазин ", "Купить: молоко, хлеб ", "    Сдать практическую", "Прикрепить файлы ", "  ----------", "----------"};
        string[] day2 = {"    Доделать практическую ", "Доделать функции 1 и 2 ", "    Посмотреть скидки в стиме ", "Проверить список желаемого ", "  ----------", "----------"};
        string[] day3 = {"    Посмотреть новую серию стоуна ", "Новый мир серия 12 ", "    Дописать код ", "Исправить ошибки ", "  ----------", "----------"};
        string[] day4 = {"    Посмотрить новую серию стоуна ", "Новый мир серия 13 ", "    Купить сверчков ", "Купить 3 пачки ", "  ----------", "----------" };
        string[] day5 = {"    Проверить промокоды ", "Купить пиццу если промокоды есть ", "    Покормить ящериц ", "Проверить и долить воду ", "  ----------", "----------"};
                                                                               // ДЛЯ ВЫВОДА ТОГО ЧТО УЖЕ ЕСТЬ
        if (d == 1)
        {
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day1[0]);
            Console.WriteLine(day1[2]);
            Console.WriteLine(day1[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад ");
        }
        if (d == 2)
        {
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day2[0]);
            Console.WriteLine(day2[2]);
            Console.WriteLine(day2[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d == 3)
        {
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day3[0]);
            Console.WriteLine(day3[2]);
            Console.WriteLine(day3[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d==4)
        {
            Console.WriteLine("  Заметки: ");
            Console.WriteLine(day4[0]);
            Console.WriteLine(day4[2]);
            Console.WriteLine(day4[4]);
            Console.WriteLine("  Добавить заметку ");
            Console.WriteLine("  Назад");
        }
        if (d==5)
        {
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

            if (info.Key == ConsoleKey.UpArrow && post != 1)
            {
                post--;
            }
            else if (info.Key == ConsoleKey.DownArrow && post != 5)
            {
                post++;
            }
        }
        while (info.Key != ConsoleKey.Enter);
        
        if (post == 1)                                                              //НАЧАЛО ПЕРВОЙ ЗАМЕТКИ
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Enter");
            if (d==1)
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
            if (d==2)
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

        if (post == 2)                                                             //НАЧАЛО ВТОРОЙ ЗАМЕТКИ
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

        if (post == 3)                                                                            //НАЧАЛО 3 ЗАМЕТКИ
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

        if (post == 4)
        {                                                                              //НАЧАЛО ДОБАВЛЕНИЯ ЗАМЕТКИ
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            if (d == 1)
            {
                Console.WriteLine("Введите заметку (для корректного использования поставьте 2 пробела перед вводом заметки):");
                day1[4] = Console.ReadLine();
                Console.WriteLine("Добавте описание");
                day1[5] = Console.ReadLine();
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
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
                    if (key.Key == ConsoleKey.Escape)
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
                    if (key.Key == ConsoleKey.Escape)
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
                    if (key.Key == ConsoleKey.Escape)
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
                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                Console.Clear();
                Zametki(d);
            }
        }                                                                             //КОНЕЦ ВВОДА ЗАМЕТКИ

        if (post == 5)
        {
            Console.Clear();
            Vibor();
        }
    }   
}
// нужно переделать базу данных, добавление описания и времени, место которое берёт данные из массива нужно переелать под актуальный массив