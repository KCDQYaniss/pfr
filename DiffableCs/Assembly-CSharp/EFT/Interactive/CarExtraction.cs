namespace EFT.Interactive;

public class CarExtraction : ExfiltrationSubscriber
{
	private const float _maxLifeTime = 45; //Field offset: 0x0
	public BezierSpline Spline; //Field offset: 0x30
	public WheelDrive Driver; //Field offset: 0x38
	public float _previousT; //Field offset: 0x40
	public float Step; //Field offset: 0x44
	private float _currentTime; //Field offset: 0x48
	private float _lifeTime; //Field offset: 0x4C
	private bool _idle; //Field offset: 0x50

	public CarExtraction() { }

	public virtual void Dispose() { }

	public virtual void Play(bool force = false) { }

	private void Update() { }

}

