namespace FileManagerApp
{
    public class FileManager
    {
        public void CreateFile(string path)
        {
            Console.Write("Enter the file name (including extension, e.g., file.txt): ");
            string fileName = Console.ReadLine();
    
            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Error: No file name entered!");
                return;
            }
    
            string fullPath = Path.Combine(path, fileName); 
    
            if (File.Exists(fullPath))
            {
                Console.WriteLine($"Error: File '{fileName}' already exists in {path}!");
                return;
            }
    
            try
            {
                using (File.Create(fullPath)) { } 
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
    
        public void CreateDirectory(string path)
        {
            Console.WriteLine("Enter the folder name:");
            string folderName = Console.ReadLine();
    
            if (string.IsNullOrWhiteSpace(folderName))
            {
                Console.WriteLine("Error: No folder name entered!");
                return; 
            }
    
            string fullPath = Path.Combine(path, folderName);
    
            if (Directory.Exists(fullPath))
            {
                Console.WriteLine($"Error: Folder '{folderName}' already exists in {path}!");
                return;
            }
    
            try
            {
                Directory.CreateDirectory(fullPath);
                Console.WriteLine($"Success: Folder '{folderName}' created at {path}!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: No permission to create a folder here!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    
    }
}

