public class HashTable
{
    private const int TableSize = 10;
    private LinkedList<Product>[] table;

    public HashTable()
    {
        table = new LinkedList<Product>[TableSize];
        for (int i = 0; i < TableSize; i++)
            table[i] = new LinkedList<Product>();
    }

    public void Add(Product product)
    {
        int index = HashDivision(product.ItemNumber);
        table[index].Add(product);
    }

    public Product Find(int itemNumber)
    {
        int index = HashDivision(itemNumber);
        LinkedList<Product> list = table[index];
        foreach (Product product in list)
        {
            if (product.ItemNumber == itemNumber)
                return product;
        }
        return null;
    }

    public bool Remove(int itemNumber)
    {
        int index = HashDivision(itemNumber);
        LinkedList<Product> list = table[index];
        foreach (Product product in list)
        {
            if (product.ItemNumber == itemNumber)
                return list.Remove(product);
        }
        return false;
    }

    private int HashDivision(int key)
    {
        return key % TableSize;
    }

    private int HashMultiplication(int key)
    {
        double a = 0.6180339887; // Константа 0 < a < 1
        double value = key * a % 1;
        return (int)(TableSize * value);
    }
}