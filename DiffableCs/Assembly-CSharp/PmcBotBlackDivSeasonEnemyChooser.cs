//Type is in global namespace

public class PmcBotBlackDivSeasonEnemyChooser : BotEnemyChooser
{
	private const float FORCE_ENEMY_DISTANCE = 200; //Field offset: 0x0
	private const float FORCE_ENEMY_TIME = 3; //Field offset: 0x0

	public PmcBotBlackDivSeasonEnemyChooser(BotOwner owner) { }

	public virtual EnemyInfo FindDangerEnemy() { }

}

