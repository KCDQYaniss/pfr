//Type is in global namespace

public class AIBossPlayer : IBossToFollow
{
	private readonly Player _player; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IAmBoos>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private PatrollingData <PatrollingData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List <Followers>k__BackingField; //Field offset: 0x28

	public override List Followers
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override int FollowersTargetCount
	{
		 get { } //Length: 6
	}

	public bool IAmBoos
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool IsAI
	{
		 get { } //Length: 3
	}

	public override bool IsAlive
	{
		 get { } //Length: 90
	}

	public override float MoveSpeed
	{
		 get { } //Length: 9
	}

	public override bool NeedProtection
	{
		 get { } //Length: 3
	}

	public private override PatrollingData PatrollingData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Vector3 Position
	{
		 get { } //Length: 83
	}

	public override Vector3 PositionIfInCover
	{
		 get { } //Length: 83
	}

	public override Vector3 PositionOrTargetCover
	{
		 get { } //Length: 83
	}

	public AIBossPlayer(Player player) { }

	public override EnemyInfo CurEnemy() { }

	public void Dispose() { }

	[CompilerGenerated]
	public override List get_Followers() { }

	public override int get_FollowersTargetCount() { }

	[CompilerGenerated]
	public bool get_IAmBoos() { }

	public override bool get_IsAI() { }

	public override bool get_IsAlive() { }

	public override float get_MoveSpeed() { }

	public override bool get_NeedProtection() { }

	[CompilerGenerated]
	public override PatrollingData get_PatrollingData() { }

	public override Vector3 get_Position() { }

	public override Vector3 get_PositionIfInCover() { }

	public override Vector3 get_PositionOrTargetCover() { }

	public override ABossLogic GetBossLogic() { }

	public override IBotOwner GetFirstFollower(bool withGrenade) { }

	public override PatrolPoint GetPatrolPosByIndex(int botFollowerIndex) { }

	public override bool IsMe(IPlayer player) { }

	public void OfferBot(BotOwner bot) { }

	public override IPlayer Player() { }

	public override void RemoveFollower(BotOwner owner) { }

	[CompilerGenerated]
	private void set_PatrollingData(PatrollingData value) { }

}

