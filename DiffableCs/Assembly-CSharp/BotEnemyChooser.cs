//Type is in global namespace

public class BotEnemyChooser : BotData
{
	private StringBuilder _loggerBuilder; //Field offset: 0x18
	private int _oldHashBetterLog; //Field offset: 0x20
	private int _oldHashPrepareLog; //Field offset: 0x24

	protected BotEnemyChooser(BotOwner owner) { }

	public override void Activate() { }

	protected EnemyInfo BetterEnemy(List enemiesInfos, bool isLogging) { }

	protected override float CalcWeight(float dist, EnemyInfo enemyInfo) { }

	public static BotEnemyChooser Create(BotOwner owner) { }

	public override void Dispose() { }

	[CanBeNull]
	public override EnemyInfo FindDangerEnemy() { }

}

