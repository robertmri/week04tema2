using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////// metoda Enqueue
            var qt = new Queue<int>();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Numarul elementelor in Queue sunt " + qt.Count);

            /////////////////////////// metoda dequeue

            var qt2 = new Queue<int>();
            qt2.Enqueue(4);
            qt2.Enqueue(5);
            qt2.Enqueue(6);

            qt2.Dequeue();

            foreach (Object obj in qt2)
            {
                Console.WriteLine(obj);

            }


        }
    }  
}
