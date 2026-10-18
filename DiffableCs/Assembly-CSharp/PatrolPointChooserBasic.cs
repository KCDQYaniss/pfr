//Type is in global namespace

public class PatrolPointChooserBasic
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10
		public static Func <>9__19_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <ChooseStartWay>b__18_0(PatrolWay x) { }

		internal bool <ChooseStartWay>b__18_1(PatrolWay x) { }

		internal bool <FindPointForFollower>b__19_1(PatrolPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public IBotOwner follower; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <FindPointForFollower>b__0(PatrolPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public PatrolPointChooserBasic <>4__this; //Field offset: 0x10
		public int minSubTargets; //Field offset: 0x18
		public PatrolPointFilterDelegate pointFilter; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal bool <FindNextPoint>b__0(PatrolPoint point) { }

	}

	protected const float NEXT_POINT_DIST_SQRT = 4; //Field offset: 0x0
	protected BotOwner _owner; //Field offset: 0x10
	protected float _nextChangeWay; //Field offset: 0x18
	protected bool _canChangeWays; //Field offset: 0x1C
	protected bool _errorPrinted; //Field offset: 0x1D
	[CompilerGenerated]
	private bool <WasCutted>k__BackingField; //Field offset: 0x1E
	[CompilerGenerated]
	private float <PathDistCoef>k__BackingField; //Field offset: 0x20

	protected PatrolPathControl PathControl
	{
		 get { } //Length: 39
	}

	public float PathDistCoef
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected BotPointControl PointControl
	{
		 get { } //Length: 39
	}

	public bool WasCutted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public PatrolPointChooserBasic(BotOwner owner) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__26_0(PatrolWay x) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__26_1(PatrolWay x) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__26_2(PatrolWay x) { }

	public override void ChooseStartWay() { }

	public void Disable() { }

	public override void Dispose() { }

	public override PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	public PatrolPointContainer FindPointForFollower(IBotOwner follower, PatrolWay way) { }

	protected PatrolPathControl get_PathControl() { }

	[CompilerGenerated]
	public float get_PathDistCoef() { }

	protected BotPointControl get_PointControl() { }

	[CompilerGenerated]
	public bool get_WasCutted() { }

	protected PatrolPointContainer GetTargetNext() { }

	public override bool IsWaySuitableByNameId(string nameId) { }

	protected void LogPatrolData() { }

	public void NextPointDecision(Action callback) { }

	[CompilerGenerated]
	protected void set_PathDistCoef(float value) { }

	[CompilerGenerated]
	protected void set_WasCutted(bool value) { }

	public override void ShallChangeWay(bool force = false) { }

	protected override bool TryToFindWay(out PatrolWay way, out float delta) { }

}

