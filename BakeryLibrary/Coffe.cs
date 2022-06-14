using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLibrary
{
    public class Coffee<T> : Items
    {
        public int IceCream { get; set; }
        public int Cream { get; set; }
        public int Salt { get; set; }
        public int Vanilla { get; set; }
        public int Arabica { get; set; }
        public int Robusta { get; set; }
        public int OrangeJuice { get; set; }
        public int FreezeRaspberry { get; set; }
        public int Chocolate { get; set; }
        public int Cinnamon { get; set; }
        public int Milk { get; set; }
        public int Syrop { get; set; }
        public int Sugar { get; set; }
        public string Degree { get; set; }
        public int Quantity { get; set; }
        int count = 0;
        public Coffee()
        { }
        public Coffee(int id, int price, T grade, string degree, string name, int sugar)
        {
            Id = id;
            Name = name;
            Sugar = sugar;
            Price = price;
            Degree = degree;
        }
        public int Count()
        {
            return count;
        }
        public List<Coffee<string>> Coffe { get; set; } = new List<Coffee<string>>();

        public Coffee<string> Return(int id)   //Возвращает кофе по заданному id.
        {
            var cof = Coffe[id];
            return cof;
        }

        public void LoadCoffee(string path)        //Загрузка из файла.
        {
            var lines = File.ReadAllLines(path);
            count = lines.Length - 1;
            for (int i = 0; i < lines.Length - 1; i++)
            {
                var splits = lines[i + 1].Split(';');
                var bread = new Coffee<string>();
                bread.Id = i + 1;
                bread.Name = splits[0];
                bread.IceCream = Convert.ToInt32(splits[1]);
                bread.Price = Convert.ToInt32(splits[2]);
                bread.Cream = Convert.ToInt32(splits[3]);
                bread.Degree = splits[4];
                bread.Salt = Convert.ToInt32(splits[5]);
                bread.Vanilla = Convert.ToInt32(splits[6]);
                bread.Arabica = Convert.ToInt32(splits[7]);
                bread.Robusta = Convert.ToInt32(splits[8]);
                bread.OrangeJuice = Convert.ToInt32(splits[9]);
                bread.FreezeRaspberry = Convert.ToInt32(splits[10]);
                bread.Chocolate = Convert.ToInt32(splits[11]);
                bread.Cinnamon = Convert.ToInt32(splits[12]);
                bread.Milk = Convert.ToInt32(splits[13]);
                bread.Syrop = Convert.ToInt32(splits[14]);
                bread.Sugar = Convert.ToInt32(splits[15]);
                Coffe.Add(bread);
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }

        public void Iterator()       //Вывод на экран.
        {
            for (int i = 0; i < Coffe.Count(); i++)
            {
                Console.WriteLine(Coffe[i].ToString());
            }
        }

        public void Feedback()             //Отзыв.
        {
            Console.WriteLine("\nННапишите номер кофе");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оцените от 1 до 10");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оставьте свой комментарий");
            string comment = Console.ReadLine();
            Coffe[id - 1].Mark = mark;
            Coffe[id - 1].Comment = comment;
            string path = @"..\FeedBack.csv";
            var fileInf1 = new FileInfo(path);
            if (fileInf1.Exists)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"..\FeedBack.csv", true);
                    sw.WriteLine($"{Coffe[id - 1].Name};{Coffe[id - 1].Price};{Coffe[id - 1].Degree};{Coffe[id - 1].Mark};{Coffe[id - 1].Comment}");
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
