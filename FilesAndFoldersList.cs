namespace FileManagerApp
{
    public class FilesAndFoldersList
    {
        public void ListFilesAndFolders(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);

                Console.WriteLine("Files:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Console.WriteLine("Folders:");
                foreach (string dir in directories)
                {
                    Console.WriteLine(dir);
                }
            }
            else
            {
                Console.WriteLine($"Error: The path '{path}' does not exist.");
            }
        }

    }
}