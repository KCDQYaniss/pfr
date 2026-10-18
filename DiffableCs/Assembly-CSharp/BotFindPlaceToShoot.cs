//Type is in global namespace

public class BotFindPlaceToShoot : BotData
{
	private readonly float PerfectDist; //Field offset: 0x18
	private readonly float RadCircle; //Field offset: 0x1C
	private float _nextSearch; //Field offset: 0x20
	private readonly float MinDist; //Field offset: 0x24
	private float _angToOffset; //Field offset: 0x28
	private Vector3 _lastDir; //Field offset: 0x2C
	private readonly List _offsets1; //Field offset: 0x38
	private readonly float _periodCheck; //Field offset: 0x40
	private EShootPositionType _shootPositionType; //Field offset: 0x44
	private EBotFindPlaceType _findPlace; //Field offset: 0x48
	private Vector3 _offsetWeapon; //Field offset: 0x4C
	[CompilerGenerated]
	private Nullable <LastGoodPoint>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private ShootToPoint <LastGoodPointShoot>k__BackingField; //Field offset: 0x68

	public private Nullable LastGoodPoint
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private ShootToPoint LastGoodPointShoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EShootPositionType ShootPositionType
	{
		 get { } //Length: 4
	}

	public BotFindPlaceToShoot(BotOwner owner, int dist, int minDist, float periodCheck, EBotFindPlaceType findPlace) { }

	public void Drop() { }

	[CompilerGenerated]
	public Nullable get_LastGoodPoint() { }

	[CompilerGenerated]
	public ShootToPoint get_LastGoodPointShoot() { }

	public EShootPositionType get_ShootPositionType() { }

	public bool IsShootToThis(ShootToPoint pointToTest) { }

	public bool ManualUpdateSearch(ShootToPoint shootTarget, float minEnemyDist, out Vector3 point) { }

	private void RecalcOffsets() { }

	public void Set(EShootPositionType positionType) { }

	[CompilerGenerated]
	private void set_LastGoodPoint(Nullable value) { }

	[CompilerGenerated]
	private void set_LastGoodPointShoot(ShootToPoint value) { }

	private bool TryTestShoot(ShootToPoint shootTarget, float minEnemyDist, out Vector3 point) { }

	private bool Type2PointTest(Vector3 pointToTest, ShootToPoint shoot, out Vector3 navMeshPoint) { }

}

