//Type is in global namespace

public interface ISourceGroup
{

	public AudioMixerGroup MixerGroup
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public AudioGroupPreset Preset
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public BetterSource BorrowSource(bool activateSource = true, bool needUpdate = true, bool useHotPool = true) { }

	public int CalculatePriority(float distanceToListener, float maxDistance) { }

	public int CalculatePrioritySq(float sqrDistanceToListener, float sqrMaxDistance) { }

	public void ClearAllPendingAndWarm() { }

	public int DeactivatePending(int budget) { }

	public int ExpireWarmEntries(int budget, double nowDspTime) { }

	public AudioMixerGroup get_MixerGroup() { }

	public AudioGroupPreset get_Preset() { }

	public int GetPoolInUseSourcesCount() { }

	public float GetPoolUsagePercent() { }

	public void Release(BetterSource source) { }

	public void set_MixerGroup(AudioMixerGroup value) { }

	public void StopAndReleaseAllActive() { }

	public int TickBudget(int perGroupBudget, double nowDspTime) { }

}

