namespace Audio;

[RequireComponent(typeof(GenericEventTranslator))]
public class AnimationEventSoundPlayer : MonoBehaviour
{
	private struct PlayConfig
	{
		public string ID; //Field offset: 0x0
		public AudioClip audioClip; //Field offset: 0x8
		[Range(0, 1)]
		public float volume; //Field offset: 0x10
		public AudioSourceGroupType groupType; //Field offset: 0x14
		public int rollOff; //Field offset: 0x18
		public float pitch; //Field offset: 0x1C
		public bool spatialize; //Field offset: 0x20
		public EOcclusionTest occlusionTest; //Field offset: 0x24
		public AudioMixerGroup mixerGroup; //Field offset: 0x28
		public AnimationCurve spreadCurve; //Field offset: 0x30
		public bool enableHighPassFilter; //Field offset: 0x38

	}

	[SerializeField]
	private PlayConfig[] _soundsPool; //Field offset: 0x20
	[SerializeField]
	private Transform _soundOverrideTransform; //Field offset: 0x28
	private GenericEventTranslator _eventTranslator; //Field offset: 0x30
	private readonly Dictionary _soundsPoolByID; //Field offset: 0x38

	public AnimationEventSoundPlayer() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void SoundPlayHandler(string soundName) { }

}

