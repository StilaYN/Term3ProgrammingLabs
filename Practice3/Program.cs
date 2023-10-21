using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TaskOneCollection();
            TaskTwoStack(5);

        }

        public static void TaskFourObserveCollection()
        {
            var collection = new ObservableCollection<Chapter>();
            collection.CollectionChanged+=CollectionChangeHandler()
        }

        public static void CollectionChangeHandler(object? sender,NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection was changed");
        }

        public static void TaskTwoStack(int numberDeletedElement)
        {
            var random = new Random();
            var stack = new Stack<char>();
            for (var i = 0; i < 15; i++)
            {
                stack.Push((char)(random.Next()%100));
            }

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            for (var i = 0; i < numberDeletedElement; i++)
            {
                stack.Pop();
            }
            stack.Push('d');
            var list = new List<char>();
            foreach (var i in stack)
            {
                list.Add(i);
            }
            Console.WriteLine("_________________________________________________");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.IndexOf('d'));
        }
        public static void TaskOneCollection()
        {
            var list = new ArrayList();
            var random = new Random();
            int specifiedElement=0;
            for (var i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    specifiedElement = random.Next();
                    list.Add(specifiedElement);
                }
                else list.Add(random.Next());
                
            }
            list.Add("HELLO");
            list.Remove(specifiedElement);
            Console.WriteLine(list.Count);
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains("HELLO"));
        }
    }
}
