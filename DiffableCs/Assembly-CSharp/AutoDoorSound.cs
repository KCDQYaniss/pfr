//Type is in global namespace

[Obfuscation(Exclude = True)]
public class AutoDoorSound : MonoBehaviour
{
	[SerializeField]
	private AudioClip _openClip; //Field offset: 0x20
	[SerializeField]
	private AudioClip _closeClip; //Field offset: 0x28
	[Range(0, 1)]
	[SerializeField]
	private float _volume; //Field offset: 0x30
	[SerializeField]
	private int _rolloff; //Field offset: 0x34

	public AutoDoorSound() { }

	[Obfuscation(Exclude = True)]
	private void OnStartClose() { }

	[Obfuscation(Exclude = True)]
	private void OnStartOpen() { }

	private void PlaySound(AudioClip clip) { }

}

