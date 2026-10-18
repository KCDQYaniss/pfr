namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public interface ISplineEmitterCalculator
{

	public void Init(Transform target) { }

	public void LateTick(float dt = 1) { }

	public void Tick() { }

}

