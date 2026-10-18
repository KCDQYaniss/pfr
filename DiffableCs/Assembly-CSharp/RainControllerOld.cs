//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class RainControllerOld : MonoBehaviour
{
	[SerializeField]
	private AudioSource _waterAudio; //Field offset: 0x20
	[SerializeField]
	private float _maxAudioVolume; //Field offset: 0x28
	[SerializeField]
	private float _minAudioVolume; //Field offset: 0x2C
	[SerializeField]
	private AnimationCurve _fadeCurve; //Field offset: 0x30
	[SerializeField]
	private float _evaluationTime; //Field offset: 0x38
	private float _timer; //Field offset: 0x3C
	private int _goForward; //Field offset: 0x40

	public RainControllerOld() { }

	private void OnTriggerEnter(Collider col) { }

	private void OnTriggerExit(Collider col) { }

	private void Update() { }

}

