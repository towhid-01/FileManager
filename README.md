# File Manager App

A simple File Manager application that allows users to perform basic file and folder operations, including creating, deleting, renaming files and folders, viewing details, and searching for files and folders. This project is built using C#.

## Features

- **Create a File**: Create a new file in the specified path.
- **Create a Folder**: Create a new folder in the specified path.
- **Delete a File**: Delete a specified file.
- **Delete a Folder**: Delete a specified folder.
- **List Files and Folders**: List all files and folders in a directory, with the option to view files or folders separately.
- **Rename File or Folder**: Rename a file or folder.
- **View File or Folder Details**: View detailed information about a file or folder, including name, size, creation time, and last modification time. For folders, the size is displayed recursively.
- **Search Files or Folders**: Search for files or folders by name within the specified directory.

## Requirements

- .NET Core SDK (or later version)
- C# compiler

## Installation

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/yourusername/FileManagerApp.git
    ```

2. Navigate to the project directory:

    ```bash
    cd FileManagerApp
    ```

3. Compile and run the project:

    ```bash
    dotnet run
    ```

## Usage

When you run the application, you will be presented with a menu with options:

- **Create a File**: Create a new file in the directory you specify.
- **Create a Folder**: Create a new folder in the directory you specify.
- **Delete a File**: Delete a file from the directory you specify.
- **Delete a Folder**: Delete a folder from the directory you specify.
- **List all Files and Folders**: List files or folders in a directory.
- **Rename File or Folder**: Rename an existing file or folder.
- **View File or Folder Details**: View details such as size, creation date, and last modified date of a file or folder.
- **Search Files or Folders**: Search for files or folders by name within a specified directory.
- **Exit**: Exit the application.

Enter the number corresponding to the action you want to perform and follow the on-screen prompts.

## Code Structure

- **FileManagerApp/Program.cs**: The main entry point of the application. Handles user input and invokes appropriate methods for different file operations.
- **FileManagerApp/FilesAndFoldersList.cs**: Manages the listing of files and folders in a specified path.
- **FileManagerApp/FileOperations.cs**: Handles file and folder operations such as creating, deleting, renaming, and viewing details.
- **FileManagerApp/FileOrFolderSearch.cs**: Handles searching for files or folders in a specified directory.

## Example

```bash
Options:
1 - Create a File
2 - Create a Folder
3 - Delete a File
4 - Delete a Folder
5 - List all Files and Folders
6 - Rename File or Folder
7 - View File or Folder Details
8 - Search Files or Folders
9 - Exit
Enter your choice: 7
Enter the path: C:\Users\YourName\Documents
Enter the number or name of the file/folder to view details: 1

File Details:
Name: example.txt
Size: 1 KB
Created On: 2025-03-02 12:34:56
Last Modified: 2025-03-02 12:34:56
