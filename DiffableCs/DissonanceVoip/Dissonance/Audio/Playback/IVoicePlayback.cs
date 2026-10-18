namespace Dissonance.Audio.Playback;

public interface IVoicePlayback
{

	public float Amplitude
	{
		 get { } //Length: 0
	}

	public bool IsActive
	{
		 get { } //Length: 0
	}

	public bool IsSpeaking
	{
		 get { } //Length: 0
	}

	public float Jitter
	{
		 get { } //Length: 0
	}

	public Nullable PacketLoss
	{
		 get { } //Length: 0
	}

	public string PlayerName
	{
		 get { } //Length: 0
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 0
	}

	public float get_Amplitude() { }

	public bool get_IsActive() { }

	public bool get_IsSpeaking() { }

	public float get_Jitter() { }

	public Nullable get_PacketLoss() { }

	public string get_PlayerName() { }

	public ChannelPriority get_Priority() { }

}

