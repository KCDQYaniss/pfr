namespace EFT.Hideout;

public class ConsumptionTimer
{
	[CompilerGenerated]
	private int <TimerStart>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <TimeLeftFromStart>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; //Field offset: 0x18

	private int CurrentTimeLeft
	{
		private get { } //Length: 171
	}

	public private bool IsRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int TimeLeft
	{
		 get { } //Length: 17
	}

	public private int TimeLeftFromStart
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TimerStart
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ConsumptionTimer() { }

	private int get_CurrentTimeLeft() { }

	[CompilerGenerated]
	public bool get_IsRunning() { }

	public int get_TimeLeft() { }

	[CompilerGenerated]
	public int get_TimeLeftFromStart() { }

	[CompilerGenerated]
	public int get_TimerStart() { }

	public void Pause() { }

	[CompilerGenerated]
	private void set_IsRunning(bool value) { }

	[CompilerGenerated]
	private void set_TimeLeftFromStart(int value) { }

	[CompilerGenerated]
	private void set_TimerStart(int value) { }

	private void SetupTimer(int startTime, int timeLeft) { }

	public void Start(int timeLeft) { }

}

