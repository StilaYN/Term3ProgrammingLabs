using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array arr1 = new Array(1, -2, 3);
            Array arr2 = new Array(1, 4, 9);
            Array res = new Array(3);
            res = arr1 * arr2;
            Console.WriteLine("Исходные массивы:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("\nПроизведение двух исходных массивов:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            if (res) { Console.WriteLine("\nМассив не содержит отрицательных элементов!"); }
            else
            {
                Console.WriteLine("\nМассив содержит отрицательные элементы!");
            }
            Console.Write("Длина результирующего массива: ");
            Console.WriteLine((int)res);
            Console.WriteLine("Равны ли исходные массивы:");
            Console.WriteLine(arr1 == arr2);
            Console.WriteLine("Первый массив меньше второго?");
            Console.WriteLine(arr1 < arr2);
            String str = "STROKA";
            Console.WriteLine("Есть ли в строк STROKA символ O");
            Console.WriteLine(str.IsSymbolContains('O'));
            Console.WriteLine("Удаление отрицательных элементов в массиве:");
            res[0] = -10;
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Array newres = res.DeleteNegativeElement();
            Console.WriteLine("\nМассив без отрицательных элементов:");
            for (int i = 0; i < newres.Length; i++)
            {
                Console.Write(newres[i] + " ");
            }
        }
    }
}
