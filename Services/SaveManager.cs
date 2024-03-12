﻿using System;
using System.IO;
using YamlDotNet.Serialization;

namespace WorldOfPain.Services
{
    public class SaveManager
    {
        private readonly string _saveFolder = Path.Combine(Directory.GetCurrentDirectory(), "YAMLStore", "Heros");

        public void Save<T>(T obj, string fileName)
        {
            string filePath = Path.Combine(_saveFolder, $"{fileName}.yaml");
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