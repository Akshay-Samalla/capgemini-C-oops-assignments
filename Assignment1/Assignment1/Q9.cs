public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetDiscountedPrice()
    {
        return Price; 
    }
}

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.9m;
    }
}

public class ClothingProduct : Product
{
    public ClothingProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.75m; 
    }
}

/*class Program
{
    static void Main()
    {
        Product[] cart = new Product[]
        {
            new ElectronicProduct("Laptop", 1000m),
            new ClothingProduct("T-Shirt", 40m)
        };

        foreach (Product item in cart)
        {
            Console.WriteLine($"{item.Name}: Original Price: {item.Price:C}, Discounted: {item.GetDiscountedPrice():C}");
        }
        
    }
}*/ 