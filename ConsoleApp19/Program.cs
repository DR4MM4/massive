using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задача 1.Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива. Если такой элемент имеется, вывести на экран его порядковый номер.Массив состоит из шести элементов.
            //Random randommas = new Random();
            //int[] omas = new int[6]; 
            //for (int i=0;i<omas.Length ;i++ )
            //{
            //    omas[i] = randommas.Next(0,6);
            //    if (omas[i] == omas[0] )
            //    {

            //            Console.WriteLine($"Элемент со значением {omas[0]} найден на позиции {i+1}.");


            //    }

            //}
            //Задача 2.Дан одномерный массив. Вывести:
            //а) все неотрицательные элементы;

            //б) все элементы, не превышающие число 100;

            //в) все четные элементы.
            //Random random = new Random();
            //int[] omas = new int[random.Next(1,15)];
            //for (int i=0;i<omas.Length ;i++)
            //{
            //omas[i] = random.Next(-100,100);
            /*a*/
            //if (omas[i]>=0)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            /*б*/
            //if (omas[i] < 100)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            /*в*/
            //if (omas[i] % 10 == 0)
            //{
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            //}

            //Задача 3.Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2.Подсчитать количество отрицательных элементов.
            //int[] omas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int count = 0;
            //for (int i = 0;i<omas.Length ;i++ )
            //{
            //    if (omas[i]<0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество неотрицательных чисел равно {count}");

            //Задача 4.Составьте программу вычисления среднего арифметического элементов с нечетными номерами.
            //int[] array = new int[10];
            //Random random = new Random();
            //int sum = 0;
            //int count = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(1, 101);
            //    if (i % 2 != 0) 
            //    {
            //        sum += array[i];
            //        count++;
            //    }
            //}
            //double average = (double)sum / count;
            //Console.WriteLine($"Среднее арифметическое нечетных элементов: {average:F2}");
            //Задача 5.Составьте программу увеличения всех элементов массива в 5 раз.
            //Random random = new Random();
            //int[] array = new int[random.Next(5,10)];
            //for (int i =0;i<array.Length ;i++ )
            //{
            //    array[i] = random.Next(-50, 50);
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.WriteLine($"после преобразований");
            //for (int i =0;i<array.Length ;i++ )
            //{
            //    array[i] = 5 * array[i];
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.ReadKey();
        }
    }
}
