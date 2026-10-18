//Type is in global namespace

public class BossSectantPriestCrossSanitar : BossWithStayFollowersPosition, IBossSanitar, IBossKojaniy
{
	[CompilerGenerated]
	private Action OnPositionsRecalculated; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnThrowRequest; //Field offset: 0x58
	[CompilerGenerated]
	private readonly Vector3 <LootPosition>k__BackingField; //Field offset: 0x60

	public virtual event Action OnPositionsRecalculated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action OnThrowRequest
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override Vector3 LootPosition
	{
		[CompilerGenerated]
		 get { } //Length: 19
	}

	public override bool ShallAttack
	{
		 get { } //Length: 3
	}

	public BossSectantPriestCrossSanitar(BotOwner owner, BotBoss bossLogic) { }

	[CompilerGenerated]
	public virtual void add_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public override void add_OnThrowRequest(Action value) { }

	public virtual void BossLogicUpdate() { }

	public override bool CanStartSuppress() { }

	public override bool CanStartUseStimulator() { }

	protected virtual void FindPositionsForFollowers(bool b) { }

	[CompilerGenerated]
	public override Vector3 get_LootPosition() { }

	public override bool get_ShallAttack() { }

	public virtual Vector3 GetTargetToLook() { }

	public override bool ISeeEnemy() { }

	public override bool IsNearLoot(EnemyInfo enemy) { }

	public override bool IsRunning() { }

	[CompilerGenerated]
	public virtual void remove_OnPositionsRecalculated(Action value) { }

	[CompilerGenerated]
	public override void remove_OnThrowRequest(Action value) { }

	public override void SetFightPosition(bool b, BotOwner owner) { }

	protected virtual void SetLogicToFollower(SectantPrizrakLayersStrategy followerLogic) { }

	public virtual void SetPatrolMode() { }

	public override void SetWannaFight() { }

	public override void SomebodyUseStimulator() { }

	public override void SupressRequestTaken() { }

	public override bool TooManyEnemies() { }

	public override void WantAskHeal(BotOwner owner) { }

}

