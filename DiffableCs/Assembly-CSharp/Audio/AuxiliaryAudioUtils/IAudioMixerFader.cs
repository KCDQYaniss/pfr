namespace Audio.AuxiliaryAudioUtils;

public interface IAudioMixerFader : IDisposable
{

	public bool IsFading
	{
		 get { } //Length: 0
	}

	public bool get_IsFading() { }

	public void StartFade(string mixerParameter, float targetValue, EAudioFadeType fadeType = 0, float duration = 0) { }

	public void StartFade(string mixerParameter, float targetValue, AnimationCurve fadeCurve, float duration = 0) { }

	public void StopFade(string mixerParameter) { }

	public void StopFade() { }

}

