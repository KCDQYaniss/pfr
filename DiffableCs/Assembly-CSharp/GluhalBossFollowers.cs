//Type is in global namespace

public class GluhalBossFollowers : BotBossFollowers
{
	public const string COMEZONE_TO_REINFORSMENTS_ID = "TrainZone"; //Field offset: 0x0
	public const string EVENT_TO_REINFORSMENTS_ID = "455"; //Field offset: 0x0
	public const int EXIT_TO_REINFORSMENTS_ID = 435; //Field offset: 0x0
	private bool _reinforsmentsByCountComplete; //Field offset: 0x30
	private bool _canUseReinforsments; //Field offset: 0x31
	private readonly Dictionary _curtCount; //Field offset: 0x38
	private readonly Dictionary _targetCount; //Field offset: 0x40

	public int ASSAULT
	{
		 get { } //Length: 56
	}

	public int SCOUT
	{
		 get { } //Length: 56
	}

	public int SECURITY
	{
		 get { } //Length: 56
	}

	public int SNIPE
	{
		 get { } //Length: 56
	}

	public virtual int TargetFollowersCount
	{
		 get { } //Length: 126
	}

	public GluhalBossFollowers(BotOwner owner) { }

	public virtual void Activate() { }

	public virtual void AddFollower(IBotOwner botFollower) { }

	private void AskReinforcements() { }

	public virtual void CheckFollowers() { }

	public virtual void Clear() { }

	public virtual List DebugInfo() { }

	public virtual void Dispose() { }

	public int get_ASSAULT() { }

	public int get_SCOUT() { }

	public int get_SECURITY() { }

	public int get_SNIPE() { }

	public virtual int get_TargetFollowersCount() { }

	private void OnEvent(string obj) { }

	private void OnExitActivated(int obj) { }

	private void OnReinforcementsTime() { }

	private void PlayerComeToPlace(string obj) { }

	public virtual void Remove(BotOwner botFollower) { }

}

