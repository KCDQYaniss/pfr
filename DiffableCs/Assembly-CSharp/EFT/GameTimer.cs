namespace EFT;

public sealed class GameTimer
{
	internal enum EGameTimerStatus
	{
		Unknown = 0,
		Started = 1,
		Stopped = 2,
	}

	private Nullable _start; //Field offset: 0x10
	private Nullable _escape; //Field offset: 0x20
	private Nullable _stop; //Field offset: 0x30
	[CompilerGenerated]
	private EGameTimerStatus <Status>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable <SessionTime>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action StartedEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action StoppedEvent; //Field offset: 0x60
	[CompilerGenerated]
	private Action SessionTimeChanged; //Field offset: 0x68

	public event Action SessionTimeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action StartedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action StoppedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public Nullable EscapeDateTime
	{
		 get { } //Length: 11
	}

	public TimeSpan PastTime
	{
		 get { } //Length: 7
	}

	public private Nullable SessionTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public Nullable StartDateTime
	{
		 get { } //Length: 11
	}

	public private EGameTimerStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DateTime StopDateTime
	{
		 get { } //Length: 62
	}

	public GameTimer(Nullable sessionTime) { }

	[CompilerGenerated]
	public void add_SessionTimeChanged(Action value) { }

	[CompilerGenerated]
	public void add_StartedEvent(Action value) { }

	[CompilerGenerated]
	public void add_StoppedEvent(Action value) { }

	public void ChangeSessionTime(TimeSpan sessionTime) { }

	public Nullable get_EscapeDateTime() { }

	public TimeSpan get_PastTime() { }

	[CompilerGenerated]
	public Nullable get_SessionTime() { }

	public Nullable get_StartDateTime() { }

	[CompilerGenerated]
	public EGameTimerStatus get_Status() { }

	public DateTime get_StopDateTime() { }

	private TimeSpan GetPastTime() { }

	[CompilerGenerated]
	public void remove_SessionTimeChanged(Action value) { }

	[CompilerGenerated]
	public void remove_StartedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_StoppedEvent(Action value) { }

	[CompilerGenerated]
	private void set_SessionTime(Nullable value) { }

	[CompilerGenerated]
	private void set_Status(EGameTimerStatus value) { }

	public void Start(Nullable startTime = null, Nullable sessionTime = null) { }

	public void Stop() { }

}

