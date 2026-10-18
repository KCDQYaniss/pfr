namespace Audio.AmbientSubsystem.Data;

public interface ISeasonSoundStorage`1
{

	public bool TryGetClip(ESeasonStatus seasonStatus, T type, EnvironmentType environment, out AudioClip clip) { }

}

