//Type is in global namespace

public class StationaryWithSuppressLayer : BaseLogicLayer
{
	private const float MAX_PERIOD_SUPRESS_NO_HIT = 3; //Field offset: 0x0
	private readonly string _name; //Field offset: 0x90
	private float _blockUntil; //Field offset: 0x98

	protected AbstractSuppressStationary _suppress
	{
		 get { } //Length: 39
	}

	public StationaryWithSuppressLayer(BotOwner bot, int priority) { }

	private bool CanShootAndHaveNoHit() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToStationary() { }

	protected virtual AICoreActionEnd EndShootFromStationary() { }

	protected virtual AICoreActionEnd EndSuppressStationary() { }

	protected AbstractSuppressStationary get__suppress() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsStationaryReadyAndFree() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

