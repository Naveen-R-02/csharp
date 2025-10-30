namespace onlinestore
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: ₹{Price}");
        }
    }

    // Derived class from Product
    class ElectronicProduct : Product
    {
        public string Brand { get; set; }
        public int Warranty { get; set; }  // in months

        public ElectronicProduct(string name, double price, string brand, int warranty)
            : base(name, price)
        {
            Brand = brand;
            Warranty = warranty;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Warranty: {Warranty} months");
        }
    }

    // Further derived class from ElectronicProduct
    class SmartPhone : ElectronicProduct
    {
        public string OS { get; set; }
        public int Storage { get; set; }  // in GB

        public SmartPhone(string name, double price, string brand, int warranty, string os, int storage)
            : base(name, price, brand, warranty)
        {
            OS = os;
            Storage = storage;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Operating System: {OS}");
            Console.WriteLine($"Storage: {Storage} GB");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of SmartPhone class
            SmartPhone phone = new SmartPhone("iPhone 15", 79999, "Apple", 24, "iOS", 256);

            Console.WriteLine("=== Product Details ===");
            phone.Display();
        }
    }
}
