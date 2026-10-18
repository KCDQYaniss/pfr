namespace Audio.SpatialSystem;

public abstract class SpatialAudioOccluder : ISpatialAudioOccluder, IAudioOccluded
{
	private const float MIN_OCCLUSION_THRESHOLD = 0.001; //Field offset: 0x0
	protected const float CHECK_DISTANCE_OFFSET = 5; //Field offset: 0x0
	protected const float HOLD_LOW_PASS_FREQUENCY = 20; //Field offset: 0x0
	protected readonly OcclusionParameters CurrentParameters; //Field offset: 0x10
	protected readonly SpatialAudioSystem AudioSystem; //Field offset: 0x18
	protected readonly Transform ListenerTransform; //Field offset: 0x20
	protected readonly AbstractLogger Logger; //Field offset: 0x28
	protected AudioSourceContainer SourceContainer; //Field offset: 0x30
	private readonly FloorHeightCalculator _floorHeightCalculator; //Field offset: 0x38
	private readonly DistancePercentageCalculator _distancePercentageCalculator; //Field offset: 0x40
	private readonly DirectionalWeightCalculator _directionalWeightCalculator; //Field offset: 0x48
	private readonly FilterCutoffCalculator _filterCutoffCalculator; //Field offset: 0x50
	private readonly ResonanceCalculator _resonanceCalculator; //Field offset: 0x58
	private bool _isDisposed; //Field offset: 0x60
	[CompilerGenerated]
	private float <PropagationEffect>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private float <ObstructionEffect>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private float <OcclusionEffect>k__BackingField; //Field offset: 0x6C

	protected bool IsPropagationActive
	{
		 get { } //Length: 15
	}

	protected Vector3 ListenerPos
	{
		 get { } //Length: 530
	}

	public override float ObstructionEffect
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float OcclusionEffect
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override float PropagationEffect
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected SpatialAudioOccluder(SpatialAudioSystem audioSystem, Transform listenerTransform, AbstractLogger logger) { }

	public override void ApplyCurrentOcclusionToSource(BetterSource source, bool snapFilters = true) { }

	protected override void ApplyOcclusionToSource(BetterSource source, bool snapFilters = false) { }

	protected override void CalculateFinalOcclusionParams(ISpatialAudioRoom currentSourceRoom, BetterSource source, Vector3 sourcePos) { }

	protected float CalculateFrequencyByDistanceCurve(AnimationCurve curve) { }

	private float CalculateRolloffScale(float maxScale) { }

	protected override float CalculateTotalEffect() { }

	protected float CalculateVolumeFactorByCurve(AnimationCurve volumeCurve, float value) { }

	private float ClampTargetVolByEnvFactor(ISpatialAudioRoom sourceRoom, AudioOcclusionEQPreset preset, float baseVol, bool isInDiffEnv, float isolationFactor) { }

	public static SpatialAudioOccluder Create(Transform listenerTransform, EOcclusionTest test, AbstractLogger logger) { }

	public override void Dispose() { }

	public void ForceUpdate() { }

	protected bool get_IsPropagationActive() { }

	protected Vector3 get_ListenerPos() { }

	[CompilerGenerated]
	public override float get_ObstructionEffect() { }

	[CompilerGenerated]
	public override float get_OcclusionEffect() { }

	[CompilerGenerated]
	public override float get_PropagationEffect() { }

	protected float GetFinalVolumeFactor(ISpatialAudioRoom sourceRoom, Vector3 sourcePos, Vector3 listenerPos, AudioGroupOcclusionSettings settings) { }

	protected bool IsPropagationCalculationValid() { }

	public void ManualLateUpdate() { }

	public void ManualUpdate() { }

	protected override void OnForceUpdate() { }

	protected override void OnLateUpdate() { }

	protected override void OnUpdate() { }

	protected override void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

	[CompilerGenerated]
	protected void set_ObstructionEffect(float value) { }

	[CompilerGenerated]
	protected void set_OcclusionEffect(float value) { }

	[CompilerGenerated]
	protected void set_PropagationEffect(float value) { }

	public override void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

	protected void UpdateInfo(AudioSourceContainer container) { }

	public override void UpdateOcclusionEffects(AudioSourceContainer container, EOcclusionApply apply) { }

}

