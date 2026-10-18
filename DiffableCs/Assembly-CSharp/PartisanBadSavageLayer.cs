//Type is in global namespace

public class PartisanBadSavageLayer : BaseLogicLayer
{
	private BossFinder _bossLogic; //Field offset: 0x90
	private AIPeriodAction _period; //Field offset: 0x98
	private AIMinePoint _closests; //Field offset: 0xA0

	public PartisanBadSavageLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	private void FindMineClose() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool HaveMineClose() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

