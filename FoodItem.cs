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
        // get food item details from user
        Console.Write("\nEnter food item name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter food item category: ");
        string category = Console.ReadLine();
        
        // use a loop to ensure valid quantity input
        int quantity = 0;
        bool invalidQuantity = true;
        while (invalidQuantity)
        {
            Console.Write("Enter quantity: ");
            int quantityInput = int.Parse(Console.ReadLine());
            if (quantityInput >= 0)
            {
                // assign valid quantity to variable
                invalidQuantity = false;
                quantity = quantityInput;
            }
            else
            {
                // prompt user to re-enter quantity
                Console.WriteLine("Quantity must be a positive integer. Please try again.");
            }
            
        }
        
        Console.Write("Enter expiration date (yyyy-mm-dd): ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());
        
        // check if item is already in list
        foreach (FoodItem item in foodItems)
        {
            if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                item.Category.Equals(category, StringComparison.OrdinalIgnoreCase) &&
                item.ExpirationDate.Date == expirationDate.Date)
            {
                // if found, update quantity and return
                item.Quantity += quantity;
                Console.WriteLine("\nFood item already exists. Updated quantity successfully!");
                return;
            }
        }
        // create new food item and add to list
        FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
        foodItems.Add(newItem);
        
        Console.WriteLine("\nFood item added successfully!");
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
            Console.WriteLine("\nFood item deleted successfully!");
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
            Console.WriteLine("\nNo food items available.");
            return;
        }
        
        Console.WriteLine("\nCurrent Food Items:");
        for (int i = 0; i < foodItems.Count; i++)
        {
            FoodItem item = foodItems[i];
            Console.WriteLine($"{i}. Name: {item.Name}, Category: {item.Category}, Quantity: {item.Quantity}, Expiration Date: {item.ExpirationDate.ToShortDateString()}");
        }
    }
}