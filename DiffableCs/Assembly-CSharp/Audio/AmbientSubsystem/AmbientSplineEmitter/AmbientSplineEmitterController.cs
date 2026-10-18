namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public sealed class AmbientSplineEmitterController : MonoBehaviour
{
	private ISplineEmitterCalculator[] _calculators; //Field offset: 0x20
	private bool _initialized; //Field offset: 0x28

	public AmbientSplineEmitterController() { }

	public void Deinit() { }

	public void Init(Transform target) { }

	public void LateTick() { }

	public void Tick() { }

}

