namespace EFT;

public class SubtitlesEventFire : MonoBehaviour
{
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x20
	[SerializeField]
	private ESubtitlesSource _source; //Field offset: 0x28
	private bool _audioSourceIsPlaying; //Field offset: 0x2C

	public SubtitlesEventFire() { }

	private void Awake() { }

}

