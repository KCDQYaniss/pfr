namespace UnityDiagnostics;

public class NetworkQuality
{
	[CompilerGenerated]
	private AvgMeasurer <PacketsQueueCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AvgMeasurer <ReceivedPacketsCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private AvgMeasurer <ProcessedPacketsCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private AvgMeasurer <SkippedPacketsCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private AvgMeasurer <UnprocessedPacketsCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private MaxMeasurer <MaxPacketsQueueCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private MaxMeasurer <MaxPacketsQueueTime>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private MaxMeasurer <MaxRtt>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private MaxMeasurer <MaxLoss>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private MaxMeasurer <MaxClientServerTimeDiff>k__BackingField; //Field offset: 0x58
	private Dictionary _maxClientServerTimeDiffByPlayer; //Field offset: 0x60

	public private MaxMeasurer MaxClientServerTimeDiff
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public uint[] MaxClientServerTimeDiffByPlayerValues
	{
		 get { } //Length: 223
	}

	public private MaxMeasurer MaxLoss
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private MaxMeasurer MaxPacketsQueueCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private MaxMeasurer MaxPacketsQueueTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private MaxMeasurer MaxRtt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AvgMeasurer PacketsQueueCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AvgMeasurer ProcessedPacketsCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AvgMeasurer ReceivedPacketsCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AvgMeasurer SkippedPacketsCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AvgMeasurer UnprocessedPacketsCount
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public NetworkQuality() { }

	public void Commit() { }

	public void CreateMeasurers() { }

	[CompilerGenerated]
	public MaxMeasurer get_MaxClientServerTimeDiff() { }

	public uint[] get_MaxClientServerTimeDiffByPlayerValues() { }

	[CompilerGenerated]
	public MaxMeasurer get_MaxLoss() { }

	[CompilerGenerated]
	public MaxMeasurer get_MaxPacketsQueueCount() { }

	[CompilerGenerated]
	public MaxMeasurer get_MaxPacketsQueueTime() { }

	[CompilerGenerated]
	public MaxMeasurer get_MaxRtt() { }

	[CompilerGenerated]
	public AvgMeasurer get_PacketsQueueCount() { }

	[CompilerGenerated]
	public AvgMeasurer get_ProcessedPacketsCount() { }

	[CompilerGenerated]
	public AvgMeasurer get_ReceivedPacketsCount() { }

	[CompilerGenerated]
	public AvgMeasurer get_SkippedPacketsCount() { }

	[CompilerGenerated]
	public AvgMeasurer get_UnprocessedPacketsCount() { }

	[CompilerGenerated]
	private void set_MaxClientServerTimeDiff(MaxMeasurer value) { }

	[CompilerGenerated]
	private void set_MaxLoss(MaxMeasurer value) { }

	[CompilerGenerated]
	private void set_MaxPacketsQueueCount(MaxMeasurer value) { }

	[CompilerGenerated]
	private void set_MaxPacketsQueueTime(MaxMeasurer value) { }

	[CompilerGenerated]
	private void set_MaxRtt(MaxMeasurer value) { }

	[CompilerGenerated]
	private void set_PacketsQueueCount(AvgMeasurer value) { }

	[CompilerGenerated]
	private void set_ProcessedPacketsCount(AvgMeasurer value) { }

	[CompilerGenerated]
	private void set_ReceivedPacketsCount(AvgMeasurer value) { }

	[CompilerGenerated]
	private void set_SkippedPacketsCount(AvgMeasurer value) { }

	[CompilerGenerated]
	private void set_UnprocessedPacketsCount(AvgMeasurer value) { }

	public virtual string ToString() { }

	public void TrackMaxClientServerTimeDiffByPlayer(string player, uint value) { }

}

