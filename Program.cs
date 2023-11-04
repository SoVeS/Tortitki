namespace smert_
{
    internal class Program
    {
        static string? Vid;
        static string? Color_Parusa;
        static string? Color_Obshivki;
        static string? Pushki;
        static string? Shturval;
        static int Cost;
        static DateTime? Vremya_Zakaza;
        static void Main(string[] args)
        {

            {

                while (true)
                {
                    Console.WriteLine("Добро пожаловать в Корабельную бухту, какой корабль хотите собрать?\n  1) Вид\n  2) Цвет парусов\n  3) Цвет обшивки\n  4) Пушки\n  5) Штурвал\n  Для выхода нажмите \"Esc\"");

                    int pos = Menu.Show(1, 5);

                    if (pos == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Корабль");
                        Console.WriteLine("  Шлюп - 1000 рублей");
                        Console.WriteLine("  Бригантина - 2000 рублей");
                        Console.WriteLine("  Галеон - 3000 рублей");
                        Console.WriteLine("  Для выхода нажмите \"Esc\"");
                        pos = Menu.Show(1, 3);
                        int Cost_vid = 0;
                        if (pos == 1)
                        {
                            Vid = "_Шлюп";
                            Cost_vid = 1000;
                        }
                        else if (pos == 2)
                        {
                            Vid = "_Бригантина";
                            Cost_vid = 2000;
                        }
                        else if (pos == 3)
                        {
                            Vid = "_Галеон";
                            Cost_vid = 3000;
                        }
                        Cost += Cost_vid;
                    }
                    else if (pos == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Цвет парусов");
                        Console.WriteLine("  Белый - 100 рублей");
                        Console.WriteLine("  Зеленый - 200 рублей");
                        Console.WriteLine("  Голубой - 300 рублей");
                        Console.WriteLine("  Для выхода нажмите \"Esc\"");
                        pos = Menu.Show(1, 3);
                        int Cost_parus = 0;
                        if (pos == 1)
                        {
                            Color_Parusa = "Белый";
                            Cost_parus = 100;
                        }
                        else if (pos == 2)
                        {
                            Color_Parusa = "Зеленый";
                            Cost_parus = 200;
                        }
                        else if (pos == 3)
                        {
                            Color_Parusa = "Голубые";
                            Cost_parus = 300;
                        }
                        Cost += Cost_parus;
                    }
                    else if (pos == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Цвет обшивки");
                        Console.WriteLine("  Белый - 250 рублей");
                        Console.WriteLine("  Черный - 300 рублей");
                        Console.WriteLine("  Коричневый - 300 рублей");
                        Console.WriteLine("  Для выхода нажмите \"Esc\"");
                        pos = Menu.Show(1, 3);
                        int Cost_obshovki = 0;
                        if (pos == 1)
                        {
                            Color_Obshivki = "Белый";
                            Cost_obshovki = 250;
                        }
                        else if (pos == 2)
                        {
                            Color_Obshivki = "Черный";
                            Cost_obshovki = 300;
                        }
                        else if (pos == 3)
                        {
                            Color_Obshivki = "Коричневый";
                            Cost_obshovki = 300;
                        }
                        Cost += Cost_obshovki;
                    }
                    else if (pos == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Пушки");
                        Console.WriteLine("  Стальные - 450 рублей");
                        Console.WriteLine("  Чугунные - 600 рублей");
                        Console.WriteLine("  Титановые - 800 рублей");
                        Console.WriteLine("  Для выхода нажмите \"Esc\"");
                        pos = Menu.Show(1, 3);
                        int Cost_pushki = 0;
                        if (pos == 1)
                        {
                            Pushki = "Стальные";
                            Cost_pushki = 450;
                        }
                        else if (pos == 2)
                        {
                            Pushki = "Чугунные";
                            Cost_pushki = 600;
                        }
                        else if (pos == 3)
                        {
                            Pushki = "Титановые";
                            Cost_pushki = 800;
                        }
                        Cost += Cost_pushki;
                    }
                    else if (pos == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите Штурвал");
                        Console.WriteLine("  Деревяный - 200 рублей");
                        Console.WriteLine("  Костяной - 700 рублей");
                        Console.WriteLine("  Золотой - 9999 рублей");
                        Console.WriteLine("  Для выхода нажмите \"Esc\"");
                        pos = Menu.Show(1, 3);
                        int Cost_sturval = 0;
                        if (pos == 1)
                        {
                            Shturval = "Деревяный";
                            Cost_sturval = 200;
                        }
                        else if (pos == 2)
                        {
                            Shturval = "Костянной";
                            Cost_sturval = 700;
                        }
                        else if (pos == 3)
                        {
                            Shturval = "Золотой";
                            Cost_sturval = 9999;
                        }
                        Cost += Cost_sturval;
                    }
                    else if (pos == -1)
                    {
                        Console.Clear();
                        break;
                    }
                 Console.Clear();
                }
                Console.WriteLine(" Итоговая цена: " + Cost);
                Vremya_Zakaza = DateTime.Now;
                Console.WriteLine("Время заказа: " + Vremya_Zakaza);
                string filePath = "Ship.txt";
                string txt = " \n1)Вид корабля: " + Vid + "\n 2)Цвет парусов: " + Color_Parusa + "\n 3)Цвет обшивки: " + Color_Obshivki + "\n 4)Пушки: " + Pushki + "\n 5)Штурвал: " + Shturval + "\n Итоговая цена:" + Cost + "рублей" + "\n Время заказа:" + Vremya_Zakaza + "\n_________________________________________________";
                File.AppendAllText(filePath, txt);
                Console.WriteLine("Вся инфа в файле Ship.txt");


            } 
        }


        public class Menu
        {

            private int minstrelka;
            private int maxstrelka;

            public Menu(int min, int max)
            {
                minstrelka = min;
                maxstrelka = max;
            }

            public static int Show(int minstrelka, int maxstrelka)
            {
                int pos = 1;
                ConsoleKeyInfo key = Console.ReadKey();

                do

                {
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");

                    if (key.Key == ConsoleKey.UpArrow && pos != minstrelka)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && pos != maxstrelka)
                    {
                        pos++;
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        return -1;
                    }

                } while (key.Key != ConsoleKey.Enter);

                return pos;
            }

        }
    }
}
