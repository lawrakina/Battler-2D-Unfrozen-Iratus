using Code.Data.Models;


namespace Code.Core{
    public abstract class GameContext{
        public UserTeamModel UserTeam{ get; set; }
        public EnemiesTeamModel EnemiesTeam{ get; set; }
        public FightProcessModel FightModel{ get; set; }
    }
}