namespace EFT;

public interface IEffectAudioPlayer : IDisposable
{

	public void Play() { }

	public void ResetCounter() { }

	public void SetTickPerPlay(int ticks) { }

	public void Stop() { }

}

