namespace Audio.AmbientSubsystem;

public class SimpleAmbientAudioSystem : MonoBehaviour
{
	[SerializeField]
	private List _ambientSoundPlayerGroups; //Field offset: 0x20
	private bool _updateState; //Field offset: 0x28

	public SimpleAmbientAudioSystem() { }

	private void Awake() { }

	public void Play() { }

	public void SetUpdateState(bool state) { }

	public void Stop(bool force = true) { }

	private void Update() { }

	private void Validate() { }

}

