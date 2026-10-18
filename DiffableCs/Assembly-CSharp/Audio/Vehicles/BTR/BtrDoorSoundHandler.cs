namespace Audio.Vehicles.BTR;

public class BtrDoorSoundHandler : MonoBehaviour
{
	[SerializeField]
	private HysteresisFilter _filter; //Field offset: 0x20
	[SerializeField]
	private Transform _hingeTransform; //Field offset: 0x28
	[SerializeField]
	private float _closeEndSoundFilterValue; //Field offset: 0x30
	[SerializeField]
	private SoundBank _openSound; //Field offset: 0x38
	[SerializeField]
	private SoundBank _closeStartSound; //Field offset: 0x40
	[SerializeField]
	private SoundBank _closeEndSound; //Field offset: 0x48
	private bool _isTargetValueReached; //Field offset: 0x50
	private AudioMixerGroup _mixerGroup; //Field offset: 0x58
	private EnvironmentType _currentEnvironment; //Field offset: 0x60

	public BtrDoorSoundHandler() { }

	public void Awake() { }

	private AudioMixerGroup GetMixerByEnvironment() { }

	private void OnDestroy() { }

	public void OnFilterEnd(bool onEnabled, bool isOn) { }

	private void OnValueChange(float value) { }

	private void PlaySound(SoundBank bank) { }

	public void SetEnvironment(EnvironmentType environmentType) { }

}

