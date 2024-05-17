using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Module12
{
    public class Program
    {
        static void Main(string[] args)
        {
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


              
                
                var premium = new User();

                Console.WriteLine("Hello," + premium.Name);
                if (premium.IsPremium != true)
                {
                    ShowAds();
                }
            

        }

        public class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
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
        }


    }

}

