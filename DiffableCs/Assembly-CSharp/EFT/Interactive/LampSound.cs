namespace EFT.Interactive;

public class LampSound
{
	private readonly LampController _lampController; //Field offset: 0x10
	private readonly ILampSoundController _soundController; //Field offset: 0x18
	private bool _readyToFlick; //Field offset: 0x20

	public LampSound(LampController lampController, int seed) { }

	public void ContinuePlay() { }

	public void Dispose() { }

	public void PlayAudio(AudioClip clip, bool loop = false) { }

	public void PlayFlickeringSound() { }

	public void PlayTurnOffClip() { }

	public void ProcessTurnOnFlickering(float intensity) { }

	public void ReleaseAudio() { }

	public void StopAudio() { }

}

