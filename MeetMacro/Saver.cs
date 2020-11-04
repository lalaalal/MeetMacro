using System;
using System.IO;

namespace MeetMacro
{
    public abstract class Saver
    {
        protected FileManager fileManager;
        
        public string FilePath { get => fileManager.FilePath; }

        public Saver(string fileName)
            => fileManager = new FileManager(fileName);

        public void Save() => fileManager.Write(Save);
        protected abstract void Save(TextWriter writer);
    }
}
