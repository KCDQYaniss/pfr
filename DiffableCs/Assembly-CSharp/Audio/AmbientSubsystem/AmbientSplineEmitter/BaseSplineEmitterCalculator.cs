namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public class BaseSplineEmitterCalculator : MonoBehaviour, ISplineEmitterCalculator
{
	protected const float MIN_SPREAD_VALUE = 0; //Field offset: 0x0
	protected const float MAX_SPREAD_VALUE = 1; //Field offset: 0x0
	[SerializeField]
	protected AbstractSplineMappedEmitter _splineEmitter; //Field offset: 0x20
	[SerializeField]
	protected BezierSpline _spline; //Field offset: 0x28
	[Range(2, 100)]
	[SerializeField]
	protected int _resolution; //Field offset: 0x30
	[Range(0, 1000)]
	[SerializeField]
	protected float _calculationRadius; //Field offset: 0x34
	protected Vector3[] Points; //Field offset: 0x38
	protected bool Initialized; //Field offset: 0x40
	private Transform _targetTransform; //Field offset: 0x48
	private Transform _splineCachedTransform; //Field offset: 0x50
	private double _splineRadius; //Field offset: 0x58
	private double _sqrMaxRange; //Field offset: 0x60
	protected Bounds SplineBounds; //Field offset: 0x68

	protected Vector3 EmitterPos
	{
		 get { } //Length: 70
	}

	public BezierSpline Spline
	{
		 get { } //Length: 5
	}

	protected Vector3 TargetPos
	{
		 get { } //Length: 138
	}

	public BaseSplineEmitterCalculator() { }

	protected override void CalculatePoints() { }

	protected Vector3 get_EmitterPos() { }

	public BezierSpline get_Spline() { }

	protected Vector3 get_TargetPos() { }

	public override void Init(Transform target) { }

	protected bool IsInRange() { }

	public override void LateTick(float dt = 1) { }

	protected override void OnDestroy() { }

	protected override void OnLateTick(float dt) { }

	protected override void OnTick() { }

	public override void Tick() { }

}

