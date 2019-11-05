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

            /////////////////////////// metoda Enqueue\
            Console.WriteLine("Metoda Queue/enqueue");
            
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
            Console.WriteLine();
            Console.WriteLine("Metoda Queue/Dequeue");
            
            var qt2 = new Queue<int>();
            qt2.Enqueue(4);
            qt2.Enqueue(5);
            qt2.Enqueue(6);

            qt2.Dequeue();

            foreach (Object obj in qt2)
            {
                Console.WriteLine(obj);

            }

            /////////////////////////// stack metoda push
            
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Metoda Stack/Push");

            var st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("Numarul elementelor in Stack sunt" + st.Count);

            //////////////////// stack metoda pop
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Metoda Stack/Pop");

            var st1 = new Stack<int>();
            st1.Push(4);
            st1.Push(5);
            st1.Push(6);

            st1.Pop();

            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }
        }
    }  
}
