using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EldenRingSpiritBattler
{
    public class SaveLoad
    {
        public class SaveFile
        {
            public List<BattleSpirit> Spirits;
            public List<SpiritTeam> Teams;

            public SaveFile(List<BattleSpirit> spirits, List<SpiritTeam> teams)
            {
                Spirits = spirits;
                Teams = teams;
            }
        }

        public static void Save(string path, List<BattleSpirit> spirits, List<SpiritTeam> teams)
        {
            SaveFile save = new(spirits, teams);
            var json = JsonConvert.SerializeObject(save, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        public static SaveFile Load(string path)
        {
            var file = File.ReadAllText(path);
            SaveFile save = JsonConvert.DeserializeObject<SaveFile>(file);
            return save;
        }
    }
}
