namespace Dissonance;

public interface IDissonancePlayer
{

	public bool IsTracking
	{
		 get { } //Length: 0
	}

	public string PlayerId
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
	}

	public Quaternion Rotation
	{
		 get { } //Length: 0
	}

	public NetworkPlayerType Type
	{
		 get { } //Length: 0
	}

	public AudioSource VoipAudioSource
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_IsTracking() { }

	public string get_PlayerId() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public NetworkPlayerType get_Type() { }

	public AudioSource get_VoipAudioSource() { }

	public void set_VoipAudioSource(AudioSource value) { }

}

