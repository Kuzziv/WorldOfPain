using System;
using System.IO;
using YamlDotNet.Serialization;

namespace WorldOfPain.Services
{
    public class SaveManager
    {
        private readonly string _saveFolder = "C:\\Users\\hifnh\\Desktop\\TheGame\\TheGame\\GameStorage\\Heros\\";

        public void Save<T>(T obj, string fileName)
        {
            // if the folder doesn't exist, create it
            if (!Directory.Exists(_saveFolder))
            {
                Directory.CreateDirectory(_saveFolder);
            }

            string filePath = _saveFolder + $"{fileName}.yaml";
            var serializer = new SerializerBuilder().Build();
            var yaml = serializer.Serialize(obj);
            File.WriteAllText(filePath, yaml);
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
