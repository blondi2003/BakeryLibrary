using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLibrary
{
    public class AllUsers
    {
        public int Balance { get; set; }
        public string Name { get; set; }
        public string NumberCard { get; set; }
        public string CVC { get; set; }


        public AllUsers()
        { }

        public void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)  //Отмена программы.
        {
            SaveUsers();
        }

        public void LoadAllUsers(string path)    //Загрузка из файла.
        {
            var lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length - 1; i++)
            {
                var splits = lines[i + 1].Split(';');
                var user = new AllUsers();
                user.NumberCard = splits[0];
                user.CVC = splits[1];
                user.Name = splits[2];
                user.Balance = Convert.ToInt32(splits[3]);
                User.Add(user);
                Console.WriteLine(user.NumberCard + " " + user.CVC + " " + user.Name + " " + user.Balance);
            }
        }

        public AllUsers TryLogin(string login, string pass)     //Проверка карты и cvc.
        {
            var customer = User.FirstOrDefault(x => x.NumberCard == login & x.CVC == pass);
            return customer;
        }

        public List<AllUsers> User { get; set; } = new List<AllUsers>();

        public void SaveUsers()       //Сохранение в файл.
        {
            string path = @"..\AllUsers.csv";
            var fileInf1 = new FileInfo(path);
            if (fileInf1.Exists)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(@"..\AllUsers.csv");
                    sw.WriteLine("NumberCard; CVC; Name; Balance");
                    for (int i = 0; i < User.Count; i++)
                    {
                        sw.WriteLine($"{User[i].NumberCard};{User[i].CVC};{User[i].Name};{User[i].Balance}");
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
    }
}
