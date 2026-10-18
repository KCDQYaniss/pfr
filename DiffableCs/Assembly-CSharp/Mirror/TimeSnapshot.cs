namespace Mirror;

public struct TimeSnapshot : Snapshot
{
	[CompilerGenerated]
	private double <remoteTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private double <localTime>k__BackingField; //Field offset: 0x8

	public override double localTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override double remoteTime
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TimeSnapshot(double remoteTime, double localTime) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_localTime() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_remoteTime() { }

	[CompilerGenerated]
	public override void set_localTime(double value) { }

	[CompilerGenerated]
	public override void set_remoteTime(double value) { }

}

