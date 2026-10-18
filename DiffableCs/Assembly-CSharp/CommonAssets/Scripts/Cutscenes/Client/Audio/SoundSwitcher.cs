namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class SoundSwitcher
{
	private readonly ISpatialAudioRoom _indoorRoom; //Field offset: 0x10
	private readonly ISpatialAudioRoom _outdoorRoom; //Field offset: 0x18
	private ISpatialAudioRoom _currentRoom; //Field offset: 0x20
	private EEnvironmentAction _prevEnvAction; //Field offset: 0x28

	public SoundSwitcher(ISpatialAudioRoom indoorRoom, ISpatialAudioRoom outdoorRoom) { }

	private EnvironmentType GetEnvironmentByAction(EEnvironmentAction action) { }

	private ISpatialAudioRoom GetRoomByEnv(EnvironmentType envType) { }

	public void ResetEnvironment(float transitionTime = 1) { }

	public void SetEnvironment(EEnvironmentAction targetAction, bool enabledHeadphones, float transitionTime = 1) { }

}

