using System;
namespace SOLID_PRINCIPLES.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //No Liskov Principle
            Banana banana = new Strawberry();
            Console.WriteLine($"Without Liskov--> Color of Banana: {banana.GetColor()}");

            // With Liskov Principle
            IFruit fruit = new Orange();
            Console.WriteLine($"With Liskov--> Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"With Liskov--> Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();
        }
    }

    public class Banana
    {
        public virtual string GetColor()
        {
            return "Yellow";
        }
    }
    public class Strawberry : Banana
    {
        public override string GetColor()
        {
            return "Red";
        }
    }


    public interface IFruit
    {
        string GetColor();
    }  
 
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }


   
}