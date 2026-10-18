//Type is in global namespace

public abstract class ABossLogic : BotData
{
	protected BotBoss _bossLogic; //Field offset: 0x18

	public BotOwner Owner
	{
		 get { } //Length: 27
	}

	public ABossLogic(BotOwner owner, BotBoss bossLogic) { }

	public abstract void Activate() { }

	public abstract void BossLogicUpdate() { }

	public override void CopyData(ABossLogic bossBossLogic) { }

	public abstract void Dispose() { }

	public BotOwner get_Owner() { }

	public override void OnDrawGizmosSelected() { }

	public abstract void SetPatrolMode() { }

}

