using System;
using System.Collections.Generic;

class Program
{
   
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Введите ваше имя : ");
        User user = new User();
        user.Name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию : ");
        user.Family = Console.ReadLine();
        Console.WriteLine("Введите ваш номер телефона :");
        user.Telephone = Console.ReadLine();

        Console.WriteLine("Выберите товар и укажите количесвто :");
        List<string> tovar = new List<string>();

        Order<Delivery> order = new Order<Delivery>();

        Console.WriteLine("Выберите способ доставки:\n 1 - Если нужна доставка на дом \n 2 - Если требуется доставка до Постамата \n 3 - Если вы хотите забрать товар из магазина");
        int change = Convert.ToInt32(Console.ReadLine());
        switch (change)
        {
            case 1:
                order.Delivery = new HomeDelivery();
                
                Console.WriteLine("Вы выбрали доставку на дом, введите свой адрес для доставки :");
                
                Adress adress = new Adress();

                Console.WriteLine("Введите индекс вашего населеннго пункта :");
                adress.indexcity = Console.ReadLine();
                Console.WriteLine("Введите ваш город :");
                adress.city = Console.ReadLine();
                Console.WriteLine("Введите вашу улицу :");
                adress.street = Console.ReadLine();
                Console.WriteLine("Введите номер дома :");
                adress.house = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер квартиры:");
                adress.appartment = Convert.ToInt32(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("Вы выбрали доставку в постамат");
                Console.WriteLine(PickPointDelivery.boxnumber);
                break;
            case 3:
                Console.WriteLine("Вы выбрали доставку в магазин");
                Console.WriteLine(ShopDelivery.shopadress); 

                break;
        }


        /*Product P1 = new Product(1, "Футболка с длинным рукавом", 1518.2, Product.Type.Футболка, "Вьетнам", Product.Sex.Men, "XXL");
        Product P2 = new Product(2, "Кроссовки беговые", 5450, Product.Type.Кроссовки, "Китай", Product.Sex.Women, "38");
        Product P3 = new Product(3, "Шорты теннисные", 2030, Product.Type.Шорты, "Тайланд", Product.Sex.Men, "L");
        Product P4 = new Product(4, "Футболка с коротким рукавом", 1318.8, Product.Type.Футболка, "Вьетнам", Product.Sex.Men, "XL");
        Product P5 = new Product(5, "Футболка с коротким рукавом", 1420.8, Product.Type.Футболка, "Вьетнам", Product.Sex.Women, "M");*/
        // Ввод адреса

        Random random = new Random();
        int a;
        a = random.Next(100);
    }

    abstract class Delivery
    {
        public Adress adress;
    }
    
    class HomeDelivery : Delivery
    {
        public string viphome;
       public void SetHome()
        {

        }
    }

    class PickPointDelivery : Delivery
    {
        static public int boxnumber = 349035;
    }

    class ShopDelivery : Delivery
    {
        static public string shopadress = "г.Уфа, ул.Черниковская 87 ";
    }

    // Заказ 
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;
        
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.adress);
        }
        //private Product product;
        //public Order (Product product)
        //{
        //    this.product = product;
        //}

        // ... Другие поля
    }
    abstract class  Product
    {
               public int NumTov;
        //public string NameTov;
        public abstract void SetTovar(int NumTov);
       /*public Product(string nametov, int numtov)
        {
            NameTov = nametov;
            NumTov = numtov;
        }*/
    }
    class Gantel: Product
    {
        public int much;
        public string gantel = "Гантель";
        public override void SetTovar(int NumTov)
        {

        }
    }
    class Girya : Product
    {
        public string girya = "Гиря";
        public override void SetTovar(int NumTov)
        {

        }
    }
    class Shanga : Product 
    {
        public string shtanga = "Штанга";
        public override void SetTovar(int NumTov)
        {

        }
    }
    class Blini : Product
    {
        public string blin = "Блин";
        public override void SetTovar(int NumTov)
        {

        }
    }

    /// <summary>
    /// 
    /// </summary>
   public class Adress
    {
        private string IndexCity;
        private string City;
        private string Street;
        private int House;
        private int Appartment;
        public string indexcity {get { return IndexCity;} set { IndexCity = value;}}
        public string city { get { return City; } set { City = value; } }
        public string street { get { return Street; }set { Street = value; } }
        public int house { get { return House; } set { House = value; } }
        public int appartment { get { return Appartment; } set { Appartment = value; } }

        public Adress(string index, string city, string street,int house,int appart )
        {
            indexcity = index;
            this.city = city;
            this.street = street;
            this.house = house;
            appartment = appart;
        }

        public Adress()
        {
        }
    }
    class Sklad
    {
        public int SKNumber;
    }
    public class User
    {
        public string Name;
        public string Family;
        public string Telephone; 
    }

  
}