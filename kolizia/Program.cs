class Program
{
    static void Main(string[] args)
    {
        HashTable hashTable = new HashTable();

        hashTable.Add(new Product { ItemNumber = 123, Name = "Product 1", Quantity = 10 });
        hashTable.Add(new Product { ItemNumber = 456, Name = "Product 2", Quantity = 5 });
        hashTable.Add(new Product { ItemNumber = 789, Name = "Product 3", Quantity = 8 });

        Product product = hashTable.Find(456);
        if (product != null)
            Console.WriteLine($"Found product: {product.Name}, Quantity: {product.Quantity}");
        else
            Console.WriteLine("Product not found.");

        bool removed = hashTable.Remove(789);
        if (removed)
            Console.WriteLine("Product removed.");
        else
            Console.WriteLine("Product not found or not removed.");

        Console.ReadLine();
    }
}