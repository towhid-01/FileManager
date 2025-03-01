while (true)
{
    Console.WriteLine("Type 'list' to show files/folders");
    Console.WriteLine("Type 'exit' to exit");
    Console.WriteLine("Type 'create' to show help");
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
    else if (userInput == "create")
    {
        Console.Write("Enter the directory path: ");
        string path = Console.ReadLine();
    
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Create a new file");
        Console.WriteLine("2 - Create a new folder");
        Console.Write("Your choice: ");
        string options = Console.ReadLine();

        if (options == "1")
        {
            Console.Write("Enter the file name (including extension, e.g., file.txt): ");
            string fileName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Error: No file name entered!");
                return;
            }

            string fullPath = Path.Combine(path, fileName); // Correctly combine directory and file name

            if (File.Exists(fullPath))
            {
                Console.WriteLine($"Error: File '{fileName}' already exists in {path}!");
                return;
            }

            try
            {
                using (File.Create(fullPath)) { } // Ensures file is created and closed immediately
                Console.WriteLine($"Success: File '{fileName}' created at {path}!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: No permission to create a file here!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}