using Code.Core;
using Code.Data.Models;
using Code.Data.Settings;
using Code.Extensions;
using UnityEngine;


namespace Code{
    public class Root : MonoBehaviour{
        [SerializeField]
        private Transform _placeForUi;


        #region PrivateData

        private GameContext _context;
        private DataOfUsers _userSettings;
        private LevelsData _levelSettings;
        private EnemiesData _enemySettings;

        #endregion


        private void Awake(){
            _context.UserTeam = ResourceLoader.LoadModel<UserTeamModel>();
            _context.EnemiesTeam = ResourceLoader.LoadModel<EnemiesTeamModel>();
            _context.FightModel = ResourceLoader.LoadModel<FightProcessModel>();

            _userSettings = ResourceLoader.LoadConfig<DataOfUsers>();
            _levelSettings = ResourceLoader.LoadConfig<LevelsData>();
            _enemySettings = ResourceLoader.LoadConfig<EnemiesData>();

            var mainController = new MainController(_placeForUi, _context, _userSettings, _levelSettings, _enemySettings);
            Controllers.Add(mainController);

            mainController.Init();
        }

        private void Update(){
            Controllers.Execute(Time.deltaTime);
        }

        private void LateUpdate(){
            Controllers.LateExecute(Time.deltaTime);
        }

        private void FixedUpdate(){
            Controllers.FixedExecute(Time.fixedDeltaTime);
        }

        private void OnDisable(){
            Controllers.Dispose();
        }
    }
}