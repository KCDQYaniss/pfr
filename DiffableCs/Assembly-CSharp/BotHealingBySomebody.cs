//Type is in global namespace

public class BotHealingBySomebody : BotData
{
	private bool _healInProcess; //Field offset: 0x18
	[CompilerGenerated]
	private float <StartWaitHeal>k__BackingField; //Field offset: 0x1C

	public private float StartWaitHeal
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BotHealingBySomebody(BotOwner owner) { }

	[CompilerGenerated]
	public float get_StartWaitHeal() { }

	private void HealComplete() { }

	public void ManualUpdate() { }

	[CompilerGenerated]
	private void set_StartWaitHeal(float value) { }

	public void StartDoHeal() { }

	public void StartWait() { }

}

