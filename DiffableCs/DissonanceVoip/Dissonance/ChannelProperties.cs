namespace Dissonance;

public sealed class ChannelProperties
{
	private readonly IChannelPriorityProvider _defaultPriority; //Field offset: 0x10
	[CompilerGenerated]
	private ushort <Id>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Positional>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	private ChannelPriority <Priority>k__BackingField; //Field offset: 0x1C
	private float _amplitudeMultiplier; //Field offset: 0x20

	internal float AmplitudeMultiplier
	{
		internal get { } //Length: 6
		internal set { } //Length: 157
	}

	public internal ushort Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public bool Positional
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ChannelPriority Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal ChannelPriority TransmitPriority
	{
		internal get { } //Length: 90
	}

	internal ChannelProperties(IChannelPriorityProvider defaultPriority) { }

	internal float get_AmplitudeMultiplier() { }

	[CompilerGenerated]
	public ushort get_Id() { }

	[CompilerGenerated]
	public bool get_Positional() { }

	[CompilerGenerated]
	public ChannelPriority get_Priority() { }

	internal ChannelPriority get_TransmitPriority() { }

	internal void set_AmplitudeMultiplier(float value) { }

	[CompilerGenerated]
	internal void set_Id(ushort value) { }

	[CompilerGenerated]
	public void set_Positional(bool value) { }

	[CompilerGenerated]
	public void set_Priority(ChannelPriority value) { }

}

