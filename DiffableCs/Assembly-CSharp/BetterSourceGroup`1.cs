//Type is in global namespace

public sealed class BetterSourceGroup`1 : ISourceGroup, ISourceReleaseListener
{
	private readonly IBetterSourcePool _pool; //Field offset: 0x0
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x0
	[CompilerGenerated]
	private readonly AudioGroupPreset <Preset>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AudioMixerGroup <MixerGroup>k__BackingField; //Field offset: 0x0

	public override AudioMixerGroup MixerGroup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override AudioGroupPreset Preset
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BetterSourceGroup`1(AudioMixerGroup mixerGroup, GameObject prefab, AudioGroupPreset preset, IBetterSourceUpdater updater, IBetterSourceCulling culling, bool spatialize) { }

	public override BetterSource BorrowSource(bool activateSource = true, bool needUpdate = true, bool useHotPool = true) { }

	public override int CalculatePriority(float distanceToListener, float maxDistance) { }

	public override int CalculatePrioritySq(float sqrDistanceToListener, float sqrMaxDistance) { }

	public override void ClearAllPendingAndWarm() { }

	public override int DeactivatePending(int budget) { }

	public override int ExpireWarmEntries(int budget, double nowDspTime) { }

	[CompilerGenerated]
	public override AudioMixerGroup get_MixerGroup() { }

	[CompilerGenerated]
	public override AudioGroupPreset get_Preset() { }

	public override int GetPoolInUseSourcesCount() { }

	public override float GetPoolUsagePercent() { }

	public override void OnSourceReleased(BetterSource source) { }

	public override void Release(BetterSource source) { }

	[CompilerGenerated]
	public override void set_MixerGroup(AudioMixerGroup value) { }

	public override void StopAndReleaseAllActive() { }

	public override int TickBudget(int perGroupBudget, double nowDspTime) { }

}

