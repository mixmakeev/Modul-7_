using System; // Подключенное пространство имен
using System.Text;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Решение проблемы с отображением кирилицы 
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;
            Console.WriteLine("Hello");
            Console.ReadKey();

        }
    }
}
