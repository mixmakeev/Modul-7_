using System; // Подключенное пространство имен
using System.Text;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    abstract class Delivery
    {
        public string Address;
    }

    class ClientData 
    {
        public string FirstName;
        public string LastName;
        public DateOnly DateBD;

    }
    class HomeDelivery : Delivery
    {
        public string Address;
    }



    class PickPointDelivery : Delivery
    {
        public string Address;
    }

    class ShopDelivery : Delivery
    {
        public string Address;
    }

    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public DateTime dateTime;

        public string Description;

        public ClientData[] ClientData;



        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
    class Programs // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            static void Swap<T>(ref T x, ref T y)
            {
                T t = x;
                x = y;
                y = t;
            }
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Решение проблемы с отображением кирилицы 
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;
            Console.WriteLine("Hello");
           

            Console.ReadKey();

        }
    }
}
