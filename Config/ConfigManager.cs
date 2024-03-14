using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace WorldOfPain.Config
{
    public class ConfigManager
    {
        public Config LoadConfig(string filePath)
        {
            try
            {
                // Read the YAML file
                string yaml = File.ReadAllText(filePath);

                // Deserialize YAML to Config object
                var deserializer = new DeserializerBuilder().Build();
                return deserializer.Deserialize<Config>(yaml);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration file: {ex.Message}");
                return null;
            }
        }
    }
}
