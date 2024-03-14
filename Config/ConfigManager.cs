using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace WorldOfPain.Config
{
    /// <summary>
    /// Manages loading configuration settings from a YAML file.
    /// </summary>
    public class ConfigManager
    {
        /// <summary>
        /// Loads configuration settings from the specified YAML file.
        /// </summary>
        /// <param name="filePath">The path to the YAML configuration file.</param>
        /// <returns>The loaded configuration settings as a <see cref="Config"/> object.</returns>
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
