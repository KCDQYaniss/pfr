//Type is in global namespace

public class BossVSRF : ABossLogic
{
	private static int _nextId; //Field offset: 0x0
	public int Id; //Field offset: 0x20

	private static BossVSRF() { }

	public BossVSRF(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	public virtual void SetPatrolMode() { }

}

