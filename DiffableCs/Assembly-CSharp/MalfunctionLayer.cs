//Type is in global namespace

public class MalfunctionLayer : BaseLogicLayer
{
	private const float HOLD_FOR_FIX_PERIOD = 25; //Field offset: 0x0
	private const float HOLD_FOR_FIX_TIME = 0.25; //Field offset: 0x0
	private float _holdForFixBeginTime; //Field offset: 0x90

	public MalfunctionLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRepairMalfunction() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndShootToSmoke() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual string GetCustomData() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

