//Type is in global namespace

public class PartisanFightLayer : PartisanFightBaseLayer
{
	private const float DISTANCE_TO_FIGHT = 200; //Field offset: 0x0
	private float _fightUntil; //Field offset: 0x98

	public PartisanFightLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndDogFight() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

	protected AICoreActionResult ShootOrDogFight(string info) { }

}

