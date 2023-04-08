using GenericClassess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassess.DataBase
{
    public abstract class GenericDB<T> where T : BaseEntity
    {
        public static List<T> Db;

        static GenericDB()
        {
            Db = new List<T>();
        }
        public static void PrintAll()
        {
            foreach (T item in Db)
            {
                item.GetInfo();
            }
        }
        public static void Insert(T item)
        {
            Db.Add(item);
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"The item{item.GetType().Name} was added to the GenericDB");
            Console.ResetColor();
        }
        public static void Remove(T item)
        {
            Db.Remove(item);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The item{item.GetType().Name} was removed from the GenericDB");
            Console.ResetColor();
        }
        public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);
    }
}
