namespace EFT;

public class LoopedSpeechPlayer
{
	private BetterSource _loopedSource; //Field offset: 0x10
	private bool _isPlaying; //Field offset: 0x18
	private Player _player; //Field offset: 0x20

	public bool IsPlaying
	{
		 get { } //Length: 5
	}

	public LoopedSpeechPlayer() { }

	public void Dispose() { }

	public bool get_IsPlaying() { }

	private void OnFadeOutComplete() { }

	public void Play(Player player, EPhraseTrigger trigger, ETagStatus tags, float volume = 1) { }

	public void Stop(float fadeOut = 0) { }

}

