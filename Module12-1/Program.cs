using BenchmarkDotNet.Running;
using Module12_1;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Module12
{
    public class Program
    {
        static void Main(string[] args)
        {

            Estimate(20);
            Console.ReadKey();


           /* var summary = BenchmarkRunner.Run<Testing>();
            
            
            Console.WriteLine("Как тебя зовут");
            var name = Console.ReadLine();
            var greetings = "Привет," + name;
            Console.WriteLine(greetings);


            Console.WriteLine("Сколько элементов будет в массиве?");
            var count = Int32.Parse(Console.ReadLine());

            var array = new string[count];
            for (int i = 0; i < count; i++)
            {
               array[i] = Console.ReadLine();
            }

            Console.WriteLine("Все элементы считаны");


            Console.WriteLine("Введите свой возраст");
            var age = Int32.Parse(Console.ReadLine());

            if (age > 13)
            {
                Console.WriteLine("Вы успешно зарегестрированы");
            }
            else
            {
                Console.WriteLine("Пользователи младше 14 лет не могут быть зарегестрированы");
            }

            List<User> list = new List<User>() 
            { 
                new User ("AAA", "aaa", false),
                new User ("BBB", "bbb", true),
                new User ("CCC", "ccc", false)
            };
              
            foreach (var item in list)
            {
                Console.WriteLine("Hello," + item.Name);
                if (item.IsPremium != true)
                {
                    ShowAds();
                }
            }

            static void ShowAds()
            {
                Console.WriteLine("Посетите наш сайт с бесплаьными играми ...");
                // Остановка на 1 с
                Thread.Sleep(1000);

                Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                // Остановка на 2 с
                Thread.Sleep(2000);

                Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                // Остановка на 2 с
                Thread.Sleep(3000);
            }


            //бинанрный поиск с рекурсией
            static int BinarySearch(int value, int[] array, int left, int right)
            {

                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (left < right)
                {
                    if (value < midElement)
                    {
                        return BinarySearch(value, array, left, middle - 1);
                    }
                    else
                    {
                        return BinarySearch(value, array, middle + 1, right);
                    }
                }
                else
                {
                    return -1;
                }
            }
            //бинарный поиск без рекурсии
            static int BinarySearch2(int value, int[] array, int left, int right)
            {
                while (left <= right)
                {
                    var middle = (left + right) / 2;

                    var midElement = array[middle];

                    if (midElement == value)
                    {
                        return middle;
                    }
                    else if (value < midElement)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                return -1;
            }
            //пузыриковая сортировка
            static void BubbleSort(int[] array)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            //метод, который будет возвращать индекс элемента в отсортированном массиве, на место которого можно будет вставить элемент так, чтобы не нарушить порядок сортировки.
            static int GetIndex(int[] array, int element)
            {
                int index;
                for (index = 0; index < array.Length; index++)
                {
                    if (array[index] > element)
                        return index;
                }

                return index;
            }


        }

        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }

            public User(string login, string name, bool isPremium)
            {
                Login = login;
                Name = name;
                IsPremium = isPremium;
            }*/


        }

        static void CreateMatrix(int n)
        {
            var matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }

            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = i + j;
                }
            }
        }

        static void Estimate(int n)
        {
            for (int i = 0; i < n; i++) 
            {
                CreateMatrix(10000);
            }
        }
    }

}

