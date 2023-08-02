using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.works
{
    class Program
    {
        public static void task1()
        {
            Console.WriteLine("enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum < secondNum)
                Console.WriteLine("<");
            else if (firstNum > secondNum)
                Console.WriteLine(">");
            else
                Console.WriteLine("=");
            Console.ReadLine();

        }
        public static void task2()
        {
            Console.WriteLine("enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(firstNum , Math.Max(secondNum,thirdNum));
            int min = Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            int result = max - min;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void task3()
        {
            Console.WriteLine("enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose oparation: -,+,*,/  ");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "-":
                    Console.WriteLine(firstNum - secondNum);
                    break;
                case "+":
                    Console.WriteLine(firstNum + secondNum);
                    break;
                case "*":
                    Console.WriteLine(firstNum * secondNum);
                    break;
                case "/":
                    Console.WriteLine(firstNum / secondNum);
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;
            }
            Console.ReadKey();
        }
        public static void task4()
        {
            Console.WriteLine("choose the number 1-9 :");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num}*{i}={result}");
            }
           
            Console.ReadLine();
           
        }
        public static void task5()
        {
            int num;
            int summ=0;
            int count=0;
            while (true)
            {
                Console.WriteLine("Enter the number :");
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                    break;
                summ += num;
                count++;
            }
            
            Console.WriteLine($"Count {count}");
            Console.WriteLine($"Sum {summ/count}");
            Console.ReadLine();


        }
        public static void task6()
        {
            Console.WriteLine("Введите начальное значение диапазона:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение диапазона:");
            int end = int.Parse(Console.ReadLine());

            int totalSum = 0;

            
            if (start % 2 == 0)
            {
                start++;
            }

           
            for (int num = start; num <= end; num += 2)
            {
                totalSum += num;
            }
            Console.WriteLine($"Сумма всех нечетных чисел в диапазоне от {start} до {end} равна {totalSum}.");
            Console.ReadLine();

        }
        public static void task7()
        {
            Console.WriteLine("Введите количество членов последовательности Фибоначчи (не более 15):");
            int n = int.Parse(Console.ReadLine());

            if (n > 15)
            {
                Console.WriteLine("Количество членов последовательности должно быть не более 15.");
                return;
            }

            int[] fibonacciArray = new int[n];

          
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciArray[i] = 1;
                }
                else
                {
                    fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
                }
            }

            Console.WriteLine("Массив в прямом порядке:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibonacciArray[i] + " ");
            }
            Console.WriteLine("\nМассив в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(fibonacciArray[i] + " ");
            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Выбери задание: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1: task1(); ; break;
                    case 2: task2(); ; break;
                    case 3: task3(); ; break;
                    case 4: task4(); ; break;
                    case 5: task5(); ; break;
                    case 6: task6(); ; break;
                    case 7: task7(); ; break;

                }
            }
        }
    }
}
