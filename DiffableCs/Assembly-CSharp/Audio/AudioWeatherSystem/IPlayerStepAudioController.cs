namespace Audio.AudioWeatherSystem;

public interface IPlayerStepAudioController : IDisposable
{

	public void Play(EAudioMovementState movementState, EnvironmentType environment, float distance = 0, float baseStepVolume = 1, float blendParameter = 0, bool stereo = false) { }

	public void UpdateSoundRolloff(float rolloff) { }

	public void UpdateSurface(ESurfaceSound surface) { }

	public void UpdateUnderRoofStatus(bool isUnderRoof) { }

}

