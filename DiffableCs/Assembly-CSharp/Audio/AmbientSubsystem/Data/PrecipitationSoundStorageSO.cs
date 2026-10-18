namespace Audio.AmbientSubsystem.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/PrecipitationSoundStorageSO", fileName = "PrecipitationSoundStorageSO")]
public class PrecipitationSoundStorageSO : ScriptableObject, ISeasonSoundStorage
{
	[SerializeField]
	private PrecipitationSoundStorage _storage; //Field offset: 0x18

	public PrecipitationSoundStorageSO() { }

	public override bool TryGetClip(ESeasonStatus seasonStatus, ERainIntensity type, EnvironmentType environment, out AudioClip clip) { }

}

