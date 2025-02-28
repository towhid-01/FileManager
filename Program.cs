while (true)
{
    Console.WriteLine("Type 'list' to show files/folders");
    Console.WriteLine("Type 'exit' to exit");
    Console.Write("Enter Your Choice: ");
    string userInput = Console.ReadLine().ToLower();

    if (userInput == "exit")
    {
        break;
    }

    if (userInput == "list")
    {
        Console.Write("Enter the directory path: ");
        string path = Console.ReadLine();

        if (!Directory.Exists(path))
        {
            Console.WriteLine("Error: Directory does not exist!");
            continue;
        }

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Show Files");
        Console.WriteLine("2 - Show Folders");
        Console.Write("Your choice: ");
        string options = Console.ReadLine();

        string[] fileList = Array.Empty<string>();

        if (options == "1")
            fileList = Directory.GetFiles(path);
        else if (options == "2")
            fileList = Directory.GetDirectories(path);
        else
        {
            Console.WriteLine("Invalid option! Please enter 1 or 2.");
            continue;
        }

        if (fileList.Length == 0)
        {
            Console.WriteLine("No files or folders found.");
        }
        else
        {
            Console.WriteLine("\nListing contents:");
            foreach (var file in fileList)
            {
                Console.WriteLine(file);
            }
        }
    }
}