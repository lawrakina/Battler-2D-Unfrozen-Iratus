using System.Collections.Generic;
using Code.Data.Settings;
using UnityEngine;


namespace Code.Data.Models{
    [CreateAssetMenu(fileName = nameof(UserTeamModel), menuName = "Models/" + nameof(UserTeamModel))]
    public class UserTeamModel: ScriptableObject, ITeam{
        public List<Solder> List{ get; set; }
    }
}