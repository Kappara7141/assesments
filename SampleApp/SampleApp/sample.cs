using System;
namespace csharp basic
{
  public class sample
  {
   public static void main(string[]args)
   {
    int age;
            string ename;
            Console.WriteLine("Enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("congratulations Mr/Ms {0} on your {1} birthday", ename, age);
            Console.ReadKey();
   }

  }
}