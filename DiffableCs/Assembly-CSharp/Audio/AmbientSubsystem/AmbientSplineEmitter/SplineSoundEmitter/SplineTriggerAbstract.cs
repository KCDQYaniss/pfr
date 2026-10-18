namespace Audio.AmbientSubsystem.AmbientSplineEmitter.SplineSoundEmitter;

public abstract class SplineTriggerAbstract : MonoBehaviour
{
	[Range(0, 100)]
	[SerializeField]
	protected int _triggerChance; //Field offset: 0x20
	[Range(0, 600)]
	[SerializeField]
	protected float _cooldown; //Field offset: 0x24
	[SerializeField]
	private bool _triggerOnce; //Field offset: 0x28
	private float _nextTime; //Field offset: 0x2C
	private bool _isTriggered; //Field offset: 0x30

	protected SplineTriggerAbstract() { }

	private void Awake() { }

	protected override void OnAwake() { }

	public abstract void OnTriggered() { }

	public void PushTrigger() { }

}

