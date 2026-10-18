namespace Dissonance.Audio.Playback;

public interface IPriorityManager
{

	public ChannelPriority TopPriority
	{
		 get { } //Length: 0
	}

	public ChannelPriority get_TopPriority() { }

}

