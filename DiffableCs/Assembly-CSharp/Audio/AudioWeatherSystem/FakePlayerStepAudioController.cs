namespace Audio.AudioWeatherSystem;

public class FakePlayerStepAudioController : IPlayerStepAudioController, IDisposable
{

	public FakePlayerStepAudioController() { }

	public override void Dispose() { }

	public override void Play(EAudioMovementState movementState, EnvironmentType environment, float distance = 0, float baseStepVolume = 1, float blendParameter = 0, bool stereo = false) { }

	public override void UpdateSoundRolloff(float rolloff) { }

	public override void UpdateSurface(ESurfaceSound surface) { }

	public override void UpdateUnderRoofStatus(bool isUnderRoof) { }

}

