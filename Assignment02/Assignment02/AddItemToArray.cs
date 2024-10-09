namespace Assignment02;

public class GroceyList
{
    static string[] AddItemToArray(string[] array, string newItem)
    {
        string[] newArray = new string[array.Length + 1]; 
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i]; 
        }
        newArray[array.Length] = newItem; 
        return newArray;
    }

    static string[] RemoveItemFromArray(string[] array, string itemToRemove)
    {
        int index = Array.IndexOf(array, itemToRemove);
        if (index == -1)
        {
            Console.WriteLine($"Item '{itemToRemove}' not found in the list.");
            return array;
        }

        string[] newArray = new string[array.Length - 1]; // Create a new array with one less slot
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != index) // Skip the item to be removed
            {
                newArray[j++] = array[i]; // Copy other items
            }
        }

        Console.WriteLine($"Removed: {itemToRemove}");
        return newArray;
    }

    public void GroceryList()
    {
        bool check = true;
        string[] items = new string[0];
        while (check)
        {
            Console.Write("Enter command (+ item, - item, or -- to clear, or / to quit)):");
            string input = Console.ReadLine();
            if (input == "/")
            {
                break;
            }else if (input == "--")
            {
                items = new string[0];
                Console.WriteLine("List cleared.");
            }else if (input.StartsWith("+ "))
            {
                string newItem = input.Substring(2); 
                items = AddItemToArray(items, newItem);
                Console.WriteLine($"Added: {newItem}");
                Console.Write("The current list has: ");
                foreach (var item in items)
                {
                    Console.Write(item+',');
                }
                Console.WriteLine();
            }
            else if (input.StartsWith("- "))
            {
                string itemToRemove = input.Substring(2);
                items = RemoveItemFromArray(items, itemToRemove);
                Console.Write("The current list has: ");
                foreach (var item in items)
                {
                    Console.Write(item+',');
                    
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid command.Try again.");
            }
        }
        
    }
}