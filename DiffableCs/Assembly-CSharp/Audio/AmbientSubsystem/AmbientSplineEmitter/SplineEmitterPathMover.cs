namespace Audio.AmbientSubsystem.AmbientSplineEmitter;

public class SplineEmitterPathMover : BaseSplineEmitterCalculator
{
	private enum EMovementAction
	{
		Stop = 0,
		Continue = 1,
		Repeat = 2,
		Reverse = 3,
	}

	private const float PATH_MOVER_SEGMENT_SAMPLE_STEP = 0.01; //Field offset: 0x0
	private const float MIN_FADE_TIME = 0.5; //Field offset: 0x0
	[SerializeField]
	private EMovementStrategy MovementStrategy; //Field offset: 0x80
	[SerializeField]
	private EMovementAction _movementActionOnCompleted; //Field offset: 0x81
	[SerializeField]
	private Vector2 _startMovementRandomDelayRange; //Field offset: 0x84
	[SerializeField]
	private float _movementSpeed; //Field offset: 0x8C
	[SerializeField]
	private bool _resetPositionOnMovementEnd; //Field offset: 0x90
	[SerializeField]
	private bool _fadeEmitter; //Field offset: 0x91
	private readonly Dictionary _movementStrategies; //Field offset: 0x98
	private IPathMovementStrategy _currentStrategy; //Field offset: 0xA0
	private EMovementAction _currentAction; //Field offset: 0xA8
	private float[] _segmentLengths; //Field offset: 0xB0
	private float _totalSegmentLength; //Field offset: 0xB8
	private IEnumerator _delayCoroutine; //Field offset: 0xC0

	public SplineEmitterPathMover() { }

	private static float CalculateSegmentLengthAt(Vector3[] points, int startIndex) { }

	private void CalculateSegmentLengths() { }

	private static void ComputeSegmentLengthsFromPoints(Vector3[] points, out float[] segmentLengths, out float totalLength) { }

	public void ExecuteCurrentStrategy() { }

	public virtual void Init(Transform target) { }

	private void InitStrategies() { }

	private void MotionCompletedHandler() { }

	protected virtual void OnDestroy() { }

	private void OnEmitterStopped() { }

	private void OnExecute() { }

	private void OnRepeatAction() { }

	private void OnReverseAction() { }

	private void OnStartEmit() { }

	private void OnStopAction() { }

	public void ResetCurrentStrategy() { }

	public void SetMovementSpeed(float durationSec) { }

	public void SetMovementStrategy(EMovementStrategy strategy) { }

	private void StopDelayedCoroutine() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

