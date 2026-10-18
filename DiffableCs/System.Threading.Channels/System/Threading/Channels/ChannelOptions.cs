namespace System.Threading.Channels;

public abstract class ChannelOptions
{
	[CompilerGenerated]
	private bool <SingleWriter>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <SingleReader>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <AllowSynchronousContinuations>k__BackingField; //Field offset: 0x12

	public bool AllowSynchronousContinuations
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool SingleReader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool SingleWriter
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected ChannelOptions() { }

	[CompilerGenerated]
	public bool get_AllowSynchronousContinuations() { }

	[CompilerGenerated]
	public bool get_SingleReader() { }

	[CompilerGenerated]
	public void set_AllowSynchronousContinuations(bool value) { }

	[CompilerGenerated]
	public void set_SingleReader(bool value) { }

	[CompilerGenerated]
	public void set_SingleWriter(bool value) { }

}

