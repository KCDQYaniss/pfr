//Type is in global namespace

public class BotSubTactic : BotData
{
	protected BotCurrentTactic _lastTactic; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnTacticChange; //Field offset: 0x20
	[CompilerGenerated]
	private BotCurrentTactic <Tactic>k__BackingField; //Field offset: 0x28

	public event Action OnTacticChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private BotCurrentTactic Tactic
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotSubTactic(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnTacticChange(Action value) { }

	public void Dispose() { }

	[CompilerGenerated]
	public BotCurrentTactic get_Tactic() { }

	[CompilerGenerated]
	public void remove_OnTacticChange(Action value) { }

	public override CoverSearchType SearchRunToCover(CoverShootType shootType) { }

	public override CoverSearchType SearchTypeAttack(CoverShootType shootType) { }

	public override CoverSearchType SearchTypeAttackMoving(CoverShootType shootType) { }

	public override CoverSearchType SearchTypeForCover(CoverShootType shootType) { }

	public override CoverSearchType SearchTypeGoToCover(CoverShootType shootType) { }

	[CompilerGenerated]
	private void set_Tactic(BotCurrentTactic value) { }

	public void SetLastTactic() { }

	public override float SetTactic(BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1) { }

}

