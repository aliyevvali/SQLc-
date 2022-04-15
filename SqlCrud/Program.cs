using System;

namespace SqlCrud
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer.Insert(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            Customer.Delete(2);
        
            Customer.Update($"UPDATE Customer SET name = '{Console.ReadLine()}' WHERE Id = {int.Parse(Console.ReadLine())}");

            Customer.GetAll();
        }
    }
}
