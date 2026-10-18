//Type is in global namespace

public class GluharFollowerEnemyChooser : BotEnemyChooser
{
	private readonly BossGluhar _bossGluhar; //Field offset: 0x28

	public GluharFollowerEnemyChooser(BotOwner owner) { }

	public virtual EnemyInfo FindDangerEnemy() { }

}

