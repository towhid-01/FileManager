namespace FileManagerApp
{
    public class FileOperations
    {
        public void Rename(string path)
        {
            if (!File.Exists(path) && !Directory.Exists(path))
            {
                Console.WriteLine("Error: File or folder does not exist.");
                return;
            }

            Console.Write("Enter the new name: ");
            string newName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Error: No new name entered!");
                return;
            }

            string directory = Path.GetDirectoryName(path);
            string newPath = Path.Combine(directory, newName);

            try
            {
                if (File.Exists(path))
                {
                    File.Move(path, newPath);
                    Console.WriteLine($"Success: File renamed to '{newName}'!");
                }
                else if (Directory.Exists(path))
                {
                    Directory.Move(path, newPath);
                    Console.WriteLine($"Success: Folder renamed to '{newName}'!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        public void ViewFileDetails(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Error: File does not exist.");
                return;
            }
            

            FileInfo fileInfo = new FileInfo(path);

            Console.WriteLine("\nFile Details:");
            Console.WriteLine($"Name: {fileInfo.Name}");
            Console.WriteLine($"Size: {fileInfo.Length} bytes");
            Console.WriteLine($"Created On: {fileInfo.CreationTime}");
            Console.WriteLine($"Last Modified: {fileInfo.LastWriteTime}");
        }
        
    }
}