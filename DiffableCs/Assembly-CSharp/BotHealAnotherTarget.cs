//Type is in global namespace

public class BotHealAnotherTarget : BotData
{
	private const float MAX_SDIST_TO_START_HEAL = 4; //Field offset: 0x0
	public IPlayer Target; //Field offset: 0x18
	private float _nextPosible; //Field offset: 0x20
	private float _askTime; //Field offset: 0x24
	[CompilerGenerated]
	private Action OnHealAsked; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsInProcess>k__BackingField; //Field offset: 0x30

	public event Action OnHealAsked
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool IsInProcess
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotHealAnotherTarget(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnHealAsked(Action value) { }

	[CompilerGenerated]
	public bool get_IsInProcess() { }

	public void HealAsk(IPlayer target) { }

	private void HealComplete(bool isOok) { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	public void remove_OnHealAsked(Action value) { }

	[CompilerGenerated]
	private void set_IsInProcess(bool value) { }

	public bool ShallDoHeal() { }

}

