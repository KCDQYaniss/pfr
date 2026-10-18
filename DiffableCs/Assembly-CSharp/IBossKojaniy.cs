//Type is in global namespace

public interface IBossKojaniy
{

	public event Action OnThrowRequest
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool EnoughtHaveGoodCovers
	{
		 get { } //Length: 0
	}

	public Vector3 LootPosition
	{
		 get { } //Length: 0
	}

	public bool ShallAttack
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnThrowRequest(Action value) { }

	public bool CanStartSuppress() { }

	public Dictionary FollowersPositions() { }

	public bool get_EnoughtHaveGoodCovers() { }

	public Vector3 get_LootPosition() { }

	public bool get_ShallAttack() { }

	public Vector3 GetTargetToLook() { }

	public bool ISeeEnemy() { }

	public bool IsNearLoot(EnemyInfo enemy) { }

	public bool IsRunning() { }

	[CompilerGenerated]
	public void remove_OnThrowRequest(Action value) { }

	public void SetHaveGoodCover(BotOwner owner, bool haveGoodCover) { }

	public void SetWannaFight() { }

	public void SupressRequestTaken() { }

	public bool TooManyEnemies() { }

}

