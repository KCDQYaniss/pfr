namespace Audio.NPC;

public class NPCAudioSourceSpatializeController : MonoBehaviour
{
	[SerializeField]
	private AudioSource _speechSource; //Field offset: 0x20
	[SerializeField]
	private AudioSource _footstepAudioSource; //Field offset: 0x28

	public NPCAudioSourceSpatializeController() { }

	private void Awake() { }

	private void CheckSpatialization() { }

	private void EnableSourceSpatialize(AudioSource source, bool spatialize) { }

}

