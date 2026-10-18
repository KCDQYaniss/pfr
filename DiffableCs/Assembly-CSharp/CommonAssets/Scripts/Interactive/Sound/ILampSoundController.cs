namespace CommonAssets.Scripts.Interactive.Sound;

public interface ILampSoundController : IDisposable
{

	public bool Enabled
	{
		 get { } //Length: 0
	}

	public bool IsLoop
	{
		 get { } //Length: 0
	}

	public bool IsPlaying
	{
		 get { } //Length: 0
	}

	public void ContinuePlay() { }

	public bool get_Enabled() { }

	public bool get_IsLoop() { }

	public bool get_IsPlaying() { }

	public void Play(AudioClip clip, float volume, bool loop = false) { }

	public void Release() { }

	public void SetPitch(int seed, float pitch) { }

	public void Stop() { }

}

