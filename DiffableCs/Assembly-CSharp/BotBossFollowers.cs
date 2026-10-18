//Type is in global namespace

public class BotBossFollowers : BotData
{
	protected const float DELTA_FOLLOWERS_CHECK = 15; //Field offset: 0x0
	protected const float DELTA_FOLLOWERS_CLOSE = 0.97; //Field offset: 0x0
	protected float _nextTimeCheckFollowers; //Field offset: 0x18
	protected float _nextTimeCheckClose; //Field offset: 0x1C
	protected List _followers; //Field offset: 0x20
	[CompilerGenerated]
	private int <TargetFollowersCount>k__BackingField; //Field offset: 0x28

	public override List Followers
	{
		 get { } //Length: 5
	}

	public override int TargetFollowersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BotBossFollowers(BotOwner owner) { }

	public override void Activate() { }

	public override void AddFollower(IBotOwner botFollower) { }

	public override void CheckFollowers() { }

	public override void Clear() { }

	public override List DebugInfo() { }

	public override void Dispose() { }

	public override List get_Followers() { }

	[CompilerGenerated]
	public override int get_TargetFollowersCount() { }

	public override void Remove(BotOwner botFollower) { }

	[CompilerGenerated]
	protected override void set_TargetFollowersCount(int value) { }

	public void SetTargetFollowersCount(int followersCount) { }

	public void UpdateFollowers() { }

}

