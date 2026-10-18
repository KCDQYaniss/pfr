namespace Audio.AudioCulling;

public abstract class BaseAudioCulling : MonoBehaviour
{
	protected const int MAX_UPDATES_PER_FRAME = 10; //Field offset: 0x0
	protected Transform _listenerTransform; //Field offset: 0x20
	protected bool _isWorking; //Field offset: 0x28
	protected int _nextIndex; //Field offset: 0x2C
	private Coroutine _workCoroutine; //Field offset: 0x30

	protected BaseAudioCulling() { }

	protected override void Awake() { }

	protected override void OnDestroy() { }

	public override void SetListenerTransform(Transform listenerTransform) { }

	protected override void Start() { }

	protected override void StartWorkCoroutine() { }

	public override void StopWork() { }

	protected override void StopWorkCoroutine() { }

	protected abstract IEnumerator Work() { }

}

