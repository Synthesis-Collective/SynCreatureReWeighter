using Newtonsoft.Json;
using System.Collections.Generic;

namespace CreatureReWeighter
{
    public partial class CreatureReWeighterSettings
    {
        public HashSet<RaceWeightDefinition> WeightByRace { get; set; } = new HashSet<RaceWeightDefinition>();

        public bool VerboseMode { get; set; } = false;
    }
}
