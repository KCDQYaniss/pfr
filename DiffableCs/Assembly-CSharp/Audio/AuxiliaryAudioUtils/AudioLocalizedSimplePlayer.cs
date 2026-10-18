namespace Audio.AuxiliaryAudioUtils;

[RequireComponent(typeof(AudioSource))]
public class AudioLocalizedSimplePlayer : MonoBehaviour
{
	private struct LocalizedClip
	{
		public string language; //Field offset: 0x0
		public AudioClip clip; //Field offset: 0x8

	}

	[SerializeField]
	private bool _playOnAwake; //Field offset: 0x20
	[SerializeField]
	private AudioSource _source; //Field offset: 0x28
	[SerializeField]
	private LocalizedClip[] _localizedClips; //Field offset: 0x30
	[SerializeField]
	private AudioClip _defaultClip; //Field offset: 0x38

	public AudioLocalizedSimplePlayer() { }

	private void Awake() { }

	public void Play() { }

	private void Start() { }

}

