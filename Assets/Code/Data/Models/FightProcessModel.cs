using UniRx;
using UnityEngine;


namespace Code.Data.Models{
    [CreateAssetMenu(fileName = nameof(FightProcessModel), menuName = "Models/" + nameof(FightProcessModel))]
    public class FightProcessModel: ScriptableObject{
        public ReactiveProperty<GameState> ChangeGameState{ get; set; }
    }
}