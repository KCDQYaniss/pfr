namespace EFT.GlobalEvents.AudioEvents;

public class FirefightDirectorGunfireEvent : BaseEvent
{
	[CompilerGenerated]
	private FirefightAreaController <Source>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector3 <Pos>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Shots>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private double <TimeSec>k__BackingField; //Field offset: 0x30

	public private Vector3 Pos
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private int Shots
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private FirefightAreaController Source
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private double TimeSec
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public FirefightDirectorGunfireEvent() { }

	[CompilerGenerated]
	public Vector3 get_Pos() { }

	[CompilerGenerated]
	public int get_Shots() { }

	[CompilerGenerated]
	public FirefightAreaController get_Source() { }

	[CompilerGenerated]
	public double get_TimeSec() { }

	public void Invoke(FirefightAreaController source, Vector3 pos, int shots, double timeSec) { }

	public virtual void Reset() { }

	[CompilerGenerated]
	private void set_Pos(Vector3 value) { }

	[CompilerGenerated]
	private void set_Shots(int value) { }

	[CompilerGenerated]
	private void set_Source(FirefightAreaController value) { }

	[CompilerGenerated]
	private void set_TimeSec(double value) { }

}

