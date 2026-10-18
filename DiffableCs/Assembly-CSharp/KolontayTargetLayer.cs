//Type is in global namespace

public class KolontayTargetLayer : KolontayAbstractFightLayer
{
	private float _nextCheckEnemies; //Field offset: 0xA0
	private readonly BossFinder _bossLogic; //Field offset: 0xA8

	public KolontayTargetLayer(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

