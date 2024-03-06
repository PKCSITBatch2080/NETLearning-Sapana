using System;
using System.IO;
using System.Xml.Schema;

class FileDirectoryHandling
{
    // File IO
    public static void CreateFile()
    {
        var folderPath = @"D:\Dotnet-git\NETLearning-Sapana\consoleapp\g.fileDirectoryIO"; //absolute path
        var filePath =$"{folderPath}\\student.txt";

        File.WriteAllText(filePath,"This is first line of text");

        Directory.CreateDirectory($"{folderPath}\\Dummy"); //folder banauxa

        // create 10 files with names as File1.cs File2.cs.....
        // each file should contain variable 'age' where value as 1,2,3....
        // file bhitra -> byte age = 1;

        for(int i=1; i<=10; i++)
        {
          var file =$"File{i}";
          var fileP = $"{folderPath}\\Dummy\\{file}.cs";
          File.WriteAllText(fileP,"class " +  file + "{ }");
        }
        //deleted all 10 files

        for (int i = 1; i <= 10; i++)
        {
            var file =$"File{i}";
            var fileName = $"{folderPath}\\Dummy\\{file}.cs";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"File '{fileName}' deleted.");
            }
            else
            {
                Console.WriteLine($"File '{fileName}' does not exist.");
            }

         // reading
        string content = File.ReadAllText("D:\\Program.cs");
        var words = content.Split([' ', ',', '.', ':', '-']);
        Console.WriteLine(words.Length);

        string genericsFile ="d.generics.cs"; //project bhitrai vako file read gareko
        var fileContent = File.ReadAllText(genericsFile);
        Console.WriteLine(fileContent);

    }
}
}