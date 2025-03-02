using System;
using FileManagerApp;
class Program
{
    static void Main()
    {
        FileManager fileManager = new FileManager();
        FileandFolderDeleter fileandFolderDeleter = new FileandFolderDeleter();
        FilesAndFoldersList listFilesAndFolders = new FilesAndFoldersList();
        FileOperations fileOperations = new FileOperations();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1 - Create a File");
            Console.WriteLine("2 - Create a Folder");
            Console.WriteLine("3 - Delete a File");
            Console.WriteLine("4 - Delete a Folder");
            Console.WriteLine("5 - List all Files and Folders");
            Console.WriteLine("6 - Rename File or Folder");
            Console.WriteLine("7 - View File Details");
            Console.WriteLine("8 - Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();

            if (choice == "8")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            Console.Write("Enter the path: ");
            string path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("Error: No path entered!");
                continue;
            }

            if (choice == "1")
            {
                fileManager.CreateFile(path); 
            }
            else if (choice == "2")
            {
                fileManager.CreateDirectory(path); 
            }
            else if (choice == "3")
            {
                fileandFolderDeleter.DeleteFile(path);
            }
            else if (choice == "4")
            {
                fileandFolderDeleter.DeleteDirectory(path);
            }
            else if (choice == "5")
            {
                listFilesAndFolders.ListFilesAndFolders(path);
            }
            else if (choice == "6")
            {
                fileOperations.Rename(path);
            }
            else if (choice == "7")
            {
                fileOperations.ViewFileDetails(path);
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1, 2, 3, 4 or 5.");
            }
        }
    }
}