//Type is in global namespace

public class PartisanPlantingTargetManyLayer : PartisanBasePlantingLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public EnemyInfo enemy; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetDecision>g__GoodPoint|0(GroupPoint arg) { }

	}

	public const float SDIST_TO_STOP_ON_HEAR = 2025; //Field offset: 0x0
	private float _lastTimeFoundGood; //Field offset: 0xB0
	private float _stopUntil; //Field offset: 0xB4
	private CustomNavigationPoint _cachePoint; //Field offset: 0xB8
	private HashSet _cachePoints; //Field offset: 0xC0

	public PartisanPlantingTargetManyLayer(BotOwner bot, int priority, AvoidDangerLayer avoidLayerToCheck) { }

	protected virtual AICoreActionEnd EndGoToCoverPointTactical() { }

	protected virtual AICoreActionEnd EndGoToPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndMoveStealthy() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

