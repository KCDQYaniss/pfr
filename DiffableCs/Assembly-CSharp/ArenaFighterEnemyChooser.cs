//Type is in global namespace

public class ArenaFighterEnemyChooser : BotEnemyChooser
{
	private string _questId; //Field offset: 0x28
	private readonly Dictionary _cacheContainsQuest; //Field offset: 0x30

	public ArenaFighterEnemyChooser(BotOwner owner) { }

	public virtual void Activate() { }

	protected virtual float CalcWeight(float dist, EnemyInfo enemyInfo) { }

	public virtual void Dispose() { }

}

