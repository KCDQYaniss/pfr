namespace Dissonance.Audio.Playback;

internal interface IVoicePlaybackInternal : IRemoteChannelProvider, IVoicePlayback
{

	public bool AllowPositionalPlayback
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public AudioSource AudioSource
	{
		 get { } //Length: 0
	}

	public bool IsApplyingAudioSpatialization
	{
		 get { } //Length: 0
	}

	public bool IsMuted
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float PlaybackVolume
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void ForceReset() { }

	public bool get_AllowPositionalPlayback() { }

	public AudioSource get_AudioSource() { }

	public bool get_IsApplyingAudioSpatialization() { }

	public bool get_IsMuted() { }

	public float get_PlaybackVolume() { }

	public void ReceiveAudioPacket(VoicePacket packet) { }

	public void Reset() { }

	public void set_AllowPositionalPlayback(bool value) { }

	public void set_IsMuted(bool value) { }

	public void set_PlaybackVolume(float value) { }

	public void SetTransform(Vector3 position, Quaternion rotation) { }

	public void StartPlayback() { }

	public void StopPlayback() { }

}

