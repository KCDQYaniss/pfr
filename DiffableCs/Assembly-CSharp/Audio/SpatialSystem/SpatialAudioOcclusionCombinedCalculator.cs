namespace Audio.SpatialSystem;

public sealed class SpatialAudioOcclusionCombinedCalculator : AbstractSpatialAudioCalculator
{
	private enum ECombinedStep
	{
		Idle = 0,
		DirectTestScheduled = 1,
		TDScheduled = 2,
		RScheduled = 3,
		Complete = 4,
	}

	private readonly float _maxDistance; //Field offset: 0x20
	private readonly LayerMask _occlusionLayerMask; //Field offset: 0x24
	private readonly float _transmissionThreshold; //Field offset: 0x28
	private readonly float _diffractionThreshold; //Field offset: 0x2C
	private readonly float _minClearPathScore; //Field offset: 0x30
	private Vector3 _listenerPosition; //Field offset: 0x34
	private Vector3 _sourcePosition; //Field offset: 0x40
	private float _sqrMaxDistance; //Field offset: 0x4C
	private float _currentMaxDistance; //Field offset: 0x50
	private bool _isCalculating; //Field offset: 0x54
	private bool _needsRecalculation; //Field offset: 0x55
	private readonly IAudioOcclusionCalculator _reflectionCalculator; //Field offset: 0x58
	private readonly IAudioOcclusionCalculator _diffractionCalculator; //Field offset: 0x60
	private readonly TransmissionCalculator _transmissionCalculator; //Field offset: 0x68
	private readonly List _occlusionCalculators; //Field offset: 0x70
	private readonly PositionChangeChecker _positionChangeChecker; //Field offset: 0x78
	private JobHandle _reflectionHandle; //Field offset: 0x80
	private JobHandle _transmissionHandle; //Field offset: 0x90
	private JobHandle _diffractionHandle; //Field offset: 0xA0
	private ECombinedStep _combinedStep; //Field offset: 0xB0
	private bool _ranTransmission; //Field offset: 0xB4
	private bool _ranDiffraction; //Field offset: 0xB5
	private bool _ranReflection; //Field offset: 0xB6
	private float _lastTScore; //Field offset: 0xB8
	private float _lastDScore; //Field offset: 0xBC
	private float _lastRScore; //Field offset: 0xC0
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0xC8
	private int _currentPriority; //Field offset: 0xD0
	[CompilerGenerated]
	private AggregateOcclusionResult <LastAggregateResult>k__BackingField; //Field offset: 0xD4

	public bool IsCalculating
	{
		 get { } //Length: 5
	}

	public private AggregateOcclusionResult LastAggregateResult
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public SpatialAudioOcclusionCombinedCalculator(AudioOcclusionSettings occlusionSettings, SpatialAudioSystem system) { }

	protected virtual void Finalize() { }

	public AggregateOcclusionResult FinalizeAndGetAggregateResult() { }

	public bool get_IsCalculating() { }

	[CompilerGenerated]
	public AggregateOcclusionResult get_LastAggregateResult() { }

	public AggregateOcclusionResult GetLastResult() { }

	public virtual float GetScore() { }

	protected virtual void OnDispose() { }

	protected virtual void OnLateUpdate() { }

	protected virtual void OnReset() { }

	protected virtual void OnUpdate(AudioSourceContainer sourceContainer, Vector3 listenerPosition, bool forceUpdate = false) { }

	protected virtual void OnWarmUp() { }

	private void ProcessCalculationSteps() { }

	[CompilerGenerated]
	private void set_LastAggregateResult(AggregateOcclusionResult value) { }

	public void StartCalculation(Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance, float sqrMaxDistance) { }

	private void WarUpInternal(IAudioOcclusionCalculator occlusionCalculator, Vector3 listenerPosition, Vector3 sourcePosition, float maxDistance) { }

}

