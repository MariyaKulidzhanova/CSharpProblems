using System;

namespace TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            ///input line for Brackets and Roman Numbers classes
            string inputLine = Console.ReadLine();

            /// For Brackets class
            Brackets userBrackets = new Brackets(inputLine);
            bool result = userBrackets.CountBrackets();

            if (result)
            {
                Console.WriteLine("Скобочная структура сбалансирована");
            }
            else
            {
                Console.WriteLine("Скобочная структура не сбалансирована");
            }

            /// For Roman Numbers class
            /*
            RomanNumbers numbers = new RomanNumbers(inputLine);

            Console.Write(numbers.RomanToInt());*/

            /// For Double Linked List
            /*DoubleLinkedList<int> list1 = new DoubleLinkedList<int>();
            list1.AddFirst(5);
            list1.AddLast(11);
            list1.AddLast(4);
            list1.AddFirst(9);

            Console.WriteLine("List1 before reversing: ");
            foreach (int a in list1)
            {
                Console.Write(a + " ");
            }
            list1.Reverse();

            Console.WriteLine("List1 after reversing: ");
            foreach (int a in list1)
            {
                Console.Write(a + " ");
            }*/
        }
    }
}
