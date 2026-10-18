//Type is in global namespace

public class WedgeCloseDist : BaseWedgeLayer
{
	private const float DF_DIST = 5; //Field offset: 0x0
	protected BotMeleeAssaultData _assaultData; //Field offset: 0xB0
	private AIPeriodAction _provocationPeriod; //Field offset: 0xB8
	private bool _holdOrDF; //Field offset: 0xC0
	private float _endDogFight; //Field offset: 0xC4
	private List _tgriggers; //Field offset: 0xC8

	public WedgeCloseDist(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndGoToEnemy() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	private void Provocation() { }

	public virtual bool ShallUseNow() { }

}

