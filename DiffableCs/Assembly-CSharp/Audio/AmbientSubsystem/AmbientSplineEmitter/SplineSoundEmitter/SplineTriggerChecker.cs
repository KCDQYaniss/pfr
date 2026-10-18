namespace Audio.AmbientSubsystem.AmbientSplineEmitter.SplineSoundEmitter;

public class SplineTriggerChecker : BaseSplineEmitterCalculator
{
	[BurstCompile]
	private struct DistanceCalculationJob : IJobParallelFor
	{
		[ReadOnly]
		public float sqrDetectionMaxRadius; //Field offset: 0x0
		[ReadOnly]
		public Vector3 emitterPosition; //Field offset: 0x4
		[ReadOnly]
		public NativeArray triggerPositions; //Field offset: 0x10
		[ReadOnly]
		public NativeArray triggerIDs; //Field offset: 0x20
		public ParallelWriter validTriggerIDs; //Field offset: 0x30

		public override void Execute(int index) { }

	}

	[SerializeField]
	private float _checkCooldown; //Field offset: 0x80
	[SerializeField]
	private float _checkMaxRadius; //Field offset: 0x84
	[SerializeField]
	private float _checkPositionDiff; //Field offset: 0x88
	[SerializeField]
	private List _cachedTriggers; //Field offset: 0x90
	private readonly Dictionary _triggersMap; //Field offset: 0x98
	private float _sqrDetectionMaxRadius; //Field offset: 0xA0
	private float _nextCheckTime; //Field offset: 0xA4
	private Vector3 _emitterLastPos; //Field offset: 0xA8
	private JobHandle _jobHandle; //Field offset: 0xB8
	private Vector3 _targetPosition; //Field offset: 0xC8
	private NativeArray _triggersPositions; //Field offset: 0xD8
	private NativeArray _triggersIDs; //Field offset: 0xE8
	private NativeParallelHashSet _validTriggersIDs; //Field offset: 0xF8

	public SplineTriggerChecker() { }

	private void AllocateNativeContainers() { }

	private void DisposeNativeContainers() { }

	public virtual void Init(Transform target) { }

	private bool IsEmitterPositionChanged() { }

	public virtual void LateTick(float dt = 1) { }

	protected virtual void OnDestroy() { }

	public virtual void Tick() { }

}

