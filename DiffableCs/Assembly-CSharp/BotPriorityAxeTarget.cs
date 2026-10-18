//Type is in global namespace

public class BotPriorityAxeTarget : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public EnemyInfo closestPerson; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <FindTarget>b__0(GroupPoint point) { }

	}

	private const float NOT_BOSS_ALL_PERSIUT_RAD = 200; //Field offset: 0x0
	private const float CHECK_PERIOD = 2; //Field offset: 0x0
	private const float Y_DELTA = 1.5; //Field offset: 0x0
	private float _lostPeriodAxeTarget; //Field offset: 0x18
	private float _nextCheckPeriod; //Field offset: 0x1C
	private float _nextGo; //Field offset: 0x20
	private float _runDist; //Field offset: 0x24
	private float _runSDist; //Field offset: 0x28
	private CustomNavigationPoint _closestPoint; //Field offset: 0x30
	private EnemyInfo _closestPerson; //Field offset: 0x38
	private bool _allPursuit; //Field offset: 0x40
	private float _curDistPursuit; //Field offset: 0x44
	private HashSet _persuitTypes; //Field offset: 0x48
	private Dictionary _personalPersuitDistance; //Field offset: 0x50
	private float _possibleRadiusLostTime; //Field offset: 0x58

	public bool AllPursuit
	{
		 get { } //Length: 5
		 set { } //Length: 705
	}

	public bool HavePointToGo
	{
		 get { } //Length: 9
	}

	public BotPriorityAxeTarget(BotOwner owner) { }

	public void FindTarget() { }

	public bool get_AllPursuit() { }

	public bool get_HavePointToGo() { }

	public bool HavePersonalPersuitDistance(WildSpawnType role, out float f) { }

	public bool IsInPossibleRadius() { }

	public bool IsPointInsideDangerZone() { }

	public void ManualUpdate() { }

	private void MoveCheck() { }

	public void set_AllPursuit(bool value) { }

}

