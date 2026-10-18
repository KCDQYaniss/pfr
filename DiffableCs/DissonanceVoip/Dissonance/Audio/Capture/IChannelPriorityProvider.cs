namespace Dissonance.Audio.Capture;

internal interface IChannelPriorityProvider
{

	public ChannelPriority DefaultChannelPriority
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ChannelPriority get_DefaultChannelPriority() { }

	public void set_DefaultChannelPriority(ChannelPriority value) { }

}

