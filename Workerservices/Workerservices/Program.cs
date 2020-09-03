using System;
using System.IO;

namespace Workerservices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
            //fileSystemWatcher.Path = "";
            //fileSystemWatcher
            Watcher watcher = new Watcher();
            watcher.MainWatcher();
        }
    }
}
