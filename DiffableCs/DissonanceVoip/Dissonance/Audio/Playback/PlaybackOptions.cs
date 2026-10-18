namespace Dissonance.Audio.Playback;

public struct PlaybackOptions
{
	private readonly bool _isPositional; //Field offset: 0x0
	private readonly float _amplitudeMultiplier; //Field offset: 0x4
	private readonly ChannelPriority _priority; //Field offset: 0x8

	public float AmplitudeMultiplier
	{
		 get { } //Length: 6
	}

	public bool IsPositional
	{
		 get { } //Length: 4
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 4
	}

	public PlaybackOptions(bool isPositional, float amplitudeMultiplier, ChannelPriority priority) { }

	public float get_AmplitudeMultiplier() { }

	public bool get_IsPositional() { }

	public ChannelPriority get_Priority() { }

}

