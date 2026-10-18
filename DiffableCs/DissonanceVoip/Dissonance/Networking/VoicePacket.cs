namespace Dissonance.Networking;

public struct VoicePacket
{
	public readonly string SenderPlayerId; //Field offset: 0x0
	public readonly ArraySegment EncodedAudioFrame; //Field offset: 0x8
	public readonly uint SequenceNumber; //Field offset: 0x18
	[CanBeNull]
	public readonly List Channels; //Field offset: 0x20
	private readonly PlaybackOptions _options; //Field offset: 0x28

	[Obsolete("Use `PlaybackOptions.AmplitudeMultiplier` property")]
	public float AmplitudeMultiplier
	{
		 get { } //Length: 14
	}

	public PlaybackOptions PlaybackOptions
	{
		 get { } //Length: 19
	}

	[Obsolete("Use `PlaybackOptions.IsPositional` property")]
	public bool Positional
	{
		 get { } //Length: 23
	}

	[Obsolete("Use `PlaybackOptions.Priority` property")]
	public ChannelPriority Priority
	{
		 get { } //Length: 12
	}

	public VoicePacket(string senderPlayerId, ChannelPriority priority, float ampMul, bool positional, ArraySegment encodedAudioFrame, uint sequence, List channels = null) { }

	public float get_AmplitudeMultiplier() { }

	public PlaybackOptions get_PlaybackOptions() { }

	public bool get_Positional() { }

	public ChannelPriority get_Priority() { }

}

