namespace Audio.ConfiguredAudioPlayer;

public interface IConfiguredAudioPlayer
{

	public void Play(AudioClipConfig config, bool force = false) { }

	public void Release(bool allowFadeout = false, Action onReleased = null) { }

	public void Stop(bool allowFadeout = false, Action onStopped = null) { }

}

