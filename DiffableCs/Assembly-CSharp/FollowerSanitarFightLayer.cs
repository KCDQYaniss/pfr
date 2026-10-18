//Type is in global namespace

public class FollowerSanitarFightLayer : AbstractSanitarFightLayer
{
	private const float PREF_DIST_TO_CENTER = 15; //Field offset: 0x0

	public FollowerSanitarFightLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPointForFight(bool checkCurrent) { }

	public virtual string Name() { }

	public void SetCorePosition(Vector3 followersPositionValue) { }

	public virtual bool ShallUseNow() { }

}

