//Type is in global namespace

public class ZryachiyPatrolLayer : ZryachiyAbstractLayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <GetDecision>b__6_1() { }

	}

	private const int RUN_END_DIST = 6; //Field offset: 0x0
	private const int DELAY_AFTER_SHOOT = 8; //Field offset: 0x0
	private readonly float _startTime; //Field offset: 0xB0
	private AIPlaceInfo _lookTo; //Field offset: 0xB8
	private readonly List _myPlaces; //Field offset: 0xC0

	public ZryachiyPatrolLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <.ctor>b__5_0(CustomNavigationPoint x) { }

	[CompilerGenerated]
	private void <GetDecision>b__6_0(CustomNavigationPoint point) { }

	protected virtual AICoreActionEnd EndCrawlNode() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndLayNode() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private CoverSearchData GetCoverSearchData() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	private AICoreActionResult SetPointAndLay() { }

	public virtual bool ShallUseNow() { }

}

