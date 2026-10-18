namespace EFT.Hideout;

public interface IAudioPlaybackSettings
{

	public void Pause(AudioArray audioArray) { }

	public void Play(AudioArray audioArray, ELightStatus status, bool firstStart) { }

}

