//Type is in global namespace

public class PatrolLookAroundSimple : BotData, IPatrolLook
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__8_0(int x) { }

	}

	protected const int angCount = 8; //Field offset: 0x0
	public int[] shuffledDirections; //Field offset: 0x18
	protected BotObserveData botObserveData; //Field offset: 0x20
	protected Vector3 _baseLook; //Field offset: 0x28
	protected float _nextLookPoint; //Field offset: 0x34
	protected float _poseCoef; //Field offset: 0x38
	protected PatrollingData data; //Field offset: 0x40
	protected int _countPointsToLookRemain; //Field offset: 0x48

	public PatrolLookAroundSimple(BotOwner owner, PatrollingData data, BotObserveData botObserveData) { }

	protected float GetLookTime(PatrolPoint point) { }

	public override void SetComeToPoint() { }

	public override void SetDefault(bool max) { }

	protected Vector3 Test4Sides(Vector3 dir, Vector3 headPos) { }

	public override void Update() { }

}

