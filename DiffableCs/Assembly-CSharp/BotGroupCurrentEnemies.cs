//Type is in global namespace

public class BotGroupCurrentEnemies
{
	public int ActiveEnemies; //Field offset: 0x10
	private ITimer _timer; //Field offset: 0x18
	private readonly BotsGroup _group; //Field offset: 0x20
	private readonly float deltaSeen; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnCurrentCheck; //Field offset: 0x30

	public event Action OnCurrentCheck
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BotGroupCurrentEnemies(BotsGroup group) { }

	[CompilerGenerated]
	public void add_OnCurrentCheck(Action value) { }

	private void CheckEnemies() { }

	public void Dispose() { }

	public void GetVision() { }

	public void LoseVision() { }

	private void OnTimerCheck() { }

	[CompilerGenerated]
	public void remove_OnCurrentCheck(Action value) { }

	private void StopTimer() { }

}

