using System;
using System.IO;
using WorldOfPain.Interfaces;
using YamlDotNet.Serialization;

namespace WorldOfPain.Services
{
    public class SaveManager
    {
        private readonly string _saveFolder ;
        private readonly string _folderName;
        public SaveManager(string folderName)
        {
            // Get the current directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // Get the parent directory of the current directory (move up one folder)
            string parentDirectory1 = Directory.GetParent(currentDirectory).FullName;

            // Get the parent directory of the parent directory (move up one more folder)
            string parentDirectory2 = Directory.GetParent(parentDirectory1).FullName;

            // Get the parent directory of the parent directory (move up one more folder)
            string parentDirectory3 = Directory.GetParent(parentDirectory2).FullName;

            // Combine the parent directory with "GameStorage" and the specified folder name
            _saveFolder = Path.Combine(parentDirectory3, "GameStorage", folderName);
        }

        public void Save<T>(T obj, string fileName)
        {
            // if the folder doesn't exist, create it
            //if (!Directory.Exists(_saveFolder))
            //{
            //    Directory.CreateDirectory(_saveFolder);
            //}


            //string filePath = _saveFolder + $"{fileName}.yaml";
            //var serializer = new SerializerBuilder().Build();
            //var yaml = serializer.Serialize(obj);
            //File.WriteAllText(filePath, yaml);
        }

        public T Load<T>(string fileName)
        {
            string filePath = Path.Combine(_saveFolder, $"{fileName}.yaml");
            var deserializer = new DeserializerBuilder().Build();
            var yaml = File.ReadAllText(filePath);
            return deserializer.Deserialize<T>(yaml);
        }
    }
}
