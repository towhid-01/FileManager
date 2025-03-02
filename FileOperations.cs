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
        
        public void ViewFolderDetails(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Error: Folder does not exist.");
                return;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            // Calculate folder size
            long size = GetDirectorySize(path);

            Console.WriteLine("\nFolder Details:");
            Console.WriteLine($"Name: {dirInfo.Name}");
            Console.WriteLine($"Created On: {dirInfo.CreationTime}");
            Console.WriteLine($"Last Modified: {dirInfo.LastWriteTime}");
            Console.WriteLine($"Size: {FormatSize(size)}");
        }

        // Get the size of the folder recursively
        private long GetDirectorySize(string path)
        {
            long size = 0;

            // Get all files in the directory
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            // Recursively get the size of subdirectories
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                size += GetDirectorySize(directory);
            }

            return size;
        }

        // Format the size to GB or MB
        private string FormatSize(long sizeInBytes)
        {
            double sizeInMB = sizeInBytes / 1024.0 / 1024.0;
            if (sizeInMB >= 1024)
            {
                double sizeInGB = sizeInMB / 1024.0;
                return $"{sizeInGB:F2} GB";
            }
            else
            {
                return $"{sizeInMB:F2} MB";
            }
        }
        

        
    }
}