using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLibrary
{
    public class Bakery<T> : Items
    {
        const int MAX = 110;    //Задаётся константа.
        public bool Sugar { get; set; }
        public int Quantity { get; set; }
        public T Size { get; set; }
        int count;
        public Bakery()
        { }
        public Bakery(int id, int price, T size, string name, bool sugar, int quantity)
        {
            Id = id;
            Name = name;
            Sugar = sugar;
            Price = price;
            Quantity = quantity;
            Size = size;
        }
        public int Count()
        {
            return count;
        }
        public List<Bakery<string>> Bread { get; set; } = new List<Bakery<string>>();

        public int Proverka(int id, int qu)     //Проверка на переполнение.
        {
            int amount = 0;
            for (int j = 0; j < Bread.Count(); j++)
            {
                if (Bread[j].Id == id)
                {
                    if (Bread[j].Quantity < qu)
                        amount = 100000;
                }
            }
            return amount;
        }

        public int Buy(int id, int qu)      //Покупка товара.
        {
            int chek = 0;
            for (int i = 0; i < Bread.Count(); i++)
            {
                if (Bread[i].Id == id)
                {
                    if (Bread[i].Quantity < qu)
                    {
                        Console.WriteLine("Нет товаров.");
                        chek -= MAX;
                    }
                    else
                    {
                        Bread[i].Quantity -= qu;
                        chek += 1;
                    }
                }
            }
            return chek;
        }

        public void Iterator()     //Вывод всеx булочек.
        {
            for (int i = 0; i < Bread.Count(); i++)
            {
                Console.WriteLine(Bread[i].ToString());
            }
        }

        public bool Amount(int id)    //Проверка на количество.
        {
            bool c;
            Bread[id].Quantity--;
            if (Bread[id].Quantity > -1)
            {
                c = true;
            }
            else
            {
                c = false;
                Bread[id].Quantity++;
                Console.WriteLine("Товар закончился.");
            }
            return c;
        }

        public Bakery<string> Return(int id)     //Возвращает булку с заданным id.
        {
            var cof = Bread[id];
            return cof;
        }

        public Bakery<string> Return(double id)   //Перегрузка прошлого метода.
        {
            var cof = Bread[(int)id];
            return cof;
        }

        public void LoadBakery(string path)      //Загрузка из файла.
        {
            var lines = File.ReadAllLines(path);
            count = lines.Length - 1;
            for (int i = 0; i < lines.Length - 1; i++)
            {
                var splits = lines[i + 1].Split(';');
                var bread = new Bakery<string>();
                bread.Id = i + 1;
                bread.Name = splits[0];
                bread.Sugar = Convert.ToBoolean(splits[1]);
                bread.Price = Convert.ToInt32(splits[2]);
                bread.Size = splits[3];
                bread.Quantity = Convert.ToInt32(splits[4]);
                Bread.Add(bread);
            }
        }

        public void SaveBread()         //Сохранение в файл.
        {
            string path = @"..\bakery.csv";
            var fileInf1 = new FileInfo(path);
            if (fileInf1.Exists)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"..\bakery.csv");
                    sw.WriteLine("Name; Sugar; Price; Size; Quantity");
                    for (int i = 0; i < Bread.Count; i++)
                    {
                        sw.WriteLine($"{Bread[i].Name};{Bread[i].Sugar};{Bread[i].Price};{Bread[i].Size};{Bread[i].Quantity}");
                    }
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                }
                finally
                {
                    Console.WriteLine("\n");
                }
            }
        }

        public string BuyProduct(string k)       //Покупка товара.
        {
            string line = $"{Id} {Name} {Sugar} {Price} {Size} {Quantity}";
            Console.WriteLine("Вы купили: " + line);
            k = line;
            return k;
        }
        public override string ToString()      //Вывод основных данных.
        {
            return $"{Id} {Name} {Sugar} {Price} {Size} {Quantity}";
        }
        public string ToExcel()
        {
            return $"{Name};{Sugar};{Price};{Size};{Quantity}";
        }

        public void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)      //Сохранение при закрытии.
        {
            SaveBread();
        }

        public void Feedback()         //Отзыв.
        {
            Console.WriteLine("\nОцените от 1 до 10");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оставьте свой комментарий");
            string comment = Console.ReadLine();
            Bread[1].Mark = mark;
            Bread[1].Comment = comment;
            string path = @"..\FeedBack.csv";
            var fileInf1 = new FileInfo(path);
            if (fileInf1.Exists)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"..\FeedBack.csv", true);
                    sw.WriteLine($"{Bread[1].Mark};{Bread[1].Comment}");
                    sw.Close();
                }
                finally
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
