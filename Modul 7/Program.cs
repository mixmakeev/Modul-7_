using System; // Подключенное пространство имен
using System.Text;

namespace Store // Объявление пространства имен для данного кода
{

    class Skis // Лыжи
    {
        public int SkisID { get; }
        public int SkisLenght { get; }
        public string SkisModel { get; }

        public Skis(int skisID, int skisLenght, string SkisModel)
        {
            SkisID = skisID;
            SkisLenght = skisLenght;
            this.SkisModel = SkisModel;
        }
    }

    class SkiPoles //лыжные палки
    {
        public int SkiPolesID { get; }
        public int SkiPolesLenght { get; }
        public string SkiPolesModel { get; }

        public SkiPoles(int skipolesID, int SkiPolesLenght, string skipolesModel)
        {
            SkiPolesID = skipolesID;
            this.SkiPolesLenght = SkiPolesLenght;
            SkiPolesModel = skipolesModel;
        }
    }




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

    class Product
    { 
        public string ProductName;

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
        public int Id { get; }

        public TDelivery Delivery { get; }

        public int Number;

        public Product ProductName;

        public int CountProduct;

        public DateTime dateTime;

        public string Description;

        public ClientData[] ClientData;

        public Order( int id, TDelivery delivery)
        {
            TDelivery Delivery = delivery;
            Id = id;
        }




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
