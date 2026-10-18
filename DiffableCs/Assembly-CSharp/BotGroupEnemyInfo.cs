//Type is in global namespace

public class BotGroupEnemyInfo
{
	private static int _nextId; //Field offset: 0x0
	public IPlayer Player; //Field offset: 0x10
	private Vector3 _enemyLastPosition; //Field offset: 0x18
	private Vector3 _enemyLastPositionSense; //Field offset: 0x24
	private readonly BotsGroup _botGroup; //Field offset: 0x30
	private readonly Vector3[] _searchPositions; //Field offset: 0x38
	private float _lastRefreshSearchPositions; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsLastPositionChecked>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private float <LastChangeVisionTime>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <EnemyLastSeenTimeSense>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private float <EnemyLastSeenTimeReal>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Vector3 <SuppressedPos>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private string <LastHostilityRule>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <SuppressedEndTime>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsHaveSeen>k__BackingField; //Field offset: 0x6C
	private int _id; //Field offset: 0x70
	[CompilerGenerated]
	private Vector3 <EnemyWeaponRootLastPos>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private float <LastShootTime>k__BackingField; //Field offset: 0x80

	public Vector3 EnemyLastPosition
	{
		 get { } //Length: 19
		 set { } //Length: 144
	}

	public private float EnemyLastSeenTimeReal
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float EnemyLastSeenTimeSense
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Vector3 EnemyLastVisiblePosition
	{
		 get { } //Length: 19
		 set { } //Length: 140
	}

	public Vector3 EnemyWeaponRootLastPos
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public private bool IsHaveSeen
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsLastPositionChecked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private float LastChangeVisionTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public string LastHostilityRule
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private float LastShootTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	private float SuppressedEndTime
	{
		[CompilerGenerated]
		private get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private Vector3 SuppressedPos
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public BotGroupEnemyInfo(IPlayer player, BotsGroup botGroup) { }

	public void Clear() { }

	public Vector3 get_EnemyLastPosition() { }

	[CompilerGenerated]
	public float get_EnemyLastSeenTimeReal() { }

	[CompilerGenerated]
	public float get_EnemyLastSeenTimeSense() { }

	public Vector3 get_EnemyLastVisiblePosition() { }

	[CompilerGenerated]
	public Vector3 get_EnemyWeaponRootLastPos() { }

	[CompilerGenerated]
	public bool get_IsHaveSeen() { }

	[CompilerGenerated]
	public bool get_IsLastPositionChecked() { }

	[CompilerGenerated]
	public float get_LastChangeVisionTime() { }

	[CompilerGenerated]
	public string get_LastHostilityRule() { }

	[CompilerGenerated]
	public float get_LastShootTime() { }

	[CompilerGenerated]
	private float get_SuppressedEndTime() { }

	[CompilerGenerated]
	public Vector3 get_SuppressedPos() { }

	public Vector3 GetPositionForSearch(int searchIndex) { }

	public bool IsSuppressed() { }

	public void set_EnemyLastPosition(Vector3 value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenTimeReal(float value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenTimeSense(float value) { }

	public void set_EnemyLastVisiblePosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_EnemyWeaponRootLastPos(Vector3 value) { }

	[CompilerGenerated]
	private void set_IsHaveSeen(bool value) { }

	[CompilerGenerated]
	public void set_IsLastPositionChecked(bool value) { }

	[CompilerGenerated]
	private void set_LastChangeVisionTime(float value) { }

	[CompilerGenerated]
	public void set_LastHostilityRule(string value) { }

	[CompilerGenerated]
	private void set_LastShootTime(float value) { }

	[CompilerGenerated]
	private void set_SuppressedEndTime(float value) { }

	[CompilerGenerated]
	private void set_SuppressedPos(Vector3 value) { }

	public void SetLastShootTime() { }

	public void SetLastVisionChange(float lastChangeVisionTime) { }

	public void SetSuppressEndTime(float suppressedEndTime) { }

	public bool ShallISuppress() { }

	public void Sync(EnemyInfo info) { }

}

