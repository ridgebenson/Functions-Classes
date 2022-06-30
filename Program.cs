using System;
namespace Defining{
    class Program{
        static void Main(string[] args){
            Book b1=new Book("War and Peace","Leo",825);
            Book b2=new Book("Love and Hope","Dan",563);
            Book b3=new Book("Inferno","Brown",678);
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
            Console.WriteLine(b3.GetDescription());
        }
    }
}