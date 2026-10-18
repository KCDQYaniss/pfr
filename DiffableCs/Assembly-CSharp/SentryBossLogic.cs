//Type is in global namespace

public class SentryBossLogic : ABossLogic, IAccessBossLogic
{
	private readonly HashSet _accessedPlayerIds; //Field offset: 0x20

	public SentryBossLogic(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	public override bool HaveAccess(int playerId) { }

	private void OnTerminalAccessGained(Player player) { }

	public virtual void SetPatrolMode() { }

}

