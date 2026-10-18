namespace Audio.AmbientSubsystem;

public class AmbientSoundPlayerCulling : AudioCullingManager
{

	public AmbientSoundPlayerCulling() { }

	protected virtual AmbientSoundPlayerCullingHandler CreateHandler(AudioSourcePriorityCalculator priorityCalculator) { }

}

