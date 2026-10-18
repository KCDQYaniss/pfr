//Type is in global namespace

public abstract class ExUsecAbstractStrategy : BaseBrain
{
	private readonly HashSet _subscribed; //Field offset: 0x58

	protected ExUsecAbstractStrategy(BotOwner owner) { }

	private void CheckGroupOnSubscribe(BotsGroup botsGroup) { }

	public virtual void Dispose() { }

	private void DisposeSubscribing() { }

	private void OnBotAdd(BotOwner bot) { }

	private void OnReportEnemy(IPlayer enemy, Vector3 enemyPos, Vector3 weaponRootLast, EEnemyPartVisibleType isVisibleOnlyBySense, BotOwner reporter) { }

	protected void SubscribeOthersGroups() { }

}

