namespace EFT;

public class ExfiltrationTimerSoundPlayer : MonoBehaviour
{
	[SerializeField]
	private ExfiltrationPoint _exfiltrationPoint; //Field offset: 0x20
	[SerializeField]
	private EExfiltrationStatus _targetRequiredStatus; //Field offset: 0x28
	[SerializeField]
	private AudioSingleClipContainer _openSound; //Field offset: 0x30
	[SerializeField]
	private AudioSourceGroupType _groupType; //Field offset: 0x38
	[SerializeField]
	private bool _spatialize; //Field offset: 0x3C
	[SerializeField]
	private bool _enabledHighPassFilter; //Field offset: 0x3D
	[SerializeField]
	private bool _enabledReverb; //Field offset: 0x3E
	private bool _isPlaying; //Field offset: 0x3F
	private bool _hasTimerRequirement; //Field offset: 0x40
	private IEnumerator _timerCoroutine; //Field offset: 0x48

	public ExfiltrationTimerSoundPlayer() { }

	private void AfterGameStarted() { }

	private void Awake() { }

	private void ExfiltrationPointOnOnStatusChanged(ExfiltrationPoint point, EExfiltrationStatus status) { }

	private bool HasTimerRequirement() { }

	public void OnDestroy() { }

	public void PlaySound() { }

}

