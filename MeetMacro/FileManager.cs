using System;
using System.IO;

namespace MeetMacro
{
    public class FileManager
    {
        public delegate void Writer(TextWriter writer);

        public static string DirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"MeetMacro");
        public string FilePath { private set; get; }

        public FileManager(string fileName)
        {
            FilePath = Path.Combine(DirectoryPath, fileName);

            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);
            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
        }

        public string[] Read() => File.ReadAllLines(FilePath);

        public void Write(Writer write)
        {
            using TextWriter writer = new StreamWriter(FilePath);
            write(writer);
        }
    }
}
