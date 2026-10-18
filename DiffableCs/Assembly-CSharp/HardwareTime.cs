//Type is in global namespace

public class HardwareTime
{
	private const long STOP_WATCH_RESTART_LIMIT_MS = 10800000; //Field offset: 0x0
	private readonly Stopwatch _stopwatch; //Field offset: 0x10
	private long _previousTime; //Field offset: 0x18
	[CompilerGenerated]
	private float <DeltaTime>k__BackingField; //Field offset: 0x20

	public private float DeltaTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public HardwareTime() { }

	[CompilerGenerated]
	public float get_DeltaTime() { }

	public void RecordDeltaTime() { }

	[CompilerGenerated]
	private void set_DeltaTime(float value) { }

}

