using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EldenRingSpiritBattler
{
    public class UserConfig
    {
        // JsonExtensionData stores info in config file not present in class in order to retain settings between versions.
        [JsonExtensionData]
        private IDictionary<string, JToken>? _additionalData;

        [JsonIgnore]
        public static readonly string ConfigPath = $@"{Directory.GetCurrentDirectory()}\config.json";

        public UserConfig()
        { }

        public static UserConfig Load()
        {
            if (File.Exists(ConfigPath))
            {
                try
                {
                    var file = File.ReadAllText(ConfigPath);
                    return JsonConvert.DeserializeObject<UserConfig>(file);
                }
                catch (JsonException)
                {
                    MessageBox.Show("Couldn't read settings from \"config.ini\"." +
                        "\nSettings will be reset.", "Error", MessageBoxButtons.OK);
                }
            }
            return new UserConfig();
        }

        public static void Save(UserConfig config)
        {
            var json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(ConfigPath, json);
        }

        // Settings
        public bool ReduceEnemyCollisionRadii = true;
        public bool EnableResummoning = true;
        public bool ExpandSummonAreas = true;
        public bool HidePlayer = false;
        public bool SummonsFindTargetsEasily = false;
    }
}
