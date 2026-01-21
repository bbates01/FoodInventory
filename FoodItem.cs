namespace Assignment3;

public class FoodItem
{
    public string Name;
    public string Category;
    public int Quantity;
    public DateTime ExpirationDate;
    
    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }
    
    public static void AddFoodItem(List<FoodItem> foodItems)
    {
        Console.Write("Enter food item name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter food item category: ");
        string category = Console.ReadLine();
        
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        
        Console.Write("Enter expiration date (yyyy-mm-dd): ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());
        
        FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
        foodItems.Add(newItem);
        
        Console.WriteLine("Food item added successfully!");
    }

    public static void DeleteFoodItem(List<FoodItem> foodItems)
    {
        // print current food items with indices
        PrintFoodItems(foodItems);
        Console.Write("Enter the index of the food item to delete: ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < foodItems.Count)
        {
            foodItems.RemoveAt(index);
            Console.WriteLine("Food item deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid index. No food item deleted.");
        }
    }
    public static void PrintFoodItems(List<FoodItem> foodItems)
    {
        if (foodItems.Count == 0)
        {
            Console.WriteLine("No food items available.");
            return;
        }
        
        Console.WriteLine("Current Food Items:");
        for (int i = 0; i < foodItems.Count; i++)
        {
            FoodItem item = foodItems[i];
            Console.WriteLine($"{i}. Name: {item.Name}, Category: {item.Category}, Quantity: {item.Quantity}, Expiration Date: {item.ExpirationDate.ToShortDateString()}");
        }
    }
}