namespace Dissonance;

public struct RemoteChannel
{
	private readonly string _target; //Field offset: 0x0
	private readonly ChannelType _type; //Field offset: 0x8
	private readonly PlaybackOptions _options; //Field offset: 0xC

	public PlaybackOptions Options
	{
		 get { } //Length: 19
	}

	public string TargetName
	{
		 get { } //Length: 4
	}

	public ChannelType Type
	{
		 get { } //Length: 4
	}

	internal RemoteChannel(string targetName, ChannelType type, PlaybackOptions options) { }

	public PlaybackOptions get_Options() { }

	public string get_TargetName() { }

	public ChannelType get_Type() { }

}

