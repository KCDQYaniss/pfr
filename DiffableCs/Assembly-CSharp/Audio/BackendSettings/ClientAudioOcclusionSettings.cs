namespace Audio.BackendSettings;

public class ClientAudioOcclusionSettings
{
	public LocationOcclusionBackendSettings locationOcclusionSettings; //Field offset: 0x10
	public AudioGroupOcclusionBackendSettings[] audioGroupOcclusionSettings; //Field offset: 0x18
	private Dictionary _audioGroupOcclusionSettingsMap; //Field offset: 0x20

	public ClientAudioOcclusionSettings() { }

	public bool TryGetSettingsForGroup(AudioSourceGroupType groupType, out string jsonSettings) { }

}

