using System;
using System.IO;
class FDHandling
{
    // File IO
    public static void CreateFile()
    {
        var folderPath = @"C:\Users\T U F\OneDrive\Desktop\Net\NetLearning_Seema\FirstConsoleApp\G.FileIO";
        var filePath = $"{folderPath}\\student.txt";

        File.WriteAllText(filePath, "This is first line of text");

        Directory.CreateDirectory($"{folderPath}\\Dummy");

        // Create 10 files with names File1.cs, File2.cs, File3.cs ...
        // Each file should contain a byte variable 'age' with value as 1, 2, 3 ...

        for (int counter = 1; counter <= 10; counter++)
        {
            var file = $"File{counter}";
            var fileP = $"{folderPath}\\Dummy\\{file}.cs";
            // write content to the file
            File.WriteAllText(fileP, "class " + file + " { } ");
        }

        // reading
        string content = File.ReadAllText("D:\\stories");
        var words = content.Split([' ', ',', '.', ':', '-']);
        Console.WriteLine(words.Length);
    }
}