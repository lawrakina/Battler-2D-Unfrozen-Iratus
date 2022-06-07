using System.Collections.Generic;
using Code.Data.Settings;
using UnityEngine;


namespace Code.Data.Models{
    [CreateAssetMenu(fileName = nameof(EnemiesTeamModel), menuName = "Models/" + nameof(EnemiesTeamModel))]
    public class EnemiesTeamModel: ScriptableObject, ITeam{
        public List<Solder> List{ get; set; }
    }
}