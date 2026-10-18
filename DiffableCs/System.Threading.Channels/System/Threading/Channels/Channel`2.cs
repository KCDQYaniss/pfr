namespace System.Threading.Channels;

[Nullable(0)]
[NullableContext(1)]
public abstract class Channel`2
{
	[CompilerGenerated]
	private ChannelReader <Reader>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ChannelWriter <Writer>k__BackingField; //Field offset: 0x0

	public ChannelReader Reader
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ChannelWriter Writer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	protected Channel`2() { }

	[CompilerGenerated]
	public ChannelReader get_Reader() { }

	[CompilerGenerated]
	public ChannelWriter get_Writer() { }

	[CompilerGenerated]
	protected void set_Reader(ChannelReader value) { }

	[CompilerGenerated]
	protected void set_Writer(ChannelWriter value) { }

}

