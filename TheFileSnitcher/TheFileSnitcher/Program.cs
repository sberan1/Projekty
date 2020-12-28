using System;
using System.IO;
using System.Security.Permissions;

namespace TheFileSnitcher
{
    public class Watcher
        {
            public static void Main()
            {
                Run();
            }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private static void Run()
        {
            string[] args = Environment.GetCommandLineArgs();
            Console.Write("Zadej cestu k souboru: ");
            args[0] = Console.ReadLine();
 
                // Create a new FileSystemWatcher and set its properties.
                using (FileSystemWatcher watcher = new FileSystemWatcher())
                {
                    watcher.Path = args[0];

                    // Watch for changes in LastAccess and LastWrite times, and
                    // the renaming of files or directories.
                    watcher.NotifyFilter = NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName
                                         | NotifyFilters.DirectoryName;

                    // Add event handlers.
                    watcher.Changed += OnChanged;
                    watcher.Created += OnChanged;
                    watcher.Deleted += OnChanged;
                    watcher.Renamed += OnRenamed;

                    // Begin watching.
                    watcher.EnableRaisingEvents = true;

                    // Wait for the user to quit the program.
                    Console.WriteLine("Press 'q' to quit the sample.");
                    while (Console.Read() != 'q') ;
                }
            }

            // Define the event handlers.
            private static void OnChanged(object source, FileSystemEventArgs e) =>
                // Specify what is done when a file is changed, created, or deleted.
                Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

            private static void OnRenamed(object source, RenamedEventArgs e) =>
                // Specify what is done when a file is renamed.
                Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
        }
    }

