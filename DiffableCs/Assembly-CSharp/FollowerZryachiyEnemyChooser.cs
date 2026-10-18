//Type is in global namespace

public class FollowerZryachiyEnemyChooser : BotEnemyChooser
{
	public const float PERIOD_OF_BOSS_ATTACK_TO_START_FIGHT = 15; //Field offset: 0x0
	private readonly HashSet _ignoreId; //Field offset: 0x28
	private StringBuilder _loggerBuilder; //Field offset: 0x30
	private int _oldHash; //Field offset: 0x38

	public FollowerZryachiyEnemyChooser(BotOwner owner) { }

	protected virtual float CalcWeight(float dist, EnemyInfo enemyInfo) { }

	private bool EnemiesMoreThan3() { }

	public virtual EnemyInfo FindDangerEnemy() { }

	private bool SpendEnought(EnemyInfo info) { }

	private void SubIgnore(EnemyInfo bossEnemyInfo, IPlayer person) { }

	private void TryAddToIgnore(EnemyInfo bossEnemyInfo) { }

}

