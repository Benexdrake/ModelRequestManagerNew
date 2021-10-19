using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Menu
    {
        public static List<Option> options;
        private static object person;
        private static object inventar;
        private static DbConn db;
        public Menu()
        {
            db = new DbConn();
        }
        public void OptionMenu()
        {
            options = new List<Option>
            {
                new Option("PersonInfo", () => PersonInfo(db)),
                new Option("InventarInfo", () => InventarInfo(db)),
                new Option("Exit", () => Environment.Exit(0)),
            };
            int index = 0;
            WriteMenu(options, options[index]);
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow && index + 1 < options.Count)
                {
                    index++;
                    WriteMenu(options, options[index]);
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow && index - 1 >= 0)
                {
                    index--;
                    WriteMenu(options, options[index]);
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            } while (keyInfo.Key != ConsoleKey.X);
            Console.ReadKey();
        }
        void PersonInfo(DbConn db)
        {
            List<Person> person = new List<Person>();
            List<Inventar> inventar = new List<Inventar>();
            Console.Clear();
            db.MainDb(0,person,inventar);
            
            Thread.Sleep(1000);
            WriteMenu(options, options[0]);
        }
        void InventarInfo(DbConn db)
        {
            List<Person> person = new List<Person>();
            List<Inventar> inventar = new List<Inventar>();
            Console.Clear();
            db.MainDb(1,person,inventar);

            foreach (var inventar1 in inventar)
            {
                Console.WriteLine(inventar1.inventar1);
                Console.WriteLine(inventar1.inventar2);
            }
            Console.ReadLine();
            Thread.Sleep(1000);

            WriteMenu(options, options[0]);
        }
        void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();
            foreach(Option currentOption in options)
            {
                if(currentOption == selectedOption)
                {
                    Console.Write(">");
                }
                Console.WriteLine(currentOption.Name);
            }
        }
    }
}
