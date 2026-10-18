//Type is in global namespace

public class FullMapPatrolLayer : PatrolAssaultLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FindPoint>b__8_0(GroupPoint point) { }

		internal bool <FindPoint>b__8_1(GroupPoint point) { }

	}

	private CustomNavigationPoint _point; //Field offset: 0x98
	private AICorePoint _lastCore; //Field offset: 0xA0
	private float MAX_STAY_AT_COVER; //Field offset: 0xA8
	private float MIN_STAY_AT_COVER; //Field offset: 0xAC
	private float _stayAtCover; //Field offset: 0xB0
	private float _lastTimeSetPoint; //Field offset: 0xB4

	public FullMapPatrolLayer(BotOwner bot, int priority) { }

	protected virtual AICoreActionEnd EndAlternativePatrol() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndGoToCoverPointTactical() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndSimplePatrol() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

