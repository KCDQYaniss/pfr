//Type is in global namespace

public abstract class PartisanFightBaseLayer : BaseLogicLayer
{
	public const float LOW_KARMA = 0.5; //Field offset: 0x0
	private float _provocationHold; //Field offset: 0x90

	protected PartisanFightBaseLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected void SayAttackIfLow() { }

	protected void SayProvocaionPeriod() { }

	protected bool WantAttackCauseHit() { }

}

