using Code.Core;
using Code.Data;
using Code.Data.Settings;
using UniRx;
using UnityEngine;


namespace Code{
    public class MainController : BaseController, IExecute{
        private readonly Transform _placeForUi;
        private readonly GameContext _context;
        private readonly DataOfUsers _userSettings;
        private readonly LevelsData _levelSettings;
        private readonly EnemiesData _enemySettings;

        public MainController(Transform placeForUi, GameContext context, DataOfUsers userSettings, LevelsData levelSettings,
            EnemiesData enemySettings){
            _placeForUi = placeForUi;
            _context = context;
            _userSettings = userSettings;
            _levelSettings = levelSettings;
            _enemySettings = enemySettings;
        }

        public void Execute(float deltaTime){
            if (!IsOn) return;
        }

        public override void Init(){
            _context.FightModel.ChangeGameState.Subscribe(ChangeGameState).AddTo(_subscriptions);
        }

        private void ChangeGameState(GameState state){
        }
    }
}