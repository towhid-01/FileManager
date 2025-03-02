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
        
    }
}