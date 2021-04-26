using System; // подключаем пространство имен

namespace HelloApp // объявление нового пространства имен
{
    class Program // объявление нового класса
    {
        static void Main(string[] args) // объявление нового метода
        {
            Console.WriteLine("Ввудите свое имя: "); // действия метода
            string name = Console.ReadLine(); // вводим имя
            Console.WriteLine($"Привет {name}");
        } // конец объявления метода
    } // конец объявления класса
} // конец объявления нового пространства имен
