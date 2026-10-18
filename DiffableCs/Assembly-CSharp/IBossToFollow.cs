//Type is in global namespace

public interface IBossToFollow
{

	public List Followers
	{
		 get { } //Length: 0
	}

	public int FollowersTargetCount
	{
		 get { } //Length: 0
	}

	public bool IsAI
	{
		 get { } //Length: 0
	}

	public bool IsAlive
	{
		 get { } //Length: 0
	}

	public float MoveSpeed
	{
		 get { } //Length: 0
	}

	public bool NeedProtection
	{
		 get { } //Length: 0
	}

	public PatrollingData PatrollingData
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Vector3 PositionIfInCover
	{
		 get { } //Length: 0
	}

	public Vector3 PositionOrTargetCover
	{
		 get { } //Length: 0
	}

	public EnemyInfo CurEnemy() { }

	public List get_Followers() { }

	public int get_FollowersTargetCount() { }

	public bool get_IsAI() { }

	public bool get_IsAlive() { }

	public float get_MoveSpeed() { }

	public bool get_NeedProtection() { }

	public PatrollingData get_PatrollingData() { }

	public Vector3 get_Position() { }

	public Vector3 get_PositionIfInCover() { }

	public Vector3 get_PositionOrTargetCover() { }

	public ABossLogic GetBossLogic() { }

	public IBotOwner GetFirstFollower(bool withGrenade) { }

	public PatrolPoint GetPatrolPosByIndex(int botFollowerIndex) { }

	public bool IsMe(IPlayer player) { }

	public IPlayer Player() { }

	public void RemoveFollower(BotOwner owner) { }

}

