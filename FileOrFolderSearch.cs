namespace FileManagerApp
{
    public class FileOrFolderSearch
    {
        public void Search(string path, string keyword)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Error: Directory does not exist.");
                return;
            }

            string[] files = Directory.GetFiles(path, $"*{keyword}*");
            string[] folders = Directory.GetDirectories(path, $"*{keyword}*");

            if (files.Length == 0 && folders.Length == 0)
            {
                Console.WriteLine($"No files or folders found matching '{keyword}' in {path}.");
                return;
            }

            Console.WriteLine($"Results for '{keyword}':");

            foreach (var file in files)
            {
                Console.WriteLine($"File: {file}");
            }

            foreach (var folder in folders)
            {
                Console.WriteLine($"Folder: {folder}");
            }
        }
    }
}

