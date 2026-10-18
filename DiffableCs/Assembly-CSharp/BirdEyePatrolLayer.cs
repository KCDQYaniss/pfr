//Type is in global namespace

public class BirdEyePatrolLayer : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public BirdEyePatrolLayer <>4__this; //Field offset: 0x10
		public int maxFarDist; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal bool <ChoosePointsToPatrol>b__0(GroupPoint x) { }

	}

	private const int MIN_COUNT_TO_RND = 2; //Field offset: 0x0
	private List _listToRefresh; //Field offset: 0x90
	private CustomNavigationPoint _lastChoose; //Field offset: 0x98
	private float _lastTimeChoose; //Field offset: 0xA0
	private readonly float _maxSDist; //Field offset: 0xA4
	private readonly float _minSDist; //Field offset: 0xA8
	private float _startHoldTime; //Field offset: 0xAC
	private float _nextCheckReload; //Field offset: 0xB0
	private float _nextEndHoldCheck; //Field offset: 0xB4
	private readonly bool _controlY; //Field offset: 0xB8
	private readonly bool _controlDist; //Field offset: 0xB9
	private readonly ECoverPointSpecial _specialsToEvade; //Field offset: 0xBC
	private readonly bool _noChecks; //Field offset: 0xC0
	private readonly bool _haveSpecials; //Field offset: 0xC1

	private bool WannaMeds
	{
		private get { } //Length: 146
	}

	public BirdEyePatrolLayer(BotOwner bot, int priority, ECoverPatrolControls controls, float minDist, float maxDist, ECoverPointSpecial specialsToEvade) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__24_0(GroupPoint x) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__24_1(GroupPoint x) { }

	[CompilerGenerated]
	private bool <RefreshNewPoint>b__24_2(GroupPoint x) { }

	private void ChoosePointsToPatrol() { }

	protected virtual AICoreActionEnd EndHeal() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private bool get_WannaMeds() { }

	public virtual AICoreActionResult GetDecision() { }

	private bool IsGoodForBoss(Vector3 point, float minDist, float maxDist) { }

	private bool IsGoodSpecial(GroupPoint point) { }

	private bool LongTimeAtPoint(float period) { }

	public virtual string Name() { }

	private void RefreshNewPoint() { }

	public virtual bool ShallUseNow() { }

	private int SortByYPos(GroupPoint pointA, GroupPoint pointB) { }

}

