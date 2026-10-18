//Type is in global namespace

public class ParticlePoolItem : MonoBehaviour
{
	private Action _callback; //Field offset: 0x20
	private ParticleSystem _system; //Field offset: 0x28
	private Transform _transform; //Field offset: 0x30
	private float _playTime; //Field offset: 0x38
	private float _timer; //Field offset: 0x3C
	private bool _isRunning; //Field offset: 0x40

	public ParticlePoolItem() { }

	public void Awake() { }

	public void Init(Action callback) { }

	public void Stop() { }

	private void Update() { }

	public void UseItem(Vector3 position, Vector3 rotation) { }

}

