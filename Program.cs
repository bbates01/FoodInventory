/* Class responsibilities
    - Print menu
    - Handle user input
    - Call FoodItem class methods based on user input
 */

using Assignment3;

internal class Program
{
    private static void Main(string[] args)
    {
        // initialize empty list of food items
        List<FoodItem> foodItems = new List<FoodItem>();
        
        // loop until user chooses to exit
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nWelcome to the Food Item Manager!");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the program");
            Console.Write("Please enter your choice (1-4): ");
            // get and process user input
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FoodItem.AddFoodItem(foodItems);
                    break;
                case "2":
                    FoodItem.DeleteFoodItem(foodItems);
                    break;
                case "3":
                    FoodItem.PrintFoodItems(foodItems);
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}