namespace Audio.AutoPanner;

[RequireComponent(typeof(BaseAmbientSoundPlayer), typeof(AudioSource))]
public class AmbientPlayerAutoPanner : MonoBehaviour
{
	[SerializeField]
	private BaseAmbientSoundPlayer _soundPlayer; //Field offset: 0x20
	[SerializeField]
	private AudioSource _source; //Field offset: 0x28
	[Header("Settings")]
	[SerializeField]
	[Space]
	private Vector2 _lChannelPanRange; //Field offset: 0x30
	[SerializeField]
	private Vector2 _rChannelPanRange; //Field offset: 0x38
	private ISoundPanner _panner; //Field offset: 0x40

	public AmbientPlayerAutoPanner() { }

	private void Awake() { }

	private float GetRandomPanValue() { }

	private void OnDestroy() { }

	private void PlayStateHandler() { }

	private void Validate() { }

}

