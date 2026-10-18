namespace Audio.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/SoundBankWithSettings", fileName = "SoundBankWithSettings")]
public class SoundBankWithSettings : ScriptableObject
{
	[SerializeField]
	private List Clips; //Field offset: 0x18
	[Range(0, 5)]
	public int Importance; //Field offset: 0x20
	[Range(0, 1)]
	public float BaseVolume; //Field offset: 0x24
	[Range(0, 1000)]
	public float Rolloff; //Field offset: 0x28
	private List _excludedClips; //Field offset: 0x30
	private List _includedClips; //Field offset: 0x38

	public SoundBankWithSettings() { }

	private AudioClip GetCommonRandomClip() { }

	private AudioClip GetRandomClipWithExclusion() { }

	private void ResetData() { }

	public bool TryGetRandomClip(out AudioClip clip, bool ignoreExcluded = false) { }

}

