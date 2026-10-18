//Type is in global namespace

public class WedgeTargetLayer : BaseWedgeLayer
{
	private const float SDIST_FAR_OK = 289; //Field offset: 0x0
	private float _nextCoverChnage; //Field offset: 0xB0

	public WedgeTargetLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsFarEnought(GroupPoint arg) { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

