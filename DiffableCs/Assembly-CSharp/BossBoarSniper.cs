//Type is in global namespace

public class BossBoarSniper : ABossLogic
{
	private BotOwner _botForReport; //Field offset: 0x20
	private IBossAskingForSuppress _boarLogic; //Field offset: 0x28

	public BossBoarSniper(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	private void ConnectWith(BotOwner bot) { }

	public virtual void Dispose() { }

	private void OnBossReportToMe(IPlayer enemy, Vector3 enemypos, Vector3 weaponrootlast, EEnemyPartVisibleType visibleType, BotOwner reporter) { }

	private void OnBotStateChange(EBotState obj) { }

	private void OnMeReportToBoss(IPlayer enemy, Vector3 enemypos, Vector3 weaponrootlast, EEnemyPartVisibleType visibleType, BotOwner reporter) { }

	public virtual void SetPatrolMode() { }

	private void TryEstablishConnection() { }

}

