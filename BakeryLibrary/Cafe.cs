using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLibrary
{
    public class Cafe
    {
        public int Balance { get; set; }
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
        public int AlmondM { get; set; }
        public int CoconutM { get; set; }
        public int RiceM { get; set; }
        public int MapleS { get; set; }
        public int RaspberryS { get; set; }
        public int PistachioS { get; set; }
        public int Sugar { get; set; }
        int count;

        public List<Cafe> CoffeeH { get; set; } = new List<Cafe>();

        public bool Espresso()    //Проверка на наличие разного кофе (все виды кофе аналогично, проверяется наличие нужных ингридиентов).
        {
            bool c = false;
            Arabica--;
            if (Arabica > -1)
            {
                c = true;
            }
            else
            {
                Arabica++;
            }
            return c;
        }

        public bool Cappuccino()
        {
            bool c = false;
            Robusta--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM--;
                if (Robusta > -1 & CoconutM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    CoconutM++;
                }
            }
            else if (milk == 2)
            {
                RiceM--;
                if (Robusta > -1 & RiceM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    RiceM++;
                }
            }
            else if (milk == 3)
            {
                AlmondM--;
                if (Robusta > -1 & AlmondM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    AlmondM++;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Robusta++;
            }
            return c;
        }

        public bool Americano()
        {
            bool c = false;
            Arabica -= 2;
            if (Arabica > -1)
            {
                c = true;
            }
            else
            {
                Arabica += 2;
            }
            return c;
        }

        public bool Latte()
        {
            bool c = false;
            Robusta--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM -= 2;
                if (Robusta > -1 & CoconutM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    CoconutM += 2 ;
                }
            }
            else if (milk == 2)
            {
                RiceM -= 2;
                if (Robusta > -1 & RiceM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    RiceM += 2;
                }
            }
            else if (milk == 3)
            {
                AlmondM -= 2;
                if (Robusta > -1 & AlmondM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    AlmondM += 2;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Robusta++;
            }
            return c;
        }

        public bool Frappe()
        {
            bool c = false;
            Arabica--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберети тип сиропа:\n" + "1) Кленовый\n" + "2) Фисташковый\n" + "3) Малиновый");
            int syrop = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & CoconutM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        CoconutM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & CoconutM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        CoconutM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & CoconutM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        CoconutM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    CoconutM++;
                }
            }
            else if (milk == 2)
            {
                RiceM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & RiceM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        RiceM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & RiceM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        RiceM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & RiceM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        RiceM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    RiceM++;
                }
            }
            else if (milk == 3)
            {
                AlmondM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & AlmondM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        AlmondM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & AlmondM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        AlmondM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & AlmondM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        AlmondM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    AlmondM++;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Arabica++;
            }
            return c;
        }

        public bool WithMilk()
        {
            bool c = false;
            Robusta--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM--;
                if (Robusta > -1 & CoconutM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    CoconutM++;
                }
            }
            else if (milk == 2)
            {
                RiceM--;
                if (Robusta > -1 & RiceM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    RiceM++;
                }
            }
            else if (milk == 3)
            {
                AlmondM--;
                if (Robusta > -1 & AlmondM > -1)
                {
                    c = true;
                }
                else
                {
                    Robusta++;
                    AlmondM++;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Robusta++;
            }
            return c;
        }

        public bool Glisse()
        {
            bool c = false;
            Arabica--;
            IceCream--;
            if (Arabica > -1 & IceCream > -1)
            {
                c = true;
            }
            else
            {
                Arabica++;
                IceCream++;
            }
            return c;
        }

        public bool ConPanna()
        {
            bool c = false;
            Robusta--;
            Cream--;
            if (Robusta > -1 & Cream > -1)
            {
                c = true;
            }
            else
            {
                Robusta++;
                Cream++;
            }
            return c;
        }

        public bool LatteMacchiato()
        {
            bool c = false;
            Arabica--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM -= 2;
                if (Arabica > -1 & CoconutM > -1)
                {
                    c = true;
                }
                else
                {
                    Arabica++;
                    CoconutM += 2;
                }
            }
            else if (milk == 2)
            {
                RiceM -= 2;
                if (Arabica > -1 & RiceM > -1)
                {
                    c = true;
                }
                else
                {
                    Arabica++;
                    RiceM += 2;
                }
            }
            else if (milk == 3)
            {
                AlmondM -= 2;
                if (Arabica > -1 & AlmondM > -1)
                {
                    c = true;
                }
                else
                {
                    Arabica++;
                    AlmondM += 2;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Arabica++;
            }
            return c;
        }

        public bool Raf()
        {
            bool c = false;
            Arabica--;
            Vanilla--;
            Cream--;
            Console.WriteLine("Выберети тип молока:\n" + "1) Кокосовое молоко\n" + "2) Рисовое молоко\n" + "3) Миндальное молоко");
            int milk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберети тип сиропа:\n" + "1) Кленовый\n" + "2) Фисташковый\n" + "3) Малиновый");
            int syrop = Convert.ToInt32(Console.ReadLine());
            if (milk == 1)
            {
                CoconutM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & CoconutM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        CoconutM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & CoconutM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        CoconutM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & CoconutM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        CoconutM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    Vanilla++;
                    Cream++;
                    CoconutM++;
                }
            }
            else if (milk == 2)
            {
                RiceM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & RiceM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        RiceM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & RiceM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        RiceM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & RiceM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        RiceM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    Vanilla++;
                    Cream++;
                    RiceM++;
                }
            }
            else if (milk == 3)
            {
                AlmondM--;
                if (syrop == 1)
                {
                    MapleS--;
                    if (Arabica > -1 & AlmondM > -1 & MapleS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        AlmondM++;
                        MapleS++;
                    }
                }
                else if (syrop == 2)
                {
                    PistachioS--;
                    if (Arabica > -1 & AlmondM > -1 & PistachioS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        AlmondM++;
                        PistachioS++;
                    }
                }
                else if (syrop == 3)
                {
                    MapleS--;
                    if (Arabica > -1 & AlmondM > -1 & RaspberryS > -1)
                    {
                        c = true;
                    }
                    else
                    {
                        Arabica++;
                        Vanilla++;
                        Cream++;
                        AlmondM++;
                        RaspberryS++;
                    }
                }
                else
                {
                    Console.WriteLine("Такого сиропа нет");
                    Arabica++;
                    Vanilla++;
                    Cream++;
                    AlmondM++;
                }
            }
            else
            {
                Console.WriteLine("Такого молока нет");
                Arabica++;
                Vanilla++;
                Cream++;
            }
            return c;
        }

        //Различные топинги.

        public bool Icecream()
        {
            bool c = false;
            IceCream--;
            if (IceCream > -1)
            {
                c = true;
            }
            else
            {
                IceCream++;
            }
            return c;
        }

        public bool S4lt()
        {
            bool c = false;
            Salt--;
            if (Salt > -1)
            {
                c = true;
            }
            else
            {
                Salt++;
            }
            return c;
        }

        public bool Juice()
        {
            bool c = false;
            OrangeJuice--;
            if (OrangeJuice > -1)
            {
                c = true;
            }
            else
            {
                OrangeJuice++;
            }
            return c;
        }

        public bool Freeze()
        {
            bool c = false;
            FreezeRaspberry--;
            if (FreezeRaspberry > -1)
            {
                c = true;
            }
            else
            {
                FreezeRaspberry++;
            }
            return c;
        }

        public bool Choco()
        {
            bool c = false;
            Chocolate--;
            if (Chocolate > -1)
            {
                c = true;
            }
            else
            {
                Chocolate++;
            }
            return c;
        }

        public bool Cinamon()
        {
            bool c = false;
            Cinnamon--;
            if (Cinnamon > -1)
            {
                c = true;
            }
            else
            {
                Cinnamon++;
            }
            return c;
        }

        public void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)   //Отмена программы.
        {
            SaveCafe();
        }

        public void LoadCafe(string path)     //Загрузка из файла.
        {
            var lines = File.ReadAllLines(path);
            count = lines.Length - 1;
            var splits = lines[1].Split(';');
            var bread = new Cafe();
            bread.Balance = Convert.ToInt32(splits[0]);
            bread.IceCream = Convert.ToInt32(splits[1]);
            bread.Cream = Convert.ToInt32(splits[2]);
            bread.Salt = Convert.ToInt32(splits[3]);
            bread.Vanilla = Convert.ToInt32(splits[4]);
            bread.Arabica = Convert.ToInt32(splits[5]);
            bread.Robusta = Convert.ToInt32(splits[6]);
            bread.OrangeJuice = Convert.ToInt32(splits[7]);
            bread.FreezeRaspberry = Convert.ToInt32(splits[8]);
            bread.Chocolate = Convert.ToInt32(splits[9]);
            bread.Cinnamon = Convert.ToInt32(splits[10]);
            bread.AlmondM = Convert.ToInt32(splits[11]);
            bread.CoconutM = Convert.ToInt32(splits[12]);
            bread.RiceM = Convert.ToInt32(splits[13]);
            bread.MapleS = Convert.ToInt32(splits[14]);
            bread.RaspberryS = Convert.ToInt32(splits[15]);
            bread.PistachioS = Convert.ToInt32(splits[16]);
            CoffeeH.Add(bread);
        }

        public void SaveCafe()    //Сохранение в файл.
        {
            string path = @"..\Cafe.csv";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"..\Cafe.csv");
                    sw.WriteLine("Balance; IceCream; Cream; Salt; Vanilla; Arabica; Robusta; OrangeJuice; FreezeRaspberry; Chocolate; Cinnamon; AlmondM; CoconutM; RiceM; MapleS; RaspberryS; PistachioS");
                    sw.WriteLine($"{Balance};{IceCream};{Cream};{Salt};{Vanilla};{Arabica};{Robusta};{OrangeJuice};{FreezeRaspberry};{Chocolate};{Cinnamon};{AlmondM};{CoconutM};{RiceM};{MapleS};{RaspberryS};{PistachioS}");
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
    }
}
