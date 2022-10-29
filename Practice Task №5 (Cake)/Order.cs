using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.IO;

namespace Practice_Task__5__Cake_
{
    public class Order
    {
        public int Position = 9;
        private int SummaOfOrder = 0;
        public static int position_In_SubMenu;
        private string YourOrder = "";
        string icon;
        ConsoleKeyInfo pressedKey;
        DateTime Today = DateTime.Today;

        private void MainMenu()
        {
            Console.WriteLine(@"
 ██████╗ █████╗ ██╗  ██╗███████╗██████╗ ██╗   ██╗██╗   ██╗ ██████╗ ██████╗ ███╗   ███╗
██╔════╝██╔══██╗██║ ██╔╝██╔════╝██╔══██╗██║   ██║╚██╗ ██╔╝██╔════╝██╔═══██╗████╗ ████║
██║     ███████║█████╔╝ █████╗  ██████╔╝██║   ██║ ╚████╔╝ ██║     ██║   ██║██╔████╔██║
██║     ██╔══██║██╔═██╗ ██╔══╝  ██╔══██╗██║   ██║  ╚██╔╝  ██║     ██║   ██║██║╚██╔╝██║
╚██████╗██║  ██║██║  ██╗███████╗██████╔╝╚██████╔╝   ██║██╗╚██████╗╚██████╔╝██║ ╚═╝ ██║
 ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═════╝  ╚═════╝    ╚═╝╚═╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝                                                                                  
Здравствуйте, вы на нашем сайте для заказа тортов - CakeBuy.com - Самые лучшие и бюджетные торты на заказ!");
            Console.WriteLine("  Форма торта\n  Размер торта\n  Вкус коржей\n  Количество коржей\n  Глазурь\n  Декор\n  Рассчитаться за заказ");
            Console.WriteLine("Цена: " + SummaOfOrder);
            Console.WriteLine("Ваш торт: " + YourOrder);


            Console.SetCursorPosition(0, Position);
            icon = ">>";
            Console.WriteLine(icon);
        }
        public int Arrows()
        {
            do
            {
                Console.Clear();
                MainMenu();
                Console.CursorVisible = false;

                pressedKey = Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    Position--;

                    if (Position == 8)
                    {
                        Position = 15;
                    }
                }

                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    Position++;
                    if (Position == 16)
                    {
                        Position = 9;
                    }
                }

                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Вы вышли с сайта/программы, но зачем? Разве вы не хотите заказать у нас торт? (плюс - хочу, минус - не хочу)");

                    string answer = Console.ReadLine();

                    if (answer == "плюс" || answer == "Плюс" || answer == "+")
                    {
                        Console.WriteLine("Ну тогда больше не пытайтесь выйти из приложения :)");
                        Thread.Sleep(2000);
                    }

                    else
                    {
                        Console.WriteLine("Ну как хотите..");
                        Environment.Exit(0);
                    }
                }
            } while (pressedKey.Key != ConsoleKey.Enter);
            /*if (Position == 15)
            {
                SavePlease();
            }*/
            return Position;
        }

        public int SubMenu(List<Items> Shapes, List<Items> Sizes, List<Items> Taste, List<Items> Amount, List<Items> glaze, List<Items> decor)
        {

            int position_In_SubMenu = 1;
            ConsoleKeyInfo pressedKey;
            do
            {
                if (Position == 9)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите форму торта:");

                        foreach (var item in Shapes)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);
                        pressedKey = Console.ReadKey(true);


                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += Shapes[position_In_SubMenu - 1].Name + " - " + Shapes[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += Shapes[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);

                    }
                }

                else if (Position == 10)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите размер торта:");
                        foreach (var item in Sizes)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);

                        pressedKey = Console.ReadKey(true);

                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += Sizes[position_In_SubMenu - 1].Name + " - " + Sizes[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += Sizes[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);
                    }
                }

                else if (Position == 11)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите вкус коржей для торта:");

                        foreach (var item in Taste)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);

                        pressedKey = Console.ReadKey(true);

                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += Taste[position_In_SubMenu - 1].Name + " - " + Taste[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += Taste[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);
                    }
                }

                else if (Position == 12)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите количество коржей для торта:");
                        foreach (var item in Amount)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);

                        pressedKey = Console.ReadKey(true);

                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += Amount[position_In_SubMenu - 1].Name + " - " + Amount[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += Amount[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);
                    }
                }

                else if (Position == 13)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите глазурь для торта:");
                        foreach (var item in glaze)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);

                        pressedKey = Console.ReadKey(true);

                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += glaze[position_In_SubMenu - 1].Name + " - " + glaze[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += glaze[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);
                    }
                }
                else if (Position == 14)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите декор для торта:");
                        foreach (var item in decor)
                        {
                            Console.WriteLine("  " + item.Name + " - " + item.Cost);
                        }
                        Console.SetCursorPosition(0, position_In_SubMenu);
                        icon = ">>";
                        Console.WriteLine(icon);

                        pressedKey = Console.ReadKey(true);

                        if (pressedKey.Key == ConsoleKey.UpArrow)
                        {
                            position_In_SubMenu--;

                            if (position_In_SubMenu == 0)
                            {
                                position_In_SubMenu = 3;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.DownArrow)
                        {
                            position_In_SubMenu++;
                            if (position_In_SubMenu == 4)
                            {
                                position_In_SubMenu = 1;
                            }
                        }
                        else if (pressedKey.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Arrows();
                            break;
                        }
                    } while (pressedKey.Key != ConsoleKey.Enter);
                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.Write("Добавлено к заказу..");
                        Anim();

                        YourOrder += decor[position_In_SubMenu - 1].Name + " - " + decor[position_In_SubMenu - 1].Cost + "; ";
                        SummaOfOrder += decor[position_In_SubMenu - 1].Cost;
                        Thread.Sleep(2000);
                    }
                }
                else if (Position == 15)
                {
                    Console.Clear();
                    SaveTXT(YourOrder, SummaOfOrder, Position);
                }
            } while (true);
            return 0;
        }
        public void SaveTXT(string YourOrder, int SummaOfOrder, int Position)
        {

            string way = "C:\\Users\\Максим\\OneDrive\\Рабочий стол\\CakesOrder.txt";
            if (!File.Exists(way))
            {
                File.Create(way);
                File.WriteAllText(way, "Заказ от: " + Today.ToShortDateString() + "\n\t\tЗаказ: " + YourOrder + "\n\t\tЦена: " + SummaOfOrder);

            }
            else
            {
                File.AppendAllText(way, "Заказ от: " + Today.ToShortDateString() + "\n\t\tЗаказ: " + YourOrder + "\n\t\tЦена: " + SummaOfOrder);
            }
            Console.Clear();
            Console.WriteLine("Спасибо за заказ! Цена оплаты: " + SummaOfOrder + ". Нажмите ESCAPE, чтобы совершить ещё один заказ.");

            SummaOfOrder = 0;
            YourOrder = "";
            Position = 9;
            pressedKey = Console.ReadKey();
            while (true)
            {
                if (pressedKey.Key == ConsoleKey.Escape)
                {
                    break;
                    Arrows();
                }
            }
        }
        private void Anim()
        {
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write("Добавлено к заказу...");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write("Добавлено к заказу..");
            Thread.Sleep(300);
            Console.Clear();
            Console.Write("Добавлено к заказу.");
            Thread.Sleep(100);

        }
    }
}
