using System;
using System.IO;


namespace WorkingWithFilesBL
{
    public class FileProcessor
    {
        private static readonly string _backupDirectoryName = "backup";
        private static readonly string _inProgressDirectoryName = "processing";
        private static readonly string _completedDirectoryName = "complete";
        public string InputFilePath { get;  }

        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            Console.WriteLine($"Pradedu bylos apdorojimą {InputFilePath}");
            if (!File.Exists(InputFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {InputFilePath} neegzistuoja.");
                return;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(InputFilePath);
            string rootDirectoryPath = directoryInfo.Parent.Parent.FullName;
            Console.WriteLine($"Šakninis katalogas yra {rootDirectoryPath}");

            string backupDirectoryPath = Path.Combine(rootDirectoryPath, _backupDirectoryName);

            Directory.CreateDirectory(backupDirectoryPath);

            string inputFileName = Path.GetFileName(InputFilePath);
            string backupFilePath = Path.Combine(backupDirectoryPath, inputFileName);
            Console.WriteLine($"Kopijuoju {InputFilePath} į {backupFilePath}");
            File.Copy(InputFilePath, backupFilePath);

            Directory.CreateDirectory(Path.Combine(rootDirectoryPath, _inProgressDirectoryName));

            string inProgressFilePath = Path.Combine(rootDirectoryPath, _inProgressDirectoryName, inputFileName);

            if (File.Exists(inProgressFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {inProgressFilePath} jau apdorota");
            }
            Console.WriteLine($"Perkeliu {InputFilePath} į {inProgressFilePath}");
            File.Move(InputFilePath, inProgressFilePath);

            string extension = Path.GetExtension(InputFilePath);
            switch (extension)
            {
                case ".txt":
                    ProcessTextFile(inProgressFilePath);
                    break;
                default:
                    Console.WriteLine($"Nepalaikomas bylos tipas {extension}");
                    break;
            }

            string completedDirectoryPath = Path.Combine(rootDirectoryPath, _completedDirectoryName);
            Directory.CreateDirectory(completedDirectoryPath);

            Console.WriteLine($"Perkeliamas {inProgressFilePath} į {completedDirectoryPath}");
            var completedFileName = string.Format("{0}-{1}{2}", Path.GetFileNameWithoutExtension(InputFilePath), Guid.NewGuid(), extension);
            var completedFilePath = Path.Combine(completedDirectoryPath, completedFileName);
            File.Move(inProgressFilePath, completedFilePath);

            string inProgressDirectoryPath = Path.GetDirectoryName(inProgressFilePath);
            Directory.Delete(inProgressDirectoryPath, true);

        }
        private void ProcessTextFile(string inProgressPath)
        {
            Console.WriteLine($"Apdorojama byla {inProgressPath}");
        }

    }
}
