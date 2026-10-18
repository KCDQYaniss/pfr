//Type is in global namespace

public class BotTacticData : BotData
{
	public float AggressionCoef; //Field offset: 0x18
	private bool _shallReturnToAttack; //Field offset: 0x1C
	private float _returnToAttackTime; //Field offset: 0x20
	[CompilerGenerated]
	private BotSubTactic <SubTactic>k__BackingField; //Field offset: 0x28

	public private BotSubTactic SubTactic
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotCurrentTactic Tactic
	{
		 get { } //Length: 26
	}

	public BotTacticData(BotOwner owner) { }

	public void Activate() { }

	public void AggressionChange(float val) { }

	public void Dispose() { }

	[CompilerGenerated]
	public BotSubTactic get_SubTactic() { }

	public BotCurrentTactic get_Tactic() { }

	public bool IsCurTactic(BotCurrentTactic tactic) { }

	[CompilerGenerated]
	private void set_SubTactic(BotSubTactic value) { }

	private void SetPrevTactic() { }

	public void SetTactic(BotCurrentTactic tactic, bool shallAutoReturnToAttack = false, float delta = -1) { }

	public void UpdateChangeTactics() { }

}

