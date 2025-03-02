namespace FileManagerApp
{
    public class FileandFolderDeleter
{
    public void DeleteFile(string path)
    {
        Console.Write("Enter the file name (including extension) e.g. , fileName.txt)");
        string fileName = Console.ReadLine();

        if (string.IsNullOrEmpty(fileName))
        {
            Console.WriteLine("You must enter a file name.");
            return;
        }
        string fullPath = Path.Combine(path, fileName);

        if (!File.Exists(fullPath))
        {
            Console.WriteLine($"Error: File '{fileName}' does not exist in {path}!");
            return;
        }

        try
        {
            File.Delete(fullPath);
            Console.WriteLine($"Success: File '{fileName}' deleted from {path}!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: No permission to delete this file!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
    }

    public void DeleteDirectory(string path)
    {
        Console.Write("Enter the directory name (including extension) e.g. , directoryName.txt)");
        string directoryName = Console.ReadLine();

        if (string.IsNullOrEmpty(directoryName))
        {
            Console.WriteLine("You must enter a directory name.");
            return;
        }
        string fullPath = Path.Combine(path, directoryName);

        if (!Directory.Exists(fullPath))
        {
            Console.WriteLine($"Error: Directory '{directoryName}' does not exist in {path}!");
            return;
        }

        try
        {
            Directory.Delete(fullPath,true);
            Console.WriteLine($"Success: Directory '{directoryName}' deleted from {path}!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: No permission to delete this directory!");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
}

